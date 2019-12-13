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
    public partial class fKhachHang : Form
    {
        BSL_KhachHang BSLKhachHang = new BSL_KhachHang();
        public fKhachHang()
        {
            InitializeComponent();
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            LoadDataKhachHang();
        }
        void LoadDataKhachHang()
        {
            try
            {
                dgvKhachHang.DataSource = BSLKhachHang.LayKhachHang();
                dgvKhachHang.AutoResizeColumns();
                ReloadF();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PHUTUNG!");
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            //Chuyển thông tin lên
            if (dgvKhachHang.Rows[r].Cells[0].Value == null) this.txtMaKH.Text = "";
            else this.txtMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            if (dgvKhachHang.Rows[r].Cells[1].Value == null) this.txtTenKH.Text = "";
            else this.txtTenKH.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            if (dgvKhachHang.Rows[r].Cells[2].Value == null) this.dtpNgaySinh.Text = "";
            else this.dtpNgaySinh.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            if (dgvKhachHang.Rows[r].Cells[3].Value == null) this.txtCMND.Text = "";
            else this.txtCMND.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            if (dgvKhachHang.Rows[r].Cells[4].Value == null) this.txtSDT.Text = "";
            else this.txtSDT.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();
            if (dgvKhachHang.Rows[r].Cells[5].Value == null) this.txtDiaChi.Text = "";
            else this.txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[5].Value.ToString();
        }
        private void ReloadF()
        {
            this.txtMaKH.Enabled = false;
            this.txtTenKH.Enabled = false;
            this.dtpNgaySinh.Enabled = false;
            this.txtCMND.Enabled = false;
            this.txtSDT.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.btnTimKiem.Enabled = true;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvKhachHang_CellClick(null, null);
            this.txtMaKH.Enabled = false;
            this.txtTenKH.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
            this.txtCMND.Enabled = true;
            this.txtSDT.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.btnTimKiem.Enabled = false;
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtTenKH.Focus();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!txtMaKH.Text.Trim().Equals("") && !txtTenKH.Text.Trim().Equals("") && !dtpNgaySinh.Text.Trim().Equals("") &&
                !txtCMND.Text.Trim().Equals("") && !txtSDT.Text.Trim().Equals("") && !txtDiaChi.Text.Trim().Equals(""))
            {
                    int r = dgvKhachHang.CurrentCell.RowIndex;
                    int iMaKH = Convert.ToInt32(dgvKhachHang.Rows[r].Cells[0].Value.ToString());
                    BSLKhachHang.CapNhatKhachHang(iMaKH, this.txtTenKH.Text, Convert.ToDateTime(this.dtpNgaySinh.Text),
                        this.txtCMND.Text, this.txtSDT.Text, this.txtDiaChi.Text);
                    LoadDataKhachHang();
                    MessageBox.Show("Đã sửa thành công!");
            }
            else
            {
                MessageBox.Show("Lỗi rồi! Hãy nhập đầy đủ thông tin");
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReloadF();
            dgvKhachHang_CellClick(null, null);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            int iMaKH = Convert.ToInt32(dgvKhachHang.Rows[r].Cells[0].Value.ToString());
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                BSLKhachHang.XoaKhachHang(Convert.ToInt32(this.txtMaKH.Text));
                LoadDataKhachHang();
                MessageBox.Show("Đã xóa xong!");
            }
            else
            {
                MessageBox.Show("Không xóa được!");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = BSLKhachHang.LayKhachHangTheoSDT(this.txtTimKiem.Text);
            if (dgvKhachHang.RowCount > 0) dgvKhachHang_CellClick(null, null);
            else MessageBox.Show("Không có khách hàng cần tìm!");
        }
    }
}
