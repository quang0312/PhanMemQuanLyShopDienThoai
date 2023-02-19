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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        public void Display()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<SanPhamInfo> _ProductList = new List<SanPhamInfo>();
                _ProductList = _entity.SanPhams.Select(x => new SanPhamInfo
                {
                    ID = x.ID,
                    MaSP = x.MaSP,
                    TenSP = x.TenSP,
                    LoaiSP = x.LoaiSP,
                    NhaSanXuat = x.NhaSanXuat,
                    SoLuong = x.SoLuong,
                    MauSac = x.MauSac,
                    Gia = x.Gia
                }).ToList();

                dgvwSanPham.DataSource = _ProductList;
            }
        }
        private void DataGridViewWidth()
        {
            DataGridViewColumn column = dgvwSanPham.Columns[2];
            column.Width = 250;
            DataGridViewColumn column1 = dgvwSanPham.Columns[7];
            column1.Width = 200;
            dgvwSanPham.Columns[0].Visible = false;
            dgvwSanPham.Columns["Gia"].DefaultCellStyle.Format = "0,00.## VND";
        }

        public void cbxLoai()
        {
            cbxLoaiSP.Items.Add("Cao Cấp");
            cbxLoaiSP.Items.Add("Phổ Thông");
            cbxLoaiSP.Items.Add("Trung Bình");
        }

        public void cbxcolor()
        {
            cbxColor.Items.Add("Đen");
            cbxColor.Items.Add("Trắng");
            cbxColor.Items.Add("Xám");
            cbxColor.Items.Add("Đỏ");
            cbxColor.Items.Add("Xanh lá");
            cbxColor.Items.Add("Xanh dương");
            cbxColor.Items.Add("Vàng");
        }

        public void cbxNSX()
        {
            cbxNhaSanXuat.Items.Add("SamSung");
            cbxNhaSanXuat.Items.Add("Iphone");
            cbxNhaSanXuat.Items.Add("Xiaomi");
            cbxNhaSanXuat.Items.Add("Oppo");
            cbxNhaSanXuat.Items.Add("Vivo");
            cbxNhaSanXuat.Items.Add("Huawei");

        }

        public void cbxsearchitem()
        {
            cbxSearchProduct.Items.Add("Mã Sản Phẩm");
            cbxSearchProduct.Items.Add("Tên Sản Phẩm");
            cbxSearchProduct.Items.Add("Loại SP");
            cbxSearchProduct.Items.Add("Màu Sắc");
            cbxSearchProduct.Items.Add("Nhà Sản Xuất");
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gbxProductList_Enter(object sender, EventArgs e)
        {

        }


        //Save
        public bool SaveSanPham(SanPham sp)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                _entity.SanPhams.Add(sp);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtProductCode.Text;
            sp.TenSP = txtProductName.Text;
            sp.LoaiSP = cbxLoaiSP.Text;
            sp.SoLuong = Convert.ToInt32(txtAmount.Text);
            sp.MauSac = cbxColor.Text;
            sp.NhaSanXuat = cbxNhaSanXuat.Text;
            sp.Gia = Convert.ToDouble(txtPrice.Text);
            bool result = SaveSanPham(sp);
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

        //DELETE
        public bool DeleteSP(int id)
        {
            bool result = false;
            try
            {
                using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                {
                    SanPham sp = _entity.SanPhams.Find(id);
                    if (sp != null)
                    {
                        _entity.SanPhams.Remove(sp);
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



        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtPrice.Text, System.Globalization.NumberStyles.AllowThousands);
            txtPrice.Text = string.Format(culture, "{0:N0}", value);
            txtPrice.Select(txtPrice.Text.Length, 0);
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            cbxLoai();
             cbxNSX();
            cbxcolor();
            cbxsearchitem();
            Display();
            DataGridViewWidth();
        }

        public void ClearFields()
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            cbxLoaiSP.SelectedIndex = -1;
            cbxColor.SelectedIndex = -1;
            txtAmount.Text = "";
            cbxNhaSanXuat.SelectedIndex = -1;
            txtPrice.Text = "0";
        }

        private void dgvwSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwSanPham.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwSanPham.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    txtProductCode.Text = row.Cells[1].Value.ToString();
                    txtProductName.Text = row.Cells[2].Value.ToString();
                    cbxLoaiSP.SelectedItem = row.Cells[3].Value.ToString();
                    cbxColor.SelectedItem = row.Cells[6].Value.ToString();
                    txtAmount.Text = row.Cells[5].Value.ToString();
                    cbxNhaSanXuat.Text = row.Cells[4].Value.ToString();
                    txtPrice.Text = row.Cells[7].Value.ToString();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idproduct = Convert.ToInt32(lblID.Text);
                bool result = DeleteSP(idproduct);
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
        public bool UpdateSP(SanPham stp)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                SanPham sp = _entity.SanPhams.Where(x => x.ID == stp.ID).Select(x => x).FirstOrDefault();
                sp.MaSP = stp.MaSP;
                sp.TenSP = stp.TenSP;
                sp.LoaiSP = stp.LoaiSP;
                sp.MauSac = stp.MauSac;
                sp.SoLuong = stp.SoLuong;
                sp.NhaSanXuat = stp.NhaSanXuat;
                sp.Gia = stp.Gia;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham stp = new SanPham();
                stp.ID = Convert.ToInt32(lblID.Text);
                stp.MaSP = txtProductCode.Text;
                stp.TenSP = txtProductName.Text;
                stp.LoaiSP = cbxLoaiSP.SelectedItem.ToString();
                stp.MauSac = cbxColor.SelectedItem.ToString();
                stp.SoLuong = Convert.ToInt32(txtAmount.Text);
                stp.NhaSanXuat = cbxNhaSanXuat.SelectedItem.ToString();
                stp.Gia = Convert.ToDouble(txtPrice.Text);
                bool result = UpdateSP(stp);
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

        private void btnOffPRO_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void dgvwSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            if (cbxSearchProduct.Text == "Mã Sản Phẩm")
            {
                dgvwSanPham.DataSource = XemDL("select * from SanPham where MaSP like '%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Tên Sản Phẩm")
            {
                dgvwSanPham.DataSource = XemDL("select * from SanPham where TenSP like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Loại SP")
            {
                dgvwSanPham.DataSource = XemDL("select * from SanPham where LoaiSP like '%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Màu Sắc")
            {
                dgvwSanPham.DataSource = XemDL("select * from SanPham where MauSac like N'%" + txtSearch.Text.Trim() + "%'");
            }
            if (cbxSearchProduct.Text == "Nhà Sản Xuất")
            {
                dgvwSanPham.DataSource = XemDL("select * from SanPham where NhaSanXuat like N'%" + txtSearch.Text.Trim() + "%'");
            }
        }

        private void cbxSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
