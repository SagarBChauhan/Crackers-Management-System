namespace CMS
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            ManiXButton.Office2010White office2010White1 = new ManiXButton.Office2010White();
            ManiXButton.Office2010Publisher office2010Publisher1 = new ManiXButton.Office2010Publisher();
            ManiXButton.Office2010Red office2010Red1 = new ManiXButton.Office2010Red();
            ManiXButton.Office2010Green office2010Green1 = new ManiXButton.Office2010Green();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBillId = new System.Windows.Forms.TextBox();
            this.cbCatagoryName = new System.Windows.Forms.ComboBox();
            this.cbSubcategoryName = new System.Windows.Forms.ComboBox();
            this.TxtItemId = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbFirstName = new System.Windows.Forms.ComboBox();
            this.CbLastName = new System.Windows.Forms.ComboBox();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblError = new System.Windows.Forms.Label();
            this.LblTotalAmount = new System.Windows.Forms.Label();
            this.LblQty = new System.Windows.Forms.Label();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.GroupCustomer = new System.Windows.Forms.GroupBox();
            this.btnNextCust = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupProduct = new System.Windows.Forms.GroupBox();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnSerchItem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnPrintBill = new ManiXButton.XButton();
            this.BtnEnable = new ManiXButton.XButton();
            this.BtnReset = new ManiXButton.XButton();
            this.BtnRemove = new ManiXButton.XButton();
            this.BtnAdd = new ManiXButton.XButton();
            this.AvilQty = new ControlsDemo.ExtdTextBox();
            this.TxtTotalAmt = new ControlsDemo.ExtdTextBox();
            this.TxtPrice = new ControlsDemo.ExtdTextBox();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupCustomer.SuspendLayout();
            this.groupProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // TxtBillId
            // 
            resources.ApplyResources(this.TxtBillId, "TxtBillId");
            this.TxtBillId.Name = "TxtBillId";
            // 
            // cbCatagoryName
            // 
            this.cbCatagoryName.FormattingEnabled = true;
            resources.ApplyResources(this.cbCatagoryName, "cbCatagoryName");
            this.cbCatagoryName.Name = "cbCatagoryName";
            this.cbCatagoryName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbSubcategoryName
            // 
            this.cbSubcategoryName.FormattingEnabled = true;
            resources.ApplyResources(this.cbSubcategoryName, "cbSubcategoryName");
            this.cbSubcategoryName.Name = "cbSubcategoryName";
            this.cbSubcategoryName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cbSubcategoryName.Leave += new System.EventHandler(this.cbSubcategoryName_Leave);
            // 
            // TxtItemId
            // 
            resources.ApplyResources(this.TxtItemId, "TxtItemId");
            this.TxtItemId.Name = "TxtItemId";
            // 
            // TxtQty
            // 
            resources.ApplyResources(this.TxtQty, "TxtQty");
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Leave += new System.EventHandler(this.TxtQty_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // cbFirstName
            // 
            this.cbFirstName.FormattingEnabled = true;
            resources.ApplyResources(this.cbFirstName, "cbFirstName");
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Leave += new System.EventHandler(this.cbFirstName_Leave);
            // 
            // CbLastName
            // 
            this.CbLastName.FormattingEnabled = true;
            resources.ApplyResources(this.CbLastName, "CbLastName");
            this.CbLastName.Name = "CbLastName";
            this.CbLastName.Leave += new System.EventHandler(this.CbLastName_Leave);
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            resources.ApplyResources(this.listViewItems, "listViewItems");
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.SelectedIndexChanged += new System.EventHandler(this.listViewItems_SelectedIndexChanged);
            this.listViewItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewItems_MouseClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewItems);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // LblError
            // 
            resources.ApplyResources(this.LblError, "LblError");
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Name = "LblError";
            // 
            // LblTotalAmount
            // 
            resources.ApplyResources(this.LblTotalAmount, "LblTotalAmount");
            this.LblTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTotalAmount.Name = "LblTotalAmount";
            // 
            // LblQty
            // 
            resources.ApplyResources(this.LblQty, "LblQty");
            this.LblQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblQty.Name = "LblQty";
            // 
            // BtnContinue
            // 
            this.BtnContinue.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnContinue, "BtnContinue");
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            this.BtnContinue.Leave += new System.EventHandler(this.BtnContinue_Leave);
            // 
            // GroupCustomer
            // 
            this.GroupCustomer.Controls.Add(this.btnNextCust);
            this.GroupCustomer.Controls.Add(this.BtnContinue);
            this.GroupCustomer.Controls.Add(this.BtnAddCustomer);
            this.GroupCustomer.Controls.Add(this.button2);
            this.GroupCustomer.Controls.Add(this.CbLastName);
            this.GroupCustomer.Controls.Add(this.cbFirstName);
            this.GroupCustomer.Controls.Add(this.TxtBillId);
            this.GroupCustomer.Controls.Add(this.label8);
            this.GroupCustomer.Controls.Add(this.label1);
            this.GroupCustomer.Controls.Add(this.dateTimePicker1);
            resources.ApplyResources(this.GroupCustomer, "GroupCustomer");
            this.GroupCustomer.Name = "GroupCustomer";
            this.GroupCustomer.TabStop = false;
            // 
            // btnNextCust
            // 
            this.btnNextCust.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnNextCust, "btnNextCust");
            this.btnNextCust.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__10_;
            this.btnNextCust.Name = "btnNextCust";
            this.btnNextCust.UseVisualStyleBackColor = true;
            this.btnNextCust.Click += new System.EventHandler(this.btnNextCust_Click);
            this.btnNextCust.Leave += new System.EventHandler(this.btnNextCust_Leave);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnAddCustomer, "BtnAddCustomer");
            this.BtnAddCustomer.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__8_;
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddcus_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__7_;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupProduct
            // 
            this.groupProduct.Controls.Add(this.BtnPrevious);
            this.groupProduct.Controls.Add(this.AvilQty);
            this.groupProduct.Controls.Add(this.TxtTotalAmt);
            this.groupProduct.Controls.Add(this.TxtPrice);
            this.groupProduct.Controls.Add(this.BtnSerchItem);
            this.groupProduct.Controls.Add(this.cbSubcategoryName);
            this.groupProduct.Controls.Add(this.cbCatagoryName);
            this.groupProduct.Controls.Add(this.TxtQty);
            this.groupProduct.Controls.Add(this.TxtItemId);
            this.groupProduct.Controls.Add(this.label4);
            this.groupProduct.Controls.Add(this.label6);
            this.groupProduct.Controls.Add(this.label5);
            this.groupProduct.Controls.Add(this.label3);
            this.groupProduct.Controls.Add(this.label2);
            resources.ApplyResources(this.groupProduct, "groupProduct");
            this.groupProduct.Name = "groupProduct";
            this.groupProduct.TabStop = false;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnPrevious, "BtnPrevious");
            this.BtnPrevious.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__9_;
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            this.BtnPrevious.Leave += new System.EventHandler(this.BtnPrevious_Leave);
            // 
            // BtnSerchItem
            // 
            this.BtnSerchItem.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnSerchItem, "BtnSerchItem");
            this.BtnSerchItem.Image = global::CMS.Properties.Resources.Webp_net_resizeimage__7_;
            this.BtnSerchItem.Name = "BtnSerchItem";
            this.BtnSerchItem.UseVisualStyleBackColor = true;
            this.BtnSerchItem.Click += new System.EventHandler(this.BtnSerchItem_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Name = "label10";
            // 
            // LblUser
            // 
            resources.ApplyResources(this.LblUser, "LblUser");
            this.LblUser.Name = "LblUser";
            // 
            // BtnPrintBill
            // 
            office2010White1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010White1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010White1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010White1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010White1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            office2010White1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            office2010White1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            office2010White1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010White1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010White1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010White1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010White1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010White1.TextColor = System.Drawing.Color.Black;
            this.BtnPrintBill.ColorTable = office2010White1;
            resources.ApplyResources(this.BtnPrintBill, "BtnPrintBill");
            this.BtnPrintBill.Name = "BtnPrintBill";
            this.BtnPrintBill.Theme = ManiXButton.Theme.MSOffice2010_WHITE;
            this.BtnPrintBill.UseVisualStyleBackColor = true;
            this.BtnPrintBill.Click += new System.EventHandler(this.BtnPrintBill_Click);
            // 
            // BtnEnable
            // 
            this.BtnEnable.ColorTable = office2010White1;
            resources.ApplyResources(this.BtnEnable, "BtnEnable");
            this.BtnEnable.Name = "BtnEnable";
            this.BtnEnable.Theme = ManiXButton.Theme.MSOffice2010_WHITE;
            this.BtnEnable.UseVisualStyleBackColor = true;
            this.BtnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
            // 
            // BtnReset
            // 
            office2010Publisher1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Publisher1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Publisher1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Publisher1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Publisher1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Publisher1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Publisher1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            office2010Publisher1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            office2010Publisher1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            office2010Publisher1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            office2010Publisher1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Publisher1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Publisher1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Publisher1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Publisher1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Publisher1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Publisher1.TextColor = System.Drawing.Color.White;
            this.BtnReset.ColorTable = office2010Publisher1;
            resources.ApplyResources(this.BtnReset, "BtnReset");
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Theme = ManiXButton.Theme.MSOffice2010_Publisher;
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnRemove
            // 
            office2010Red1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Red1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Red1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Red1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Red1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Red1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Red1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            office2010Red1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            office2010Red1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(77)))), ((int)(((byte)(45)))));
            office2010Red1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            office2010Red1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Red1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Red1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Red1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Red1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Red1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Red1.TextColor = System.Drawing.Color.White;
            this.BtnRemove.ColorTable = office2010Red1;
            resources.ApplyResources(this.BtnRemove, "BtnRemove");
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Theme = ManiXButton.Theme.MSOffice2010_RED;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            office2010Green1.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(72)))), ((int)(((byte)(161)))));
            office2010Green1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(135)))), ((int)(((byte)(228)))));
            office2010Green1.ButtonMouseOverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonMouseOverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonMouseOverColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(137)))));
            office2010Green1.ButtonMouseOverColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            office2010Green1.ButtonNormalColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonNormalColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(43)))));
            office2010Green1.ButtonNormalColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            office2010Green1.ButtonSelectedColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(199)))), ((int)(((byte)(87)))));
            office2010Green1.ButtonSelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(215)))));
            office2010Green1.ButtonSelectedColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(117)))));
            office2010Green1.ButtonSelectedColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(107)))));
            office2010Green1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            office2010Green1.TextColor = System.Drawing.Color.White;
            this.BtnAdd.ColorTable = office2010Green1;
            resources.ApplyResources(this.BtnAdd, "BtnAdd");
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Theme = ManiXButton.Theme.MSOffice2010_Green;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AvilQty
            // 
            this.AvilQty.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.AvilQty, "AvilQty");
            this.AvilQty.Name = "AvilQty";
            this.AvilQty.WaterMarkColor = System.Drawing.Color.Gray;
            this.AvilQty.WaterMarkFont = null;
            this.AvilQty.WaterMarkText = "Avilable Qty";
            // 
            // TxtTotalAmt
            // 
            this.TxtTotalAmt.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.TxtTotalAmt, "TxtTotalAmt");
            this.TxtTotalAmt.Name = "TxtTotalAmt";
            this.TxtTotalAmt.WaterMarkColor = System.Drawing.Color.Gray;
            this.TxtTotalAmt.WaterMarkFont = null;
            this.TxtTotalAmt.WaterMarkText = "Amount";
            // 
            // TxtPrice
            // 
            this.TxtPrice.ForeColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.TxtPrice, "TxtPrice");
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.Gray;
            this.TxtPrice.WaterMarkFont = null;
            this.TxtPrice.WaterMarkText = "Price";
            // 
            // Bill
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.LblTotalAmount);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblQty);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnPrintBill);
            this.Controls.Add(this.BtnEnable);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.GroupCustomer);
            this.Controls.Add(this.groupProduct);
            this.Name = "Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bill_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupCustomer.ResumeLayout(false);
            this.GroupCustomer.PerformLayout();
            this.groupProduct.ResumeLayout(false);
            this.groupProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBillId;
        private System.Windows.Forms.ComboBox cbCatagoryName;
        private System.Windows.Forms.ComboBox cbSubcategoryName;
        private System.Windows.Forms.TextBox TxtItemId;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbFirstName;
        private System.Windows.Forms.ComboBox CbLastName;
        private ManiXButton.XButton BtnAdd;
        private ManiXButton.XButton BtnRemove;
        private ManiXButton.XButton BtnReset;
        private System.Windows.Forms.Button BtnSerchItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private ManiXButton.XButton BtnEnable;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblError;
        private ManiXButton.XButton BtnPrintBill;
        private System.Windows.Forms.Label LblTotalAmount;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Button BtnContinue;
        private ControlsDemo.ExtdTextBox TxtPrice;
        private ControlsDemo.ExtdTextBox TxtTotalAmt;
        private ControlsDemo.ExtdTextBox AvilQty;
        private System.Windows.Forms.GroupBox GroupCustomer;
        private System.Windows.Forms.Button btnNextCust;
        private System.Windows.Forms.GroupBox groupProduct;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblUser;
    }
}