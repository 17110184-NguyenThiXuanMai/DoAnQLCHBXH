using QLCHBXH.BSL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBXH.Presentation_Layer
{
    public partial class fGiamGia : Form
    {
        BSL_GiamGia BLGG = new BSL_GiamGia();
        bool Them;
        public fGiamGia()
        {
            InitializeComponent();
        }
        private void fGiamGia_Load(object sender, EventArgs e)
        {
            LoadDataGiamGia();
            ReloadF();
        }
        private void ReloadF()
        {
            txtMaGiamGia.Enabled = false;
            txtPhanTramGiam.Enabled = false;
            dtpNgayBatDau.Enabled = false;
            dtpNgayKetThuc.Enabled = false;
            btnLuu.Enabled = false;
            btnReload.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void ReloadT()
        {
            txtMaGiamGia.ResetText();
            txtPhanTramGiam.ResetText();
            dtpNgayBatDau.ResetText();
            dtpNgayKetThuc.ResetText();
            txtMaGiamGia.Enabled = true;
            txtPhanTramGiam.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            btnLuu.Enabled = true;
            btnReload.Enabled = true;
            btnHuy.Enabled = true;
        }
        private void LoadDataGiamGia()
        {
            dgvGiamGia.DataSource = BLGG.LayGiamGia();
            //dgvGiamGia_CellClick(null, null);
        }
        private void dgvGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvGiamGia.CurrentCell.RowIndex;
            this.txtMaGiamGia.Text = dgvGiamGia.Rows[r].Cells[0].Value.ToString();
            this.txtPhanTramGiam.Text = dgvGiamGia.Rows[r].Cells[1].Value.ToString();
            this.dtpNgayBatDau.Text = dgvGiamGia.Rows[r].Cells[2].Value.ToString();
            this.dtpNgayKetThuc.Text = dgvGiamGia.Rows[r].Cells[3].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            ReloadT();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaGiamGia.Focus();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadF();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            dgvGiamGia_CellClick(null, null);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaGiamGia.ResetText();
            txtPhanTramGiam.ResetText();
            dtpNgayBatDau.ResetText();
            dtpNgayKetThuc.ResetText();
            txtMaGiamGia.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ReloadF();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (!txtMaGiamGia.Text.Trim().Equals("") && !txtPhanTramGiam.Text.Trim().Equals("")
               && !dtpNgayBatDau.Text.Trim().Equals("") && !dtpNgayKetThuc.Text.Trim().Equals(""))
            {
                if (Them)
                {
                    BLGG.ThemGiamGia(this.txtMaGiamGia.Text, Convert.ToDecimal(this.txtPhanTramGiam.Text), this.dtpNgayBatDau.Value.Date, this.dtpNgayKetThuc.Value.Date);
                    LoadDataGiamGia();
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    int r = dgvGiamGia.CurrentCell.RowIndex;
                    string strMaNV = dgvGiamGia.Rows[r].Cells[0].Value.ToString();
                    BLGG.SuaGiamGia(this.txtMaGiamGia.Text, Convert.ToDecimal(this.txtPhanTramGiam.Text), this.dtpNgayBatDau.Value.Date, this.dtpNgayKetThuc.Value.Date);
                    LoadDataGiamGia();
                    MessageBox.Show("Đã sửa xong!");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ReloadF();
            btnThem.Enabled = true;
            int r = dgvGiamGia.CurrentCell.RowIndex;
            string strGiamGia =
                dgvGiamGia.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc xóa không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BLGG.XoaGiamGia(txtMaGiamGia.Text);
                LoadDataGiamGia();
                MessageBox.Show("Đã xóa xong!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaGiamGia.Enabled = false;
            txtPhanTramGiam.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            btnLuu.Enabled = true;
            btnReload.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void txtPhanTramGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
