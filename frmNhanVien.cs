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
//using System.Globalization; //Thu vien de dinh danh datetime tu gridview hien len thanh datetime trong form 


namespace ShopDienThoai
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void Display()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<NhanVienInfo> _NhanVienList = new List<NhanVienInfo>();
                _NhanVienList = _entity.NhanViens.Select(x => new NhanVienInfo

                {
                    ID = x.ID,
                    Ma = x.MaNV,
                    Ten = x.TenNV,
                    Tuoi = x.Tuoi,
                    GioiTinh = x.GioiTinh,
                    SoDienThoai = x.SoDienThoai,
                    DiaChi = x.DiaChi

                }).ToList();


                dgvwNhanVien.DataSource = _NhanVienList;

            }

        }

        private void DataGridViewWidth()
        {
            DataGridViewColumn column = dgvwNhanVien.Columns[6];
            column.Width = 350;
            DataGridViewColumn column1 = dgvwNhanVien.Columns[2];
            column1.Width = 200;
            dgvwNhanVien.Columns[0].Visible = false;
        }

        private void dgvwNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwNhanVien.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwNhanVien.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtStaffCode.Text = row.Cells[1].Value.ToString();
                    txtStaffName.Text = row.Cells[2].Value.ToString();
                    cbxGender.SelectedItem = row.Cells[4].Value.ToString();
                    dtpDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
                    txtPhoneStaff.Text = row.Cells[5].Value.ToString();
                    txtAddressStaff.Text = row.Cells[6].Value.ToString();
                }
            }
        }


        private void btnOffStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhanVien NhanVien = new NhanVien();
            NhanVien.MaNV = txtStaffCode.Text;
            NhanVien.TenNV = txtStaffName.Text;
            NhanVien.GioiTinh = cbxGender.Text;
            NhanVien.Tuoi = Convert.ToDateTime(dtpDOB.Text);
            // NhanVien.Age = Convert.ToDateTime(dtpDOB.Value.ToString("dd-MM-yyyy"));
            NhanVien.SoDienThoai = txtPhoneStaff.Text;
            NhanVien.DiaChi = txtAddressStaff.Text;
            bool result = SaveNV(NhanVien);
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

        public void cbxsearchitem()
        {
            cbxSearchStaff.Items.Add("Mã Nhân Viên");
            cbxSearchStaff.Items.Add("Tên Nhân Viên");
            cbxSearchStaff.Items.Add("Tuổi");
            cbxSearchStaff.Items.Add("Địa Chỉ");
            cbxSearchStaff.Items.Add("Giới tính");
        }


        private void cbxSearchStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void cbxGenderitem()
        {
            cbxGender.Items.Add("Nam");
            cbxGender.Items.Add("Nữ");

        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cbxGenderitem();
            cbxsearchitem();
            Display();
            DataGridViewWidth();

        }
        public void ClearFields()
        {
            txtStaffCode.Text = "";
            txtStaffName.Text = "";
            cbxGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now; // sau khi nhap sua xoa khi thanh datetime se load ve ngay hien tai
            txtPhoneStaff.Text = "";
            txtAddressStaff.Text = "";
        }

        public bool SaveNV(NhanVien NhanVien)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                _entity.NhanViens.Add(NhanVien);
                _entity.SaveChanges();
                result = true;
            }
            return result;
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

        //Delete
        public bool DeleteNV(int id)
        {
            bool result = false;
            try
            {
                using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                {
                    NhanVien _staff = _entity.NhanViens.Find(id);
                    if (_staff != null)
                    {
                        _entity.NhanViens.Remove(_staff);
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
                int idstaff = Convert.ToInt32(lblID.Text);
                bool result = DeleteNV(idstaff);
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
       public bool UpdateNV(NhanVien sta)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                NhanVien _staff = _entity.NhanViens.Where(x => x.ID == sta.ID).Select(x => x).FirstOrDefault();
                _staff.MaNV = sta.MaNV;
                _staff.TenNV = sta.TenNV;
                _staff.Tuoi = sta.Tuoi;
                _staff.GioiTinh = sta.GioiTinh;
                _staff.SoDienThoai = sta.SoDienThoai;
                _staff.DiaChi = sta.DiaChi;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien sta = new NhanVien();
                sta.ID = Convert.ToInt32(lblID.Text);
                sta.MaNV = txtStaffCode.Text;
                sta.TenNV = txtStaffName.Text;
                sta.Tuoi = Convert.ToDateTime(dtpDOB.Text);
                sta.GioiTinh = cbxGender.SelectedItem.ToString();
                sta.SoDienThoai = txtPhoneStaff.Text;
                sta.DiaChi = txtAddressStaff.Text;
                bool result = UpdateNV(sta);
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


        //HIDE FORM
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
                    cn.ConnectionString = @"Data Source=LAPTOP-U70IDTIG;Initial Catalog=QLDienThoai ;Integrated Security=True";
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
            if (cbxSearchStaff.Text == "Mã Nhân Viên")
            {
                dgvwNhanVien.DataSource = XemDL("select * from NhanVien where MaNV like '%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Tên Nhân Viên")
            {
                dgvwNhanVien.DataSource = XemDL("select * from NhanVien where TenNV like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Tuổi")
            {
                dgvwNhanVien.DataSource = XemDL("select * from NhanVien where Tuoi like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Địa Chỉ")
            {
                dgvwNhanVien.DataSource = XemDL("select * from NhanVien where DiaChi like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchStaff.Text == "Giới tính")
            {
                dgvwNhanVien.DataSource = XemDL("select * from NhanVien where GioiTinh like N'%" + txtSearch.Text.Trim() + "%'");
            }
        }

        private void dgvwNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
