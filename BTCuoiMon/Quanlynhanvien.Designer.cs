namespace BTCuoiMon
{
    partial class Quanlynhanvien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblMaDa = new System.Windows.Forms.Label();
            this.lblMaPb = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTieude = new System.Windows.Forms.Label();
            this.btlonDataSet = new BTCuoiMon.btlonDataSet();
            this.btlonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUANTableAdapter = new BTCuoiMon.btlonDataSetTableAdapters.DUANTableAdapter();
            this.tableAdapterManager = new BTCuoiMon.btlonDataSetTableAdapters.TableAdapterManager();
            this.cbxDuan = new System.Windows.Forms.ComboBox();
            this.dUANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btlonDataSet1 = new BTCuoiMon.btlonDataSet1();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGBANTableAdapter = new BTCuoiMon.btlonDataSet1TableAdapters.PHONGBANTableAdapter();
            this.tableAdapterManager1 = new BTCuoiMon.btlonDataSet1TableAdapters.TableAdapterManager();
            this.cbxPhongban = new System.Windows.Forms.ComboBox();
            this.pHONGBANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btlonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btlonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btlonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.75F));
            this.tableLayoutPanel1.Controls.Add(this.dgvNhanVien, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-6, 234);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.48624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51376F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tenNv,
            this.luongNv,
            this.diachiNv,
            this.ngaysinhNv,
            this.daNv,
            this.pbNv});
            this.dgvNhanVien.Location = new System.Drawing.Point(109, 3);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(688, 176);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maNv";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // tenNv
            // 
            this.tenNv.DataPropertyName = "tenNv";
            this.tenNv.HeaderText = "Tên NV";
            this.tenNv.MinimumWidth = 6;
            this.tenNv.Name = "tenNv";
            this.tenNv.Width = 125;
            // 
            // luongNv
            // 
            this.luongNv.DataPropertyName = "luongNv";
            this.luongNv.HeaderText = "Lương NV";
            this.luongNv.MinimumWidth = 6;
            this.luongNv.Name = "luongNv";
            this.luongNv.Width = 125;
            // 
            // diachiNv
            // 
            this.diachiNv.DataPropertyName = "diachiNv";
            this.diachiNv.HeaderText = "Địa chỉ";
            this.diachiNv.MinimumWidth = 6;
            this.diachiNv.Name = "diachiNv";
            this.diachiNv.Width = 125;
            // 
            // ngaysinhNv
            // 
            this.ngaysinhNv.DataPropertyName = "ngaysinhNv";
            this.ngaysinhNv.HeaderText = "Ngày sinh";
            this.ngaysinhNv.MinimumWidth = 6;
            this.ngaysinhNv.Name = "ngaysinhNv";
            this.ngaysinhNv.Width = 125;
            // 
            // daNv
            // 
            this.daNv.DataPropertyName = "daNv";
            this.daNv.HeaderText = "Dự án";
            this.daNv.MinimumWidth = 6;
            this.daNv.Name = "daNv";
            this.daNv.Width = 125;
            // 
            // pbNv
            // 
            this.pbNv.DataPropertyName = "pbNv";
            this.pbNv.HeaderText = "Phòng ban";
            this.pbNv.MinimumWidth = 6;
            this.pbNv.Name = "pbNv";
            this.pbNv.Width = 125;
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Location = new System.Drawing.Point(169, 39);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(51, 16);
            this.lblMaNv.TabIndex = 0;
            this.lblMaNv.Text = "Mã NV:";
            this.lblMaNv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Location = new System.Drawing.Point(169, 68);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(67, 16);
            this.lblTenNv.TabIndex = 1;
            this.lblTenNv.Text = "Họ và tên:";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(169, 96);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaysinh.TabIndex = 2;
            this.lblNgaysinh.Text = "Ngày sinh:";
            this.lblNgaysinh.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(254, 39);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(221, 22);
            this.txtMaNv.TabIndex = 3;
            // 
            // txtTenNv
            // 
            this.txtTenNv.Location = new System.Drawing.Point(254, 68);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(221, 22);
            this.txtTenNv.TabIndex = 4;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(584, 39);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(174, 22);
            this.txtDiachi.TabIndex = 9;
            // 
            // lblMaDa
            // 
            this.lblMaDa.AutoSize = true;
            this.lblMaDa.Location = new System.Drawing.Point(481, 124);
            this.lblMaDa.Name = "lblMaDa";
            this.lblMaDa.Size = new System.Drawing.Size(65, 16);
            this.lblMaDa.TabIndex = 8;
            this.lblMaDa.Text = "Mã dự án:";
            // 
            // lblMaPb
            // 
            this.lblMaPb.AutoSize = true;
            this.lblMaPb.Location = new System.Drawing.Point(481, 96);
            this.lblMaPb.Name = "lblMaPb";
            this.lblMaPb.Size = new System.Drawing.Size(96, 16);
            this.lblMaPb.TabIndex = 7;
            this.lblMaPb.Text = "Mã phòng ban:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(481, 39);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(50, 16);
            this.lblDiachi.TabIndex = 6;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(254, 96);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(221, 22);
            this.dtpNgaysinh.TabIndex = 12;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(172, 124);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(254, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(584, 68);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(174, 22);
            this.txtLuong.TabIndex = 18;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(481, 68);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(47, 16);
            this.lblLuong.TabIndex = 17;
            this.lblLuong.Text = "Lương:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(416, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(254, 176);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(335, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(497, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(578, 176);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportExcel.TabIndex = 21;
            this.btnExportExcel.Text = "Xuất";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 233);
            this.panel1.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(6, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTieude.Location = new System.Drawing.Point(340, 4);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(219, 29);
            this.lblTieude.TabIndex = 24;
            this.lblTieude.Text = "Quản lý nhân viên";
            // 
            // btlonDataSet
            // 
            this.btlonDataSet.DataSetName = "btlonDataSet";
            this.btlonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btlonDataSetBindingSource
            // 
            this.btlonDataSetBindingSource.DataSource = this.btlonDataSet;
            this.btlonDataSetBindingSource.Position = 0;
            // 
            // dUANBindingSource
            // 
            this.dUANBindingSource.DataMember = "DUAN";
            this.dUANBindingSource.DataSource = this.btlonDataSet;
            // 
            // dUANTableAdapter
            // 
            this.dUANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DUANTableAdapter = this.dUANTableAdapter;
            this.tableAdapterManager.UpdateOrder = BTCuoiMon.btlonDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbxDuan
            // 
            this.cbxDuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dUANBindingSource, "maDa", true));
            this.cbxDuan.DataSource = this.dUANBindingSource1;
            this.cbxDuan.DisplayMember = "maDa";
            this.cbxDuan.FormattingEnabled = true;
            this.cbxDuan.Location = new System.Drawing.Point(584, 126);
            this.cbxDuan.Name = "cbxDuan";
            this.cbxDuan.Size = new System.Drawing.Size(174, 24);
            this.cbxDuan.TabIndex = 25;
            this.cbxDuan.ValueMember = "maDa";
            // 
            // dUANBindingSource1
            // 
            this.dUANBindingSource1.DataMember = "DUAN";
            this.dUANBindingSource1.DataSource = this.btlonDataSetBindingSource;
            // 
            // btlonDataSet1
            // 
            this.btlonDataSet1.DataSetName = "btlonDataSet1";
            this.btlonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.btlonDataSet1;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PHONGBANTableAdapter = this.pHONGBANTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BTCuoiMon.btlonDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbxPhongban
            // 
            this.cbxPhongban.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pHONGBANBindingSource, "maPb", true));
            this.cbxPhongban.DataSource = this.pHONGBANBindingSource1;
            this.cbxPhongban.DisplayMember = "maPb";
            this.cbxPhongban.FormattingEnabled = true;
            this.cbxPhongban.Location = new System.Drawing.Point(584, 96);
            this.cbxPhongban.Name = "cbxPhongban";
            this.cbxPhongban.Size = new System.Drawing.Size(174, 24);
            this.cbxPhongban.TabIndex = 26;
            this.cbxPhongban.ValueMember = "maPb";
            // 
            // pHONGBANBindingSource1
            // 
            this.pHONGBANBindingSource1.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource1.DataSource = this.btlonDataSet1;
            // 
            // Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 472);
            this.Controls.Add(this.cbxPhongban);
            this.Controls.Add(this.cbxDuan);
            this.Controls.Add(this.lblTieude);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lblMaDa);
            this.Controls.Add(this.lblMaPb);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.txtTenNv);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblTenNv);
            this.Controls.Add(this.lblMaNv);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Quanlynhanvien";
            this.Text = "Quanlynhanvien";
            this.Load += new System.EventHandler(this.Quanlynhanvien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btlonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btlonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btlonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblMaDa;
        private System.Windows.Forms.Label lblMaPb;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn daNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbNv;
        private btlonDataSet btlonDataSet;
        private System.Windows.Forms.BindingSource btlonDataSetBindingSource;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private btlonDataSetTableAdapters.DUANTableAdapter dUANTableAdapter;
        private btlonDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxDuan;
        private System.Windows.Forms.BindingSource dUANBindingSource1;
        private btlonDataSet1 btlonDataSet1;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private btlonDataSet1TableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private btlonDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cbxPhongban;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource1;
    }
}