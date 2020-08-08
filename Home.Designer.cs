namespace CMS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnManage = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnStockAlert = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.LblUserName = new System.Windows.Forms.Label();
            this.BtnPwdChange = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.PanalSide = new System.Windows.Forms.Panel();
            this.PanalLow = new System.Windows.Forms.Panel();
            this.about1 = new CMS.About();
            this.changePassword1 = new CMS.ChangePassword();
            this.order1 = new CMS.Order();
            this.manage1 = new CMS.Manage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(228, 841);
            this.panel1.TabIndex = 3;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SidePanel.Location = new System.Drawing.Point(0, 137);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 90);
            this.SidePanel.TabIndex = 3;
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
            this.BtnManage.Image = global::CMS.Properties.Resources.favicon__9_;
            this.BtnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManage.Location = new System.Drawing.Point(15, 233);
            this.BtnManage.Name = "BtnManage";
            this.BtnManage.Size = new System.Drawing.Size(213, 88);
            this.BtnManage.TabIndex = 1;
            this.BtnManage.Text = "  Manage";
            this.BtnManage.UseVisualStyleBackColor = true;
            this.BtnManage.Click += new System.EventHandler(this.BtnManage_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.BtnStockAlert);
            this.panel2.Controls.Add(this.BtnRefresh);
            this.panel2.Controls.Add(this.LblUserName);
            this.panel2.Controls.Add(this.BtnPwdChange);
            this.panel2.Controls.Add(this.BtnLogOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1582, 41);
            this.panel2.TabIndex = 5;
            // 
            // BtnStockAlert
            // 
            this.BtnStockAlert.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnStockAlert.FlatAppearance.BorderSize = 0;
            this.BtnStockAlert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStockAlert.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__15_;
            this.BtnStockAlert.Location = new System.Drawing.Point(1094, 0);
            this.BtnStockAlert.Name = "BtnStockAlert";
            this.BtnStockAlert.Size = new System.Drawing.Size(51, 41);
            this.BtnStockAlert.TabIndex = 27;
            this.BtnStockAlert.UseVisualStyleBackColor = true;
            this.BtnStockAlert.Click += new System.EventHandler(this.BtnStockAlert_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRefresh.FlatAppearance.BorderSize = 0;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRefresh.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__16_;
            this.BtnRefresh.Location = new System.Drawing.Point(1145, 0);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(51, 41);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
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
            this.BtnPwdChange.Location = new System.Drawing.Point(1196, 0);
            this.BtnPwdChange.Name = "BtnPwdChange";
            this.BtnPwdChange.Size = new System.Drawing.Size(193, 41);
            this.BtnPwdChange.TabIndex = 1;
            this.BtnPwdChange.Text = "    Change Password";
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
            this.BtnLogOut.Location = new System.Drawing.Point(1389, 0);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(193, 41);
            this.BtnLogOut.TabIndex = 0;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // PanalSide
            // 
            this.PanalSide.BackColor = System.Drawing.Color.Transparent;
            this.PanalSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanalSide.Location = new System.Drawing.Point(1800, 41);
            this.PanalSide.Name = "PanalSide";
            this.PanalSide.Size = new System.Drawing.Size(10, 800);
            this.PanalSide.TabIndex = 21;
            // 
            // PanalLow
            // 
            this.PanalLow.BackColor = System.Drawing.Color.Transparent;
            this.PanalLow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanalLow.Location = new System.Drawing.Point(228, 831);
            this.PanalLow.Name = "PanalLow";
            this.PanalLow.Size = new System.Drawing.Size(1572, 10);
            this.PanalLow.TabIndex = 22;
            // 
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.Transparent;
            this.about1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about1.Location = new System.Drawing.Point(228, 41);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(1795, 845);
            this.about1.TabIndex = 26;
            // 
            // changePassword1
            // 
            this.changePassword1.BackColor = System.Drawing.Color.Transparent;
            this.changePassword1.Location = new System.Drawing.Point(228, 41);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(1583, 797);
            this.changePassword1.TabIndex = 25;
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.Transparent;
            this.order1.Location = new System.Drawing.Point(228, 41);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(1787, 936);
            this.order1.TabIndex = 24;
            // 
            // manage1
            // 
            this.manage1.BackColor = System.Drawing.Color.Transparent;
            this.manage1.Location = new System.Drawing.Point(228, 41);
            this.manage1.Name = "manage1";
            this.manage1.Size = new System.Drawing.Size(1617, 936);
            this.manage1.TabIndex = 23;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1810, 841);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.changePassword1);
            this.Controls.Add(this.order1);
            this.Controls.Add(this.manage1);
            this.Controls.Add(this.PanalLow);
            this.Controls.Add(this.PanalSide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnManage;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPwdChange;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Panel PanalSide;
        private System.Windows.Forms.Panel PanalLow;
        private Manage manage1;
        private Order order1;
        private ChangePassword changePassword1;
        private System.Windows.Forms.Label LblUserName;
        private About about1;
        private System.Windows.Forms.Button BtnStockAlert;
        private System.Windows.Forms.Button BtnRefresh;
    }
}