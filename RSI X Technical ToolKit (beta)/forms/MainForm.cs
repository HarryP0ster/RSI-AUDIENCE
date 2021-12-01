using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor;
//using agorartc;
using RSI_X_Desktop.forms;

namespace RSI_X_Desktop.forms
{
    public partial class MainForm : Form
    {
        static private string userName = "";
        
        public MainForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }



        private void formTheme1_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Button join");

            string code = NewTextBox.Text.Remove(4,1);
            if (AgoraObject.JoinRoom(code))
            {
                System.Diagnostics.Debug.WriteLine("Connect...");

                Hide();
                Audience Audit = new();
                AgoraObject.CurrentForm = CurForm.FormAudience;
                Audit.Show(this);


                Audit.FormClosed += (s, e) =>
                {
                    System.Threading.Thread.Sleep(100);
                    this.Show();
                };
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm");
            string i = DateTime.Now.ToString("MM");
            string dm = "";
            switch (i)
            {
                case "01": dm = "January"; break;
                case "02": dm = "February"; break;
                case "03": dm = "March"; break;
                case "04": dm = "April"; break;
                case "05": dm = "May"; break;
                case "06": dm = "June"; break;
                case "07": dm = "July"; break;
                case "08": dm = "August"; break;
                case "09": dm = "September"; break;
                case "10": dm = "October"; break;
                case "11": dm = "November"; break;
                case "12": dm = "December"; break;
            }
            LocalTimeLabel.Text = DateTime.Now.DayOfWeek.ToString() + ", " + dm + " " + DateTime.Now.ToString("dd, yyyy");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            NewTextBox.Clear();
            GC.Collect();
        }

        private void bigTextBox1_VisibleChanged(object sender, EventArgs e)
        {
            //if (this.Visible)
            //{
            //    NewTextBox.Invalidate();
            //    AgoraObject.CurrentForm = CurForm.None;
            //}
        }

        static public void UpdateName(string name) 
        { userName = name; }

        static public string GetUserName() => userName;

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //для того, чтобы форма не вылетала при сворачивании ее в панель инстурментов
            //НЕ УДАЛЯТЬ!
            if (this.WindowState == FormWindowState.Minimized)
            {
                NewTextBox.Hide();
            }
            else if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                NewTextBox.Show();
            }
        }

        private void NewTextBox_Click(object sender, EventArgs e)
        {
            NewTextBox.SelectionStart = 0;
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
