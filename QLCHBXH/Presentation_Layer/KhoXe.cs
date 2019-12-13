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
    public partial class fKhoXe : Form
    {
        BSL_KhoXe BSLKhoXe = new BSL_KhoXe();
        bool Them, Them2;
        string hinh = "";
        string file = "";
        public fKhoXe()
        {
            InitializeComponent();
        }
        private void fKhoXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'showroomAudiDataSet28.Xe' table. You can move, or remove it, as needed.
            this.xeTableAdapter1.Fill(this.showroomAudiDataSet28.Xe);
            LoadDataXe();
            ReloadF();
            LoadDataKhoXe();
            ReloadF2();
            btnReload3.Enabled = false;
        }
        void LoadDataXe()
        {
            dgvXe.DataSource = BSLKhoXe.LayXe();
        }
        void LoadDataKhoXe()
        {
            dgvKhoXe.DataSource = BSLKhoXe.LayKhoXe();
        }
        private void ReloadF()
        {
            this.txtMaXe.Enabled = false;
            this.cbKieuXe.Enabled = false;
            this.txtTenXe.Enabled = false;
            this.txtSoLuong.Enabled = false;
            this.cbMau.Enabled = false;
            this.txtLoaiDongCo.Enabled = false;
            this.txtMaLuc.Enabled = false;
            this.txtMomenXoan.Enabled = false;
            this.txtTocDoToiDa.Enabled = false;
            this.txtSuTangToc.Enabled = false;
            this.dtpNgayNhap.Enabled = false;
            this.txtGiaXe.Enabled = false;
            this.cbMaGiamGia.Enabled = false;
            this.ptbHinhAnh.Enabled = false;
            this.btnReload2.Enabled = false;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnSua.Enabled = true;
            this.btnHuy.Enabled = false;
        }
        private void ReloadF2()
        {
            this.cbMaXe.Enabled = false;
            this.txtMaChiec.Enabled = false;
            this.btnThem2.Enabled = true;
            this.btnXoa2.Enabled = true;
            this.btnLuu2.Enabled = false;
            this.btnSua2.Enabled = true;
            this.txtTinhTrang.Enabled = false;
        }
        private void ReloadT()
        {
            this.txtMaXe.ResetText();
            this.cbKieuXe.ResetText();
            this.txtTenXe.ResetText();
            this.txtSoLuong.ResetText();
            this.cbMau.ResetText();
            this.txtLoaiDongCo.ResetText();
            this.txtMaLuc.ResetText();
            this.txtMomenXoan.ResetText();
            this.txtTocDoToiDa.ResetText();
            this.txtSuTangToc.ResetText();
            this.dtpNgayNhap.ResetText();
            this.txtGiaXe.ResetText();
            this.cbMaGiamGia.ResetText();
            this.txtMaXe.Enabled = true;
            this.cbKieuXe.Enabled = true;
            this.txtTenXe.Enabled = true;
            this.txtSoLuong.Enabled = true;
            this.cbMau.Enabled = true;
            this.txtLoaiDongCo.Enabled = true;
            this.txtMaLuc.Enabled = true;
            this.txtMomenXoan.Enabled = true;
            this.txtTocDoToiDa.Enabled = true;
            this.txtSuTangToc.Enabled = true;
            this.dtpNgayNhap.Enabled = true;
            this.txtGiaXe.Enabled = true;
            this.cbMaGiamGia.Enabled = true;
            this.ptbHinhAnh.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            ReloadT();
            txtMaXe.Focus();
            this.ptbHinhAnh.Image = Properties.Resources.car2;
            this.btnThem.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnReload2.Enabled = true;
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ReloadF();
            btnXoa.Enabled = true;
            if (!txtMaXe.Text.Trim().Equals("") && !cbKieuXe.Text.Trim().Equals("") && !txtTenXe.Text.Trim().Equals("") && !txtSoLuong.Text.Trim().Equals("")
               && !cbMau.Text.Trim().Equals("") && !txtLoaiDongCo.Text.Trim().Equals("") && !txtMaLuc.Text.Trim().Equals("") && !txtMomenXoan.Text.Trim().Equals("")
               && !txtTocDoToiDa.Text.Trim().Equals("") && !txtSuTangToc.Text.Trim().Equals("") && !dtpNgayNhap.Text.Trim().Equals("")
               && !txtGiaXe.Text.Trim().Equals(""))
            {
                if (Them)
                {
                    if (this.cbMaGiamGia.Text == "")
                    {
                        BSLKhoXe.ThemXe(this.txtMaXe.Text, this.cbKieuXe.Text, this.txtTenXe.Text, file, Convert.ToInt32(this.txtSoLuong.Text), this.cbMau.Text,
                        this.txtLoaiDongCo.Text, Convert.ToInt32(this.txtMaLuc.Text), Convert.ToInt32(this.txtMomenXoan.Text),
                        this.txtTocDoToiDa.Text, this.txtSuTangToc.Text, this.dtpNgayNhap.Value.Date, Convert.ToDecimal(this.txtGiaXe.Text),
                        null);
                    }
                    else
                    {
                        BSLKhoXe.ThemXe(this.txtMaXe.Text, this.cbKieuXe.Text, this.txtTenXe.Text, file, Convert.ToInt32(this.txtSoLuong.Text), this.cbMau.Text,
                        this.txtLoaiDongCo.Text, Convert.ToInt32(this.txtMaLuc.Text), Convert.ToInt32(this.txtMomenXoan.Text),
                        this.txtTocDoToiDa.Text, this.txtSuTangToc.Text, this.dtpNgayNhap.Value.Date, Convert.ToDecimal(this.txtGiaXe.Text),
                        this.cbMaGiamGia.Text);
                    }
                    LoadDataXe();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    int r = dgvXe.CurrentCell.RowIndex;
                    string strMaXe = dgvXe.Rows[r].Cells[0].Value.ToString();
                    BSLKhoXe.CapNhatXe(strMaXe, this.cbKieuXe.Text, this.txtTenXe.Text, file, Convert.ToInt32(this.txtSoLuong.Text), this.cbMau.Text,
                        this.txtLoaiDongCo.Text, Convert.ToInt32(this.txtMaLuc.Text), Convert.ToInt32(this.txtMomenXoan.Text),
                        this.txtTocDoToiDa.Text, this.txtSuTangToc.Text, this.dtpNgayNhap.Value.Date, Convert.ToDecimal(this.txtGiaXe.Text),
                        this.cbMaGiamGia.Text);
                    LoadDataXe();
                    MessageBox.Show("Đã sửa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Lỗi rồi! Hãy nhập đầy đủ thông tin");
            }
        }
        private void ptbHinhAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
                file = Path.GetFileName(openFileDialog1.FileName);
                hinh = Path.Combine(src, file);
                if (!File.Exists(Path.Combine(src, file)))
                    File.Copy(openFileDialog1.FileName, hinh);
                ptbHinhAnh.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.txtMaXe.Enabled = false;
            this.cbKieuXe.Enabled = true;
            this.txtTenXe.Enabled = true;
            this.txtSoLuong.Enabled = true;
            this.cbMau.Enabled = true;
            this.txtLoaiDongCo.Enabled = true;
            this.txtMaLuc.Enabled = true;
            this.txtMomenXoan.Enabled = true;
            this.txtTocDoToiDa.Enabled = true;
            this.txtSuTangToc.Enabled = true;
            this.dtpNgayNhap.Enabled = true;
            this.txtGiaXe.Enabled = true;
            this.cbMaGiamGia.Enabled = true;
            this.btnLuu.Enabled = true;
            this.ptbHinhAnh.Enabled = true;
            this.btnReload2.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.cbKieuXe.Focus();
        }
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvXe.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            this.txtMaXe.Text = dgvXe.Rows[r].Cells[0].Value.ToString();
            this.cbKieuXe.Text = dgvXe.Rows[r].Cells[1].Value.ToString();
            this.txtTenXe.Text = dgvXe.Rows[r].Cells[2].Value.ToString();
            if (dgvXe.Rows[r].Cells[3].Value != null)
            {
                file = dgvXe.Rows[r].Cells[3].Value.ToString();
                ptbHinhAnh.Image = GetImage(dgvXe.Rows[r].Cells[3].Value.ToString());
            }
            this.txtSoLuong.Text = dgvXe.Rows[r].Cells[4].Value.ToString();
            this.cbMau.Text = dgvXe.Rows[r].Cells[5].Value.ToString();
            this.txtLoaiDongCo.Text = dgvXe.Rows[r].Cells[6].Value.ToString();
            this.txtMaLuc.Text = dgvXe.Rows[r].Cells[7].Value.ToString();
            this.txtMomenXoan.Text = dgvXe.Rows[r].Cells[8].Value.ToString();
            this.txtTocDoToiDa.Text = dgvXe.Rows[r].Cells[9].Value.ToString();
            this.txtSuTangToc.Text = dgvXe.Rows[r].Cells[10].Value.ToString();
            this.dtpNgayNhap.Text = dgvXe.Rows[r].Cells[11].Value.ToString();
            this.txtGiaXe.Text = dgvXe.Rows[r].Cells[12].Value.ToString();
            if (dgvXe.Rows[r].Cells[13].Value == null) this.cbMaGiamGia.Text = "";
            else cbMaGiamGia.Text = dgvXe.Rows[r].Cells[13].Value.ToString();
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ReloadF();
            dgvXe_CellClick(null, null);
            txtMaChiec.ResetText();
            tabControl1.SelectTab(1);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtMaXe.Focus();
            this.txtMaXe.ResetText();
            this.cbKieuXe.ResetText();
            this.txtTenXe.ResetText();
            this.txtSoLuong.ResetText();
            this.cbMau.ResetText();
            this.txtLoaiDongCo.ResetText();
            this.txtMaLuc.ResetText();
            this.txtMomenXoan.ResetText();
            this.txtTocDoToiDa.ResetText();
            this.txtSuTangToc.ResetText();
            this.dtpNgayNhap.ResetText();
            this.txtGiaXe.ResetText();
            this.cbMaGiamGia.ResetText();
            this.btnReload2.Enabled = true;
            txtMaChiec.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvXe.CurrentCell.RowIndex;
            string strMaXe = dgvXe.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BSLKhoXe.XoaXe(txtMaXe.Text);
                LoadDataXe();
                this.txtMaXe.ResetText();
                this.cbKieuXe.ResetText();
                this.txtTenXe.ResetText();
                this.txtSoLuong.ResetText();
                this.cbMau.ResetText();
                this.txtLoaiDongCo.ResetText();
                this.txtMaLuc.ResetText();
                this.txtMomenXoan.ResetText();
                this.txtTocDoToiDa.ResetText();
                this.txtSuTangToc.ResetText();
                this.dtpNgayNhap.ResetText();
                this.txtGiaXe.ResetText();
                this.cbMaGiamGia.ResetText();
                this.ptbHinhAnh.ResetText();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không xóa được!");
            }
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            cbMaXe.SelectedIndex = -1;
        }
        private void btnTroVe2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string _manv = txtTimkiem.Text;
            dgvXe.DataSource = BSLKhoXe.LayMaXe(_manv);
        }
        private void btnReload2_Click(object sender, EventArgs e)
        {
            LoadDataXe();
            ReloadF();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
            txtTimkiem.Focus();
            LoadDataXe();
        }
        private void dgvKhoXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhoXe.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            this.txtMaChiec.Text = dgvKhoXe.Rows[r].Cells[0].Value.ToString();
            this.cbMaXe.Text = dgvKhoXe.Rows[r].Cells[1].Value.ToString();
            this.txtTinhTrang.Text = dgvKhoXe.Rows[r].Cells[2].Value.ToString();
        }
        private void btnXoa2_Click(object sender, EventArgs e)
        {
            int r = dgvKhoXe.CurrentCell.RowIndex;
            string strMaChiec =
                dgvKhoXe.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc xóa không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BSLKhoXe.XoaXeTrongKho(txtMaChiec.Text);
                LoadDataKhoXe();
                txtMaChiec.ResetText();
                cbMaXe.ResetText();
                this.txtTinhTrang.ResetText();
                MessageBox.Show("Đã xóa xong!");
                LoadDataXe();
            }
        }
        private void btnThem2_Click(object sender, EventArgs e)
        {
            Them2 = true;
            btnThem2.Enabled = false;
            btnLuu2.Enabled = true;
            btnXoa2.Enabled = false;
            btnSua2.Enabled = false;
            btnReload3.Enabled = true;
            txtMaChiec.ResetText();
            cbMaXe.ResetText();
            txtMaChiec.Enabled = true;
            cbMaXe.Enabled = true;
            txtMaChiec.ResetText();
            cbMaXe.ResetText();
            txtTinhTrang.Enabled = true;
            string tinhTrang = "Còn hàng";
            txtTinhTrang.Text = tinhTrang;
        }
        private void btnReload3_Click(object sender, EventArgs e)
        {
            ReloadF2();
            LoadDataKhoXe();
            dgvKhoXe_CellClick(null, null);
        }
        private void btnSua2_Click(object sender, EventArgs e)
        {
            Them2 = false;
            btnSua2.Enabled = false;
            btnXoa2.Enabled = false;
            btnReload3.Enabled = true;
            btnLuu2.Enabled = true;
            cbMaXe.Enabled = true;
            txtTinhTrang.Enabled = false;
        }
        private void btnLuu2_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnThem2.Enabled = true;
            btnSua2.Enabled = true;
            if (!txtMaChiec.Text.Trim().Equals("") && !cbMaXe.Text.Trim().Equals("") && !txtTinhTrang.Text.Trim().Equals(""))
            {
                if (Them2)
                {
                    
                    BSLKhoXe.ThemXeVaoKho(this.txtMaChiec.Text, this.cbMaXe.Text, this.txtTinhTrang.Text);
                    LoadDataKhoXe();
                    MessageBox.Show("Đã thêm thành công!");
                }
                else
                {
                    int r = dgvXe.CurrentCell.RowIndex;
                    string strMaXe = dgvKhoXe.Rows[r].Cells[0].Value.ToString();
                    BSLKhoXe.CapNhatKhoXe(txtMaChiec.Text, this.cbMaXe.Text);
                    LoadDataKhoXe();
                    MessageBox.Show("Đã sửa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!");
            }
        }
        public Image GetImage(string hinhanh)
        {
            string hinh = "";
            string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
            if (hinhanh != null) hinh = Path.Combine(src, hinhanh);
            if (File.Exists(hinh)) return Image.FromFile(hinh);
            return null;
        }

    }
}
