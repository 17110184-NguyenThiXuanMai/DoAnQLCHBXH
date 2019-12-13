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
    public partial class fLichLamViec : Form
    {
        BSL_QuanLyNhanVien BLNV = new BSL_QuanLyNhanVien();
        string strCalam = null;
        bool Them;
        public fLichLamViec()
        {
            InitializeComponent();
        }
        private void fLichLamViec_Load(object sender, EventArgs e)
        {
            LoadDataLichLam();
        }
        private void LoadDataLichLam()
        {
            dgvLichlamviec.DataSource = BLNV.LayLichLam();
            dgvLichlamviec.AutoResizeColumns();
            ReloadF();
            dgvLichlamviec_CellClick(null, null);
        }
        private void ReloadF()
        {
            cbMaNV.Enabled = false;
            dtpNgaybatdau.Enabled = false;
            dtpNgayketthuc.Enabled = false;
            rbCa1.Enabled = false;
            rbCa2.Enabled = false;
            rbFull.Enabled = false;
            btnReload.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void ReloadT()
        {
            cbMaNV.ResetText();
            dtpNgaybatdau.ResetText();
            dtpNgayketthuc.ResetText();
            cbMaNV.Enabled = true;
            dtpNgaybatdau.Enabled = true;
            dtpNgayketthuc.Enabled = true;
            rbCa1.Enabled = true;
            rbCa2.Enabled = true;
            rbFull.Enabled = true;
            btnReload.Enabled = true;
            btnLuu.Enabled = true;
        }
        private void dgvLichlamviec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLichlamviec.CurrentCell.RowIndex;
            this.cbMaNV.Text = dgvLichlamviec.Rows[r].Cells[0].Value.ToString();
            this.dtpNgaybatdau.Text = dgvLichlamviec.Rows[r].Cells[1].Value.ToString();
            this.dtpNgayketthuc.Text = dgvLichlamviec.Rows[r].Cells[2].Value.ToString();
            strCalam = dgvLichlamviec.Rows[r].Cells[3].Value.ToString();
            if (strCalam == "Ca 1")
            {
                rbCa1.Checked = true;
            }
            else if (strCalam == "Ca 2")
            {
                rbCa2.Checked = true;
            }
            else rbFull.Checked = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            ReloadT();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            if (rbCa1.Checked) strCalam = "Ca 1";
            else if (rbCa2.Checked) strCalam = "Ca 2";
            else strCalam = "Full";
            int c = BLNV.ChonLichLam(cbMaNV.Text, dtpNgaybatdau.Value.Date, dtpNgayketthuc.Value.Date, strCalam);
            this.cbMaNV.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (rbCa1.Checked) strCalam = "Ca 1";
            else if (rbCa2.Checked) strCalam = "Ca 2";
            else strCalam = "Full";
            ReloadF();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            if (!cbMaNV.Text.Trim().Equals("") && !dtpNgaybatdau.Text.Trim().Equals("") && !dtpNgayketthuc.Text.Trim().Equals(""))
            {
                if (Them)
                {
                    BLNV.ThemLichLam(this.cbMaNV.Text, this.dtpNgaybatdau.Value.Date, this.dtpNgayketthuc.Value.Date, strCalam);
                    LoadDataLichLam();
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    int r = dgvLichlamviec.CurrentCell.RowIndex;
                    string strlichlam = dgvLichlamviec.Rows[r].Cells[0].Value.ToString();
                    BLNV.SuaLichLam(this.cbMaNV.Text, this.dtpNgaybatdau.Value.Date, this.dtpNgayketthuc.Value.Date, strCalam);
                    LoadDataLichLam();
                    MessageBox.Show("Đã sửa xong!");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!!!");
            }
        }
        private void rbCa1_CheckedChanged(object sender, EventArgs e)
        {
            strCalam = "Ca 1";
        }
        private void rbCa2_CheckedChanged(object sender, EventArgs e)
        {
            strCalam = "Ca 2";
        }
        private void rbFull_CheckedChanged(object sender, EventArgs e)
        {
            strCalam = "Full";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvLichlamviec.CurrentCell.RowIndex;
            string strLichLam =
                dgvLichlamviec.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc xóa không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BLNV.XoaLichLam(cbMaNV.Text, dtpNgaybatdau.Value.Date, dtpNgayketthuc.Value.Date);
                LoadDataLichLam();
                MessageBox.Show("Đã xóa xong!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Them = false;
                this.cbMaNV.Enabled = false;
                this.dtpNgaybatdau.Enabled = false;
                this.dtpNgayketthuc.Enabled = false;
                rbCa1.Enabled = true;
                rbCa2.Enabled = true;
                rbFull.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnReload.Enabled = true;
                btnLuu.Enabled = true;
                dgvLichlamviec_CellClick(null, null);
                if (strCalam == "Ca 1")
                {
                    rbCa1.Checked = true;
                }
                else if (strCalam == "Ca 2")
                {
                    rbCa2.Checked = true;
                }
                else
                {
                    rbFull.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn ca làm!");
            }
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string _manv = txtTimkiem.Text;
            dgvLichlamviec.DataSource = BLNV.LayMaNhanVienTrongLichLam(_manv);
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadF();
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            dgvLichlamviec_CellClick(null, null);
        }
    }
}
