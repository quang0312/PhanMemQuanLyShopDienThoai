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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-U70IDTIG;Initial Catalog=QLDienThoai;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter da;
        DataTable dt;
        int id = 0;

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbProduct.Text = dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtIDProduct.Text = Convert.ToString(cbProduct.SelectedValue);
            txtPrice.Text = dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
            nmAddDrink.Value = Convert.ToInt32(dgvMenu.Rows[e.RowIndex].Cells[2].Value.ToString());
        }
        public void DisplayDrink()
        {
            da = new SqlDataAdapter("select * from SanPham", conn);
            dt = new DataTable();
            da.Fill(dt);
            cbProduct.DataSource = dt;
            cbProduct.DisplayMember = "TenSP";
            cbProduct.ValueMember = "ID";
        }

        private void cbProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from SanPham where ID =" + cbProduct.SelectedValue, conn);
            dt = new DataTable();
            da.Fill(dt);
            txtIDProduct.Text = dt.Rows[0]["ID"].ToString();
            txtPrice.Text = dt.Rows[0]["Gia"].ToString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisplayDrink();
            UpdateBill();
        }

        public void setdefault()
        {
            cbProduct.SelectedValue = -1;
            txtIDProduct.Text = "";
            txtPrice.Text = "";
        }
        public void DisplayData()
        {
            da = new SqlDataAdapter("select SanPham.TenSP,format( ChiTietHoaDon.UnitPrice,'#,###,### VND') as 'Don gia', ChiTietHoaDon.SoLuong, format(ChiTietHoaDon.IntoMoney,'#,###') as 'Thanh Tien' from dbo.ChiTietHoaDon, dbo.SanPham where ChiTietHoaDon.SanPhamID = SanPham.ID", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvMenu.DataSource = dt;
        }
        /*-------------------------------CRUD--------------------------------------*/
        public void UpdateBill()
        {
            conn.Open();
            command = new SqlCommand("update dbo.ChiTietHoaDon set UnitPrice = SanPham.Gia from SanPham, ChiTietHoaDon where SanPham.ID = ChiTietHoaDon.SanPhamID", conn);
            command.ExecuteNonQuery();
            command = new SqlCommand("update dbo.ChiTietHoaDon set ChiTietHoaDon.IntoMoney = ChiTietHoaDon.SoLuong * ChiTietHoaDon.UnitPrice from SanPham, ChiTietHoaDon where SanPham.ID = ChiTietHoaDon.SanPhamID", conn);
            command.ExecuteNonQuery();
            conn.Close();
            DisplayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand("insert into dbo.ChiTietHoaDon (SanPhamID, Soluong)" + "values('" + Convert.ToInt32(cbProduct.SelectedValue) + "','" + Convert.ToInt32(nmAddDrink.Value.ToString()) + "')", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Added Sucessfully!..", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            nmAddDrink.Value = 1;
            UpdateBill();
            setdefault();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
            txtPay.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand("Delete from dbo.ChiTietHoaDon where SanPhamID = '" + cbProduct.SelectedValue + "'", conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted Sucessfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            UpdateBill();
            setdefault();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand("Delete from dbo.ChiTietHoaDon", conn);
            command.ExecuteNonQuery();
            conn.Close();
            DisplayData();
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgvMenu_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            da = new SqlDataAdapter("SELECT Convert(varchar, cast(SUM(IntoMoney) as money), 1) FROM dbo.ChiTietHoaDon", conn);
            dt = new DataTable();
            da.Fill(dt);
            txtPay.Text = dt.Rows[0][0].ToString();
        }
    }
}
