namespace GMS
{
    partial class frmSale
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductVolumn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.txtProductSalePrice = new System.Windows.Forms.TextBox();
            this.txtProductWeight = new System.Windows.Forms.TextBox();
            this.txtProductTexture = new System.Windows.Forms.TextBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(70, 12);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(163, 20);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            this.txtCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสลูกค้า";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "วันที่";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ชื่อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "สกุล";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(70, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(212, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(338, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(211, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductVolumn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnFindProduct);
            this.groupBox1.Controls.Add(this.txtProductSalePrice);
            this.groupBox1.Controls.Add(this.txtProductWeight);
            this.groupBox1.Controls.Add(this.txtProductTexture);
            this.groupBox1.Controls.Add(this.txtProductType);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลสินค้า";
            // 
            // txtProductVolumn
            // 
            this.txtProductVolumn.Location = new System.Drawing.Point(372, 83);
            this.txtProductVolumn.Name = "txtProductVolumn";
            this.txtProductVolumn.ReadOnly = true;
            this.txtProductVolumn.Size = new System.Drawing.Size(156, 20);
            this.txtProductVolumn.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "เหลือในสต๊อก";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "บาท";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "กรัม";
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.Location = new System.Drawing.Point(138, 39);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(43, 23);
            this.btnFindProduct.TabIndex = 12;
            this.btnFindProduct.Text = "ค้นหา";
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // txtProductSalePrice
            // 
            this.txtProductSalePrice.Location = new System.Drawing.Point(199, 83);
            this.txtProductSalePrice.Name = "txtProductSalePrice";
            this.txtProductSalePrice.ReadOnly = true;
            this.txtProductSalePrice.Size = new System.Drawing.Size(135, 20);
            this.txtProductSalePrice.TabIndex = 9;
            // 
            // txtProductWeight
            // 
            this.txtProductWeight.Location = new System.Drawing.Point(32, 83);
            this.txtProductWeight.Name = "txtProductWeight";
            this.txtProductWeight.ReadOnly = true;
            this.txtProductWeight.Size = new System.Drawing.Size(122, 20);
            this.txtProductWeight.TabIndex = 8;
            // 
            // txtProductTexture
            // 
            this.txtProductTexture.Location = new System.Drawing.Point(372, 39);
            this.txtProductTexture.Name = "txtProductTexture";
            this.txtProductTexture.ReadOnly = true;
            this.txtProductTexture.Size = new System.Drawing.Size(156, 20);
            this.txtProductTexture.TabIndex = 7;
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(199, 39);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.ReadOnly = true;
            this.txtProductType.Size = new System.Drawing.Size(167, 20);
            this.txtProductType.TabIndex = 6;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(32, 39);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductID_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "ราคาขาย";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "นัำหนัก";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ลาย ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ชนิด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "รหัสสินค้า";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(239, 10);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(43, 23);
            this.btnFindCustomer.TabIndex = 1;
            this.btnFindCustomer.Text = "ค้นหา";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(257, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(358, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(16, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 24);
            this.panel1.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "สถานะ:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(153, 209);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "ขายใหม่";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 267);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerID);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ขายทองใหม่ประจำวัน";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductSalePrice;
        private System.Windows.Forms.TextBox txtProductWeight;
        private System.Windows.Forms.TextBox txtProductTexture;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtProductVolumn;
        private System.Windows.Forms.Label label5;
    }
}