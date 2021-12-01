::=============================================================================
:: This script is the main entrance for building and releasing
:: Agora C# SDK to NuGet.
::
:: For pushing the SDK to NuGet, please set the API key for NuGet
:: as an environment variable called %NUGET_APIKEY%.
::
::  Input: %1 (TYPE) : build or release
::         %2 (VERSION) : 3.4.0, etc.
::         %3 (CONFIG) : Debug or Release (For "%TYPE%"=="build" only)
::         %4 (APP-KEY) : The app-key for download iris
::         %5 (WIN-URL) : The url for iris_win
::         %6 (IRIS-NAME) : The name of Iris package
::
:: Created by Yiqing Huang on Apr 23, 2021.
:: Modified by Yiqing Huang on May 12, 2021.
:: Modified by Hugo Chaan on September 2, 2021.
::=============================================================================
@echo off

SET CURDIR=%cd%
SET APP_KEY=%4
SET WIN_URL=%5
SET IRIS_NAME=%6

goto :main


:main
setlocal
SET TYPE=%1
if "%TYPE%"=="release" (CALL :release %2) else (CALL :build %2 %3)
endlocal
EXIT /B 0

:download_in_txt
setlocal
SET URL=%~1
SET OUT_FILENAME=%~2
curl -H "X-JFrog-Art-Api:%APP_KEY%" %URL://artifactory.=//artifactory-api.bj2.% -o "%CURDIR%\%OUT_FILENAME%"
:: powershell -command "[Net.ServicePointManager]::SecurityProtocol = @('Tls, Tls11, Tls12, Ssl3') ; & Invoke-WebRequest -Uri %URL://artifactory.=//artifactory-api.bj2.% -Headers @{'X-JFrog-Art-Api' = '%APP_KEY%'} -OutFile %OUT_FILENAME%"
endlocal
EXIT /B 0

:download_in_command
setlocal
SET URL=%~1
SET OUT_FILENAME=%~2
curl -H "X-JFrog-Art-Api:%APP_KEY%" %URL://artifactory.=//artifactory-api.bj2.% -o "%CURDIR%\%OUT_FILENAME%"
:: powershell -command "[Net.ServicePointManager]::SecurityProtocol = @('Tls, Tls11, Tls12, Ssl3') ; & Invoke-WebRequest -Uri %URL://artifactory.=//artifactory-api.bj2.% -Headers @{'X-JFrog-Art-Api' = '%APP_KEY%'} -OutFile %OUT_FILENAME%"
endlocal
EXIT /B 0

:: Download Iris and related native SDK libraries
:: according to the URL in 'url_config.txt'.
::
:: Params: %~1 (URL_FILE): The path to the url_config file.
::         %~2 (OUT_FILENAME): The output file name.
:download_library
setlocal
SET URL_FILE=%~1
SET OUT_FILENAME=%~2
for /F "usebackq delims=" %%a in (%URL_FILE%) do SET URL=%%a
echo =====Start downloading libraries=====
echo %URL_FILE%
echo %OUT_FILENAME%
if "%WIN_URL%"=="" (echo URL: %URL%) else (echo URL: %WIN_URL%)
if "%WIN_URL%"=="" (CALL :download_in_txt %URL% %OUT_FILENAME%) else (CALL :download_in_command %WIN_URL% %OUT_FILENAME%)
echo =====Finish downloading libraries=====
endlocal
EXIT /B 0


:: Build and push package to NuGet.
::
:: Params: %~1 (VERSION): 3.4.0, etc.
::
:: Notes: Please set the API key for NuGet upload as an environment
::        variable called %NUGET_APIKEY% in advance.
:Release
setlocal
SET SOURCE=https://api.nuget.org/v3/index.json

call :build %~1 Release pack

echo =====Start pushing x86 package to NuGet=====
dotnet nuget push %CURDIR%\agorartc\bin\x86\Release\*.nupkg -k %NUGET_APIKEY% -s %SOURCE%
echo =====Finish pushing x86 package to NuGet=====

echo =====Start pushing x64 package to NuGet=====
dotnet nuget push %CURDIR%\agorartc\bin\x64\Release\*.nupkg -k %NUGET_APIKEY% -s %SOURCE%
echo =====Finish pushing x64 package to NuGet=====

echo =====Start removing unnecessary files=====
rmdir /q /s %CURDIR%\agorartc\bin
echo =====Finish removing unnecessary files=====

endlocal
EXIT /B 0


:: Build and compress dlls into a zip file.
::
:: Params: %~1 (VERSION): 3.4.0, etc.
::         %~2 (CONFIG): Debug or Release
::         %~3 (CLEAN_FLAG) (Optional): If not empty string, the `bin/`
::                                      directory will not be cleaned up.
::
:: Notes: Please set the API key for NuGet upload as an environment
::        variable called %NUGET_APIKEY% in advance.
:build
setlocal
if "%~1"=="" goto :error
if "%~2"=="" goto :error
SET VERSION=%~1
SET CONFIG=%~2
echo =====Start building for %VERSION%=====

