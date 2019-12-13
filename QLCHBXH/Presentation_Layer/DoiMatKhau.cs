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
    public partial class fDoiMatKhau : Form
    {
        BSL_User BLUser = new BSL_User();
        public fDoiMatKhau()
        {
            InitializeComponent();
        }
        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtPass.Focus();
            label8.Visible = false;
            txtUsername.Text = this.Text;
        }
        bool LayUsername(string username)
        {
            return BLUser.LayUsername(username);
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.UserName = txtUsername.Text;
            dn.Pass = txtImportpass.Text;
            BLUser.SuaPass(dn);
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void txtImportpass_TextChanged(object sender, EventArgs e)
        {
            if (txtImportpass.Text == "")
            {
                label8.Visible = false;
            }
            else if (txtImportpass.Text != txtNewpass.Text)
            {
                if (txtNewpass.Text == "")
                {
                    label8.Visible = true;
                    label8.Text = "Please enter a new password!";
                }
                else
                {
                    label8.Visible = true;
                    label8.Text = "Not Matched";
                }
            }
            else if (txtImportpass.Text == txtNewpass.Text)
            {
                label8.Visible = true;
                label8.Text = "OK";
            }
        }
    }
}
