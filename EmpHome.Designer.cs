namespace CMS
{
    partial class EmpHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanalLow = new System.Windows.Forms.Panel();
            this.PanalSide = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BtnPwdChange = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnManage = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.changePassword1 = new CMS.ChangePassword();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanalLow
            // 
            this.PanalLow.BackColor = System.Drawing.Color.Transparent;
            this.PanalLow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanalLow.Location = new System.Drawing.Point(228, 810);
            this.PanalLow.Name = "PanalLow";
            this.PanalLow.Size = new System.Drawing.Size(1568, 10);
            this.PanalLow.TabIndex = 29;
            // 
            // PanalSide
            // 
            this.PanalSide.BackColor = System.Drawing.Color.Transparent;
            this.PanalSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanalSide.Location = new System.Drawing.Point(1796, 41);
            this.PanalSide.Name = "PanalSide";
            this.PanalSide.Size = new System.Drawing.Size(10, 779);
            this.PanalSide.TabIndex = 28;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SidePanel.Location = new System.Drawing.Point(0, 137);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 90);
            this.SidePanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.LblUserName);
            this.panel2.Controls.Add(this.BtnPwdChange);
            this.panel2.Controls.Add(this.BtnLogOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1578, 41);
            this.panel2.TabIndex = 27;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblUserName.Font = new System.Drawing.Font("Rockwell", 20F);
            this.LblUserName.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__3_;
            this.LblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblUserName.Location = new System.Drawing.Point(0, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(0, 38);
            this.LblUserName.TabIndex = 26;
            // 
            // BtnPwdChange
            // 
            this.BtnPwdChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnPwdChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnPwdChange.FlatAppearance.BorderSize = 0;
            this.BtnPwdChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPwdChange.Image = global::CMS.Properties.Resources.favicon__14_;
            this.BtnPwdChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPwdChange.Location = new System.Drawing.Point(1192, 0);
            this.BtnPwdChange.Name = "BtnPwdChange";
            this.BtnPwdChange.Size = new System.Drawing.Size(193, 41);
            this.BtnPwdChange.TabIndex = 1;
            this.BtnPwdChange.Text = "Change Password";
            this.BtnPwdChange.UseVisualStyleBackColor = false;
            this.BtnPwdChange.Click += new System.EventHandler(this.BtnPwdChange_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Image = global::CMS.Properties.Resources.favicon__11_;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(1385, 0);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(193, 41);
            this.BtnLogOut.TabIndex = 0;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnAbout);
            this.panel1.Controls.Add(this.BtnOrder);
            this.panel1.Controls.Add(this.BtnManage);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 820);
            this.panel1.TabIndex = 26;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Image = global::CMS.Properties.Resources.favicon__11_;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(12, 519);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(213, 88);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "  Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAbout.Image = global::CMS.Properties.Resources.favicon__8_;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbout.Location = new System.Drawing.Point(15, 425);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(213, 88);
            this.BtnAbout.TabIndex = 3;
            this.BtnAbout.Text = "  About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.FlatAppearance.BorderSize = 0;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOrder.Image = global::CMS.Properties.Resources.favicon__15_;
            this.BtnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrder.Location = new System.Drawing.Point(15, 329);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(213, 88);
            this.BtnOrder.TabIndex = 2;
            this.BtnOrder.Text = "  Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnManage
            // 
            this.BtnManage.FlatAppearance.BorderSize = 0;
            this.BtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManage.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnManage.Image = global::CMS.Properties.Resources.favicon__8_;
            this.BtnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManage.Location = new System.Drawing.Point(15, 233);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(213, 88);
            this.BtnManage.TabIndex = 1;
            this.BtnManage.Text = "      Product Info";
            this.BtnManage.UseVisualStyleBackColor = true;
            this.BtnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHome.Image = global::CMS.Properties.Resources.favicon__12_;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(15, 138);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(213, 88);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "  Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // changePassword1
            // 
            this.changePassword1.Location = new System.Drawing.Point(228, 44);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(1568, 776);
            this.changePassword1.TabIndex = 30;
            // 
            // EmpHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 820);
            this.Controls.Add(this.changePassword1);
            this.Controls.Add(this.PanalLow);
            this.Controls.Add(this.PanalSide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPwdChange;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Panel PanalLow;
        private System.Windows.Forms.Panel PanalSide;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnManage;
        private System.Windows.Forms.Button BtnHome;
        private ChangePassword changePassword1;
    }
}