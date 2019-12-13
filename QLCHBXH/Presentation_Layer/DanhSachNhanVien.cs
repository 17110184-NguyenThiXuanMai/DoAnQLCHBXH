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
    public partial class fDanhSachNhanVien : Form
    {
        BSL_QuanLyNhanVien BLNV = new BSL_QuanLyNhanVien();
        public fDanhSachNhanVien()
        {
            InitializeComponent();
        }
        private void fDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataDanhSachNhanVien();
        }
        void LoadDataDanhSachNhanVien()
        {
            dgvTimkiemnv.DataSource = BLNV.LayNhanVien();
            dgvTimkiemnv.AutoResizeColumns();
            dgvTimkiemnv_CellClick(null, null);
        }
        public Image GetImage(string hinhanh)
        {
            string hinh = "";
            string src = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources";
            if (hinhanh != null) hinh = Path.Combine(src, hinhanh);
            if (File.Exists(hinh)) return Image.FromFile(hinh);
            return null;
        }
        private void dgvTimkiemnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTimkiemnv.CurrentCell.RowIndex;
            if (dgvTimkiemnv.Rows[r].Cells[2].Value != null) ptbHinhanh.Image = GetImage(dgvTimkiemnv.Rows[r].Cells[2].Value.ToString());
            else ptbHinhanh.Image = Properties.Resources.user_126px;
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Text == "Mã Nhân Viên")
            {
                string _manv = txtTimkiem.Text;
                dgvTimkiemnv.DataSource = BLNV.LayMaNhanVien(_manv);
            }
            else if (cbTimkiem.Text == "Tên Nhân Viên")
            {
                string _tennv = txtTimkiem.Text;
                dgvTimkiemnv.DataSource = BLNV.LayTenNhanVien(_tennv);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tìm kiếm theo", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
