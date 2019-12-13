using QLCHBXH.BSL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBXH.Presentation_Layer
{
    public partial class fThongTinNhanVien : Form
    {
        BSL_QuanLyNhanVien BLNV = new BSL_QuanLyNhanVien();
        bool Them;
        string file = "";
        string hinh = "";
        public fThongTinNhanVien()
        {
            InitializeComponent();
        }
        private void fThongTinNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
            ReloadF();
        }
        private void LoadDataNhanVien()
        {
            dgvNhanvien.DataSource = BLNV.LayNhanVien();
            dgvNhanvien.AutoResizeColumns();
            dgvNhanvien_CellClick(null, null);
        }
        private void ReloadF()
        {
            this.txtMaNV.Enabled = false;
            this.txtHoten.Enabled = false;
            this.ptbHinhanh.Enabled = false;
            this.cbGioitinh.Enabled = false;
            this.txtChucvu.Enabled = false;
            this.dtpNgaysinh.Enabled = false;
            this.txtDiachi.Enabled = false;
            this.txtSDT.Enabled = false;
            this.txtLuong.Enabled = false;
            btnLuu.Enabled = false;
            btnReload.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void ReloadT()
        {
            this.txtMaNV.Enabled = true;
            this.txtHoten.Enabled = true;
            this.ptbHinhanh.Enabled = true;
            this.cbGioitinh.Enabled = true;
            this.txtChucvu.Enabled = true;
            this.dtpNgaysinh.Enabled = true;
            this.txtDiachi.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtLuong.Enabled = true;
            btnLuu.Enabled = true;
            btnReload.Enabled = true;
            btnHuy.Enabled = true;
        }
        public Image GetImage(string hinhanh)
        {
            string hinh = "";
            string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
            if (hinhanh != null) hinh = Path.Combine(src, hinhanh);
            if (File.Exists(hinh)) return Image.FromFile(hinh);
            return null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtMaNV.ResetText();
            this.txtHoten.ResetText();
            this.ptbHinhanh.Image = Properties.Resources.user_126px;
            this.cbGioitinh.ResetText();
            this.txtChucvu.ResetText();
            this.dtpNgaysinh.ResetText();
            this.txtSDT.ResetText();
            this.txtDiachi.ResetText();
            this.txtLuong.ResetText();
            this.txtMaNV.Focus();
            ReloadT();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.txtMaNV.Enabled = false;
            this.txtHoten.Enabled = true;
            this.ptbHinhanh.Enabled = true;
            this.cbGioitinh.Enabled = true;
            this.txtChucvu.Enabled = true;
            this.dtpNgaysinh.Enabled = true;
            this.txtDiachi.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtLuong.Enabled = true;
            btnReload.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = false;
            dgvNhanvien_CellClick(null, null);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnReload.Enabled = false;
            btnHuy.Enabled = false;
            if (!txtMaNV.Text.Trim().Equals("") && !txtHoten.Text.Trim().Equals("")
               && !cbGioitinh.Text.Trim().Equals("") && !txtChucvu.Text.Trim().Equals("") && !dtpNgaysinh.Text.Trim().Equals("")
               && !txtDiachi.Text.Trim().Equals("") && !txtSDT.Text.Trim().Equals("") && !txtLuong.Text.Trim().Equals(""))
            {
                if (Them)
                {
                    BLNV.ThemNhanVien(this.txtMaNV.Text, this.txtHoten.Text, file, this.cbGioitinh.Text,
                        this.txtChucvu.Text, this.dtpNgaysinh.Value.Date, this.txtDiachi.Text, this.txtSDT.Text, Convert.ToDecimal(this.txtLuong.Text));
                    LoadDataNhanVien();
                    MessageBox.Show("Đã thêm xong!");
                    fDoiMatKhau add = new fDoiMatKhau();
                    add.ShowDialog();
                }
                else
                {
                    int r = dgvNhanvien.CurrentCell.RowIndex;
                    string strMaNV = dgvNhanvien.Rows[r].Cells[0].Value.ToString();
                    BLNV.SuaNhanVien(this.txtMaNV.Text, this.txtHoten.Text, file, this.cbGioitinh.Text,
                        this.txtChucvu.Text, this.dtpNgaysinh.Value.Date, this.txtDiachi.Text, this.txtSDT.Text, Convert.ToDecimal(this.txtLuong.Text));
                    LoadDataNhanVien();
                    MessageBox.Show("Đã sửa xong!");
                }

            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!");
            }
        }
        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanvien.CurrentCell.RowIndex;
            this.txtMaNV.Text = dgvNhanvien.Rows[r].Cells[0].Value.ToString();
            this.txtHoten.Text = dgvNhanvien.Rows[r].Cells[1].Value.ToString();
            if (dgvNhanvien.Rows[r].Cells[2].Value != null)
            {
                file = dgvNhanvien.Rows[r].Cells[2].Value.ToString();
                ptbHinhanh.Image = GetImage(dgvNhanvien.Rows[r].Cells[2].Value.ToString());
            }
            else ptbHinhanh.Image = Properties.Resources.user_126px;
            this.cbGioitinh.Text = dgvNhanvien.Rows[r].Cells[3].Value.ToString();
            this.txtChucvu.Text = dgvNhanvien.Rows[r].Cells[4].Value.ToString();
            this.dtpNgaysinh.Text = dgvNhanvien.Rows[r].Cells[5].Value.ToString();
            this.txtDiachi.Text = dgvNhanvien.Rows[r].Cells[6].Value.ToString();
            this.txtSDT.Text = dgvNhanvien.Rows[r].Cells[7].Value.ToString();
            this.txtLuong.Text = dgvNhanvien.Rows[r].Cells[8].Value.ToString();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvNhanvien.CurrentCell.RowIndex;
            string strNHANVIEN =
                dgvNhanvien.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc xóa không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BLNV.XoaNhanVien(txtMaNV.Text);
                LoadDataNhanVien();
                MessageBox.Show("Đã xóa xong!");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataNhanVien();
            ReloadF();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }
        private void ptbHinhanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
                file = Path.GetFileName(openFileDialog1.FileName);
                hinh = Path.Combine(src, file);
                if (!File.Exists(Path.Combine(src, file)))
                    File.Copy(openFileDialog1.FileName, hinh);
                ptbHinhanh.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            this.txtMaNV.ResetText();
            this.txtHoten.ResetText();
            this.ptbHinhanh.Image = Properties.Resources.user_126px;
            this.cbGioitinh.ResetText();
            this.txtChucvu.ResetText();
            this.dtpNgaysinh.ResetText();
            this.txtSDT.ResetText();
            this.txtDiachi.ResetText();
            this.txtLuong.ResetText();
        }
    }
}
