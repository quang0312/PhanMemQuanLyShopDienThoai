
namespace ShopDienThoai
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnOffPRO = new System.Windows.Forms.Button();
            this.gbxIPIFProduct = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxSearchProduct = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxNhaSanXuat = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxProductList = new System.Windows.Forms.GroupBox();
            this.dgvwSanPham = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbxIPIFProduct.SuspendLayout();
            this.gbxProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1424, 12);
            this.panel2.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1245, 25);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(1293, 16);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 30);
            this.btnHideForm.TabIndex = 21;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // btnOffPRO
            // 
            this.btnOffPRO.FlatAppearance.BorderSize = 0;
            this.btnOffPRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffPRO.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffPRO.ForeColor = System.Drawing.Color.White;
            this.btnOffPRO.Image = ((System.Drawing.Image)(resources.GetObject("btnOffPRO.Image")));
            this.btnOffPRO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffPRO.Location = new System.Drawing.Point(1356, 16);
            this.btnOffPRO.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffPRO.Name = "btnOffPRO";
            this.btnOffPRO.Size = new System.Drawing.Size(43, 30);
            this.btnOffPRO.TabIndex = 22;
            this.btnOffPRO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffPRO.UseVisualStyleBackColor = true;
            this.btnOffPRO.Click += new System.EventHandler(this.btnOffPRO_Click);
            // 
            // gbxIPIFProduct
            // 
            this.gbxIPIFProduct.AutoSize = true;
            this.gbxIPIFProduct.Controls.Add(this.btnSearch);
            this.gbxIPIFProduct.Controls.Add(this.txtSearch);
            this.gbxIPIFProduct.Controls.Add(this.cbxSearchProduct);
            this.gbxIPIFProduct.Controls.Add(this.label9);
            this.gbxIPIFProduct.Controls.Add(this.txtAmount);
            this.gbxIPIFProduct.Controls.Add(this.txtPrice);
            this.gbxIPIFProduct.Controls.Add(this.label8);
            this.gbxIPIFProduct.Controls.Add(this.cbxNhaSanXuat);
            this.gbxIPIFProduct.Controls.Add(this.cbxColor);
            this.gbxIPIFProduct.Controls.Add(this.btnUpdate);
            this.gbxIPIFProduct.Controls.Add(this.btnClose);
            this.gbxIPIFProduct.Controls.Add(this.btnDelete);
            this.gbxIPIFProduct.Controls.Add(this.btnSave);
            this.gbxIPIFProduct.Controls.Add(this.cbxLoaiSP);
            this.gbxIPIFProduct.Controls.Add(this.txtProductName);
            this.gbxIPIFProduct.Controls.Add(this.txtProductCode);
            this.gbxIPIFProduct.Controls.Add(this.label7);
            this.gbxIPIFProduct.Controls.Add(this.label6);
            this.gbxIPIFProduct.Controls.Add(this.label5);
            this.gbxIPIFProduct.Controls.Add(this.label4);
            this.gbxIPIFProduct.Controls.Add(this.label3);
            this.gbxIPIFProduct.Controls.Add(this.label2);
            this.gbxIPIFProduct.Location = new System.Drawing.Point(0, 78);
            this.gbxIPIFProduct.Margin = new System.Windows.Forms.Padding(4);
            this.gbxIPIFProduct.Name = "gbxIPIFProduct";
            this.gbxIPIFProduct.Padding = new System.Windows.Forms.Padding(4);
            this.gbxIPIFProduct.Size = new System.Drawing.Size(1422, 280);
            this.gbxIPIFProduct.TabIndex = 23;
            this.gbxIPIFProduct.TabStop = false;
            this.gbxIPIFProduct.Text = "Thông Tin Sản Phẩm";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(594, 214);
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
            // cbxSearchProduct
            // 
            this.cbxSearchProduct.FormattingEnabled = true;
            this.cbxSearchProduct.Location = new System.Drawing.Point(126, 214);
            this.cbxSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchProduct.Name = "cbxSearchProduct";
            this.cbxSearchProduct.Size = new System.Drawing.Size(160, 24);
            this.cbxSearchProduct.TabIndex = 17;
            this.cbxSearchProduct.SelectedIndexChanged += new System.EventHandler(this.cbxSearchProduct_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 218);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tìm Kiếm:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(900, 140);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(349, 22);
            this.txtAmount.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(900, 194);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(349, 22);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(720, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giá:";
            // 
            // cbxNhaSanXuat
            // 
            this.cbxNhaSanXuat.FormattingEnabled = true;
            this.cbxNhaSanXuat.Location = new System.Drawing.Point(900, 85);
            this.cbxNhaSanXuat.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNhaSanXuat.Name = "cbxNhaSanXuat";
            this.cbxNhaSanXuat.Size = new System.Drawing.Size(349, 24);
            this.cbxNhaSanXuat.TabIndex = 10;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(900, 30);
            this.cbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(349, 24);
            this.cbxColor.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(1091, 229);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 15;
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
            this.btnClose.TabIndex = 16;
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
            this.btnDelete.TabIndex = 14;
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
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxLoaiSP
            // 
            this.cbxLoaiSP.FormattingEnabled = true;
            this.cbxLoaiSP.Location = new System.Drawing.Point(235, 158);
            this.cbxLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLoaiSP.Name = "cbxLoaiSP";
            this.cbxLoaiSP.Size = new System.Drawing.Size(349, 24);
            this.cbxLoaiSP.TabIndex = 8;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(235, 91);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(349, 22);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(235, 30);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(349, 22);
            this.txtProductCode.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhà Sản Xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại SP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên SP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SP:";
            // 
            // gbxProductList
            // 
            this.gbxProductList.AutoSize = true;
            this.gbxProductList.Controls.Add(this.dgvwSanPham);
            this.gbxProductList.Location = new System.Drawing.Point(0, 366);
            this.gbxProductList.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProductList.Name = "gbxProductList";
            this.gbxProductList.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProductList.Size = new System.Drawing.Size(1434, 420);
            this.gbxProductList.TabIndex = 24;
            this.gbxProductList.TabStop = false;
            this.gbxProductList.Text = "Danh sách Sản Phẩm";
            // 
            // dgvwSanPham
            // 
            this.dgvwSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvwSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSanPham.Location = new System.Drawing.Point(0, 23);
            this.dgvwSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwSanPham.Name = "dgvwSanPham";
            this.dgvwSanPham.RowHeadersWidth = 62;
            this.dgvwSanPham.Size = new System.Drawing.Size(1426, 374);
            this.dgvwSanPham.TabIndex = 0;
            this.dgvwSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSanPham_CellClick);
            this.dgvwSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSanPham_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(586, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 47);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sản Phẩm";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(72, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 786);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxProductList);
            this.Controls.Add(this.gbxIPIFProduct);
            this.Controls.Add(this.btnOffPRO);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel2);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.gbxIPIFProduct.ResumeLayout(false);
            this.gbxIPIFProduct.PerformLayout();
            this.gbxProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Button btnOffPRO;
        private System.Windows.Forms.GroupBox gbxIPIFProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxSearchProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxNhaSanXuat;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxLoaiSP;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxProductList;
        private System.Windows.Forms.DataGridView dgvwSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}