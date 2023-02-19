using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDienThoai
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        public void ClearFields()
        {
            txtTK.Text = "";
            txtMK.Text = "";
            txtHoTen.Text = "";
            txtXNMK.Text = "";
            txtEmail.Text = "";
        }

        public bool SaveLogin(Login lg)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                _entity.Logins.Add(lg);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                Login lg = new Login();
                lg.Username = txtTK.Text;
                lg.HoTen = txtHoTen.Text;
                lg.Password = txtMK.Text;
                lg.Email = txtEmail.Text;
                lg.XacNhanMK = txtXNMK.Text;
                bool result = SaveLogin(lg);
                if (result == true)
                {

                    MessageBox.Show("Đăng Ký Thành Công", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Đăng Ký Thất Bại", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtTK.Text = "";
                    txtHoTen.Text = "";
                    txtEmail.Text = "";
                    txtMK.Text = "";
                    txtXNMK.Text = "";
                    txtTK.Focus();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("connection errors!,Xin thu lai?\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
