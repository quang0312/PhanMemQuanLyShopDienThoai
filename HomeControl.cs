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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnManageInforProduct_Click(object sender, EventArgs e)
        {
            frmThongKeHD tk = new frmThongKeHD();
            tk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmThongKeSP tk = new frmThongKeSP();
            tk.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
