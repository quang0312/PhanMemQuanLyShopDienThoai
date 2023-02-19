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
    public partial class frmThongKeHD : Form
    {
        public frmThongKeHD()
        {
            InitializeComponent();
        }

        private void frmThongKeHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDienThoaiDataSet.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.ChiTietHoaDonTableAdapter.Fill(this.QLDienThoaiDataSet.ChiTietHoaDon);

            this.reportViewer1.RefreshReport();
        }
    }
}
