namespace QLCHBXH
{
    partial class fPhuTung
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
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPhuTung = new System.Windows.Forms.DataGridView();
            this.maPhuTungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhuTungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhuTungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhuTungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuTungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showroomAudiDataSet1 = new QLCHBXH.ShowroomAudiDataSet1();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLoaiPhuTung = new System.Windows.Forms.ComboBox();
            this.txtGiaPhuTung = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTenPhuTung = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhuTung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.phuTungTableAdapter = new QLCHBXH.ShowroomAudiDataSet1TableAdapters.PhuTungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuTungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet1)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(334, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "CHI TIẾT PHỤ TÙNG";
            // 
            // dgvPhuTung
            // 
            this.dgvPhuTung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPhuTung.AutoGenerateColumns = false;
            this.dgvPhuTung.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvPhuTung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhuTung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhuTung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhuTungDataGridViewTextBoxColumn,
            this.loaiPhuTungDataGridViewTextBoxColumn,
            this.tenPhuTungDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.giaPhuTungDataGridViewTextBoxColumn});
            this.dgvPhuTung.DataSource = this.phuTungBindingSource;
            this.dgvPhuTung.EnableHeadersVisualStyles = false;
            this.dgvPhuTung.GridColor = System.Drawing.Color.DarkGray;
            this.dgvPhuTung.Location = new System.Drawing.Point(416, 46);
            this.dgvPhuTung.Name = "dgvPhuTung";
            this.dgvPhuTung.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            this.dgvPhuTung.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhuTung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPhuTung.ShowEditingIcon = false;
            this.dgvPhuTung.Size = new System.Drawing.Size(532, 396);
            this.dgvPhuTung.TabIndex = 10;
            this.dgvPhuTung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuTung_CellClick);
            // 
            // maPhuTungDataGridViewTextBoxColumn
            // 
            this.maPhuTungDataGridViewTextBoxColumn.DataPropertyName = "MaPhuTung";
            this.maPhuTungDataGridViewTextBoxColumn.HeaderText = "Mã phụ tùng";
            this.maPhuTungDataGridViewTextBoxColumn.Name = "maPhuTungDataGridViewTextBoxColumn";
            // 
            // loaiPhuTungDataGridViewTextBoxColumn
            // 
            this.loaiPhuTungDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhuTung";
            this.loaiPhuTungDataGridViewTextBoxColumn.HeaderText = "Loại phụ tùng";
            this.loaiPhuTungDataGridViewTextBoxColumn.Name = "loaiPhuTungDataGridViewTextBoxColumn";
            // 
            // tenPhuTungDataGridViewTextBoxColumn
            // 
            this.tenPhuTungDataGridViewTextBoxColumn.DataPropertyName = "TenPhuTung";
            this.tenPhuTungDataGridViewTextBoxColumn.HeaderText = "Tên phụ tùng";
            this.tenPhuTungDataGridViewTextBoxColumn.Name = "tenPhuTungDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // giaPhuTungDataGridViewTextBoxColumn
            // 
            this.giaPhuTungDataGridViewTextBoxColumn.DataPropertyName = "GiaPhuTung";
            this.giaPhuTungDataGridViewTextBoxColumn.HeaderText = "Giá phụ tùng";
            this.giaPhuTungDataGridViewTextBoxColumn.Name = "giaPhuTungDataGridViewTextBoxColumn";
            // 
            // phuTungBindingSource
            // 
            this.phuTungBindingSource.DataMember = "PhuTung";
            this.phuTungBindingSource.DataSource = this.showroomAudiDataSet1;
            // 
            // showroomAudiDataSet1
            // 
            this.showroomAudiDataSet1.DataSetName = "ShowroomAudiDataSet1";
            this.showroomAudiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.panel1);
            this.gbThongTin.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbThongTin.Location = new System.Drawing.Point(10, 38);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(367, 251);
            this.gbThongTin.TabIndex = 9;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLoaiPhuTung);
            this.panel1.Controls.Add(this.txtGiaPhuTung);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtTenPhuTung);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaPhuTung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 225);
            this.panel1.TabIndex = 22;
            // 
            // cbLoaiPhuTung
            // 
            this.cbLoaiPhuTung.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhuTung.FormattingEnabled = true;
            this.cbLoaiPhuTung.Items.AddRange(new object[] {
            "Hệ thống làm mát, nhiên liệu",
            "Hệ thống động cơ, hộp số",
            "Hệ thống gầm, phanh",
            "Hệ thống điện, điều hòa"});
            this.cbLoaiPhuTung.Location = new System.Drawing.Point(179, 65);
            this.cbLoaiPhuTung.Name = "cbLoaiPhuTung";
            this.cbLoaiPhuTung.Size = new System.Drawing.Size(121, 25);
            this.cbLoaiPhuTung.TabIndex = 55;
            // 
            // txtGiaPhuTung
            // 
            this.txtGiaPhuTung.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhuTung.Location = new System.Drawing.Point(179, 182);
            this.txtGiaPhuTung.Name = "txtGiaPhuTung";
            this.txtGiaPhuTung.Size = new System.Drawing.Size(121, 23);
            this.txtGiaPhuTung.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(75, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "Giá phụ tùng:";
            // 
            // txtTenPhuTung
            // 
            this.txtTenPhuTung.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhuTung.Location = new System.Drawing.Point(179, 105);
            this.txtTenPhuTung.Name = "txtTenPhuTung";
            this.txtTenPhuTung.Size = new System.Drawing.Size(121, 23);
            this.txtTenPhuTung.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(75, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tên phụ tùng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(179, 144);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 23);
            this.txtSoLuong.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(75, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(75, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Loại phụ tùng:";
            // 
            // txtMaPhuTung
            // 
            this.txtMaPhuTung.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhuTung.Location = new System.Drawing.Point(179, 22);
            this.txtMaPhuTung.Name = "txtMaPhuTung";
            this.txtMaPhuTung.Size = new System.Drawing.Size(121, 23);
            this.txtMaPhuTung.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã phụ tùng:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Silver;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.Location = new System.Drawing.Point(141, 340);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 28);
            this.btnHuy.TabIndex = 35;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.Location = new System.Drawing.Point(83, 306);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 28);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Silver;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.Location = new System.Drawing.Point(24, 340);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 28);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.Location = new System.Drawing.Point(260, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 28);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Silver;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSua.Location = new System.Drawing.Point(200, 306);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 28);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // phuTungTableAdapter
            // 
            this.phuTungTableAdapter.ClearBeforeFill = true;
            // 
            // fPhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvPhuTung);
            this.Controls.Add(this.gbThongTin);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPhuTung";
            this.Text = "CarSparts";
            this.Load += new System.EventHandler(this.CarSparts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuTungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet1)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPhuTung;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGiaPhuTung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTenPhuTung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhuTung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private ShowroomAudiDataSet1 showroomAudiDataSet1;
        private System.Windows.Forms.BindingSource phuTungBindingSource;
        private ShowroomAudiDataSet1TableAdapters.PhuTungTableAdapter phuTungTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhuTungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhuTungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhuTungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhuTungDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbLoaiPhuTung;
    }
}