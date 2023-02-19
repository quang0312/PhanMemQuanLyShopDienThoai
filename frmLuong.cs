using ShopDienThoai.Model;
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
    public partial class frmLuong : Form
    {
        public frmLuong()
        {
            InitializeComponent();
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

        public void Display()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<LuongInfo> _salaryinfo = new List<LuongInfo>();
                _salaryinfo = _entity.Luongs.Select(x => new LuongInfo
                {
                    ID = x.ID,
                    MaNV = x.MaNV,
                    TenNV = x.TenNV,
                    HoursWork = x.Hours_work,
                    Bonus = x.Bonus,
                    TotalLuong = x.Total_luong
                }).ToList();
                dgvwSalary.DataSource = _salaryinfo;
            }
        }
        private void DataGridViewLoad()
        {
            dgvwSalary.Columns[0].Visible = false;
            dgvwSalary.Columns[4].DefaultCellStyle.Format = "0,00.## VND";
            dgvwSalary.Columns[5].DefaultCellStyle.Format = "0,00.## VND";
        }

        public bool SaveLuong(Luong lg)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                _entity.Luongs.Add(lg);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Luong lg = new Luong();
            lg.MaNV = cbxStaffCode.Text;
            lg.TenNV = txtStaffName.Text;
            lg.Hours_work = Convert.ToInt32(txtHours.Text);
            lg.Bonus = Convert.ToDouble(txtBonus.Text);
            lg.Total_luong = Convert.ToDouble(txtTotalSalary.Text);
            bool result = SaveLuong(lg);
            if (result == true)
            {
                MessageBox.Show("Saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("Save failed!, Please try again?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvwSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvwSalary.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvwSalary.SelectedRows)
                {
                    lblID.Text = row.Cells[0].Value.ToString();
                    cbxStaffCode.Text = row.Cells[1].Value.ToString();
                    txtStaffName.Text = row.Cells[2].Value.ToString();
                    txtHours.Text = row.Cells[3].Value.ToString();
                    txtBonus.Text = row.Cells[4].Value.ToString();
                    txtTotalSalary.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        public bool DeleteLuong(int id)
        {
            bool result = false;
            try
            {
                using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                {
                    Luong lg = _entity.Luongs.Find(id);
                    if (lg != null)
                    {
                        _entity.Luongs.Remove(lg);
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



        private void txtTotalSalary_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTotalSalary.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTotalSalary.Text = String.Format(culture, "{0:N0}", value);
            txtTotalSalary.Select(txtTotalSalary.Text.Length, 0);
        }

        public void SetValueNhanVien()
        {
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                List<NhanVien> _staff = new List<NhanVien>();
                _staff = _entity.NhanViens.ToList();
                cbxStaffCode.DataSource = _staff;
                cbxStaffCode.DisplayMember = "MaNV";
                cbxStaffCode.ValueMember = "ID";
            }
        }

        private void cbxStaffCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
                if (cb.SelectedValue != null)
                {
                    NhanVien tbs = new NhanVien();
                    tbs = cb.SelectedItem as NhanVien;
                    txtStaffName.Text = tbs.TenNV;
                }
        }

        private void chkProbation_CheckedChanged(object sender, EventArgs e)
        {
            double luongcanban = 20000;
            double luongthuviec = 15000;
            double Tongluong, bouns;
            int hours;
            if (txtHours.Text == "")
                hours = 0;
            else
                hours = Convert.ToInt32(txtHours.Text);
            if (txtBonus.Text == "")
                bouns = 0;
            else
                bouns = Convert.ToDouble(txtBonus.Text);
            if (chkProbation.Checked == true)
            {
                Tongluong = hours * luongthuviec + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
            else
            {
                Tongluong = hours * luongcanban + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            double luongcanban = 20000;
            double luongthuviec = 15000;
            double Tongluong, bouns;
            int hours;
            if (txtHours.Text == "")
                hours = 0;
            else
                hours = Convert.ToInt32(txtHours.Text);
            if (txtBonus.Text == "")
                bouns = 0;
            else
                bouns = Convert.ToDouble(txtBonus.Text);
            if (chkProbation.Checked == true)
            {
                Tongluong = hours * luongthuviec + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
            else
            {
                Tongluong = hours * luongcanban + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            double luongcanban = 20000;
            double luongthuviec = 15000;
            double Tongluong, bouns;
            int hours;
            if (txtHours.Text == "")
                hours = 0;
            else
                hours = Convert.ToInt32(txtHours.Text);
            if (txtBonus.Text == "")
                bouns = 0;
            else
                bouns = Convert.ToDouble(txtBonus.Text);
            if (chkProbation.Checked == true)
            {
                Tongluong = hours * luongthuviec + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
            else
            {
                Tongluong = hours * luongcanban + bouns;
                txtTotalSalary.Text = Tongluong.ToString();
            }
        }
        public void ClearFields()
        {

            cbxStaffCode.SelectedIndex = -1;
            txtStaffName.Text = "";
            txtHours.Text = "0";
            chkProbation.Checked = false;
            txtBonus.Text = "0";
            txtTotalSalary.Text = "0";
        }

        private void btnOffStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            SetValueNhanVien();
            cbxStaffCode.SelectedIndex = -1;
            txtStaffName.Text = "";
            txtBonus.Text = "0";
            Display();
            DataGridViewLoad();
            Total();
        }

        public void Total()
        {
            txtTotalSalayList.Text = "0";
            for (int i = 0; i < dgvwSalary.Rows.Count; i++)
            {
                txtTotalSalayList.Text = Convert.ToString(double.Parse(txtTotalSalayList.Text) + double.Parse(dgvwSalary.Rows[i].Cells[5].Value.ToString()));
            }
        }
        private void dgvwSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idluong = Convert.ToInt32(lblID.Text);
                bool result = DeleteLuong(idluong);
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

        //Update
        public bool UpdateLuong(Luong sts)
        {
            bool result = false;
            using (QLDienThoaiEntities _entity = new QLDienThoaiEntities())
            {
                Luong lg = _entity.Luongs.Where(x => x.ID == sts.ID).Select(x => x).FirstOrDefault();
                lg.Hours_work = sts.Hours_work;
                lg.Bonus = sts.Bonus;
                lg.Total_luong = sts.Total_luong;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Luong sts = new Luong();
                sts.ID = Convert.ToInt32(lblID.Text);
                sts.Hours_work = Convert.ToInt32(txtHours.Text);
                sts.Bonus = Convert.ToDouble(txtBonus.Text);
                sts.Total_luong = Convert.ToDouble(txtTotalSalary.Text);
                bool result = UpdateLuong(sts);
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

        private void txtTotalSalayList_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(txtTotalSalayList.Text, System.Globalization.NumberStyles.AllowThousands);
            txtTotalSalayList.Text = String.Format(culture, "{0:N0}", value);
            txtTotalSalayList.Select(txtTotalSalayList.Text.Length, 0);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
