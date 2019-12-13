using QLCHBXH.BSL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBXH
{
    public partial class fSanPham : Form
    {
        BSL_Xe BSLXe = new BSL_Xe();
        BSL_KhoXe BSLKhoXe = new BSL_KhoXe();
        BSL_KhachHang BSLKhachHang = new BSL_KhachHang();
        LayHoaDon lhd = new LayHoaDon();
        bool Them = false;
        public fSanPham()
        {
            InitializeComponent();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            LoadDataXe();
            LoadDataHopDong();
            LoadDataBaoTri();
            LoadDataXeBaoTri();
        }

        #region Xe
        void LoadDataXe()
        {
            try
            {
                dgvXe.DataSource = BSLKhoXe.LayXe();
                dgvXe.AutoResizeColumns();
                ReloadFXe();
                dgvXe_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table XE!");
            }
        }
        private void ReloadFXe()
        {
            this.txtMaXe.Enabled = false;
            this.txtKieuXe.Enabled = false;
            this.txtTenXe.Enabled = false;
            this.txtSoLuong.Enabled = false;
            this.txtMau.Enabled = false;
            this.txtLoaiDongCo.Enabled = false;
            this.txtMaLuc.Enabled = false;
            this.txtMomenXoan.Enabled = false;
            this.txtTocDoToiDa.Enabled = false;
            this.txtSuTangToc.Enabled = false;
            this.dtpNgayNhap.Enabled = false;
            this.txtGiaXe.Enabled = false;
            this.txtMaGiamGia.Enabled = false;
            this.btnTaoBill.Enabled = true;
        }
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvXe.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            this.txtMaXe.Text = dgvXe.Rows[r].Cells[0].Value.ToString();
            this.txtKieuXe.Text = dgvXe.Rows[r].Cells[1].Value.ToString();
            this.txtTenXe.Text = dgvXe.Rows[r].Cells[2].Value.ToString();
            if (dgvXe.Rows[r].Cells[3].Value != null) ptbHinh.Image = EditImageSize(GetImage(dgvXe.Rows[r].Cells[3].Value.ToString()));
            this.txtSoLuong.Text = dgvXe.Rows[r].Cells[4].Value.ToString();
            if (Convert.ToInt32(dgvXe.Rows[r].Cells[4].Value) == 0)
                MessageBox.Show("Tạm hết hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.txtMau.Text = dgvXe.Rows[r].Cells[5].Value.ToString();
            this.txtLoaiDongCo.Text = dgvXe.Rows[r].Cells[6].Value.ToString();
            this.txtMaLuc.Text = dgvXe.Rows[r].Cells[7].Value.ToString();
            this.txtMomenXoan.Text = dgvXe.Rows[r].Cells[8].Value.ToString();
            this.txtTocDoToiDa.Text = dgvXe.Rows[r].Cells[9].Value.ToString();
            this.txtSuTangToc.Text = dgvXe.Rows[r].Cells[10].Value.ToString();
            this.dtpNgayNhap.Text = dgvXe.Rows[r].Cells[11].Value.ToString();
            this.txtGiaXe.Text = dgvXe.Rows[r].Cells[12].Value.ToString();
            if (dgvXe.Rows[r].Cells[13].Value == null) this.txtMaGiamGia.Text = "";
            else txtMaGiamGia.Text = dgvXe.Rows[r].Cells[13].Value.ToString();
            this.txtMaChiec.Text = BSLXe.LayMaChiec(this.txtMaXe.Text);
        }
        public Image GetImage(string Hinh)
        {
            string path = "";
            string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
            if (Hinh != null) path = Path.Combine(src, Hinh);
            if (File.Exists(path)) return Image.FromFile(path);
            return null;
        }
        public Image EditImageSize(Image i)
        {
            return (Image)(new Bitmap(i, new Size(179, 203)));
        }
        #endregion

        #region Bán hàng
        void LoadDataHopDong()
        {
            try
            {
                dgvHopDong.DataSource = BSLXe.LayHopDong();
                dgvHopDong.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HOPDONG!");
            }
        }
        void ReloadT()
        {
            this.txtMaChiec.Enabled = false;
            this.txtMaHD.Enabled = true;
            this.cbNguoiBan.Enabled = true;
            this.txtTenKH.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
            this.txtCMND.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.cbGoiBaoHiem.Enabled = true;
            this.txtThoiHan.Enabled = true;
            this.txtMaBaoTri.Enabled = true;
            this.dtpNgayHetHan.Enabled = true;
        }
        void ReloadF()
        {
            this.cbGoiBaoHiem.Enabled = false;
            this.txtThoiHan.Enabled = false;
            this.txtMaBaoTri.Enabled = false;
            this.dtpNgayHetHan.Enabled = false;
            this.txtMaHD.Enabled = false;
            this.cbNguoiBan.Enabled = false;
            this.txtTenKH.Enabled = false;
            this.dtpNgaySinh.Enabled = false;
            this.txtCMND.Enabled = false;
            this.txtSDT.Enabled = false;
            this.txtDiaChi.Enabled = false;
        }
        private void btnTaoBill_Click(object sender, EventArgs e)
        {
            Them = true;
            tabControlXe.SelectTab(1);
            this.txtMaHD.Focus();
            this.cbGoiBaoHiem.DataSource = BSLXe.LayMaBaoHiem();
            this.cbNguoiBan.DataSource = BSLXe.LayMaNhanSu();
            cbGoiBaoHiem.SelectedIndex = -1;
            cbNguoiBan.SelectedIndex = -1;
            dgvChiTietHopDong.Rows.Clear();
            ReloadT();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                BSLKhachHang.ThemKhachHang(this.txtTenKH.Text, Convert.ToDateTime(this.dtpNgaySinh.Text), this.txtCMND.Text, this.txtSDT.Text, this.txtDiaChi.Text);
                Them = false;
            }
            dgvChiTietHopDong.Rows.Add(txtMaHD.Text, txtMaChiec.Text, cbGoiBaoHiem.SelectedValue.ToString(), txtThoiHan.Text, txtMaBaoTri.Text);
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thêm xe hoặc gói bảo hiểm vào mã hợp đồng " + this.txtMaHD.Text + " này?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                tabControlXe.SelectTab(0);
                this.btnTaoBill.Enabled = false;
                ReloadF();
                this.cbGoiBaoHiem.Enabled = true;
                this.txtThoiHan.Enabled = true;
            }
            else ReloadF();
            int r = dgvXe.CurrentCell.RowIndex;
            int soLuong = Convert.ToInt32(dgvXe.Rows[r].Cells[4].Value.ToString());
            soLuong = soLuong - 1;
            dgvXe.Rows[r].Cells[4].Value = soLuong.ToString();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal tongTien = 0, giaXe = 0, giaBH = 0;
            for (int i = 0; i < dgvChiTietHopDong.Rows.Count - 1; i++)
            {
                giaXe = BSLXe.LayGiaTienXe(dgvChiTietHopDong.Rows[i].Cells[1].Value.ToString());
                giaBH = BSLXe.LayGiaTienBaoHiem(dgvChiTietHopDong.Rows[i].Cells[2].Value.ToString());
                decimal thoiHan = Convert.ToDecimal(txtThoiHan.Text.Split(' ')[0]);
                tongTien = giaXe + giaBH * thoiHan;
                string tenSP = BSLXe.LayTenSanPham(dgvChiTietHopDong.Rows[i].Cells[1].Value.ToString());
                lhd.mTenSP.Add(tenSP);
                string tenGoiBH = BSLXe.LayTenGoiBaoHiem(dgvChiTietHopDong.Rows[i].Cells[2].Value.ToString());
                lhd.mTenGoiBaoHiem.Add(tenGoiBH);
            }
            BSLXe.ThemHopDong(this.txtMaHD.Text, BSLKhachHang.LayKhachHang().Last().MaKH, cbNguoiBan.SelectedValue.ToString(), tongTien,
                  DateTime.Now.Date, dtpNgayHetHan.Value.Date);
            LoadDataHopDong();
            BSLXe.ThemMaBaoTri(this.txtMaBaoTri.Text);
            BSLXe.ThemXeBaoTri(this.txtMaBaoTri.Text, this.txtMaChiec.Text, BSLKhachHang.LayKhachHang().Last().MaKH);

            List<String> mMaChiec = new List<string>();
            for (int i = 0; i < dgvChiTietHopDong.Rows.Count - 1; i++)
            {
                BSLXe.ThemChiTietHopDong(dgvChiTietHopDong.Rows[i].Cells[0].Value.ToString(), dgvChiTietHopDong.Rows[i].Cells[1].Value.ToString(),
                       dgvChiTietHopDong.Rows[i].Cells[2].Value.ToString(), dgvChiTietHopDong.Rows[i].Cells[3].Value.ToString(),
                       dgvChiTietHopDong.Rows[i].Cells[4].Value.ToString());
                string maChiec = dgvChiTietHopDong.Rows[i].Cells[1].Value.ToString();
                mMaChiec.Add(maChiec);
            }
            List<String> lMaChiec = mMaChiec.Distinct().ToList<String>();
            for (int i = 0; i < lMaChiec.Count; i++)
                BSLXe.CheckSoLuongXe(BSLXe.LayMaXe(lMaChiec[i]));

            lhd.thanhTien = tongTien * (decimal)1.1;
            lhd.tenKH = BSLKhachHang.LayKhachHang().Last().HoTen.ToString();
            lhd.tenNV = BSLXe.LayTenNhanVien(cbNguoiBan.SelectedValue.ToString());
            lhd.ngayLapHD = DateTime.Now.Date;
            lhd.maHopDong = this.txtMaHD.Text;
            LoadDataXe();
            LoadDataBaoTri();
            LoadDataXeBaoTri();
            fHoaDon hd = new fHoaDon();
            hd.Tag = lhd;
            hd.ShowDialog();
        }
        #endregion

        #region Bảo trì
        void LoadDataBaoTri()
        {
            try
            {
                dgvBaoTri.DataSource = BSLXe.LayBaoTri();
                dgvBaoTri.AutoResizeColumns();
                ReloadFBaoTri();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table XE!");
            }
        }
        private void dgvBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBaoTri.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            this.txtMaBaoTri2.Text = dgvBaoTri.Rows[r].Cells[0].Value.ToString();
            if (dgvBaoTri.Rows[r].Cells[1].Value == null) this.txtDongCo.Text = "";
            else this.txtDongCo.Text = dgvBaoTri.Rows[r].Cells[1].Value.ToString();
            if (dgvBaoTri.Rows[r].Cells[2].Value == null) this.txtHTDL.Text = "";
            else this.txtHTDL.Text = dgvBaoTri.Rows[r].Cells[2].Value.ToString();
            if (dgvBaoTri.Rows[r].Cells[3].Value == null) this.txtGamVaThanXe.Text = "";
            else this.txtGamVaThanXe.Text = dgvBaoTri.Rows[r].Cells[3].Value.ToString();
            if (dgvBaoTri.Rows[r].Cells[4].Value == null) this.txtCapDo.Text = "";
            else this.txtCapDo.Text = dgvBaoTri.Rows[r].Cells[4].Value.ToString();
            if (dgvBaoTri.Rows[r].Cells[5].Value == null) this.dtpNgayLay.Text = "";
            else this.dtpNgayLay.Text = dgvBaoTri.Rows[r].Cells[5].Value.ToString();
        }
        void ReloadFBaoTri()
        {
            this.txtMaBaoTri2.Enabled = false;
            this.txtMaPhuTung.Enabled = false;
            this.txtDongCo.Enabled = false;
            this.txtHTDL.Enabled = false;
            this.txtGamVaThanXe.Enabled = false;
            this.txtCapDo.Enabled = false;
            this.dtpNgayLay.Enabled = false;
            this.btnSuaBT.Enabled = true;
            this.btnLuuBT.Enabled = false;
            this.btnHuyBT.Enabled = false;
            this.btnXoaBT.Enabled = true;
        }
        void ReloadCapNhatBaoTri()
        {
            this.txtMaPhuTung.Enabled = true;
            this.txtMaPhuTung.Focus();
            this.txtDongCo.Enabled = true;
            this.txtHTDL.Enabled = true;
            this.txtGamVaThanXe.Enabled = true;
            this.txtCapDo.Enabled = true;
            this.dtpNgayLay.Enabled = true;
            this.btnSuaBT.Enabled = false;
            this.btnLuuBT.Enabled = true;
            this.btnHuyBT.Enabled = true;
            this.btnXoaBT.Enabled = false;
        }
        void LoadDataXeBaoTri()
        {
            try
            {
                dgvXeBaoTri.DataSource = BSLXe.LayXeBaoTri();
                dgvXeBaoTri.AutoResizeColumns();
                ReloadFXeBaoTri();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table XE!");
            }
        }
        private void dgvXeBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvXeBaoTri.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            this.txtMaBaoTri3.Text = dgvXeBaoTri.Rows[r].Cells[0].Value.ToString();
            this.txtMaChiec3.Text = dgvXeBaoTri.Rows[r].Cells[1].Value.ToString();
            this.txtMaKH3.Text = dgvXeBaoTri.Rows[r].Cells[2].Value.ToString();
        }
        void ReloadFXeBaoTri()
        {
            this.txtMaBaoTri3.Enabled = false;
            this.txtMaChiec3.Enabled = false;
            this.txtMaKH3.Enabled = false;
        }
        private void btnCapNhatBT_Click(object sender, EventArgs e)
        {
            dgvBaoTri_CellClick(null, null);
            ReloadCapNhatBaoTri();
        }
        private void btnLuuBT_Click(object sender, EventArgs e)
        {
            if (!txtMaBaoTri2.Text.Trim().Equals("") && !txtMaPhuTung.Text.Trim().Equals("") && !txtDongCo.Text.Trim().Equals("") && !txtHTDL.Text.Trim().Equals("") &&
                !txtGamVaThanXe.Text.Trim().Equals("") && !txtCapDo.Text.Trim().Equals("") && !dtpNgayLay.Text.Trim().Equals(""))
            {
                int r = dgvBaoTri.CurrentCell.RowIndex;
                string strMaBaoTri = dgvBaoTri.Rows[r].Cells[0].Value.ToString();
                BSLXe.CapNhatBaoTri(strMaBaoTri, this.txtMaPhuTung.Text, this.txtDongCo.Text, this.txtHTDL.Text, this.txtGamVaThanXe.Text,
                    Convert.ToInt32(this.txtCapDo.Text), Convert.ToDateTime(this.dtpNgayLay.Text));
                LoadDataBaoTri();
                MessageBox.Show("Đã sửa thành công!");
            }
            else
            {
                MessageBox.Show("Lỗi rồi! Hãy nhập đầy đủ thông tin");
            }
        }
        private void btnHuyBT_Click(object sender, EventArgs e)
        {
            ReloadFBaoTri();
            dgvBaoTri_CellClick(null, null);
        }
        private void btnXoaBT_Click(object sender, EventArgs e)
        {
            int r = dgvBaoTri.CurrentCell.RowIndex;
            string strMaBaoTri = dgvBaoTri.Rows[r].Cells[0].Value.ToString();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BSLXe.XoaBaoTri(this.txtMaBaoTri2.Text);
                LoadDataBaoTri();
                LoadDataXeBaoTri();
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
