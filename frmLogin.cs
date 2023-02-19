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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-U70IDTIG ;Initial Catalog=QLDienThoai ;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * from Login where Username= '" + tk + "' and Password='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    MessageBox.Show("Đăng Nhập thành công", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHome frm = new frmHome();
                    frm.HelloName = txtTK.Text;
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Đăng Nhập thất bại", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTK.Text = "";
                    txtMK.Text = "";
                    txtTK.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection errors!,Xin thu lai?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có muốn thoát hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy frm = new frmDangKy();
            frm.Show();
        }
    }
}
