namespace CMS
{
    partial class Order
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
            this.BtnReport = new System.Windows.Forms.Button();
            this.BTnHistory = new System.Windows.Forms.Button();
            this.BtnBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(844, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order";
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Rockwell", 20F);
            this.BtnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReport.Image = global::CMS.Properties.Resources._67360_200;
            this.BtnReport.Location = new System.Drawing.Point(1162, 286);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(377, 365);
            this.BtnReport.TabIndex = 10;
            this.BtnReport.Text = "Report";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReport.UseVisualStyleBackColor = false;
            // 
            // BTnHistory
            // 
            this.BTnHistory.BackColor = System.Drawing.Color.Transparent;
            this.BTnHistory.FlatAppearance.BorderSize = 0;
            this.BTnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTnHistory.Font = new System.Drawing.Font("Rockwell", 20F);
            this.BTnHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTnHistory.Image = global::CMS.Properties.Resources.history_grey_192x192;
            this.BTnHistory.Location = new System.Drawing.Point(705, 286);
            this.BTnHistory.Name = "BTnHistory";
            this.BTnHistory.Size = new System.Drawing.Size(377, 365);
            this.BTnHistory.TabIndex = 10;
            this.BTnHistory.Text = "History";
            this.BTnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTnHistory.UseVisualStyleBackColor = false;
            // 
            // BtnBill
            // 
            this.BtnBill.BackColor = System.Drawing.Color.Transparent;
            this.BtnBill.FlatAppearance.BorderSize = 0;
            this.BtnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBill.Font = new System.Drawing.Font("Rockwell", 20F);
            this.BtnBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBill.Image = global::CMS.Properties.Resources._54908_200;
            this.BtnBill.Location = new System.Drawing.Point(248, 286);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.Size = new System.Drawing.Size(377, 365);
            this.BtnBill.TabIndex = 10;
            this.BtnBill.Text = "Bill";
            this.BtnBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBill.UseVisualStyleBackColor = false;
            this.BtnBill.Click += new System.EventHandler(this.BtnBill_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BTnHistory);
            this.Controls.Add(this.BtnBill);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1787, 936);
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBill;
        private System.Windows.Forms.Button BTnHistory;
        private System.Windows.Forms.Button BtnReport;
    }
}
