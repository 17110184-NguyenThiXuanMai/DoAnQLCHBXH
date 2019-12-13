using QLCHBXH.BSL_Layer;
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

namespace QLCHBXH
{
    public partial class fBaoHiem : Form
    {
        BSL_BaoHiem BSLBaoHiem = new BSL_BaoHiem();
        bool Them;
        public fBaoHiem()
        {
            InitializeComponent();
        }

        #region Events
        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ptbMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbMinimize.Visible = true;
            ptbMaximize.Visible = false;
        }
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbMinimize.Visible = false;
            ptbMaximize.Visible = true;
        }
        private void ptbHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Methods
        private void fBaoHiem_Load(object sender, EventArgs e)
        {
            LoadDataBaoHiem();
        }
        void LoadDataBaoHiem()
        {
            try
            {
                dgvBaoHiem.DataSource = BSLBaoHiem.LayBaoHiem();
                dgvBaoHiem.AutoResizeColumns();
                ReloadF();
                dgvBaoHiem_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table BAOHIEM!");
            }
        }
        private void dgvBaoHiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBaoHiem.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            this.txtMaBaoHiem.Text = dgvBaoHiem.Rows[r].Cells[0].Value.ToString();
            this.txtGoiBaoHiem.Text = dgvBaoHiem.Rows[r].Cells[1].Value.ToString();
            this.txtGiaBaoHiem.Text = dgvBaoHiem.Rows[r].Cells[2].Value.ToString();
        }
        private void ReloadF()
        {
            this.txtMaBaoHiem.Enabled = false;
            this.txtGoiBaoHiem.Enabled = false;
            this.txtGiaBaoHiem.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }
        private void ReloadT()
        {
            this.txtMaBaoHiem.ResetText();
            this.txtGoiBaoHiem.ResetText();
            this.txtGiaBaoHiem.ResetText();
            this.txtMaBaoHiem.Enabled = true;
            this.txtGoiBaoHiem.Enabled = true;
            this.txtGiaBaoHiem.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            ReloadT();
            this.btnThem.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaBaoHiem.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvBaoHiem_CellClick(null, null);
            this.txtGoiBaoHiem.Enabled = true;
            this.txtGiaBaoHiem.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaBaoHiem.Enabled = false;
            this.txtGoiBaoHiem.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtMaBaoHiem.Text.Trim().Equals("") && !txtGoiBaoHiem.Text.Trim().Equals("") && !txtGiaBaoHiem.Text.Trim().Equals(""))
            {
                if (Them)
                {
                    BSLBaoHiem.ThemBaoHiem(this.txtMaBaoHiem.Text, this.txtGoiBaoHiem.Text, Convert.ToDecimal(this.txtGiaBaoHiem.Text));
                    LoadDataBaoHiem();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    int r = dgvBaoHiem.CurrentCell.RowIndex;
                    string strMaBaoHiem = dgvBaoHiem.Rows[r].Cells[0].Value.ToString();
                    BSLBaoHiem.CapNhatBaoHiem(strMaBaoHiem, this.txtGoiBaoHiem.Text, Convert.ToDecimal(this.txtGiaBaoHiem.Text));
                    LoadDataBaoHiem();
                    MessageBox.Show("Đã sửa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Lỗi rồi! Hãy nhập đầy đủ thông tin");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReloadF();
            dgvBaoHiem_CellClick(null, null);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvBaoHiem.CurrentCell.RowIndex;
            string strMaBaoHiem = dgvBaoHiem.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BSLBaoHiem.XoaBaoHiem(txtMaBaoHiem.Text);
                LoadDataBaoHiem();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không xóa được!");
            }
        }
        #endregion
    }
}
