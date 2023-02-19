using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using ShopDienThoai.Model;

namespace ShopDienThoai
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        public void Display()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                             
                List <ChiTietHoaDonInfo> _ChiTietHDList = new List<ChiTietHoaDonInfo>();
                _ChiTietHDList = _entity.ChiTietHoaDons.Select(x => new ChiTietHoaDonInfo
                {
                    ID = x.ID,                 
                    MaHoaDon = x.MaHoaDon,
                    MaSP = x.MaSP,
                    TenSP = x.TenSP,
                    SoLuong = x.SoLuong,
                    UnitPrice = x.UnitPrice,
                    Discount = x.Discount,
                    IntoMoney = x.IntoMoney
                }).ToList();
                dgvwChiTietHoaDon.DataSource = _ChiTietHDList;
            }
        }


        //TEXT CHANGED
        private void DataGridViewLoad()
        {
            dgvwChiTietHoaDon.Columns[0].Visible = false;
            dgvwChiTietHoaDon.Columns["UnitPrice"].DefaultCellStyle.Format = "0,00.## VND";
            dgvwChiTietHoaDon.Columns["IntoMoney"].DefaultCellStyle.Format = "0,00.## VND";
        }

        private void gbxGenInfo_Enter(object sender, EventArgs e)
        {

        }

        private void txtIntoMoney_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtIntoMoney.Text, System.Globalization.NumberStyles.AllowThousands);
            txtIntoMoney.Text = String.Format(culture, "{0:N0}", value);
            txtIntoMoney.Select(txtIntoMoney.Text.Length, 0);
        }

        //DELETE
        public bool DeleteHD(int id)
        {
            bool result = false;
            try
            {
                using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                {
                    ChiTietHoaDon _cthd = _entity.ChiTietHoaDons.Find(id);
                    if (_cthd != null)
                    {
                        _entity.ChiTietHoaDons.Remove(_cthd);
                        _entity.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int idhoadon = Convert.ToInt32(lblID.Text);
                bool result = DeleteHD(idhoadon);
                if (result == true)
                {
                    MessageBox.Show("Deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                    Total();
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion failed!,Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtUnitPrice.Text, System.Globalization.NumberStyles.AllowThousands);
            txtUnitPrice.Text = String.Format(culture, "{0:N0}", value);
            txtUnitPrice.Select(txtUnitPrice.Text.Length, 0);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            double unitprice, discount, intomoney;
            int Am;
            if (txtAmount.Text == "")

                Am = 0;

            else

                Am = Convert.ToInt32(txtAmount.Text);

            if (txtDiscount.Text == "")

                discount = 0;

            else

                discount = Convert.ToDouble(txtDiscount.Text);

            if (txtUnitPrice.Text == "")

                unitprice = 0;

            else
            {
                unitprice = Convert.ToDouble(txtUnitPrice.Text);
                intomoney = Am * unitprice - Am * unitprice * discount / 100;
                txtIntoMoney.Text = intomoney.ToString();
                //txtIntoMoney.Text=intomoney.ToString("N3").Replace(".000","");
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTotal.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTotal.Text = String.Format(culture, "{0:N0}", value);
            txtTotal.Select(txtTotal.Text.Length, 0);
        }

        //SET VALUES
        public void SetValueNV()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<NhanVien> _staff = new List<NhanVien>();
                _staff = _entity.NhanViens.ToList();
                cboMaNhanVien.DataSource = _staff;
                cboMaNhanVien.DisplayMember = "MaNV";
                cboMaNhanVien.ValueMember = "ID";
            }
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                if (cb.SelectedValue != null)
                {
                    SanPham tbp = new SanPham();
                    tbp = cb.SelectedItem as SanPham;
                    txtProductName.Text = tbp.TenSP;
                    txtUnitPrice.Text = tbp.Gia.ToString();
                }
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                if (cb.SelectedValue != null)
                {
                    NhanVien tbs = new NhanVien();
                    tbs = cb.SelectedItem as NhanVien;
                    txtStaffName.Text = tbs.TenNV;
                }
        }

        public void SetValueKH()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<KhachHang> kh = new List<KhachHang>();
                kh = _entity.KhachHangs.ToList();
                cboMaKhach.DataSource = kh;
                cboMaKhach.DisplayMember = "MaKH";
                cboMaKhach.ValueMember = "ID";
            }
        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                if (cb.SelectedValue != null)
                {
                    KhachHang tbc = new KhachHang();
                    tbc = cb.SelectedItem as KhachHang;
                    txtCustomerName.Text = tbc.TenKH;
                    txtAddressCustomer.Text = tbc.DiaChi;
                    txtPhoneCustomer.Text = tbc.SoDienThoai;
                }
        }

        public void SetValueSP()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<SanPham> sp = new List<SanPham>();
                sp = _entity.SanPhams.ToList();
                cboMaHang.DataSource = sp;
                cboMaHang.DisplayMember = "MaSP";
                cboMaHang.ValueMember = "ID";
            }
        }

        private void dgvwChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvwChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwChiTietHoaDon.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwChiTietHoaDon.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtBillCode.Text = row.Cells[1].Value.ToString();
                    cboMaHang.Text = row.Cells[2].Value.ToString();
                    txtProductName.Text = row.Cells[3].Value.ToString();
                    txtAmount.Text = row.Cells[4].Value.ToString();
                    txtUnitPrice.Text = row.Cells[5].Value.ToString();
                    txtDiscount.Text = row.Cells[6].Value.ToString();
                    txtIntoMoney.Text = row.Cells[7].Value.ToString();
                }
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnAddBill.Enabled = true;
            btnLuu.Enabled = false;
            btnDeleteProduct.Enabled = false;
            txtBillCode.ReadOnly = true;
            txtStaffName.ReadOnly = true;
            txtCustomerName.ReadOnly = true;
            txtAddressCustomer.ReadOnly = true;
            txtPhoneCustomer.ReadOnly = true;
            txtProductName.ReadOnly = true;
            txtUnitPrice.ReadOnly = true;
            txtIntoMoney.ReadOnly = true;
            // txtTotal.Text = "0";
            txtDiscount.Text = "0";
            SetValueNV();
            cboMaNhanVien.SelectedIndex = -1;
            txtStaffName.Text = "";
            SetValueKH();
            cboMaKhach.SelectedIndex = -1;
            txtCustomerName.Text = "";
            txtAddressCustomer.Text = "";
            txtPhoneCustomer.Text = "";
            SetValueSP();
            cboMaHang.SelectedIndex = -1;
            txtProductName.Text = "";
            txtUnitPrice.Text = "0";
            SetValueHD();
            cbxMaHD.SelectedIndex = -1;
            Display();
            DataGridViewLoad();
        }

       
        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel2.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        // Khoi tao 2 bien va tao hem co chua nang thu nho form khi click vao icon duoi thanh taskbar cua windows
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        private void btnOffBill_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReloadForm_Click(object sender, EventArgs e)
        {
            txtIntoMoney.Text = "0";
            txtAmount.Text = "";
            frmHoaDon_Load(sender, e);
        }

        //SAVE
        public bool SaveChiTietHoaDon(ChiTietHoaDon cthd)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                _entity.ChiTietHoaDons.Add(cthd);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        public void Total()
        {
            txtTotal.Text = "0";
            for (int i = 0; i < dgvwChiTietHoaDon.Rows.Count; i++)
            {
                txtTotal.Text = Convert.ToString(double.Parse(txtTotal.Text) + double.Parse(dgvwChiTietHoaDon.Rows[i].Cells[7].Value.ToString()));
            }
        }

        public void checktotal()
        {
            if (dgvwChiTietHoaDon.Rows.Count == 0)
            {
                txtTotal.Text = "0";
            }
            else
            {
                //txtTotal.Text = "0";
                for (int i = 0; i < dgvwChiTietHoaDon.Rows.Count; i++)
                {
                    txtTotal.Text = Convert.ToString(double.Parse(txtTotal.Text) + double.Parse(dgvwChiTietHoaDon.Rows[i].Cells[7].Value.ToString()));
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.MaHoaDon = txtBillCode.Text;
            cthd.MaSP = cboMaHang.Text;
            cthd.TenSP = txtProductName.Text;
            cthd.SoLuong = Convert.ToInt32(txtAmount.Text);
            cthd.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
            cthd.Discount = Convert.ToDouble(txtDiscount.Text);
            cthd.IntoMoney = Convert.ToDouble(txtIntoMoney.Text);
            bool result = SaveChiTietHoaDon(cthd);
            if (result == true)
            {
                MessageBox.Show("Saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
                Total();
            }
            else
            {
                MessageBox.Show("Save failed!, Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            double unitprice, discount, intomoney;
            int Am;
            if (txtAmount.Text == "")

                Am = 0;

            else

                Am = Convert.ToInt32(txtAmount.Text);

            if (txtDiscount.Text == "")

                discount = 0;

            else

                discount = Convert.ToDouble(txtDiscount.Text);

            if (txtUnitPrice.Text == "")

                unitprice = 0;

            else
            {
                unitprice = Convert.ToDouble(txtUnitPrice.Text);
                intomoney = Am * unitprice - Am * unitprice * discount / 100;
                txtIntoMoney.Text = intomoney.ToString();
                //txtIntoMoney.Text=intomoney.ToString("N3").Replace(".000","");
            }
        }
        private void Resetvalue()
        {
            txtBillCode.Text = "";
            dtpDOS.Value = DateTime.Now;
            cboMaNhanVien.Text = "";
            cboMaKhach.Text = "";
            txtTotal.Text = "0";
            cboMaHang.Text = "";
            txtAmount.Text = "";
            txtDiscount.Text = "0";
            txtIntoMoney.Text = "0";
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            Resetvalue();
            txtBillCode.Text = Functions.CreateKey("HD");
            btnLuu.Enabled = true;
            btnDeleteProduct.Enabled = true;
            DataGridViewLoad();
            Total();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cbxMaHD.Text == "" )
            {
                MessageBox.Show("Bạn phải chọn Mã Hóa Đơn để tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaHD.Focus();
                return;

            }
            txtBillCode.Text = cbxMaHD.Text;
            DataGridViewLoad();
            Display();            
            cbxMaHD.SelectedIndex = -1 ;
        }

        private void cbxMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void txtBillCode_TextChanged(object sender, EventArgs e)
        {

        }

        //SET VALUES
        public void SetValueHD()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<ChiTietHoaDon> _staff = new List<ChiTietHoaDon>();
                _staff = _entity.ChiTietHoaDons.ToList();
                cbxMaHD.DataSource = _staff;
                cbxMaHD.DisplayMember = "MaHoaDon";
                cbxMaHD.ValueMember = "ID";
                
            }
        }
        private void cbxMaHD_DropDown(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                if (cb.SelectedValue != null)
                {
                   ChiTietHoaDon tbs = new ChiTietHoaDon();
                    tbs = cb.SelectedItem as ChiTietHoaDon;
                    
                }
        }


        Bitmap bitmap;
        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            int height = dgvwChiTietHoaDon.Height;
            dgvwChiTietHoaDon.Height = dgvwChiTietHoaDon.RowCount * dgvwChiTietHoaDon.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgvwChiTietHoaDon.Width, dgvwChiTietHoaDon.Height);
            dgvwChiTietHoaDon.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvwChiTietHoaDon.Width, dgvwChiTietHoaDon.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvwChiTietHoaDon.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void dtpDOS_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
