using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ManiXButton
{
    public partial class XButton : Button
    {
        #region Fields

        private ManiXButton.Theme thm = ManiXButton.Theme.MSOffice2010_BLUE;
        private ControlsDemo.ExtdTextBox extdTextBox1;
        private ControlsDemo.ExtdTextBox extdTextBox2;

        private enum MouseState { None = 1, Down = 2, Up = 3, Enter = 4, Leave = 5, Move = 6 }

        private MouseState MState = MouseState.None;

        #endregion

        #region Constructor

        public XButton()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                      ControlStyles.Opaque |
                      ControlStyles.ResizeRedraw |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.CacheText, // We gain about 2% in painting by avoiding extra GetWindowText calls
                      true);

            this.colorTable = new Colortable();

            this.MouseLeave += new EventHandler(_MouseLeave);
            this.MouseDown += new MouseEventHandler(_MouseDown);
            this.MouseUp += new MouseEventHandler(_MouseUp);
            this.MouseMove += new MouseEventHandler(_MouseMove);
        }

        #endregion

        #region Events

        #region Paint Transparent Background

        protected void PaintTransparentBackground(Graphics g, Rectangle clipRect)
        {
            // check if we have a parent
            if (this.Parent != null)
            {
                // convert the clipRects coordinates from ours to our parents
                clipRect.Offset(this.Location);

                PaintEventArgs e = new PaintEventArgs(g, clipRect);

                // save the graphics state so that if anything goes wrong 
                // we're not fubar
                GraphicsState state = g.Save();

                try
                {
                    // move the graphics object so that we are drawing in 
                    // the correct place
                    g.TranslateTransform((float)-this.Location.X, (float)-this.Location.Y);

                    // draw the parents background and foreground
                    this.InvokePaintBackground(this.Parent, e);
                    this.InvokePaint(this.Parent, e);

                    return;
                }
                finally
                {
                    // reset everything back to where they were before
                    g.Restore(state);
                    clipRect.Offset(-this.Location.X, -this.Location.Y);
                }
            }

            // we don't have a parent, so fill the rect with
            // the default control color
            g.FillRectangle(SystemBrushes.Control, clipRect);
        }

        #endregion

        #region Mouse Events

        private void _MouseDown(object sender, MouseEventArgs mevent)
        {
            MState = MouseState.Down;
            Invalidate();
        }

        private void _MouseUp(object sender, MouseEventArgs mevent)
        {
            MState = MouseState.Up;
            Invalidate();
        }

        private void _MouseMove(object sender, MouseEventArgs mevent)
        {
            MState = MouseState.Move;
            Invalidate();
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            MState = MouseState.Leave;
            Invalidate();
        }

        #endregion

        #region Path

        public static GraphicsPath GetRoundedRect(RectangleF r, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            r = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            if (radius <= 0.0F || radius <= 0.0F)
            {
                gp.AddRectangle(r);
            }
            else
            {
                gp.AddArc((float)r.X, (float)r.Y, radius, radius, 180, 90);
                gp.AddArc((float)r.Right - radius, (float)r.Y, radius - 1, radius, 270, 90);
                gp.AddArc((float)r.Right - radius, ((float)r.Bottom) - radius - 1, radius - 1, radius, 0, 90);
                gp.AddArc((float)r.X, ((float)r.Bottom) - radius - 1, radius - 1, radius, 90, 90);
            }
            gp.CloseFigure();
            return gp;
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            this.PaintTransparentBackground(e.Graphics, this.ClientRectangle);

            #region Painting

            //now let's we begin painting
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            #endregion

            #region Color

            Color tTopColorBegin = this.colorTable.ButtonNormalColor1;
            Color tTopColorEnd = this.colorTable.ButtonNormalColor2;
            Color tBottomColorBegin = this.colorTable.ButtonNormalColor3;
            Color tBottomColorEnd = this.colorTable.ButtonNormalColor4;
            Color Textcol = this.colorTable.TextColor;


            if (!this.Enabled)
            {
                tTopColorBegin = Color.FromArgb((int)(tTopColorBegin.GetBrightness() * 255),
                    (int)(tTopColorBegin.GetBrightness() * 255),
                    (int)(tTopColorBegin.GetBrightness() * 255));
                tBottomColorEnd = Color.FromArgb((int)(tBottomColorEnd.GetBrightness() * 255),
                    (int)(tBottomColorEnd.GetBrightness() * 255),
                    (int)(tBottomColorEnd.GetBrightness() * 255));
            }
            else
            {
                if (MState == MouseState.None || MState == MouseState.Leave)
                {
                    tTopColorBegin = this.colorTable.ButtonNormalColor1;
                    tTopColorEnd = this.colorTable.ButtonNormalColor2;
                    tBottomColorBegin = this.colorTable.ButtonNormalColor3;
                    tBottomColorEnd = this.colorTable.ButtonNormalColor4;
                    Textcol = this.colorTable.TextColor;
                }
                else if (MState == MouseState.Down)
                {
                    tTopColorBegin = this.colorTable.ButtonSelectedColor1;
                    tTopColorEnd = this.colorTable.ButtonSelectedColor2;
                    tBottomColorBegin = this.colorTable.ButtonSelectedColor3;
                    tBottomColorEnd = this.colorTable.ButtonSelectedColor4;
                    Textcol = this.colorTable.SelectedTextColor;
                }
                else if (MState == MouseState.Move || MState == MouseState.Up)
                {
                    tTopColorBegin = this.colorTable.ButtonMouseOverColor1;
                    tTopColorEnd = this.colorTable.ButtonMouseOverColor2;
                    tBottomColorBegin = this.colorTable.ButtonMouseOverColor3;
                    tBottomColorEnd = this.colorTable.ButtonMouseOverColor4;
                    Textcol = this.colorTable.HoverTextColor;
                }
            }


            #endregion

            #region Theme 2010

            if (thm == ManiXButton.Theme.MSOffice2010_BLUE || thm == ManiXButton.Theme.MSOffice2010_Green || thm == ManiXButton.Theme.MSOffice2010_Yellow || thm == ManiXButton.Theme.MSOffice2010_Publisher ||
                thm == ManiXButton.Theme.MSOffice2010_RED || thm == ManiXButton.Theme.MSOffice2010_WHITE || thm == ManiXButton.Theme.MSOffice2010_Pink)
            {
                Paint2010Background(e, g, tTopColorBegin, tTopColorEnd, tBottomColorBegin, tBottomColorEnd);
                TEXTandIMAGE(this.ClientRectangle, g, Textcol);
            }

            #endregion
        }

        #region Paint 2010 Background

        protected void Paint2010Background(PaintEventArgs e, Graphics g, Color tTopColorBegin, Color tTopColorEnd, Color tBottomColorBegin, Color tBottomColorEnd)
        {
            int _roundedRadiusX = 6;

            Rectangle r = new Rectangle(this.ClientRectangle.Left, this.ClientRectangle.Top, this.ClientRectangle.Width, this.ClientRectangle.Height);
            Rectangle j = r;
            Rectangle r2 = r;
            r2.Inflate(-1, -1);
            Rectangle r3 = r2;
            r3.Inflate(-1, -1);

            //rectangle for gradient, half upper and lower
            RectangleF halfup = new RectangleF(r.Left, r.Top, r.Width, r.Height);
            RectangleF halfdown = new RectangleF(r.Left, r.Top + (r.Height / 2) - 1, r.Width, r.Height);

            //BEGIN PAINT BACKGROUND
            //for half upper, we paint using linear gradient
            using (GraphicsPath thePath = GetRoundedRect(r, _roundedRadiusX))
            {
                LinearGradientBrush lgb = new LinearGradientBrush(halfup, tBottomColorEnd, tBottomColorBegin, 90f, true);

                Blend blend = new Blend(4);
                blend.Positions = new float[] { 0, 0.18f, 0.35f, 1f };
                blend.Factors = new float[] { 0f, .4f, .9f, 1f };
                lgb.Blend = blend;
                g.FillPath(lgb, thePath);
                lgb.Dispose();

                //for half lower, we paint using radial gradient
                using (GraphicsPath p = new GraphicsPath())
                {
                    p.AddEllipse(halfdown); //make it radial
                    using (PathGradientBrush gradient = new PathGradientBrush(p))
                    {
                        gradient.WrapMode = WrapMode.Clamp;
                        gradient.CenterPoint = new PointF(Convert.ToSingle(halfdown.Left + halfdown.Width / 2), Convert.ToSingle(halfdown.Bottom));
                        gradient.CenterColor = tBottomColorEnd;
                        gradient.SurroundColors = new Color[] { tBottomColorBegin };

                        blend = new Blend(4);
                        blend.Positions = new float[] { 0, 0.15f, 0.4f, 1f };
                        blend.Factors = new float[] { 0f, .3f, 1f, 1f };
                        gradient.Blend = blend;

                        g.FillPath(gradient, thePath);
                    }
                }
                //END PAINT BACKGROUND

                //BEGIN PAINT BORDERS
                using (GraphicsPath gborderDark = thePath)
                {
                    using (Pen p = new Pen(tTopColorBegin, 1))
                    {
                        g.DrawPath(p, gborderDark);
                    }
                }
                using (GraphicsPath gborderLight = GetRoundedRect(r2, _roundedRadiusX))
                {
                    using (Pen p = new Pen(tTopColorEnd, 1))
                    {
                        g.DrawPath(p, gborderLight);
                    }
                }
                using (GraphicsPath gborderMed = GetRoundedRect(r3, _roundedRadiusX))
                {
                    SolidBrush bordermed = new SolidBrush(Color.FromArgb(50, tTopColorEnd));
                    using (Pen p = new Pen(bordermed, 1))
                    {
                        g.DrawPath(p, gborderMed);
                    }
                }
                //END PAINT BORDERS
            }
        }

        #endregion

        #region Paint TEXT AND IMAGE

        protected void TEXTandIMAGE(Rectangle Rec, Graphics g, Color textColor)
        {
            //BEGIN PAINT TEXT
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            #region Top

            if (this.TextAlign == ContentAlignment.TopLeft)
            {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Near;
            }
            else if (this.TextAlign == ContentAlignment.TopCenter)
            {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Center;
            }
            else if (this.TextAlign == ContentAlignment.TopRight)
            {
                sf.LineAlignment = StringAlignment.Near;
                sf.Alignment = StringAlignment.Far;
            }

            #endregion

            #region Middle

            else if (this.TextAlign == ContentAlignment.MiddleLeft)
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Near;
            }
            else if (this.TextAlign == ContentAlignment.MiddleCenter)
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
            }
            else if (this.TextAlign == ContentAlignment.MiddleRight)
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Far;
            }

            #endregion

            #region Bottom

            else if (this.TextAlign == ContentAlignment.BottomLeft)
            {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Near;
            }
            else if (this.TextAlign == ContentAlignment.BottomCenter)
            {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Center;
            }
            else if (this.TextAlign == ContentAlignment.BottomRight)
            {
                sf.LineAlignment = StringAlignment.Far;
                sf.Alignment = StringAlignment.Far;
            }

            #endregion

            if (this.ShowKeyboardCues)
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
            else
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Hide;
            g.DrawString(this.Text, this.Font, new SolidBrush(textColor), Rec, sf);
        }

        #endregion

        #endregion

        #region Properties

        #region ColorTable

        Colortable colorTable = null;

        [DefaultValue(typeof(Colortable), "Office2010Blue")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Colortable ColorTable
        {
            get
            {
                if (colorTable == null)
                    colorTable = new Colortable();

                return colorTable;
            }
            set
            {

                if (value == null)
                    value = Colortable.Office2010Blue;

                colorTable = (Colortable)value;

                this.Invalidate();

            }
        }

        public ManiXButton.Theme Theme
        {
            get
            {
                if (this.colorTable == Colortable.Office2010Green)
                {
                    return ManiXButton.Theme.MSOffice2010_Green;
                }
                else if (this.colorTable == Colortable.Office2010Red)
                {
                    return ManiXButton.Theme.MSOffice2010_RED;
                }
                else if (this.colorTable == Colortable.Office2010Pink)
                {
                    return ManiXButton.Theme.MSOffice2010_Pink;
                }
                else if (this.colorTable == Colortable.Office2010Yellow)
                {
                    return ManiXButton.Theme.MSOffice2010_Yellow;
                }
                else if (this.colorTable == Colortable.Office2010White)
                {
                    return ManiXButton.Theme.MSOffice2010_WHITE;
                }
                else if (this.colorTable == Colortable.Office2010Publisher)
                {
                    return ManiXButton.Theme.MSOffice2010_Publisher;
                }

                return ManiXButton.Theme.MSOffice2010_BLUE;
            }

            set
            {
                this.thm = value;

                if (thm == ManiXButton.Theme.MSOffice2010_Green)
                {
                    this.colorTable = Colortable.Office2010Green;
                }
                else if (thm == ManiXButton.Theme.MSOffice2010_RED)
                {
                    this.colorTable = Colortable.Office2010Red;
                }
                else if (thm == ManiXButton.Theme.MSOffice2010_Pink)
                {
                    this.colorTable = Colortable.Office2010Pink;
                }
                else if (thm == ManiXButton.Theme.MSOffice2010_WHITE)
                {
                    this.colorTable = Colortable.Office2010White;
                }
                else if (thm == ManiXButton.Theme.MSOffice2010_Yellow)
                {
                    this.colorTable = Colortable.Office2010Yellow;
                }
                else if (thm == ManiXButton.Theme.MSOffice2010_Publisher)
                {
                    this.colorTable = Colortable.Office2010Publisher;
                }
                else
                {
                    this.colorTable = Colortable.Office2010Blue;
                }
            }
        }

        #endregion

        #region Background Image

        [Browsable(false)]
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        [Browsable(false)]
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }
            set
            {
                base.BackgroundImageLayout = value;
            }
        }

        #endregion

        private void InitializeComponent()
        {
            this.extdTextBox1 = new ControlsDemo.ExtdTextBox();
            this.extdTextBox2 = new ControlsDemo.ExtdTextBox();
            this.SuspendLayout();
            // 
            // extdTextBox1
            // 
            this.extdTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.extdTextBox1.Location = new System.Drawing.Point(0, 0);
            this.extdTextBox1.Name = "extdTextBox1";
            this.extdTextBox1.Size = new System.Drawing.Size(100, 22);
            this.extdTextBox1.TabIndex = 0;
            this.extdTextBox1.Text = "Your Text Here";
            this.extdTextBox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.extdTextBox1.WaterMarkFont = null;
            this.extdTextBox1.WaterMarkText = "Your Text Here";
            // 
            // extdTextBox2
            // 
            this.extdTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.extdTextBox2.Location = new System.Drawing.Point(0, 0);
            this.extdTextBox2.Name = "extdTextBox2";
            this.extdTextBox2.Size = new System.Drawing.Size(100, 22);
            this.extdTextBox2.TabIndex = 0;
            this.extdTextBox2.Text = "Your Text Here";
            this.extdTextBox2.WaterMarkColor = System.Drawing.Color.Gray;
            this.extdTextBox2.WaterMarkFont = null;
            this.extdTextBox2.WaterMarkText = "Your Text Here";
            this.extdTextBox2.TextChanged += new System.EventHandler(this.extdTextBox2_TextChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private void extdTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

