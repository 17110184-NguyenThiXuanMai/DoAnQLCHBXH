using QLCHBXH.Presentation_Layer;
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
    public partial class fNhanVien : Form
    {
        public fNhanVien()
        {
            InitializeComponent();
        }
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
        private void ptbMenu_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width >= 155) timerLSlide.Start();
            else timerRSlide.Start();
        }
        private void timerLSlide_Tick(object sender, EventArgs e)
        {
            if (panelLeft.Width <= 42) timerLSlide.Stop();
            else panelLeft.Width = panelLeft.Width - 5;
        }
        private void timerRSlide_Tick(object sender, EventArgs e)
        {
            if (panelLeft.Width >= 155) timerRSlide.Stop();
            else panelLeft.Width = panelLeft.Width + 5;
        }
        public void OpenFormInPanel(object tempForm, Panel tempPanel)
        {
            if (tempPanel.Controls.Count > 0)
                tempPanel.Controls.RemoveAt(0);
            Form tf = tempForm as Form;
            tf.Text = this.Text;
            tf.TopLevel = false;
            tf.Dock = DockStyle.Fill;
            tempPanel.Controls.Add(tf);
            tempPanel.Tag = tf;
            tf.Show();
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new fSanPham(), this.panelShow);
        }
        private void btnPhuTung_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new fPhuTung(), this.panelShow);
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new fKhachHang(), this.panelShow);
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau dmk = new fDoiMatKhau();
            dmk.Text = this.Text;
            dmk.ShowDialog();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            fDangNhap dn = new fDangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Close();
        }
    }
}
