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
    public partial class frmThongKeSP : Form
    {
        public frmThongKeSP()
        {
            InitializeComponent();
        }

        private void frmThongKeSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDienThoaiDataSet1.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.QLDienThoaiDataSet1.SanPham);

            this.reportViewer1.RefreshReport();
        }
    }
}
