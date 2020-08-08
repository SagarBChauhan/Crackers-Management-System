namespace CMS
{
    partial class UpdateItemForm
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
            ManiXButton.Office2010Blue office2010Blue1 = new ManiXButton.Office2010Blue();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnUpdate = new ManiXButton.XButton();
            this.dateTimePickerExp = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMFG = new System.Windows.Forms.DateTimePicker();
            this.TxtCateGoryId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtSupplierBrandId = new System.Windows.Forms.TextBox();
            this.TxtReOrder = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtSubCategoryName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtSubCategoryId = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.BtnSearch = new ManiXButton.XButton();
            this.BtnView = new ManiXButton.XButton();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(685, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(215, 40);
            this.label16.TabIndex = 213;
            this.label16.Text = "update Item";
            // 
            // BtnUpdate
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
            this.BtnUpdate.ColorTable = office2010Blue1;
            this.BtnUpdate.Location = new System.Drawing.Point(794, 680);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(122, 47);
            this.BtnUpdate.TabIndex = 212;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dateTimePickerExp
            // 
            this.dateTimePickerExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExp.Location = new System.Drawing.Point(1076, 395);
            this.dateTimePickerExp.Name = "dateTimePickerExp";
            this.dateTimePickerExp.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerExp.TabIndex = 211;
            this.dateTimePickerExp.Value = new System.DateTime(2019, 3, 18, 0, 0, 0, 0);
            // 
            // dateTimePickerMFG
            // 
            this.dateTimePickerMFG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMFG.Location = new System.Drawing.Point(1076, 362);
            this.dateTimePickerMFG.Name = "dateTimePickerMFG";
            this.dateTimePickerMFG.Size = new System.Drawing.Size(100, 22);
            this.dateTimePickerMFG.TabIndex = 210;
            // 
            // TxtCateGoryId
            // 
            this.TxtCateGoryId.Location = new System.Drawing.Point(1076, 560);
            this.TxtCateGoryId.Name = "TxtCateGoryId";
            this.TxtCateGoryId.Size = new System.Drawing.Size(100, 22);
            this.TxtCateGoryId.TabIndex = 209;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(851, 565);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 208;
            this.label17.Text = "Category Id:";
            // 
            // TxtSupplierBrandId
            // 
            this.TxtSupplierBrandId.Location = new System.Drawing.Point(1076, 527);
            this.TxtSupplierBrandId.Name = "TxtSupplierBrandId";
            this.TxtSupplierBrandId.Size = new System.Drawing.Size(100, 22);
            this.TxtSupplierBrandId.TabIndex = 207;
            // 
            // TxtReOrder
            // 
            this.TxtReOrder.Location = new System.Drawing.Point(1076, 494);
            this.TxtReOrder.Name = "TxtReOrder";
            this.TxtReOrder.Size = new System.Drawing.Size(100, 22);
            this.TxtReOrder.TabIndex = 206;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(851, 532);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 17);
            this.label18.TabIndex = 205;
            this.label18.Text = "Supplier Brand Id:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(851, 499);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 17);
            this.label19.TabIndex = 204;
            this.label19.Text = "Re-Order level:";
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(1076, 461);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(100, 22);
            this.TxtQty.TabIndex = 203;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(1076, 428);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 202;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(851, 466);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 17);
            this.label20.TabIndex = 201;
            this.label20.Text = "Quantity:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(851, 433);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 17);
            this.label21.TabIndex = 200;
            this.label21.Text = "Price:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(851, 400);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 17);
            this.label22.TabIndex = 199;
            this.label22.Text = "Exp Date:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(851, 367);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 17);
            this.label23.TabIndex = 198;
            this.label23.Text = "mfg Date:";
            // 
            // TxtSubCategoryName
            // 
            this.TxtSubCategoryName.Location = new System.Drawing.Point(1076, 329);
            this.TxtSubCategoryName.Name = "TxtSubCategoryName";
            this.TxtSubCategoryName.Size = new System.Drawing.Size(100, 22);
            this.TxtSubCategoryName.TabIndex = 195;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(851, 334);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(158, 17);
            this.label24.TabIndex = 197;
            this.label24.Text = "Sub-Category Name:";
            // 
            // TxtSubCategoryId
            // 
            this.TxtSubCategoryId.Location = new System.Drawing.Point(1076, 296);
            this.TxtSubCategoryId.Name = "TxtSubCategoryId";
            this.TxtSubCategoryId.Size = new System.Drawing.Size(100, 22);
            this.TxtSubCategoryId.TabIndex = 194;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(851, 301);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(130, 17);
            this.label25.TabIndex = 196;
            this.label25.Text = "Sub-Category Id:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.ColorTable = office2010Blue1;
            this.BtnSearch.Location = new System.Drawing.Point(1117, 680);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(122, 47);
            this.BtnSearch.TabIndex = 214;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnView
            // 
            this.BtnView.ColorTable = office2010Blue1;
            this.BtnView.Location = new System.Drawing.Point(963, 680);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(122, 47);
            this.BtnView.TabIndex = 215;
            this.BtnView.Text = "View";
            this.BtnView.Theme = ManiXButton.Theme.MSOffice2010_BLUE;
            this.BtnView.UseVisualStyleBackColor = true;
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 798);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.dateTimePickerExp);
            this.Controls.Add(this.dateTimePickerMFG);
            this.Controls.Add(this.TxtCateGoryId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtSupplierBrandId);
            this.Controls.Add(this.TxtReOrder);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TxtSubCategoryName);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.TxtSubCategoryId);
            this.Controls.Add(this.label25);
            this.Name = "UpdateItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateItemForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private ManiXButton.XButton BtnUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerExp;
        private System.Windows.Forms.DateTimePicker dateTimePickerMFG;
        private System.Windows.Forms.TextBox TxtCateGoryId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtSupplierBrandId;
        private System.Windows.Forms.TextBox TxtReOrder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TxtSubCategoryName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TxtSubCategoryId;
        private System.Windows.Forms.Label label25;
        private ManiXButton.XButton BtnSearch;
        private ManiXButton.XButton BtnView;
    }
}