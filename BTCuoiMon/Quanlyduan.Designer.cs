namespace BTCuoiMon
{
    partial class Quanlyduan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoNVDA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotaDA = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dự án:";
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(225, 96);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(191, 22);
            this.txtMaDA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên dự án:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(225, 133);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(191, 22);
            this.txtTenDA.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số NV: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSoNVDA
            // 
            this.txtSoNVDA.Location = new System.Drawing.Point(519, 96);
            this.txtSoNVDA.Name = "txtSoNVDA";
            this.txtSoNVDA.Size = new System.Drawing.Size(191, 22);
            this.txtSoNVDA.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mô tả:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMotaDA
            // 
            this.txtMotaDA.Location = new System.Drawing.Point(519, 133);
            this.txtMotaDA.Name = "txtMotaDA";
            this.txtMotaDA.Size = new System.Drawing.Size(191, 22);
            this.txtMotaDA.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(143, 206);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(225, 207);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 22);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(445, 207);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(540, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(635, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.7061F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.2939F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDuAn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 248);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.09453F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.90547F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 201);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mada,
            this.tenda,
            this.sonv,
            this.motada});
            this.dgvDuAn.Location = new System.Drawing.Point(96, 3);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.RowHeadersWidth = 51;
            this.dgvDuAn.RowTemplate.Height = 24;
            this.dgvDuAn.Size = new System.Drawing.Size(703, 150);
            this.dgvDuAn.TabIndex = 0;
            this.dgvDuAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 248);
            this.panel1.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(372, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quản lý dự án";
            // 
            // mada
            // 
            this.mada.DataPropertyName = "maDa";
            this.mada.HeaderText = "Mã DA";
            this.mada.MinimumWidth = 6;
            this.mada.Name = "mada";
            this.mada.Width = 50;
            // 
            // tenda
            // 
            this.tenda.DataPropertyName = "tenDa";
            this.tenda.HeaderText = "Tên DA";
            this.tenda.MinimumWidth = 6;
            this.tenda.Name = "tenda";
            this.tenda.Width = 200;
            // 
            // sonv
            // 
            this.sonv.DataPropertyName = "sonvDa";
            this.sonv.HeaderText = "Số nhân viên";
            this.sonv.MinimumWidth = 6;
            this.sonv.Name = "sonv";
            this.sonv.Width = 125;
            // 
            // motada
            // 
            this.motada.DataPropertyName = "motaDa";
            this.motada.HeaderText = "Mô tả";
            this.motada.MinimumWidth = 6;
            this.motada.Name = "motada";
            this.motada.Width = 300;
            // 
            // Quanlyduan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMotaDA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoNVDA);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.label1);
            this.Name = "Quanlyduan";
            this.Text = "Quanlyduan";
            this.Load += new System.EventHandler(this.Quanlyduan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoNVDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMotaDA;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn mada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonv;
        private System.Windows.Forms.DataGridViewTextBoxColumn motada;
    }
}