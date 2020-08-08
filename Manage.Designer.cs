namespace CMS
{
    partial class Manage
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnItm = new System.Windows.Forms.Button();
            this.BtnSup = new System.Windows.Forms.Button();
            this.BtnEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(827, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage";
            // 
            // BtnItm
            // 
            this.BtnItm.BackColor = System.Drawing.Color.Transparent;
            this.BtnItm.FlatAppearance.BorderSize = 0;
            this.BtnItm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnItm.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnItm.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__11_;
            this.BtnItm.Location = new System.Drawing.Point(1155, 261);
            this.BtnItm.Name = "BtnItm";
            this.BtnItm.Size = new System.Drawing.Size(433, 415);
            this.BtnItm.TabIndex = 12;
            this.BtnItm.Text = "Item";
            this.BtnItm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnItm.UseCompatibleTextRendering = true;
            this.BtnItm.UseMnemonic = false;
            this.BtnItm.UseVisualStyleBackColor = false;
            this.BtnItm.Click += new System.EventHandler(this.BtnItm_Click);
            // 
            // BtnSup
            // 
            this.BtnSup.BackColor = System.Drawing.Color.Transparent;
            this.BtnSup.FlatAppearance.BorderSize = 0;
            this.BtnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSup.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSup.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__14_;
            this.BtnSup.Location = new System.Drawing.Point(682, 261);
            this.BtnSup.Name = "BtnSup";
            this.BtnSup.Size = new System.Drawing.Size(433, 415);
            this.BtnSup.TabIndex = 11;
            this.BtnSup.Text = "Supplier";
            this.BtnSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSup.UseCompatibleTextRendering = true;
            this.BtnSup.UseMnemonic = false;
            this.BtnSup.UseVisualStyleBackColor = false;
            this.BtnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // BtnEmp
            // 
            this.BtnEmp.BackColor = System.Drawing.Color.Transparent;
            this.BtnEmp.FlatAppearance.BorderSize = 0;
            this.BtnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmp.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmp.Image = global::CMS.Properties.Resources.employee_icon_3;
            this.BtnEmp.Location = new System.Drawing.Point(209, 261);
            this.BtnEmp.Name = "BtnEmp";
            this.BtnEmp.Size = new System.Drawing.Size(433, 415);
            this.BtnEmp.TabIndex = 10;
            this.BtnEmp.Text = "Employee";
            this.BtnEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEmp.UseCompatibleTextRendering = true;
            this.BtnEmp.UseMnemonic = false;
            this.BtnEmp.UseVisualStyleBackColor = false;
            this.BtnEmp.Click += new System.EventHandler(this.BtnEmp_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.BtnItm);
            this.Controls.Add(this.BtnSup);
            this.Controls.Add(this.BtnEmp);
            this.Controls.Add(this.label1);
            this.Name = "Manage";
            this.Size = new System.Drawing.Size(1797, 936);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnItm;
        private System.Windows.Forms.Button BtnSup;
        private System.Windows.Forms.Button BtnEmp;

    }
}
