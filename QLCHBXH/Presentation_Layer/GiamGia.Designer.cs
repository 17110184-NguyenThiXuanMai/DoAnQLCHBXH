namespace QLCHBXH.Presentation_Layer
{
    partial class fGiamGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiamGia));
            this.dgvGiamGia = new System.Windows.Forms.DataGridView();
            this.maGiamGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTramGiamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showroomAudiDataSet24 = new QLCHBXH.ShowroomAudiDataSet24();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhanTramGiam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giamGiaTableAdapter = new QLCHBXH.ShowroomAudiDataSet24TableAdapters.GiamGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet24)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiamGia
            // 
            this.dgvGiamGia.AutoGenerateColumns = false;
            this.dgvGiamGia.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiamGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiamGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiamGia.ColumnHeadersHeight = 30;
            this.dgvGiamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiamGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGiamGiaDataGridViewTextBoxColumn,
            this.phanTramGiamDataGridViewTextBoxColumn,
            this.ngayBatDauDataGridViewTextBoxColumn,
            this.ngayKetThucDataGridViewTextBoxColumn});
            this.dgvGiamGia.DataSource = this.giamGiaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiamGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiamGia.EnableHeadersVisualStyles = false;
            this.dgvGiamGia.Location = new System.Drawing.Point(26, 320);
            this.dgvGiamGia.Name = "dgvGiamGia";
            this.dgvGiamGia.RowHeadersVisible = false;
            this.dgvGiamGia.RowHeadersWidth = 51;
            this.dgvGiamGia.RowTemplate.Height = 24;
            this.dgvGiamGia.Size = new System.Drawing.Size(899, 241);
            this.dgvGiamGia.TabIndex = 12;
            this.dgvGiamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiamGia_CellClick);
            // 
            // maGiamGiaDataGridViewTextBoxColumn
            // 
            this.maGiamGiaDataGridViewTextBoxColumn.DataPropertyName = "MaGiamGia";
            this.maGiamGiaDataGridViewTextBoxColumn.HeaderText = "MaGiamGia";
            this.maGiamGiaDataGridViewTextBoxColumn.Name = "maGiamGiaDataGridViewTextBoxColumn";
            this.maGiamGiaDataGridViewTextBoxColumn.Width = 225;
            // 
            // phanTramGiamDataGridViewTextBoxColumn
            // 
            this.phanTramGiamDataGridViewTextBoxColumn.DataPropertyName = "PhanTramGiam";
            this.phanTramGiamDataGridViewTextBoxColumn.HeaderText = "PhanTramGiam";
            this.phanTramGiamDataGridViewTextBoxColumn.Name = "phanTramGiamDataGridViewTextBoxColumn";
            this.phanTramGiamDataGridViewTextBoxColumn.Width = 225;
            // 
            // ngayBatDauDataGridViewTextBoxColumn
            // 
            this.ngayBatDauDataGridViewTextBoxColumn.DataPropertyName = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.HeaderText = "NgayBatDau";
            this.ngayBatDauDataGridViewTextBoxColumn.Name = "ngayBatDauDataGridViewTextBoxColumn";
            this.ngayBatDauDataGridViewTextBoxColumn.Width = 225;
            // 
            // ngayKetThucDataGridViewTextBoxColumn
            // 
            this.ngayKetThucDataGridViewTextBoxColumn.DataPropertyName = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.HeaderText = "NgayKetThuc";
            this.ngayKetThucDataGridViewTextBoxColumn.Name = "ngayKetThucDataGridViewTextBoxColumn";
            this.ngayKetThucDataGridViewTextBoxColumn.Width = 225;
            // 
            // giamGiaBindingSource
            // 
            this.giamGiaBindingSource.DataMember = "GiamGia";
            this.giamGiaBindingSource.DataSource = this.showroomAudiDataSet24;
            // 
            // showroomAudiDataSet24
            // 
            this.showroomAudiDataSet24.DataSetName = "ShowroomAudiDataSet24";
            this.showroomAudiDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReload.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.DimGray;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(211, 189);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(164, 42);
            this.btnReload.TabIndex = 106;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 273);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHuy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.DimGray;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(20, 189);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(164, 42);
            this.btnHuy.TabIndex = 105;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.DimGray;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(211, 114);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(164, 42);
            this.btnLuu.TabIndex = 104;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.DimGray;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(20, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(164, 42);
            this.btnXoa.TabIndex = 103;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.DimGray;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(211, 37);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(164, 42);
            this.btnSua.TabIndex = 102;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.DimGray;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(20, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(164, 42);
            this.btnThem.TabIndex = 101;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(232, 217);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(171, 24);
            this.dtpNgayKetThuc.TabIndex = 8;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(232, 151);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(171, 24);
            this.dtpNgayBatDau.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Controls.Add(this.txtPhanTramGiam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaGiamGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(463, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 273);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtPhanTramGiam
            // 
            this.txtPhanTramGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTramGiam.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhanTramGiam.Location = new System.Drawing.Point(232, 101);
            this.txtPhanTramGiam.Name = "txtPhanTramGiam";
            this.txtPhanTramGiam.Size = new System.Drawing.Size(171, 24);
            this.txtPhanTramGiam.TabIndex = 6;
            this.txtPhanTramGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanTramGiam_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(58, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã giảm giá";
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGiamGia.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaGiamGia.Location = new System.Drawing.Point(232, 39);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(171, 24);
            this.txtMaGiamGia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(58, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phần trăm giảm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(58, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(58, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Giảm Giá";
            // 
            // giamGiaTableAdapter
            // 
            this.giamGiaTableAdapter.ClearBeforeFill = true;
            // 
            // fGiamGia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(950, 567);
            this.Controls.Add(this.dgvGiamGia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fGiamGia";
            this.Text = "GiamGia";
            this.Load += new System.EventHandler(this.fGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet24)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGiamGia;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhanTramGiam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private ShowroomAudiDataSet24 showroomAudiDataSet24;
        private System.Windows.Forms.BindingSource giamGiaBindingSource;
        private ShowroomAudiDataSet24TableAdapters.GiamGiaTableAdapter giamGiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanTramGiamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThucDataGridViewTextBoxColumn;
    }
}