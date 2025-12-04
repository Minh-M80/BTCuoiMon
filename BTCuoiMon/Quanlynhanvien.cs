using BTCuoiMon.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace BTCuoiMon
{
    public partial class Quanlynhanvien : Form
    {
        public Quanlynhanvien()
        {
            InitializeComponent();
        }
        NhanVien_BUS nvb = new NhanVien_BUS();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'btlonDataSet1.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.btlonDataSet1.PHONGBAN);
            // TODO: This line of code loads data into the 'btlonDataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.btlonDataSet.DUAN);
            dgvNhanVien.DataSource = nvb.getNhanvien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int luongnv = 0;
            try
            {
                luongnv = int.Parse(txtLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (txtMaNv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNv.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (luongnv == 0)
                MessageBox.Show("Thêm thất bại !");
            else
                nvb.insertNV(txtMaNv.Text, txtTenNv.Text, dtpNgaysinh.Value.ToString("yyyy-MM-dd"), txtDiachi.Text, luongnv, cbxPhongban.SelectedValue.ToString(), cbxDuan.SelectedValue.ToString());
            Quanlynhanvien_Load(sender, e);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtLuong.Text = "";
            txtMaNv.Text = "";
            txtSearch.Text = "";
            txtTenNv.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int luongnv = 0;
            try
            {
                luongnv = int.Parse(txtLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (txtMaNv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNv.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (luongnv == 0)
                MessageBox.Show("Sửa thất bại !");
            else
                nvb.updateNV(txtMaNv.Text, txtTenNv.Text, dtpNgaysinh.Value.ToString("dd/MM/yyyy"), txtDiachi.Text, luongnv, cbxPhongban.SelectedValue.ToString(), cbxDuan.SelectedValue.ToString());
            Quanlynhanvien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nvb.deleteNV(txtMaNv.Text);
            Quanlynhanvien_Load(sender, e);
        }
        private void ExportExcel(DataGridView dgv, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            // Lấy cái Header DataGridView
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            //
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvNhanVien, @"D:\", "xuatfileExcel");
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                // Gán các giá trị string an toàn hơn
                txtMaNv.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
                txtTenNv.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
                txtDiachi.Text = dgvNhanVien.Rows[index].Cells[3].Value.ToString();

                // --- Xử lý ngày sinh an toàn ---
                object ngaysinhValue = dgvNhanVien.Rows[index].Cells[4].Value;

                if (ngaysinhValue != null && ngaysinhValue != DBNull.Value)
                {
                    // Nếu giá trị KHÔNG phải NULL, thì gán nó vào DateTimePicker
                    dtpNgaysinh.Text = ngaysinhValue.ToString(); // Dòng này có thể không cần thiết nếu dòng dưới hoạt động
                    dtpNgaysinh.Value = (DateTime)ngaysinhValue;
                }
                else
                {
                    // Nếu giá trị LÀ NULL, đặt ngày tháng thành giá trị mặc định (ví dụ: ngày hôm nay)
                    dtpNgaysinh.Value = DateTime.Today;
                    // Hoặc bạn có thể thêm logic để xử lý trường hợp ngày sinh null trong UI của bạn
                }

                // --- Xử lý ComboBox an toàn ---
                object maDA = dgvNhanVien.Rows[index].Cells[5].Value;
                if (maDA != null && maDA != DBNull.Value)
                {
                    cbxDuan.SelectedValue = maDA;
                }
                else
                {
                    cbxDuan.SelectedIndex = -1; // Chọn không có gì
                }

                object maPB = dgvNhanVien.Rows[index].Cells[6].Value;
                if (maPB != null && maPB != DBNull.Value)
                {
                    cbxPhongban.SelectedValue = maPB;
                }
                else
                {
                    cbxPhongban.SelectedIndex = -1; // Chọn không có gì
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }
    }
}
