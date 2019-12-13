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
    public partial class fIntro : Form
    {
        public static int i = 0;
        public fIntro()
        {
            InitializeComponent();
        }
        private void Intro_Load(object sender, EventArgs e)
        {
            timerIntro.Start();
        }
        private void timerIntro_Tick(object sender, EventArgs e)
        {
            Display();
            i++;
            if (i == 5) i = 0;
        }
        private void Display()
        {
            if (i == 0)
            {
                ptbIntro.Image = Properties.Resources.intro1;
            }
            if (i == 1)
            {
                ptbIntro.Image = Properties.Resources.intro2;
            }
            if (i == 2)
            {
                ptbIntro.Image = Properties.Resources.intro3;
            }
            if (i == 3)
            {
                ptbIntro.Image = Properties.Resources.intro4;
            }
            if (i == 4)
            {
                ptbIntro.Image = Properties.Resources.intro5;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDangNhap dn = new fDangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
