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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaleReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOldGold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsignment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPromotion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuCustomerData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSale,
            this.mnuOldGold,
            this.mnuConsignment,
            this.mnuInventory,
            this.mnuCustomer,
            this.mnuEmployee,
            this.mnuPromotion,
            this.mnuWindows});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.MdiWindowListItem = this.mnuWindows;
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(802, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuMain";
            // 
            // mnuSale
            // 
            this.mnuSale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaleDaily,
            this.mnuSaleReport});
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(72, 20);
            this.mnuSale.Text = "ขายทองใหม่";
            // 
            // mnuSaleDaily
            // 
            this.mnuSaleDaily.Name = "mnuSaleDaily";
            this.mnuSaleDaily.Size = new System.Drawing.Size(131, 22);
            this.mnuSaleDaily.Text = "ขายประจำวัน";
            this.mnuSaleDaily.Click += new System.EventHandler(this.mnuSaleDaily_Click);
            // 
            // mnuSaleReport
            // 
            this.mnuSaleReport.Name = "mnuSaleReport";
            this.mnuSaleReport.Size = new System.Drawing.Size(131, 22);
            this.mnuSaleReport.Text = "สรุปการขาย";
            // 
            // mnuOldGold
            // 
            this.mnuOldGold.Name = "mnuOldGold";
            this.mnuOldGold.Size = new System.Drawing.Size(65, 20);
            this.mnuOldGold.Text = "ซื้อทองเก่า";
            // 
            // mnuConsignment
            // 
            this.mnuConsignment.Name = "mnuConsignment";
            this.mnuConsignment.Size = new System.Drawing.Size(56, 20);
            this.mnuConsignment.Text = "ขายฝาก";
            // 
            // mnuInventory
            // 
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(70, 20);
            this.mnuInventory.Text = "สต๊อกสินค้า";
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomerData});
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(44, 20);
            this.mnuCustomer.Text = "ลูกค้า";
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(58, 20);
            this.mnuEmployee.Text = "พนักงาน";
            // 
            // mnuPromotion
            // 
            this.mnuPromotion.Name = "mnuPromotion";
            this.mnuPromotion.Size = new System.Drawing.Size(60, 20);
            this.mnuPromotion.Text = "โปรโมชั่น";
            // 
            // mnuWindows
            // 
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(55, 20);
            this.mnuWindows.Text = "หน้า&ต่าง";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(802, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuCustomerData
            // 
            this.mnuCustomerData.Name = "mnuCustomerData";
            this.mnuCustomerData.Size = new System.Drawing.Size(152, 22);
            this.mnuCustomerData.Text = "ข้อมูลลูกค้า";
            this.mnuCustomerData.Click += new System.EventHandler(this.mnuCustomerData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 449);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuSaleDaily;
        private System.Windows.Forms.ToolStripMenuItem mnuOldGold;
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
    }
}

