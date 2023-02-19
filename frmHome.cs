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
    public partial class frmHome : Form
    {
        string strNhan;
        public frmHome()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height; //usercontrol Home uoc dat vao form 2 de chay truoc 
            SidePanel.Top = btnHome.Top;
           
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có muốn thoát hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = "Hello:" + strNhan;//lay muc textbox ten dang nhap vao day de lam cau xin chao cho form
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e) ////ham nay co chuc nang di chuyen Form khi ko co thanh title bar
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
        public string HelloName //bien lay du lieu cho strNhan duoc khai bao o form 1
        {
            get { return strNhan; }
            set { strNhan = value; }
        }

        private void nhanVienControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduct.Height;
            SidePanel.Top = btnProduct.Top;
            sanPhamControl1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBill.Height;
            SidePanel.Top = btnBill.Top;
            hoaDonControl1.BringToFront();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnStaff.Height;
            SidePanel.Top = btnStaff.Top;
            nhanVienControl1.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCustomer.Height;
            SidePanel.Top = btnCustomer.Top;
            khachHangControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeControl1.BringToFront();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeControl1.BringToFront();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            frm.ShowDialog();
        }
    }
}
