namespace CMS
{
    partial class ManageEmp
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpdateEmp = new System.Windows.Forms.Button();
            this.BtnAddEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Image = global::CMS.Properties.Resources.Custom_Icon_Design_Pretty_Office_3_Search_Male_User;
            this.BtnSearch.Location = new System.Drawing.Point(1155, 261);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(433, 415);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateEmp
            // 
            this.BtnUpdateEmp.FlatAppearance.BorderSize = 0;
            this.BtnUpdateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateEmp.Image = global::CMS.Properties.Resources.Custom_Icon_Design_Pretty_Office_3_Edit_Male_User1;
            this.BtnUpdateEmp.Location = new System.Drawing.Point(682, 261);
            this.BtnUpdateEmp.Name = "BtnUpdateEmp";
            this.BtnUpdateEmp.Size = new System.Drawing.Size(433, 415);
            this.BtnUpdateEmp.TabIndex = 8;
            this.BtnUpdateEmp.UseVisualStyleBackColor = true;
            // 
            // BtnAddEmp
            // 
            this.BtnAddEmp.FlatAppearance.BorderSize = 0;
            this.BtnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEmp.Image = global::CMS.Properties.Resources.Custom_Icon_Design_Pretty_Office_3_Add_Male_User;
            this.BtnAddEmp.Location = new System.Drawing.Point(209, 261);
            this.BtnAddEmp.Name = "BtnAddEmp";
            this.BtnAddEmp.Size = new System.Drawing.Size(433, 415);
            this.BtnAddEmp.TabIndex = 7;
            this.BtnAddEmp.UseVisualStyleBackColor = true;
            this.BtnAddEmp.Click += new System.EventHandler(this.BtnAddEmp_Click);
            // 
            // ManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnUpdateEmp);
            this.Controls.Add(this.BtnAddEmp);
            this.Name = "ManageEmp";
            this.Size = new System.Drawing.Size(1797, 936);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdateEmp;
        private System.Windows.Forms.Button BtnAddEmp;
    }
}
