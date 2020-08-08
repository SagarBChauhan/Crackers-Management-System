using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace ManiXButton
{
    #region ENUM

    public enum Theme
    {
        MSOffice2010_BLUE = 1,
        MSOffice2010_WHITE = 2,
        MSOffice2010_RED = 3,
        MSOffice2010_Green = 4,
        MSOffice2010_Pink = 5,
        MSOffice2010_Yellow = 6,
        MSOffice2010_Publisher = 7
    }

    #endregion

    #region COLOR TABLE

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Colortable
    {
        #region Static Color Tables

        static Office2010Blue office2010blu = new Office2010Blue();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010Blue
        {
            get { return office2010blu; }
        }

        static Office2010Green office2010gr = new Office2010Green();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010Green
        {
            get { return office2010gr; }
        }

        static Office2010Red office2010rd = new Office2010Red();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010Red
        {
            get { return office2010rd; }
        }

        static Office2010Pink office2010pk = new Office2010Pink();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010Pink
        {
            get { return office2010pk; }
        }

        static Office2010Yellow office2010yl = new Office2010Yellow();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010Yellow
        {
            get { return office2010yl; }
        }

        static Office2010White office2010wt = new Office2010White();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010White
        {
            get { return office2010wt; }
        }


        static Office2010Publisher office2010pb = new Office2010Publisher();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public static Colortable Office2010Publisher
        {
            get { return office2010pb; }
        }


        #endregion

        #region Custom Properties

        Color textColor = Color.White;
        Color selectedTextColor = Color.FromArgb(30, 57, 91);
        Color OverTextColor = Color.FromArgb(30, 57, 91);
        Color borderColor = Color.FromArgb(31, 72, 161);
        Color innerborderColor = Color.FromArgb(68, 135, 228);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color SelectedTextColor
        {
            get { return selectedTextColor; }
            set { selectedTextColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color HoverTextColor
        {
            get { return OverTextColor; }
            set { OverTextColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color BorderColor1
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color BorderColor2
        {
            get { return innerborderColor; }
            set { innerborderColor = value; }
        }

        #endregion

        #region Button Normal

        Color buttonNormalBegin = Color.FromArgb(31, 72, 161);
        Color buttonNormalMiddleBegin = Color.FromArgb(68, 135, 228);
        Color buttonNormalMiddleEnd = Color.FromArgb(41, 97, 181);
        Color buttonNormalEnd = Color.FromArgb(62, 125, 219);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor1
        {
            get { return buttonNormalBegin; }
            set { buttonNormalBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor2
        {
            get { return buttonNormalMiddleBegin; }
            set { buttonNormalMiddleBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor3
        {
            get { return buttonNormalMiddleEnd; }
            set { buttonNormalMiddleEnd = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonNormalColor4
        {
            get { return buttonNormalEnd; }
            set { buttonNormalEnd = value; }
        }

        #endregion

        #region Button Selected

        Color buttonSelectedBegin = Color.FromArgb(236, 199, 87);
        Color buttonSelectedMiddleBegin = Color.FromArgb(252, 243, 215);
        Color buttonSelectedMiddleEnd = Color.FromArgb(255, 229, 117);
        Color buttonSelectedEnd = Color.FromArgb(255, 216, 107);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor1
        {
            get { return buttonSelectedBegin; }
            set { buttonSelectedBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor2
        {
            get { return buttonSelectedMiddleBegin; }
            set { buttonSelectedMiddleBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor3
        {
            get { return buttonSelectedMiddleEnd; }
            set { buttonSelectedMiddleEnd = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonSelectedColor4
        {
            get { return buttonSelectedEnd; }
            set { buttonSelectedEnd = value; }
        }

        #endregion

        #region Button Mouse Over

        Color buttonMouseOverBegin = Color.FromArgb(236, 199, 87);
        Color buttonMouseOverMiddleBegin = Color.FromArgb(252, 243, 215);
        Color buttonMouseOverMiddleEnd = Color.FromArgb(249, 225, 137);
        Color buttonMouseOverEnd = Color.FromArgb(251, 249, 224);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor1
        {
            get { return buttonMouseOverBegin; }
            set { buttonMouseOverBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor2
        {
            get { return buttonMouseOverMiddleBegin; }
            set { buttonMouseOverMiddleBegin = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor3
        {
            get { return buttonMouseOverMiddleEnd; }
            set { buttonMouseOverMiddleEnd = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public virtual Color ButtonMouseOverColor4
        {
            get { return buttonMouseOverEnd; }
            set { buttonMouseOverEnd = value; }
        }

        #endregion
    }

    #endregion

    #region Office 2010 Blue

    public class Office2010Blue : Colortable
    {
        public Office2010Blue()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(31, 72, 161);
            this.ButtonNormalColor2 = Color.FromArgb(68, 135, 228);
            this.ButtonNormalColor3 = Color.FromArgb(41, 97, 181);
            this.ButtonNormalColor4 = Color.FromArgb(62, 125, 219);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Blue";
        }
    }

    #endregion

    #region Office 2010 GREEN

    public class Office2010Green : Colortable
    {
        public Office2010Green()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(42, 126, 43);
            this.ButtonNormalColor2 = Color.FromArgb(94, 184, 67);
            this.ButtonNormalColor3 = Color.FromArgb(42, 126, 43);
            this.ButtonNormalColor4 = Color.FromArgb(94, 184, 67);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Green";
        }
    }

    #endregion

    #region Office 2010 Red

    public class Office2010Red : Colortable
    {
        public Office2010Red()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(227, 77, 45);
            this.ButtonNormalColor2 = Color.FromArgb(245, 148, 64);
            this.ButtonNormalColor3 = Color.FromArgb(227, 77, 45);
            this.ButtonNormalColor4 = Color.FromArgb(245, 148, 64);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Red";
        }
    }

    #endregion

    #region Office 2010 Pink

    public class Office2010Pink : Colortable
    {
        public Office2010Pink()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(175, 6, 77);
            this.ButtonNormalColor2 = Color.FromArgb(222, 52, 119);
            this.ButtonNormalColor3 = Color.FromArgb(175, 6, 77);
            this.ButtonNormalColor4 = Color.FromArgb(222, 52, 119);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Pink";
        }
    }

    #endregion

    #region Office 2010 White

    public class Office2010White : Colortable
    {
        public Office2010White()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.Black;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(154, 154, 154);
            this.ButtonNormalColor2 = Color.FromArgb(255, 255, 255);
            this.ButtonNormalColor3 = Color.FromArgb(235, 235, 235);
            this.ButtonNormalColor4 = Color.FromArgb(255, 255, 255);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010White";
        }
    }

    #endregion

    #region Office 2010 Yellow

    public class Office2010Yellow : Colortable
    {
        public Office2010Yellow()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(252, 161, 8);
            this.ButtonNormalColor2 = Color.FromArgb(251, 191, 45);
            this.ButtonNormalColor3 = Color.FromArgb(252, 161, 8);
            this.ButtonNormalColor4 = Color.FromArgb(251, 191, 45);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Yellow";
        }
    }

    #endregion

    #region Office 2010 Publisher

    public class Office2010Publisher : Colortable
    {
        public Office2010Publisher()
        {
            // Border Color

            this.BorderColor1 = Color.FromArgb(31, 72, 161);
            this.BorderColor2 = Color.FromArgb(68, 135, 228);

            // Button Text Color

            this.TextColor = Color.White;
            this.SelectedTextColor = Color.FromArgb(30, 57, 91);
            this.HoverTextColor = Color.FromArgb(30, 57, 91);

            // Button normal color

            this.ButtonNormalColor1 = Color.FromArgb(0, 126, 126);
            this.ButtonNormalColor2 = Color.FromArgb(31, 173, 167);
            this.ButtonNormalColor3 = Color.FromArgb(0, 126, 126);
            this.ButtonNormalColor4 = Color.FromArgb(31, 173, 167);

            // Button mouseover color

            this.ButtonMouseOverColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonMouseOverColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonMouseOverColor3 = Color.FromArgb(249, 225, 137);
            this.ButtonMouseOverColor4 = Color.FromArgb(251, 249, 224);

            // Button selected color

            this.ButtonSelectedColor1 = Color.FromArgb(236, 199, 87);
            this.ButtonSelectedColor2 = Color.FromArgb(252, 243, 215);
            this.ButtonSelectedColor3 = Color.FromArgb(255, 229, 117);
            this.ButtonSelectedColor4 = Color.FromArgb(255, 216, 107);
        }

        public override string ToString()
        {
            return "Office2010Publisher";
        }
    }

    #endregion
}