echo =====Start preparing for build=====
SET URL_FILE=url_config.txt
SET OUT_FILENAME=iris.zip
mkdir %CURDIR%\agorartc
xcopy /s /y %CURDIR%\..\agorartc %CURDIR%\agorartc\
xcopy /y %CURDIR%\..\agorartc.sln %CURDIR%\
CALL :download_library %URL_FILE% %OUT_FILENAME%
mkdir %CURDIR%\temp
7z x %CURDIR%\%OUT_FILENAME% -o%CURDIR%\temp
mkdir %CURDIR%\iris %CURDIR%\iris\x86 %CURDIR%\iris\x86_64
move %CURDIR%\temp\%IRIS_NAME% %CURDIR%\iris\

SET IRIS_PATH_x86=%CURDIR%\iris\%IRIS_NAME%\Win32
SET NATIVE_SDK_x86=%CURDIR%\iris\%IRIS_NAME%\RTC\Agora_Native_SDK_for_Windows_FULL\libs\x86
SET IRIS_PATH_x64=%CURDIR%\iris\%IRIS_NAME%\x64
SET NATIVE_SDK_x64=%CURDIR%\iris\%IRIS_NAME%\RTC\Agora_Native_SDK_for_Windows_FULL\libs\x86_64

xcopy /y %IRIS_PATH_x86%\Release\* %CURDIR%\iris\x86\
xcopy /y %NATIVE_SDK_x86%\* %CURDIR%\iris\x86\
xcopy /y %IRIS_PATH_x64%\Release\* %CURDIR%\iris\x86_64\
xcopy /y %NATIVE_SDK_x64%\* %CURDIR%\iris\x86_64\

rmdir /q /s %CURDIR%\temp
del /s %CURDIR%\%OUT_FILENAME%
echo =====Finish preparing for build=====

echo =====Start building for x86=====
SET IRIS_PATH_x86=%CURDIR%\iris\x86
call %CURDIR%\compile-windows.bat x86 %CURDIR%\agorartc.sln %CONFIG% 2019
echo =====Finish building for x86=====

echo =====Start building for x64=====
SET IRIS_PATH_x64=%CURDIR%\iris\x86_64
call %CURDIR%\compile-windows.bat x64 %CURDIR%\agorartc.sln %CONFIG% 2019
echo =====Finish building for x64=====

echo =====Start packing=====
mkdir %CURDIR%\Agora_C#_SDK
mkdir %CURDIR%\Agora_C#_SDK\API-Examples
mkdir %CURDIR%\Agora_C#_SDK\libs
mkdir %CURDIR%\Agora_C#_SDK\libs\x86 %CURDIR%\Agora_C#_SDK\libs\x86_64 
:: mkdir %CURDIR%\Agora_C#_SDK\agorartc %CURDIR%\Agora_C#_SDK\agorartc\agorartc
xcopy /s %CURDIR%\iris\x86 %CURDIR%\Agora_C#_SDK\libs\x86
xcopy /s %CURDIR%\iris\x86_64 %CURDIR%\Agora_C#_SDK\libs\x86_64
xcopy /s %CURDIR%\agorartc\bin\x86\%CONFIG%\netcoreapp3.1 %CURDIR%\Agora_C#_SDK\libs\x86
xcopy /s %CURDIR%\agorartc\bin\x64\%CONFIG%\netcoreapp3.1 %CURDIR%\Agora_C#_SDK\libs\x86_64

if "%~3"=="" rmdir /q /s %CURDIR%\agorartc\bin
rmdir /q /s %CURDIR%\agorartc\obj
::xcopy /s %CURDIR%\agorartc %CURDIR%\Agora_C#_SDK\agorartc\agorartc\
::xcopy /y %CURDIR%\agorartc.sln %CURDIR%\Agora_C#_SDK\agorartc

mkdir %CURDIR%\output
powershell -command "Compress-Archive $env:CURDIR/Agora_C#_SDK/* $env:CURDIR/output/Agora_C#_SDK_%VERSION%_%CONFIG%.zip"
echo =====Finish packing=====

echo =====Start removing unnecessary files=====
rmdir /q /s %CURDIR%\Agora_C#_SDK %CURDIR%\agorartc %CURDIR%\iris
del /s %CURDIR%\agorartc.sln
echo =====Finish removing unnecessary files=====
echo =====Finish building for %VERSION%=====
endlocal
EXIT /B 0


:: Error message.
:error
echo ERROR: Missing input parameter.
EXIT /B 0