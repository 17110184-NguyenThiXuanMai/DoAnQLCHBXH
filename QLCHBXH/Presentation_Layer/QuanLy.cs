using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QLCHBXH.Presentation_Layer
{
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        int pos = 200;
        private void OpenFormInPanel(object tempForm, Panel temPanel)
        {
            if (temPanel.Controls.Count > 0)
                temPanel.Controls.RemoveAt(0);
            Form tf = tempForm as Form;
            tf.Text = this.Text;
            tf.TopLevel = false;
            tf.Dock = DockStyle.Fill;
            temPanel.Controls.Add(tf);
            temPanel.Tag = tf;
            tf.Show();
        }
        private void fQuanLy_Load(object sender, EventArgs e)
        {
            OpenFormInPanel(new fTrangChu(), plHome);
            plEmployee.Hide();
            btnWareHouse.Location = new Point(0, 140);
            btnStatistical.Location = new Point(0, pos);
            btnAccount.Location = new Point(0, 260);
        }
        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ptbMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbRestoredown.Visible = true;
            ptbMaximize.Visible = false;
        }
        private void ptbRestoredown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbMaximize.Visible = true;
            ptbRestoredown.Visible = false;
        }
        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ptbSlide_Click(object sender, EventArgs e)
        {
            if (plMenu.Width >= 222)
            {
                timerSlide2.Start();
            }
            else
            {
                timerSlide1.Start();
            }
        }
        private void timerSlide1_Tick(object sender, EventArgs e)
        {
            if (plMenu.Width >= 222)
            {
                timerSlide1.Stop();
            }
            else
            {
                plMenu.Width = plMenu.Width + 5;
            }
        }
        private void timerSlide2_Tick(object sender, EventArgs e)
        {
            if (plMenu.Width <= 77)
            {
                timerSlide2.Stop();
            }
            else
            {
                plMenu.Width = plMenu.Width - 12;
            }
        }
        private void plHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new fDanhSachNhanVien(), this.plHome);
            if (plEmployee.Visible == true)
            {
                plEmployee.Visible = false;
                btnWareHouse.Location = new Point(0, btnEmployee.Location.Y + btnEmployee.Height);
                pos = pos - 100;
                btnStatistical.Location = new Point(0, pos);
                btnAccount.Location = new Point(0, btnStatistical.Location.Y + btnStatistical.Height);
            }
            else
            {
                plEmployee.Visible = true;
                btnWareHouse.Location = new Point(0, plEmployee.Location.Y + plEmployee.Height);
                pos = pos + 100;
                btnStatistical.Location = new Point(0, pos);
                btnAccount.Location = new Point(0, btnStatistical.Location.Y + btnStatistical.Height);
            }
        }
        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Presentation_Layer.fKhoXe(), plHome);
        }
        private void btnInformation_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new fThongTinNhanVien(), this.plHome);
        }
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new fLichLamViec(), this.plHome);
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Presentation_Layer.fGiamGia(), this.plHome);
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            fDoiMatKhau dmk = new fDoiMatKhau();
            dmk.Text = this.Text;
            dmk.ShowDialog();
        }
        private void ptbHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new fTrangChu(), this.plHome);
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
