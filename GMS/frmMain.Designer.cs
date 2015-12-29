namespace GMS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsignment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPromotion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuInventoryInput = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventoryProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventoryProductType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployeeAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployeeChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBuyDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsignmentDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsignmentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.lbStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSale,
            this.mnuBuy,
            this.mnuConsignment,
            this.mnuInventory,
            this.mnuCustomer,
            this.mnuEmployee,
            this.mnuPromotion,
            this.mnuWindows});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.MdiWindowListItem = this.mnuWindows;
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(635, 26);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuMain";
            // 
            // mnuSale
            // 
            this.mnuSale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaleDaily,
            this.mnuSaleReport});
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(37, 20);
            this.mnuSale.Text = "&ขาย";
            // 
            // mnuSaleDaily
            // 
            this.mnuSaleDaily.Name = "mnuSaleDaily";
            this.mnuSaleDaily.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuSaleDaily.Size = new System.Drawing.Size(152, 22);
            this.mnuSaleDaily.Text = "ขายประจำวัน";
            this.mnuSaleDaily.Click += new System.EventHandler(this.mnuSaleDaily_Click);
            // 
            // mnuSaleReport
            // 
            this.mnuSaleReport.Name = "mnuSaleReport";
            this.mnuSaleReport.Size = new System.Drawing.Size(152, 22);
            this.mnuSaleReport.Text = "สรุปการขาย";
            // 
            // mnuBuy
            // 
            this.mnuBuy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBuyDaily});
            this.mnuBuy.Name = "mnuBuy";
            this.mnuBuy.Size = new System.Drawing.Size(39, 22);
            this.mnuBuy.Text = "&ซื้อ";
            // 
            // mnuConsignment
            // 
            this.mnuConsignment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsignmentDaily,
            this.mnuConsignmentReport});
            this.mnuConsignment.Name = "mnuConsignment";
            this.mnuConsignment.Size = new System.Drawing.Size(70, 22);
            this.mnuConsignment.Text = "ขาย&ฝาก";
            // 
            // mnuInventory
            // 
            this.mnuInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventoryInput,
            this.mnuInventoryProduct,
            this.mnuInventoryProductType});
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(90, 22);
            this.mnuInventory.Text = "&สต๊อกสินค้า";
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerData});
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(44, 20);
            this.mnuCustomer.Text = "&ลูกค้า";
            // 
            // mnuCustomerData
            // 
            this.mnuCustomerData.Name = "mnuCustomerData";
            this.mnuCustomerData.Size = new System.Drawing.Size(152, 22);
            this.mnuCustomerData.Text = "ข้อมูลลูกค้า";
            this.mnuCustomerData.Click += new System.EventHandler(this.mnuCustomerData_Click);
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEmployeeAdmin,
            this.mnuEmployeeChangePassword});
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(58, 20);
            this.mnuEmployee.Text = "&พนักงาน";
            // 
            // mnuPromotion
            // 
            this.mnuPromotion.Name = "mnuPromotion";
            this.mnuPromotion.Size = new System.Drawing.Size(60, 20);
            this.mnuPromotion.Text = "โ&ปรโมชั่น";
            // 
            // mnuWindows
            // 
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(55, 20);
            this.mnuWindows.Text = "หน้า&ต่าง";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatusDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(635, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuInventoryInput
            // 
            this.mnuInventoryInput.Name = "mnuInventoryInput";
            this.mnuInventoryInput.Size = new System.Drawing.Size(181, 22);
            this.mnuInventoryInput.Text = "นำสินค้าเข้าสู่คลัง";
            this.mnuInventoryInput.Click += new System.EventHandler(this.mnuInventoryInput_Click);
            // 
            // mnuInventoryProduct
            // 
            this.mnuInventoryProduct.Name = "mnuInventoryProduct";
            this.mnuInventoryProduct.Size = new System.Drawing.Size(181, 22);
            this.mnuInventoryProduct.Text = "รายการสินค้า";
            this.mnuInventoryProduct.Click += new System.EventHandler(this.mnuInventoryProduct_Click);
            // 
            // mnuInventoryProductType
            // 
            this.mnuInventoryProductType.Name = "mnuInventoryProductType";
            this.mnuInventoryProductType.Size = new System.Drawing.Size(181, 22);
            this.mnuInventoryProductType.Text = "ประเภทสินค้า";
            this.mnuInventoryProductType.Click += new System.EventHandler(this.mnuInventoryProductType_Click);
            // 
            // mnuEmployeeAdmin
            // 
            this.mnuEmployeeAdmin.Name = "mnuEmployeeAdmin";
            this.mnuEmployeeAdmin.Size = new System.Drawing.Size(152, 22);
            this.mnuEmployeeAdmin.Text = "ผู้ดูแลระบบ";
            // 
            // mnuEmployeeChangePassword
            // 
            this.mnuEmployeeChangePassword.Name = "mnuEmployeeChangePassword";
            this.mnuEmployeeChangePassword.Size = new System.Drawing.Size(152, 22);
            this.mnuEmployeeChangePassword.Text = "เปลี่ยนรหัสผ่าน";
            // 
            // mnuBuyDaily
            // 
            this.mnuBuyDaily.Name = "mnuBuyDaily";
            this.mnuBuyDaily.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnuBuyDaily.Size = new System.Drawing.Size(172, 22);
            this.mnuBuyDaily.Text = "ซื้อประจำวัน";
            this.mnuBuyDaily.Click += new System.EventHandler(this.mnuBuyDaily_Click);
            // 
            // mnuConsignmentDaily
            // 
            this.mnuConsignmentDaily.Name = "mnuConsignmentDaily";
            this.mnuConsignmentDaily.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuConsignmentDaily.Size = new System.Drawing.Size(181, 22);
            this.mnuConsignmentDaily.Text = "ระบบขายฝาก";
            this.mnuConsignmentDaily.Click += new System.EventHandler(this.mnuConsignmentDaily_Click);
            // 
            // mnuConsignmentReport
            // 
            this.mnuConsignmentReport.Name = "mnuConsignmentReport";
            this.mnuConsignmentReport.Size = new System.Drawing.Size(153, 22);
            this.mnuConsignmentReport.Text = "สรุปข้อมูล";
            // 
            // lbStatusDate
            // 
            this.lbStatusDate.Name = "lbStatusDate";
            this.lbStatusDate.Size = new System.Drawing.Size(44, 17);
            this.lbStatusDate.Text = "วันเวลา :";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GMS.Properties.Resources.blurred_golden_background_11289575386nW6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 294);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "การบริหารจัดการร้านทองเจริญวงศ์";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuSaleDaily;
        private System.Windows.Forms.ToolStripMenuItem mnuBuy;
        private System.Windows.Forms.ToolStripMenuItem mnuConsignment;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuPromotion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuWindows;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSaleReport;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerData;
        private System.Windows.Forms.ToolStripMenuItem mnuBuyDaily;
        private System.Windows.Forms.ToolStripMenuItem mnuInventoryInput;
        private System.Windows.Forms.ToolStripMenuItem mnuInventoryProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuInventoryProductType;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployeeAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployeeChangePassword;
        private System.Windows.Forms.ToolStripMenuItem mnuConsignmentDaily;
        private System.Windows.Forms.ToolStripMenuItem mnuConsignmentReport;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusDate;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

