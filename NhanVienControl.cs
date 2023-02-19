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
    public partial class NhanVienControl : UserControl
    {
        public NhanVienControl()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnManageInforProduct_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnv = new frmNhanVien();
            frmnv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLuong frm = new frmLuong();
            frm.Show();
        }
    }
}
