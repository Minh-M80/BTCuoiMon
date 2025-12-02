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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblMaDa = new System.Windows.Forms.Label();
            this.lblMaPb = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbxPhongban = new System.Windows.Forms.ComboBox();
            this.cbxDuan = new System.Windows.Forms.ComboBox();
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.lblTieude = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 3;
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
            // cbxPhongban
            // 
            this.cbxPhongban.FormattingEnabled = true;
            this.cbxPhongban.Location = new System.Drawing.Point(584, 96);
            this.cbxPhongban.Name = "cbxPhongban";
            this.cbxPhongban.Size = new System.Drawing.Size(174, 24);
            this.cbxPhongban.TabIndex = 13;
            // 
            // cbxDuan
            // 
            this.cbxDuan.FormattingEnabled = true;
            this.cbxDuan.Location = new System.Drawing.Point(584, 126);
            this.cbxDuan.Name = "cbxDuan";
            this.cbxDuan.Size = new System.Drawing.Size(174, 24);
            this.cbxDuan.TabIndex = 14;
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
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(254, 176);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(335, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(497, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(578, 176);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExportExcel.TabIndex = 21;
            this.btnExportExcel.Text = "Xuất";
            this.btnExportExcel.UseVisualStyleBackColor = true;
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
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(109, 3);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(688, 176);
            this.dgvNhanVien.TabIndex = 0;
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
            // Quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.cbxDuan);
            this.Controls.Add(this.cbxPhongban);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lblMaDa);
            this.Controls.Add(this.lblMaPb);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.txtTenNv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblTenNv);
            this.Controls.Add(this.lblMaNv);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Quanlynhanvien";
            this.Text = "Quanlynhanvien";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblMaDa;
        private System.Windows.Forms.Label lblMaPb;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.ComboBox cbxPhongban;
        private System.Windows.Forms.ComboBox cbxDuan;
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
    }
}