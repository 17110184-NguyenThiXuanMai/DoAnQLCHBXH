using QLCHBXH.BSL_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBXH.Presentation_Layer
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        DbDataContext db = new DbDataContext();
        #endregion

        #region Event
        private void fDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignin.PerformClick();
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.Text == "Password") txtPassword.isPassword = true;
        }
        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username") txtUsername.Text = "";
        }
        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password") txtPassword.Text = "";
            txtPassword.isPassword = true;
        }
        private void plHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Đăng nhập
        BSL_User us = new BSL_User();
        private void btnSignin_Click(object sender, EventArgs e)
        {
            string chucvu = us.LogIn(txtUsername.Text, txtPassword.Text);
            if (chucvu == "Quản lý" || chucvu == "Quản lý kho")
            {
                this.Hide();
                fQuanLy ql = new fQuanLy();
                ql.Text = txtUsername.Text;
                ql.ShowDialog();
                this.Close();
            }
            else if (chucvu == "Nhân viên bán hàng" || chucvu == "Cố vấn dịch vụ" || chucvu == "Kế toán")
            {
                this.Hide();
                fNhanVien nv = new fNhanVien();
                nv.Text = txtUsername.Text;
                nv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }
        #endregion
    }
}
