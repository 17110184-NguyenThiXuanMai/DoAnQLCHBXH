namespace QLCHBXH.Presentation_Layer
{
    partial class fDanhSachNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.ptbHinhanh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTimkiemnv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.showroomAudiDataSet23 = new QLCHBXH.ShowroomAudiDataSet23();
            this.nhanSuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanSuTableAdapter = new QLCHBXH.ShowroomAudiDataSet23TableAdapters.NhanSuTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemnv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên"});
            this.cbTimkiem.Location = new System.Drawing.Point(175, 90);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(257, 24);
            this.cbTimkiem.TabIndex = 39;
            // 
            // ptbHinhanh
            // 
            this.ptbHinhanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbHinhanh.Location = new System.Drawing.Point(746, 15);
            this.ptbHinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.ptbHinhanh.Name = "ptbHinhanh";
            this.ptbHinhanh.Size = new System.Drawing.Size(186, 176);
            this.ptbHinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHinhanh.TabIndex = 38;
            this.ptbHinhanh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(34, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(464, 92);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(257, 24);
            this.txtTimkiem.TabIndex = 40;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "HinhAnh";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = false;
            this.HinhAnh.Width = 125;
            // 
            // dgvTimkiemnv
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTimkiemnv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTimkiemnv.AutoGenerateColumns = false;
            this.dgvTimkiemnv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTimkiemnv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTimkiemnv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimkiemnv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTimkiemnv.ColumnHeadersHeight = 30;
            this.dgvTimkiemnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTimkiemnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HinhAnh,
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn});
            this.dgvTimkiemnv.DataSource = this.nhanSuBindingSource;
            this.dgvTimkiemnv.EnableHeadersVisualStyles = false;
            this.dgvTimkiemnv.Location = new System.Drawing.Point(19, 210);
            this.dgvTimkiemnv.Name = "dgvTimkiemnv";
            this.dgvTimkiemnv.RowHeadersWidth = 51;
            this.dgvTimkiemnv.RowTemplate.Height = 24;
            this.dgvTimkiemnv.Size = new System.Drawing.Size(913, 342);
            this.dgvTimkiemnv.TabIndex = 37;
            this.dgvTimkiemnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimkiemnv_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(308, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Danh Sách Nhân Viên";
            // 
            // showroomAudiDataSet23
            // 
            this.showroomAudiDataSet23.DataSetName = "ShowroomAudiDataSet23";
            this.showroomAudiDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanSuBindingSource
            // 
            this.nhanSuBindingSource.DataMember = "NhanSu";
            this.nhanSuBindingSource.DataSource = this.showroomAudiDataSet23;
            // 
            // nhanSuTableAdapter
            // 
            this.nhanSuTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // hinhAnhDataGridViewTextBoxColumn
            // 
            this.hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Luong";
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            // 
            // fDanhSachNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(950, 567);
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.ptbHinhanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.dgvTimkiemnv);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Century", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDanhSachNhanVien";
            this.Text = "DanhSachNhanVien";
            this.Load += new System.EventHandler(this.fDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemnv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showroomAudiDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanSuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.PictureBox ptbHinhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridView dgvTimkiemnv;
        private System.Windows.Forms.Label label5;
        private ShowroomAudiDataSet23 showroomAudiDataSet23;
        private System.Windows.Forms.BindingSource nhanSuBindingSource;
        private ShowroomAudiDataSet23TableAdapters.NhanSuTableAdapter nhanSuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
    }
}