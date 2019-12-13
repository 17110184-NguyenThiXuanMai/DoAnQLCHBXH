namespace QLCHBXH.Presentation_Layer
{
    partial class fLichLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLichLamViec));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.dtpNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.rbCa2 = new System.Windows.Forms.RadioButton();
            this.rbCa1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLichlamviec = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.showroomAudiDataSet27 = new QLCHBXH.ShowroomAudiDataSet27();
            this.phanCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanCongTableAdapter = new QLCHBXH.ShowroomAudiDataSet27TableAdapters.PhanCongTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichlamviec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanCongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.BackColor = System.Drawing.Color.Thistle;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(572, 462);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(164, 42);
            this.btnLuu.TabIndex = 116;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.BackColor = System.Drawing.Color.Thistle;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(386, 462);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(164, 42);
            this.btnXoa.TabIndex = 115;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.BackColor = System.Drawing.Color.Thistle;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(199, 462);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(164, 42);
            this.btnSua.TabIndex = 114;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.Thistle;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(13, 462);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(164, 42);
            this.btnThem.TabIndex = 113;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReload.BackColor = System.Drawing.Color.Thistle;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(756, 462);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(164, 42);
            this.btnReload.TabIndex = 117;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.rbFull.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateBlue;
            this.rbFull.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.rbFull.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.rbFull.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFull.Location = new System.Drawing.Point(176, 314);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(49, 23);
            this.rbFull.TabIndex = 34;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "Full";
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.CheckedChanged += new System.EventHandler(this.rbFull_CheckedChanged);
            // 
            // dtpNgayketthuc
            // 
            this.dtpNgayketthuc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayketthuc.Location = new System.Drawing.Point(176, 168);
            this.dtpNgayketthuc.Name = "dtpNgayketthuc";
            this.dtpNgayketthuc.Size = new System.Drawing.Size(212, 24);
            this.dtpNgayketthuc.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFull);
            this.groupBox1.Controls.Add(this.dtpNgayketthuc);
            this.groupBox1.Controls.Add(this.dtpNgaybatdau);
            this.groupBox1.Controls.Add(this.cbMaNV);
            this.groupBox1.Controls.Add(this.rbCa2);
            this.groupBox1.Controls.Add(this.rbCa1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 369);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dtpNgaybatdau
            // 
            this.dtpNgaybatdau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaybatdau.Location = new System.Drawing.Point(176, 106);
            this.dtpNgaybatdau.Name = "dtpNgaybatdau";
            this.dtpNgaybatdau.Size = new System.Drawing.Size(212, 24);
            this.dtpNgaybatdau.TabIndex = 32;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(176, 48);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(212, 24);
            this.cbMaNV.TabIndex = 31;
            this.cbMaNV.ValueMember = "MaNV";
            // 
            // rbCa2
            // 
            this.rbCa2.AutoSize = true;
            this.rbCa2.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.rbCa2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateBlue;
            this.rbCa2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.rbCa2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.rbCa2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCa2.Location = new System.Drawing.Point(176, 270);
            this.rbCa2.Name = "rbCa2";
            this.rbCa2.Size = new System.Drawing.Size(57, 23);
            this.rbCa2.TabIndex = 30;
            this.rbCa2.TabStop = true;
            this.rbCa2.Text = "Ca 2";
            this.rbCa2.UseVisualStyleBackColor = true;
            this.rbCa2.CheckedChanged += new System.EventHandler(this.rbCa2_CheckedChanged);
            // 
            // rbCa1
            // 
            this.rbCa1.AutoSize = true;
            this.rbCa1.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.rbCa1.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateBlue;
            this.rbCa1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.rbCa1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.rbCa1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCa1.Location = new System.Drawing.Point(176, 226);
            this.rbCa1.Name = "rbCa1";
            this.rbCa1.Size = new System.Drawing.Size(57, 23);
            this.rbCa1.TabIndex = 29;
            this.rbCa1.TabStop = true;
            this.rbCa1.Text = "Ca 1";
            this.rbCa1.UseVisualStyleBackColor = true;
            this.rbCa1.CheckedChanged += new System.EventHandler(this.rbCa1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ca Làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ngày Bắt Đầu Làm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // dgvLichlamviec
            // 
            this.dgvLichlamviec.AutoGenerateColumns = false;
            this.dgvLichlamviec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLichlamviec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichlamviec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichlamviec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvLichlamviec.ColumnHeadersHeight = 30;
            this.dgvLichlamviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLichlamviec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.ngayBatDauLamDataGridViewTextBoxColumn,
            this.ngayKetThucDataGridViewTextBoxColumn,
            this.caLamDataGridViewTextBoxColumn});
            this.dgvLichlamviec.DataSource = this.phanCongBindingSource;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichlamviec.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvLichlamviec.EnableHeadersVisualStyles = false;
            this.dgvLichlamviec.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLichlamviec.Location = new System.Drawing.Point(428, 147);
            this.dgvLichlamviec.Name = "dgvLichlamviec";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichlamviec.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvLichlamviec.RowHeadersWidth = 51;
            this.dgvLichlamviec.RowTemplate.Height = 24;
            this.dgvLichlamviec.Size = new System.Drawing.Size(487, 321);
            this.dgvLichlamviec.TabIndex = 110;
            this.dgvLichlamviec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichlamviec_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 109;
            this.label6.Text = "Tìm Kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(399, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 107;
            this.label1.Text = "Lịch Làm Việc";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(549, 108);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(341, 24);
            this.txtTimkiem.TabIndex = 111;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // showroomAudiDataSet27
            // 
            this.showroomAudiDataSet27.DataSetName = "ShowroomAudiDataSet27";
            this.showroomAudiDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phanCongBindingSource
            // 
            this.phanCongBindingSource.DataMember = "PhanCong";
            this.phanCongBindingSource.DataSource = this.showroomAudiDataSet27;
            // 
            // phanCongTableAdapter
            // 
            this.phanCongTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // ngayBatDauLamDataGridViewTextBoxColumn
            // 
            this.ngayBatDauLamDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDauLam";
            this.ngayBatDauLamDataGridViewTextBoxColumn.HeaderText = "NgayBatDauLam";
            this.ngayBatDauLamDataGridViewTextBoxColumn.Name = "ngayBatDauLamDataGridViewTextBoxColumn";
            this.ngayBatDauLamDataGridViewTextBoxColumn.Width = 120;
            // 
            // ngayKetThucDataGridViewTextBoxColumn
            // 
            this.ngayKetThucDataGridViewTextBoxColumn.DataPropertyName = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.HeaderText = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.Name = "ngayKetThucDataGridViewTextBoxColumn";
            this.ngayKetThucDataGridViewTextBoxColumn.Width = 120;
            // 
            // caLamDataGridViewTextBoxColumn
            // 
            this.caLamDataGridViewTextBoxColumn.DataPropertyName = "CaLam";
            this.caLamDataGridViewTextBoxColumn.HeaderText = "CaLam";
            this.caLamDataGridViewTextBoxColumn.Name = "caLamDataGridViewTextBoxColumn";
            // 
            // fLichLamViec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(932, 530);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLichlamviec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLichLamViec";
            this.Text = "LichLamViec";
            this.Load += new System.EventHandler(this.fLichLamViec_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichlamviec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanCongBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.DateTimePicker dtpNgayketthuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgaybatdau;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.RadioButton rbCa2;
        private System.Windows.Forms.RadioButton rbCa1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLichlamviec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private ShowroomAudiDataSet27 showroomAudiDataSet27;
        private System.Windows.Forms.BindingSource phanCongBindingSource;
        private ShowroomAudiDataSet27TableAdapters.PhanCongTableAdapter phanCongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caLamDataGridViewTextBoxColumn;
    }
}