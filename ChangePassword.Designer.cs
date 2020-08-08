namespace CMS
{
    partial class ChangePassword
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ManiXButton.Office2010Blue office2010Blue1 = new ManiXButton.Office2010Blue();
            this.BtnSubmit = new ManiXButton.XButton();
            this.TxtReNew = new ControlsDemo.ExtdTextBox();
            this.TxtNew = new ControlsDemo.ExtdTextBox();
            this.TxtOld = new ControlsDemo.ExtdTextBox();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            office2010Blue1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Blue1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Blue1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Blue1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Blue1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(97)))), ((int)(((byte)(181)))));
            office2010Blue1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(219)))));
            office2010Blue1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Blue1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Blue1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Blue1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Blue1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Blue1.TextColor = System.Drawing.Color.White;
            this.BtnSubmit.ColorTable = office2010Blue1;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(586, 357);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(118, 41);
            this.BtnSubmit.TabIndex = 3;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtReNew
            // 
            this.TxtReNew.ForeColor = System.Drawing.Color.Gray;
            this.TxtReNew.Location = new System.Drawing.Point(567, 309);
            this.TxtReNew.Name = "TxtReNew";
            this.TxtReNew.Size = new System.Drawing.Size(157, 22);
            this.TxtReNew.TabIndex = 2;
            this.TxtReNew.Text = "Retype password";
            this.TxtReNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtReNew.WaterMarkColor = System.Drawing.Color.Gray;
            this.TxtReNew.WaterMarkFont = null;
            this.TxtReNew.WaterMarkText = "Retype password";
            this.TxtReNew.Leave += new System.EventHandler(this.TxtReNew_Leave);
            // 
            // TxtNew
            // 
            this.TxtNew.ForeColor = System.Drawing.Color.Gray;
            this.TxtNew.Location = new System.Drawing.Point(567, 271);
            this.TxtNew.Name = "TxtNew";
            this.TxtNew.Size = new System.Drawing.Size(157, 22);
            this.TxtNew.TabIndex = 1;
            this.TxtNew.Text = "New Password";
            this.TxtNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNew.WaterMarkColor = System.Drawing.Color.Gray;
            this.TxtNew.WaterMarkFont = null;
            this.TxtNew.WaterMarkText = "New Password";
            // 
            // TxtOld
            // 
            this.TxtOld.ForeColor = System.Drawing.Color.Gray;
            this.TxtOld.Location = new System.Drawing.Point(567, 233);
            this.TxtOld.Name = "TxtOld";
            this.TxtOld.Size = new System.Drawing.Size(157, 22);
            this.TxtOld.TabIndex = 0;
            this.TxtOld.Text = "Old Password";
            this.TxtOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtOld.WaterMarkColor = System.Drawing.Color.Gray;
            this.TxtOld.WaterMarkFont = null;
            this.TxtOld.WaterMarkText = "Old Password";
            this.TxtOld.Leave += new System.EventHandler(this.TxtOld_Leave);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtReNew);
            this.Controls.Add(this.TxtNew);
            this.Controls.Add(this.TxtOld);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(1290, 630);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsDemo.ExtdTextBox TxtOld;
        private ControlsDemo.ExtdTextBox TxtNew;
        private ControlsDemo.ExtdTextBox TxtReNew;
        private ManiXButton.XButton BtnSubmit;
    }
}
