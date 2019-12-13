namespace QLCHBXH.Presentation_Layer
{
    partial class fIntro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIntro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.timerIntro = new System.Windows.Forms.Timer(this.components);
            this.ptbIntro = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.ptbMaximize = new System.Windows.Forms.PictureBox();
            this.ptbHide = new System.Windows.Forms.PictureBox();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIntro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 120);
            this.panel1.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDangNhap.FlatAppearance.BorderSize = 2;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Silver;
            this.btnDangNhap.Location = new System.Drawing.Point(807, 49);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(160, 41);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // timerIntro
            // 
            this.timerIntro.Enabled = true;
            this.timerIntro.Interval = 900;
            this.timerIntro.Tick += new System.EventHandler(this.timerIntro_Tick);
            // 
            // ptbIntro
            // 
            this.ptbIntro.Image = global::QLCHBXH.Properties.Resources.intro1;
            this.ptbIntro.Location = new System.Drawing.Point(-1, 116);
            this.ptbIntro.Name = "ptbIntro";
            this.ptbIntro.Size = new System.Drawing.Size(1088, 575);
            this.ptbIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbIntro.TabIndex = 3;
            this.ptbIntro.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCHBXH.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.ptbMaximize);
            this.panelTop.Controls.Add(this.ptbHide);
            this.panelTop.Controls.Add(this.ptbMinimize);
            this.panelTop.Controls.Add(this.ptbClose);
            this.panelTop.Location = new System.Drawing.Point(482, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(603, 27);
            this.panelTop.TabIndex = 4;
            // 
            // ptbMaximize
            // 
            this.ptbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximize.Image")));
            this.ptbMaximize.Location = new System.Drawing.Point(554, 5);
            this.ptbMaximize.Name = "ptbMaximize";
            this.ptbMaximize.Size = new System.Drawing.Size(19, 17);
            this.ptbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMaximize.TabIndex = 2;
            this.ptbMaximize.TabStop = false;
            this.ptbMaximize.Click += new System.EventHandler(this.ptbMaximize_Click);
            // 
            // ptbHide
            // 
            this.ptbHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbHide.Image = ((System.Drawing.Image)(resources.GetObject("ptbHide.Image")));
            this.ptbHide.Location = new System.Drawing.Point(529, 5);
            this.ptbHide.Name = "ptbHide";
            this.ptbHide.Size = new System.Drawing.Size(19, 17);
            this.ptbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHide.TabIndex = 1;
            this.ptbHide.TabStop = false;
            this.ptbHide.Click += new System.EventHandler(this.ptbHide_Click);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(555, 5);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(19, 17);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMinimize.TabIndex = 1;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(579, 5);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(19, 17);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // fIntro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 689);
            this.Controls.Add(this.ptbIntro);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIntro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbIntro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerIntro;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox ptbMaximize;
        private System.Windows.Forms.PictureBox ptbHide;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.PictureBox ptbClose;
    }
}