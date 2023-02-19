
namespace ShopDienThoai
{
    partial class frmLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuong));
            this.gbxInfoSalary = new System.Windows.Forms.GroupBox();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkProbation = new System.Windows.Forms.CheckBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.cbxStaffCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.btnOffStaff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvwSalary = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSalayList = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxInfoSalary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInfoSalary
            // 
            this.gbxInfoSalary.Controls.Add(this.txtTotalSalary);
            this.gbxInfoSalary.Controls.Add(this.label7);
            this.gbxInfoSalary.Controls.Add(this.btnClose);
            this.gbxInfoSalary.Controls.Add(this.btnDelete);
            this.gbxInfoSalary.Controls.Add(this.btnUpdate);
            this.gbxInfoSalary.Controls.Add(this.btnSave);
            this.gbxInfoSalary.Controls.Add(this.txtBonus);
            this.gbxInfoSalary.Controls.Add(this.label5);
            this.gbxInfoSalary.Controls.Add(this.txtHours);
            this.gbxInfoSalary.Controls.Add(this.label4);
            this.gbxInfoSalary.Controls.Add(this.chkProbation);
            this.gbxInfoSalary.Controls.Add(this.txtStaffName);
            this.gbxInfoSalary.Controls.Add(this.cbxStaffCode);
            this.gbxInfoSalary.Controls.Add(this.label3);
            this.gbxInfoSalary.Controls.Add(this.label2);
            this.gbxInfoSalary.Location = new System.Drawing.Point(1, 111);
            this.gbxInfoSalary.Margin = new System.Windows.Forms.Padding(4);
            this.gbxInfoSalary.Name = "gbxInfoSalary";
            this.gbxInfoSalary.Padding = new System.Windows.Forms.Padding(4);
            this.gbxInfoSalary.Size = new System.Drawing.Size(1129, 215);
            this.gbxInfoSalary.TabIndex = 27;
            this.gbxInfoSalary.TabStop = false;
            this.gbxInfoSalary.Text = "Thông Tin Lương";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Location = new System.Drawing.Point(960, 98);
            this.txtTotalSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(118, 22);
            this.txtTotalSalary.TabIndex = 14;
            this.txtTotalSalary.TextChanged += new System.EventHandler(this.txtTotalSalary_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng Lương:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(995, 165);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(887, 165);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(779, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(670, 165);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(528, 92);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(239, 22);
            this.txtBonus.TabIndex = 8;
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bonus:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(960, 46);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(118, 22);
            this.txtHours.TabIndex = 6;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số giờ làm:";
            // 
            // chkProbation
            // 
            this.chkProbation.AutoSize = true;
            this.chkProbation.Location = new System.Drawing.Point(119, 96);
            this.chkProbation.Margin = new System.Windows.Forms.Padding(4);
            this.chkProbation.Name = "chkProbation";
            this.chkProbation.Size = new System.Drawing.Size(86, 21);
            this.chkProbation.TabIndex = 4;
            this.chkProbation.Text = "Thử Việc";
            this.chkProbation.UseVisualStyleBackColor = true;
            this.chkProbation.CheckedChanged += new System.EventHandler(this.chkProbation_CheckedChanged);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Enabled = false;
            this.txtStaffName.Location = new System.Drawing.Point(531, 44);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(239, 22);
            this.txtStaffName.TabIndex = 3;
            // 
            // cbxStaffCode
            // 
            this.cbxStaffCode.FormattingEnabled = true;
            this.cbxStaffCode.Location = new System.Drawing.Point(119, 44);
            this.cbxStaffCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbxStaffCode.Name = "cbxStaffCode";
            this.cbxStaffCode.Size = new System.Drawing.Size(221, 24);
            this.cbxStaffCode.TabIndex = 2;
            this.cbxStaffCode.SelectedIndexChanged += new System.EventHandler(this.cbxStaffCode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(495, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 47);
            this.label1.TabIndex = 28;
            this.label1.Text = "LƯƠNG";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1015, 20);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "ID";
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(1044, 13);
            this.btnHideForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(43, 30);
            this.btnHideForm.TabIndex = 30;
            this.btnHideForm.UseVisualStyleBackColor = false;
            // 
            // btnOffStaff
            // 
            this.btnOffStaff.FlatAppearance.BorderSize = 0;
            this.btnOffStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffStaff.ForeColor = System.Drawing.Color.White;
            this.btnOffStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnOffStaff.Image")));
            this.btnOffStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffStaff.Location = new System.Drawing.Point(1095, 14);
            this.btnOffStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnOffStaff.Name = "btnOffStaff";
            this.btnOffStaff.Size = new System.Drawing.Size(43, 30);
            this.btnOffStaff.TabIndex = 31;
            this.btnOffStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOffStaff.UseVisualStyleBackColor = true;
            this.btnOffStaff.Click += new System.EventHandler(this.btnOffStaff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvwSalary);
            this.groupBox1.Location = new System.Drawing.Point(1, 334);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1129, 330);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Lương";
            // 
            // dgvwSalary
            // 
            this.dgvwSalary.BackgroundColor = System.Drawing.Color.White;
            this.dgvwSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSalary.Location = new System.Drawing.Point(8, 23);
            this.dgvwSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dgvwSalary.Name = "dgvwSalary";
            this.dgvwSalary.RowHeadersWidth = 62;
            this.dgvwSalary.Size = new System.Drawing.Size(1113, 299);
            this.dgvwSalary.TabIndex = 0;
            this.dgvwSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSalary_CellClick);
            this.dgvwSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwSalary_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 12);
            this.panel2.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 683);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tổng Lương trong Tuần";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTotalSalayList
            // 
            this.txtTotalSalayList.Enabled = false;
            this.txtTotalSalayList.Location = new System.Drawing.Point(899, 683);
            this.txtTotalSalayList.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSalayList.Name = "txtTotalSalayList";
            this.txtTotalSalayList.Size = new System.Drawing.Size(231, 22);
            this.txtTotalSalayList.TabIndex = 35;
            this.txtTotalSalayList.TextChanged += new System.EventHandler(this.txtTotalSalayList_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 751);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTotalSalayList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOffStaff);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxInfoSalary);
            this.Name = "frmLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLuong";
            this.Load += new System.EventHandler(this.frmLuong_Load);
            this.gbxInfoSalary.ResumeLayout(false);
            this.gbxInfoSalary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.GroupBox gbxInfoSalary;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkProbation;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.ComboBox cbxStaffCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.Button btnOffStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvwSalary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalSalayList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}