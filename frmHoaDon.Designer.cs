
namespace ShopDienThoai
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxGenInfo = new System.Windows.Forms.GroupBox();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpDOS = new System.Windows.Forms.DateTimePicker();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxProInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbxMaHD = new System.Windows.Forms.ComboBox();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnReloadForm = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvwChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.txtIntoMoney = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnOffBill = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxGenInfo.SuspendLayout();
            this.gbxProInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1391, 12);
            this.panel2.TabIndex = 7;
            // 
            // gbxGenInfo
            // 
            this.gbxGenInfo.Controls.Add(this.txtPhoneCustomer);
            this.gbxGenInfo.Controls.Add(this.txtAddressCustomer);
            this.gbxGenInfo.Controls.Add(this.txtCustomerName);
            this.gbxGenInfo.Controls.Add(this.cboMaKhach);
            this.gbxGenInfo.Controls.Add(this.txtStaffName);
            this.gbxGenInfo.Controls.Add(this.cboMaNhanVien);
            this.gbxGenInfo.Controls.Add(this.dtpDOS);
            this.gbxGenInfo.Controls.Add(this.txtBillCode);
            this.gbxGenInfo.Controls.Add(this.label9);
            this.gbxGenInfo.Controls.Add(this.label8);
            this.gbxGenInfo.Controls.Add(this.label7);
            this.gbxGenInfo.Controls.Add(this.label6);
            this.gbxGenInfo.Controls.Add(this.label5);
            this.gbxGenInfo.Controls.Add(this.label4);
            this.gbxGenInfo.Controls.Add(this.label3);
            this.gbxGenInfo.Controls.Add(this.label2);
            this.gbxGenInfo.Location = new System.Drawing.Point(0, 64);
            this.gbxGenInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGenInfo.Name = "gbxGenInfo";
            this.gbxGenInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGenInfo.Size = new System.Drawing.Size(1394, 278);
            this.gbxGenInfo.TabIndex = 8;
            this.gbxGenInfo.TabStop = false;
            this.gbxGenInfo.Text = "General Information";
            this.gbxGenInfo.Enter += new System.EventHandler(this.gbxGenInfo_Enter);
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Enabled = false;
            this.txtPhoneCustomer.Location = new System.Drawing.Point(916, 210);
            this.txtPhoneCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(380, 22);
            this.txtPhoneCustomer.TabIndex = 15;
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Enabled = false;
            this.txtAddressCustomer.Location = new System.Drawing.Point(916, 154);
            this.txtAddressCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(380, 22);
            this.txtAddressCustomer.TabIndex = 14;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(916, 94);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(380, 22);
            this.txtCustomerName.TabIndex = 13;
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(916, 32);
            this.cboMaKhach.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(380, 24);
            this.cboMaKhach.TabIndex = 12;
            this.cboMaKhach.SelectedIndexChanged += new System.EventHandler(this.cboMaKhach_SelectedIndexChanged);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Enabled = false;
            this.txtStaffName.Location = new System.Drawing.Point(212, 214);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(380, 22);
            this.txtStaffName.TabIndex = 11;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(212, 154);
            this.cboMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(380, 24);
            this.cboMaNhanVien.TabIndex = 10;
            this.cboMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboMaNhanVien_SelectedIndexChanged);
            // 
            // dtpDOS
            // 
            this.dtpDOS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOS.Location = new System.Drawing.Point(212, 90);
            this.dtpDOS.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOS.Name = "dtpDOS";
            this.dtpDOS.Size = new System.Drawing.Size(380, 22);
            this.dtpDOS.TabIndex = 9;
            this.dtpDOS.ValueChanged += new System.EventHandler(this.dtpDOS_ValueChanged);
            // 
            // txtBillCode
            // 
            this.txtBillCode.Location = new System.Drawing.Point(212, 34);
            this.txtBillCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(380, 22);
            this.txtBillCode.TabIndex = 8;
            this.txtBillCode.TextChanged += new System.EventHandler(this.txtBillCode_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(756, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(756, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(756, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Customer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(756, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Customer Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Staff Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Staff Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill Code:";
            // 
            // gbxProInfo
            // 
            this.gbxProInfo.Controls.Add(this.label1);
            this.gbxProInfo.Controls.Add(this.btnTimKiem);
            this.gbxProInfo.Controls.Add(this.cbxMaHD);
            this.gbxProInfo.Controls.Add(this.btnAddBill);
            this.gbxProInfo.Controls.Add(this.btnReloadForm);
            this.gbxProInfo.Controls.Add(this.btnDeleteProduct);
            this.gbxProInfo.Controls.Add(this.btnInHD);
            this.gbxProInfo.Controls.Add(this.btnLuu);
            this.gbxProInfo.Controls.Add(this.txtTotal);
            this.gbxProInfo.Controls.Add(this.label16);
            this.gbxProInfo.Controls.Add(this.dgvwChiTietHoaDon);
            this.gbxProInfo.Controls.Add(this.txtIntoMoney);
            this.gbxProInfo.Controls.Add(this.txtUnitPrice);
            this.gbxProInfo.Controls.Add(this.txtDiscount);
            this.gbxProInfo.Controls.Add(this.txtProductName);
            this.gbxProInfo.Controls.Add(this.txtAmount);
            this.gbxProInfo.Controls.Add(this.cboMaHang);
            this.gbxProInfo.Controls.Add(this.label15);
            this.gbxProInfo.Controls.Add(this.label14);
            this.gbxProInfo.Controls.Add(this.label13);
            this.gbxProInfo.Controls.Add(this.label12);
            this.gbxProInfo.Controls.Add(this.label11);
            this.gbxProInfo.Controls.Add(this.label10);
            this.gbxProInfo.Location = new System.Drawing.Point(0, 359);
            this.gbxProInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProInfo.Name = "gbxProInfo";
            this.gbxProInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProInfo.Size = new System.Drawing.Size(1394, 385);
            this.gbxProInfo.TabIndex = 9;
            this.gbxProInfo.TabStop = false;
            this.gbxProInfo.Text = "Products Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(903, 333);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 41);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbxMaHD
            // 
            this.cbxMaHD.FormattingEnabled = true;
            this.cbxMaHD.Location = new System.Drawing.Point(747, 345);
            this.cbxMaHD.Name = "cbxMaHD";
            this.cbxMaHD.Size = new System.Drawing.Size(150, 24);
            this.cbxMaHD.TabIndex = 32;
            this.cbxMaHD.SelectedIndexChanged += new System.EventHandler(this.cbxMaHD_SelectedIndexChanged);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddBill.Location = new System.Drawing.Point(8, 337);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(135, 28);
            this.btnAddBill.TabIndex = 30;
            this.btnAddBill.Text = "Tạo Hóa Đơn";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnReloadForm
            // 
            this.btnReloadForm.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadForm.Image")));
            this.btnReloadForm.Location = new System.Drawing.Point(580, 337);
            this.btnReloadForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadForm.Name = "btnReloadForm";
            this.btnReloadForm.Size = new System.Drawing.Size(41, 37);
            this.btnReloadForm.TabIndex = 28;
            this.btnReloadForm.UseVisualStyleBackColor = true;
            this.btnReloadForm.Click += new System.EventHandler(this.btnReloadForm_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Location = new System.Drawing.Point(446, 337);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(126, 28);
            this.btnDeleteProduct.TabIndex = 27;
            this.btnDeleteProduct.Text = "Xóa Hóa Đơn";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.Yellow;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Location = new System.Drawing.Point(307, 337);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(131, 28);
            this.btnInHD.TabIndex = 26;
            this.btnInHD.Text = "IN HÓA ĐƠN";
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnCancelBill_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuu.Location = new System.Drawing.Point(151, 337);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(143, 28);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "LƯU HÓA ĐƠN";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1121, 344);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(247, 22);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1069, 348);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "Total:";
            // 
            // dgvwChiTietHoaDon
            // 
            this.dgvwChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvwChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwChiTietHoaDon.Location = new System.Drawing.Point(0, 141);
            this.dgvwChiTietHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwChiTietHoaDon.Name = "dgvwChiTietHoaDon";
            this.dgvwChiTietHoaDon.RowHeadersWidth = 62;
            this.dgvwChiTietHoaDon.Size = new System.Drawing.Size(1378, 185);
            this.dgvwChiTietHoaDon.TabIndex = 17;
            this.dgvwChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwChiTietHoaDon_CellClick);
            this.dgvwChiTietHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwChiTietHoaDon_CellContentClick);
            // 
            // txtIntoMoney
            // 
            this.txtIntoMoney.Enabled = false;
            this.txtIntoMoney.Location = new System.Drawing.Point(1063, 87);
            this.txtIntoMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntoMoney.Name = "txtIntoMoney";
            this.txtIntoMoney.Size = new System.Drawing.Size(247, 22);
            this.txtIntoMoney.TabIndex = 16;
            this.txtIntoMoney.TextChanged += new System.EventHandler(this.txtIntoMoney_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(1063, 30);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(247, 22);
            this.txtUnitPrice.TabIndex = 15;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(643, 87);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(289, 22);
            this.txtDiscount.TabIndex = 14;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Location = new System.Drawing.Point(643, 30);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(289, 22);
            this.txtProductName.TabIndex = 13;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(210, 87);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(288, 22);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(210, 30);
            this.cboMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(288, 24);
            this.cboMaHang.TabIndex = 11;
            this.cboMaHang.SelectedIndexChanged += new System.EventHandler(this.cboMaHang_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(971, 91);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Thành Tiền:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(971, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Đơn Gía:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(531, 91);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Giảm giá %:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(531, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tên Sản Phẩm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Product Code:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(1267, 13);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 30);
            this.btnHideForm.TabIndex = 24;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // btnOffBill
            // 
            this.btnOffBill.FlatAppearance.BorderSize = 0;
            this.btnOffBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffBill.ForeColor = System.Drawing.Color.White;
            this.btnOffBill.Image = ((System.Drawing.Image)(resources.GetObject("btnOffBill.Image")));
            this.btnOffBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffBill.Location = new System.Drawing.Point(1319, 13);
            this.btnOffBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffBill.Name = "btnOffBill";
            this.btnOffBill.Size = new System.Drawing.Size(43, 30);
            this.btnOffBill.TabIndex = 23;
            this.btnOffBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffBill.UseVisualStyleBackColor = true;
            this.btnOffBill.Click += new System.EventHandler(this.btnOffBill_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1238, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(583, 13);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 47);
            this.label17.TabIndex = 26;
            this.label17.Text = "HÓA ĐƠN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 739);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.btnOffBill);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gbxProInfo);
            this.Controls.Add(this.gbxGenInfo);
            this.Controls.Add(this.panel2);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.gbxGenInfo.ResumeLayout(false);
            this.gbxGenInfo.PerformLayout();
            this.gbxProInfo.ResumeLayout(false);
            this.gbxProInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbxGenInfo;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpDOS;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxProInfo;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnReloadForm;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvwChiTietHoaDon;
        private System.Windows.Forms.TextBox txtIntoMoney;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Button btnOffBill;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbxMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
       
    }
}