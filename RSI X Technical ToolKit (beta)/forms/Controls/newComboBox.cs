
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms.Controls
{
    internal class newComboBoxComboBox : ComboBox
    {
        private int _StartIndex;

        private Color _highlightColor = Color.FromArgb(121, 176, 214);

        private SmoothingMode _SmoothingType = SmoothingMode.HighQuality;

        private Color _BGColorA = Color.FromArgb(245, 245, 245);

        private Color _BGColorB = Color.FromArgb(230, 230, 230);

        private Color _BorderColorA = Color.FromArgb(252, 252, 252);

        private Color _BorderColorB = Color.FromArgb(249, 249, 249);

        private Color _BorderColorC = Color.FromArgb(189, 189, 189);

        private Color _BorderColorD = Color.FromArgb(200, 168, 168, 168);

        private Color _TriangleColorA = Color.FromArgb(121, 176, 214);

        private Color _TriangleColorB = Color.FromArgb(27, 94, 137);

        private Color _LineColorA = Color.White;

        private Color _LineColorB = Color.FromArgb(189, 189, 189);

        private Color _LineColorC = Color.White;

        private Color _ListForeColor = Color.Black;

        private Color _ListBackColor = Color.FromArgb(255, 255, 255, 255);

        private Color _ListBorderColor = Color.FromArgb(50, Color.Black);

        private DashStyle _ListDashType = DashStyle.Dot;

        private Color _ListSelectedBackColorA = Color.FromArgb(15, Color.White);

        private Color _ListSelectedBackColorB = Color.FromArgb(0, Color.White);

        public int StartIndex
        {
            get
            {
                return _StartIndex;
            }
            set
            {
                _StartIndex = value;
                try
                {
                    base.SelectedIndex = value;
                }
                catch
                {
                }

                Invalidate();
            }
        }

        public Color ItemHighlightColor
        {
            get
            {
                return _highlightColor;
            }
            set
            {
                _highlightColor = value;
                Invalidate();
            }
        }

        public SmoothingMode SmoothingType
        {
            get
            {
                return _SmoothingType;
            }
            set
            {
                _SmoothingType = value;
                Invalidate();
            }
        }

        public Color BGColorA
        {
            get
            {
                return _BGColorA;
            }
            set
            {
                _BGColorA = value;
            }
        }

        public Color BGColorB
        {
            get
            {
                return _BGColorB;
            }
            set
            {
                _BGColorB = value;
            }
        }

        public Color BorderColorA
        {
            get
            {
                return _BorderColorA;
            }
            set
            {
                _BorderColorA = value;
            }
        }

        public Color BorderColorB
        {
            get
            {
                return _BorderColorB;
            }
            set
            {
                _BorderColorB = value;
            }
        }

        public Color BorderColorC
        {
            get
            {
                return _BorderColorC;
            }
            set
            {
                _BorderColorC = value;
            }
        }

        public Color BorderColorD
        {
            get
            {
                return _BorderColorD;
            }
            set
            {
                _BorderColorD = value;
            }
        }

        public Color TriangleColorA
        {
            get
            {
                return _TriangleColorA;
            }
            set
            {
                _TriangleColorA = value;
            }
        }

        public Color TriangleColorB
        {
            get
            {
                return _TriangleColorB;
            }
            set
            {
                _TriangleColorB = value;
            }
        }

        public Color LineColorA
        {
            get
            {
                return _LineColorA;
            }
            set
            {
                _LineColorA = value;
            }
        }

        public Color LineColorB
        {
            get
            {
                return _LineColorB;
            }
            set
            {
                _LineColorB = value;
            }
        }

        public Color LineColorC
        {
            get
            {
                return _LineColorC;
            }
            set
            {
                _LineColorC = value;
            }
        }

        public Color ListForeColor
        {
            get
            {
                return _ListForeColor;
            }
            set
            {
                _ListForeColor = value;
            }
        }

        public Color ListBackColor
        {
            get
            {
                return _ListBackColor;
            }
            set
            {
                _ListBackColor = value;
            }
        }

        public Color ListBorderColor
        {
            get
            {
                return _ListBorderColor;
            }
            set
            {
                _ListBorderColor = value;
            }
        }

        public DashStyle ListDashType
        {
            get
            {
                return _ListDashType;
            }
            set
            {
                _ListDashType = value;
            }
        }

        public Color ListSelectedBackColorA
        {
            get
            {
                return _ListSelectedBackColorA;
            }
            set
            {
                _ListSelectedBackColorA = value;
            }
        }

        public Color ListSelectedBackColorB
        {
            get
            {
                return _ListSelectedBackColorB;
            }
            set
            {
                _ListSelectedBackColorB = value;
            }
        }

        public void ReplaceItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            try
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(_highlightColor), e.Bounds);
                    LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, ListSelectedBackColorA, ListSelectedBackColorB, 90f);
                    e.Graphics.FillRectangle(brush, new Rectangle(new Point(e.Bounds.X, e.Bounds.Y), new Size(e.Bounds.Width, e.Bounds.Height)));
                    e.Graphics.DrawRectangle(new Pen(ListBorderColor)
                    {
                        DashStyle = ListDashType
                    }, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(ListBackColor), e.Bounds);
                }

                using (SolidBrush brush2 = new SolidBrush(ListForeColor))
                {
                    e.Graphics.DrawString(GetItemText(base.Items[e.Index]), e.Font, brush2, new Rectangle(e.Bounds.X + 2, e.Bounds.Y, e.Bounds.Width - 4, e.Bounds.Height));
                }
            }
            catch
            {
            }

            e.DrawFocusRectangle();
        }

        protected void DrawTriangle(Color Clr, Point FirstPoint, Point SecondPoint, Point ThirdPoint, Graphics G)
        {
            List<Point> list = new List<Point>
            {
                FirstPoint,
                SecondPoint,
                ThirdPoint
            };
            G.FillPolygon(new SolidBrush(Clr), list.ToArray());
        }

        public newComboBoxComboBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, value: true);
            base.DrawMode = DrawMode.OwnerDrawVariable;
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(27, 94, 137);
            //base.Font = new Font("Verdana", 6.75f, FontStyle.Bold);
            base.DropDownStyle = ComboBoxStyle.DropDownList;
            DoubleBuffered = true;
            //base.Size = new Size(75, 50);
            base.Width = 50;
            base.Height = 50;
            base.ItemHeight = 50;
            base.DrawItem += ReplaceItem;
            Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingType;
            graphics.Clear(BackColor);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(0, 0, base.Width - 1, base.Height - 2), BGColorA, BGColorB, 90f);
            graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, base.Width - 1, base.Height - 3), BorderColorA, BorderColorB, 90f);
            graphics.DrawRectangle(new Pen(brush), new Rectangle(1, 1, base.Width - 3, base.Height - 4));
            graphics.DrawRectangle(new Pen(BorderColorC), new Rectangle(0, 0, base.Width - 1, base.Height - 2));
            graphics.DrawLine(new Pen(BorderColorD), new Point(1, base.Height - 1), new Point(base.Width - 2, base.Height - 1));
            DrawTriangle(TriangleColorA, new Point(base.Width - 14, 8), new Point(base.Width - 7, 8), new Point(base.Width - 11, 12), graphics);
            graphics.DrawLine(new Pen(TriangleColorB), new Point(base.Width - 14, 8), new Point(base.Width - 8, 8));
            graphics.DrawLine(new Pen(LineColorA), new Point(base.Width - 22, 1), new Point(base.Width - 22, base.Height - 3));
            graphics.DrawLine(new Pen(LineColorB), new Point(base.Width - 21, 1), new Point(base.Width - 21, base.Height - 3));
            graphics.DrawLine(new Pen(LineColorC), new Point(base.Width - 20, 1), new Point(base.Width - 20, base.Height - 3));
            try
            {
                graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(5, -1, base.Width - 20, base.Height), new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                });
            }
            catch
            {
            }

            e.Graphics.DrawImage(bitmap, 0, 0);
            graphics.Dispose();
            bitmap.Dispose();
        }
    }
}
