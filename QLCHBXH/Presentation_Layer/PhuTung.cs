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
    public partial class fPhuTung : Form
    {
        BSL_PhuTung BSLPhuTung = new BSL_PhuTung();
        bool Them;

        public fPhuTung()
        {
            InitializeComponent();
        }
        private void CarSparts_Load(object sender, EventArgs e)
        {
            LoadDataPhuTung();
        }
        void LoadDataPhuTung()
        {
            try
            {
                dgvPhuTung.DataSource = BSLPhuTung.LayPhuTung();
                dgvPhuTung.AutoResizeColumns();
                ReloadF();
                dgvPhuTung_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PHUTUNG!");
            }
        }
        private void dgvPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPhuTung.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            this.txtMaPhuTung.Text = dgvPhuTung.Rows[r].Cells[0].Value.ToString();
            this.cbLoaiPhuTung.Text = dgvPhuTung.Rows[r].Cells[1].Value.ToString();
            this.txtTenPhuTung.Text = dgvPhuTung.Rows[r].Cells[2].Value.ToString();
            this.txtSoLuong.Text = dgvPhuTung.Rows[r].Cells[3].Value.ToString();
            this.txtGiaPhuTung.Text = dgvPhuTung.Rows[r].Cells[4].Value.ToString();
        }
        private void ReloadT()
        {
            this.txtMaPhuTung.ResetText();
            this.cbLoaiPhuTung.ResetText();
            this.txtTenPhuTung.ResetText();
            this.txtSoLuong.ResetText();
            this.txtGiaPhuTung.ResetText();
            this.txtMaPhuTung.Enabled = true;
            this.cbLoaiPhuTung.Enabled = true;
            this.txtTenPhuTung.Enabled = true;
            this.txtSoLuong.Enabled = true;
            this.txtGiaPhuTung.Enabled = true;
        }
        private void ReloadF()
        {
            this.txtMaPhuTung.Enabled = false;
            this.cbLoaiPhuTung.Enabled = false;
            this.txtTenPhuTung.Enabled = false;
            this.txtSoLuong.Enabled = false;
            this.txtGiaPhuTung.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
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
            this.txtMaPhuTung.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            dgvPhuTung_CellClick(null, null);
            this.cbLoaiPhuTung.Enabled = true;
            this.txtTenPhuTung.Enabled = true;
            this.txtSoLuong.Enabled = true;
            this.txtGiaPhuTung.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaPhuTung.Enabled = false;
            this.cbLoaiPhuTung.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtMaPhuTung.Text.Trim().Equals("") && !cbLoaiPhuTung.Text.Trim().Equals("") && !txtTenPhuTung.Text.Trim().Equals("") &&
                !txtSoLuong.Text.Trim().Equals("") && !txtGiaPhuTung.Text.Trim().Equals(""))
            {
                if (Them)
                {
                    BSLPhuTung.ThemPhuTung(this.txtMaPhuTung.Text, this.cbLoaiPhuTung.Text, this.txtTenPhuTung.Text,
                        Convert.ToInt32(this.txtSoLuong.Text), Convert.ToDecimal(this.txtGiaPhuTung.Text));
                    LoadDataPhuTung();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    int r = dgvPhuTung.CurrentCell.RowIndex;
                    string strMaPhuTung = dgvPhuTung.Rows[r].Cells[0].Value.ToString();
                    BSLPhuTung.CapNhatPhuTung(strMaPhuTung, this.cbLoaiPhuTung.Text, this.txtTenPhuTung.Text,
                        Convert.ToInt32(this.txtSoLuong.Text), Convert.ToDecimal(this.txtGiaPhuTung.Text));
                    LoadDataPhuTung();
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
            dgvPhuTung_CellClick(null, null);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvPhuTung.CurrentCell.RowIndex;
            string strMaPhuTung = dgvPhuTung.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BSLPhuTung.XoaPhuTung(txtMaPhuTung.Text);
                LoadDataPhuTung();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không xóa được!");
            }
        }
    }
}
