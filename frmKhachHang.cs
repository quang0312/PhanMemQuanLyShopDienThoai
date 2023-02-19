using ShopDienThoai.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDienThoai
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        public void Display()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<KhachHangInfo> _KhachHangList = new List<KhachHangInfo>();
                var tes2 = _entity.Logins.ToList();
                var tes1 = _entity.KhachHangs.ToList();

                _KhachHangList = _entity.KhachHangs.Select(x => new KhachHangInfo
                {
                    ID = x.ID,
                    Ma = x.MaKH,
                    Ten = x.TenKH,
                    Tuoi = x.Tuoi,
                    GioiTinh = x.GioiTinh,
                    SoDienThoai = x.SoDienThoai,
                    DiaChi = x.DiaChi

                }).ToList();
                dgvwKhachHang.DataSource = _KhachHangList;

            }
        }
        private void DataGridViewWidth()
        {

            DataGridViewColumn column = dgvwKhachHang.Columns[6];
            column.Width = 350;
            DataGridViewColumn column1 = dgvwKhachHang.Columns[2];
            column1.Width = 200;
            dgvwKhachHang.Columns[0].Visible = false;
        }

        public void cbxsearchitem()
        {
            cbxSearchCus.Items.Add("Mã Khách Hàng");
            cbxSearchCus.Items.Add("Tên Khách Hàng");
            cbxSearchCus.Items.Add("Ngày Sinh");
            cbxSearchCus.Items.Add("Địa Chỉ");
            cbxSearchCus.Items.Add("Giới Tính");
        }
        public void cbxgenderitem()
        {
            cbxGender.Items.Add("Nam");
            cbxGender.Items.Add("Nữ");

        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            cbxgenderitem();
            cbxsearchitem();
            Display();
            DataGridViewWidth();
        }
        public void ClearFields()
        {
            txtCustomerCode.Text = "";
            txtCustomerName.Text = "";
            cbxGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now; // sau khi nhap sua xoa khi thanh datetime se load ve ngay hien tai
            txtPhoneCus.Text = "";
            txtAddressCus.Text = "";

        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
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

        public bool SaveKhachHang(KhachHang tbKhachHang)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                _entity.KhachHangs.Add(tbKhachHang);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            KhachHang tbKhachHang = new KhachHang();
            tbKhachHang.MaKH = txtCustomerCode.Text;
            tbKhachHang.TenKH = txtCustomerName.Text;
            tbKhachHang.GioiTinh = cbxGender.Text;
            tbKhachHang.Tuoi = Convert.ToDateTime(dtpDOB.Text);
            // tbstaff.Age = Convert.ToDateTime(dtpDOB.Value.ToString("dd-MM-yyyy"));
            tbKhachHang.SoDienThoai = txtPhoneCus.Text;
            tbKhachHang.DiaChi = txtAddressCus.Text;
            bool result = SaveKhachHang(tbKhachHang);
            if (result == true)
            {
                MessageBox.Show("Saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Save failed!, Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();
        }

        private void dgvwKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwKhachHang.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwKhachHang.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtCustomerCode.Text = row.Cells[1].Value.ToString();
                    txtCustomerName.Text = row.Cells[2].Value.ToString();
                    cbxGender.SelectedItem = row.Cells[4].Value.ToString();
                    dtpDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
                    txtPhoneCus.Text = row.Cells[5].Value.ToString();
                    txtAddressCus.Text = row.Cells[6].Value.ToString();
                }
            }
        }

        //DELETE
        public bool DeleteKhachHang(int id)
        {
            bool result = false;
            try
            {
                using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                {
                    KhachHang _khachhang = _entity.KhachHangs.Find(id);
                    if (_khachhang != null)
                    {
                        _entity.KhachHangs.Remove(_khachhang);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idkh = Convert.ToInt32(lblID.Text);
                bool result = DeleteKhachHang(idkh);
                if (result == true)
                {
                    MessageBox.Show("Deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    Display();
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

        //UPDATE
        public bool UpdateKhachHang(KhachHang stc)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                KhachHang tbKhachHang = _entity.KhachHangs.Where(x => x.ID == stc.ID).Select(x => x).FirstOrDefault();
                tbKhachHang.MaKH = stc.MaKH;
                tbKhachHang.TenKH = stc.TenKH;
                tbKhachHang.Tuoi = stc.Tuoi;
                tbKhachHang.GioiTinh = stc.GioiTinh;
                tbKhachHang.SoDienThoai = stc.SoDienThoai;
                tbKhachHang.DiaChi = stc.DiaChi;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang stc = new KhachHang();
                stc.ID = Convert.ToInt32(lblID.Text);
                stc.MaKH = txtCustomerCode.Text;
                stc.TenKH = txtCustomerName.Text;
                stc.Tuoi = Convert.ToDateTime(dtpDOB.Text);
                stc.GioiTinh = cbxGender.SelectedItem.ToString();
                stc.SoDienThoai = txtPhoneCus.Text;
                stc.DiaChi = txtAddressCus.Text;
                bool result = UpdateKhachHang(stc);
                if (result == true)
                {
                    MessageBox.Show("Update successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display();
                }
                else
                {
                    MessageBox.Show("Update failed.Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed.Please try again?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //SEARCH
        public SqlConnection cn = new SqlConnection();
        public void ketnoi()
        {
            try
            {
                if (cn.State == 0)
                {
                    cn.ConnectionString = @"Data Source=LAPTOP-U70IDTIG;Initial Catalog=QLDienThoai;Integrated Security=True";
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (cn.State != 0)
            {
                cn.Close();
            }
        }

        public DataTable XemDL(string sql)
        {
            ketnoi();

            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

            //Ngatketnoi();
        }
        public SqlCommand ThucThiDl(string sql)
        {
            ketnoi();

            SqlCommand cm = new SqlCommand(sql, cn);
            cm.ExecuteNonQuery();

            return cm;

            //Ngatketnoi();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxSearchCus.Text == "Mã Khách Hàng")
            {
                dgvwKhachHang.DataSource = XemDL("select * from [KhachHang] where MaKH like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Tên Khách Hàng")
            {
                dgvwKhachHang.DataSource = XemDL("select * from [KhachHang] where TenKH like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Ngày Sinh")
            {
                dgvwKhachHang.DataSource = XemDL("select * from [KhachHang] where Tuoi like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Địa Chỉ")
            {
                dgvwKhachHang.DataSource = XemDL("select * from [KhachHang] where DiaChi like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchCus.Text == "Giới Tính")
            {
                dgvwKhachHang.DataSource = XemDL("select * from [KhachHang] where GioiTinh like N'%" + txtSearch.Text.Trim() + "%'");
            }
        }

        private void cbxSearchCus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
