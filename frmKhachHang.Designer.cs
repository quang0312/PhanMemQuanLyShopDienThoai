
namespace ShopDienThoai
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnOffCustomer = new System.Windows.Forms.Button();
            this.gbxIPIFCustomer = new System.Windows.Forms.GroupBox();
            this.cbxSearchCus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.txtAddressCus = new System.Windows.Forms.TextBox();
            this.txtPhoneCus = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCustomerList = new System.Windows.Forms.GroupBox();
            this.dgvwKhachHang = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxIPIFCustomer.SuspendLayout();
            this.gbxCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 12);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(495, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(1315, 18);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 30);
            this.btnHideForm.TabIndex = 23;
            this.btnHideForm.UseVisualStyleBackColor = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1286, 25);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID";
            // 
            // btnOffCustomer
            // 
            this.btnOffCustomer.FlatAppearance.BorderSize = 0;
            this.btnOffCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffCustomer.ForeColor = System.Drawing.Color.White;
            this.btnOffCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnOffCustomer.Image")));
            this.btnOffCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffCustomer.Location = new System.Drawing.Point(1366, 18);
            this.btnOffCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffCustomer.Name = "btnOffCustomer";
            this.btnOffCustomer.Size = new System.Drawing.Size(43, 30);
            this.btnOffCustomer.TabIndex = 24;
            this.btnOffCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffCustomer.UseVisualStyleBackColor = true;
            // 
            // gbxIPIFCustomer
            // 
            this.gbxIPIFCustomer.Controls.Add(this.cbxSearchCus);
            this.gbxIPIFCustomer.Controls.Add(this.btnSearch);
            this.gbxIPIFCustomer.Controls.Add(this.txtSearch);
            this.gbxIPIFCustomer.Controls.Add(this.label8);
            this.gbxIPIFCustomer.Controls.Add(this.btnUpdate);
            this.gbxIPIFCustomer.Controls.Add(this.btnClose);
            this.gbxIPIFCustomer.Controls.Add(this.btnDelete);
            this.gbxIPIFCustomer.Controls.Add(this.btnSave);
            this.gbxIPIFCustomer.Controls.Add(this.dtpDOB);
            this.gbxIPIFCustomer.Controls.Add(this.cbxGender);
            this.gbxIPIFCustomer.Controls.Add(this.txtAddressCus);
            this.gbxIPIFCustomer.Controls.Add(this.txtPhoneCus);
            this.gbxIPIFCustomer.Controls.Add(this.txtCustomerName);
            this.gbxIPIFCustomer.Controls.Add(this.txtCustomerCode);
            this.gbxIPIFCustomer.Controls.Add(this.label7);
            this.gbxIPIFCustomer.Controls.Add(this.label6);
            this.gbxIPIFCustomer.Controls.Add(this.label5);
            this.gbxIPIFCustomer.Controls.Add(this.label4);
            this.gbxIPIFCustomer.Controls.Add(this.label3);
            this.gbxIPIFCustomer.Controls.Add(this.label2);
            this.gbxIPIFCustomer.Location = new System.Drawing.Point(4, 95);
            this.gbxIPIFCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIPIFCustomer.Name = "gbxIPIFCustomer";
            this.gbxIPIFCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIPIFCustomer.Size = new System.Drawing.Size(1422, 258);
            this.gbxIPIFCustomer.TabIndex = 25;
            this.gbxIPIFCustomer.TabStop = false;
            this.gbxIPIFCustomer.Text = "Thông Tin khách Hàng";
            // 
            // cbxSearchCus
            // 
            this.cbxSearchCus.FormattingEnabled = true;
            this.cbxSearchCus.Location = new System.Drawing.Point(126, 214);
            this.cbxSearchCus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchCus.Name = "cbxSearchCus";
            this.cbxSearchCus.Size = new System.Drawing.Size(160, 24);
            this.cbxSearchCus.TabIndex = 17;
            this.cbxSearchCus.SelectedIndexChanged += new System.EventHandler(this.cbxSearchCus_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(599, 215);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 28);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(308, 215);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 22);
            this.txtSearch.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tìm Kiếm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(1091, 229);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1236, 229);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(946, 229);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(800, 229);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(900, 38);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(349, 22);
            this.dtpDOB.TabIndex = 9;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(235, 154);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(349, 24);
            this.cbxGender.TabIndex = 8;
            // 
            // txtAddressCus
            // 
            this.txtAddressCus.Location = new System.Drawing.Point(900, 178);
            this.txtAddressCus.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressCus.Name = "txtAddressCus";
            this.txtAddressCus.Size = new System.Drawing.Size(349, 22);
            this.txtAddressCus.TabIndex = 11;
            // 
            // txtPhoneCus
            // 
            this.txtPhoneCus.Location = new System.Drawing.Point(900, 108);
            this.txtPhoneCus.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneCus.Name = "txtPhoneCus";
            this.txtPhoneCus.Size = new System.Drawing.Size(349, 22);
            this.txtPhoneCus.TabIndex = 10;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(235, 96);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(349, 22);
            this.txtCustomerName.TabIndex = 7;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(235, 38);
            this.txtCustomerCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(349, 22);
            this.txtCustomerCode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã KH:";
            // 
            // gbxCustomerList
            // 
            this.gbxCustomerList.Controls.Add(this.dgvwKhachHang);
            this.gbxCustomerList.Location = new System.Drawing.Point(0, 381);
            this.gbxCustomerList.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCustomerList.Name = "gbxCustomerList";
            this.gbxCustomerList.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCustomerList.Size = new System.Drawing.Size(1422, 357);
            this.gbxCustomerList.TabIndex = 26;
            this.gbxCustomerList.TabStop = false;
            this.gbxCustomerList.Text = "Danh Sách Khách Hàng";
            // 
            // dgvwKhachHang
            // 
            this.dgvwKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvwKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwKhachHang.Location = new System.Drawing.Point(0, 23);
            this.dgvwKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwKhachHang.Name = "dgvwKhachHang";
            this.dgvwKhachHang.RowHeadersWidth = 62;
            this.dgvwKhachHang.Size = new System.Drawing.Size(1426, 334);
            this.dgvwKhachHang.TabIndex = 0;
            this.dgvwKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwKhachHang_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 751);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxCustomerList);
            this.Controls.Add(this.gbxIPIFCustomer);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnOffCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.gbxIPIFCustomer.ResumeLayout(false);
            this.gbxIPIFCustomer.PerformLayout();
            this.gbxCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnOffCustomer;
        private System.Windows.Forms.GroupBox gbxIPIFCustomer;
        private System.Windows.Forms.ComboBox cbxSearchCus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox txtAddressCus;
        private System.Windows.Forms.TextBox txtPhoneCus;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxCustomerList;
        private System.Windows.Forms.DataGridView dgvwKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}