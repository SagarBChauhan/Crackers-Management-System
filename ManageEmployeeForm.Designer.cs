namespace CMS
{
    partial class ManageEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpdateEmp = new System.Windows.Forms.Button();
            this.BtnAddEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(724, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Employee";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__2_;
            this.BtnSearch.Location = new System.Drawing.Point(1145, 189);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(433, 415);
            this.BtnSearch.TabIndex = 12;
            this.BtnSearch.Text = "Search Employee";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnUpdateEmp
            // 
            this.BtnUpdateEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateEmp.FlatAppearance.BorderSize = 0;
            this.BtnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateEmp.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUpdateEmp.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__1_;
            this.BtnUpdateEmp.Location = new System.Drawing.Point(672, 189);
            this.BtnUpdateEmp.Name = "BtnUpdateEmp";
            this.BtnUpdateEmp.Size = new System.Drawing.Size(433, 415);
            this.BtnUpdateEmp.TabIndex = 11;
            this.BtnUpdateEmp.Text = "Update Employee";
            this.BtnUpdateEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnUpdateEmp.UseVisualStyleBackColor = false;
            this.BtnUpdateEmp.Click += new System.EventHandler(this.BtnUpdateEmp_Click);
            // 
            // BtnAddEmp
            // 
            this.BtnAddEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddEmp.FlatAppearance.BorderSize = 0;
            this.BtnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmp.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddEmp.Image = global::CMS.Properties.Resources.Webp_net_resizeimage;
            this.BtnAddEmp.Location = new System.Drawing.Point(194, 189);
            this.BtnAddEmp.Name = "BtnAddEmp";
            this.BtnAddEmp.Size = new System.Drawing.Size(433, 415);
            this.BtnAddEmp.TabIndex = 10;
            this.BtnAddEmp.Text = "Add Employee";
            this.BtnAddEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAddEmp.UseVisualStyleBackColor = false;
            this.BtnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 793);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnUpdateEmp);
            this.Controls.Add(this.BtnAddEmp);
            this.Name = "ManageEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdateEmp;
        private System.Windows.Forms.Button BtnAddEmp;
        private System.Windows.Forms.Label label1;
    }
}