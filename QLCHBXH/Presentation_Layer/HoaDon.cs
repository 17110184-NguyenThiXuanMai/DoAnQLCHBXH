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

namespace QLCHBXH
{
    public partial class fHoaDon : Form
    {
        BSL_Xe BSLXe = new BSL_Xe();
        LayHoaDon data = new LayHoaDon();
        public fHoaDon()
        {
            InitializeComponent();
        }
        private void fHoaDon_Load(object sender, EventArgs e)
        {
            this.txtTenKH.ResetText();
            this.txtSanPham.ResetText();
            this.txtGoiBaoHiem.ResetText();
            this.txtThanhTien.ResetText();
            this.txtDate.ResetText();
            this.txtNguoiLap.ResetText();
            this.txtMaHoaDon.Focus();
            data = (LayHoaDon)this.Tag;
            for (int i = 0; i < data.mTenSP.Count - 1; i++)
                for (int j = i + 1; j < data.mTenSP.Count; j++)
                    if (data.mTenSP[i] != data.mTenSP[j]) this.txtSanPham.Text += data.mTenSP[i] + ", ";
            if (data.mTenSP.Count != data.mTenSP.Count - 1) this.txtSanPham.Text += data.mTenSP.Last();
            for (int i = 0; i < data.mTenGoiBaoHiem.Count - 1; i++)
            {
                this.txtGoiBaoHiem.Text += data.mTenGoiBaoHiem[i] + ", ";
            }
            this.txtGoiBaoHiem.Text += data.mTenGoiBaoHiem.Last();
            this.txtTenKH.Text = data.tenKH;
            this.txtThanhTien.Text = data.thanhTien.ToString();
            this.txtNguoiLap.Text = data.tenNV;
            this.txtDate.Text = data.ngayLapHD.ToString();
        }
        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            BSLXe.ThemHoaDon(this.txtMaHoaDon.Text, data.maHopDong, Convert.ToDecimal(this.txtThanhTien.Text));
            this.Close();
        }
    }
}
