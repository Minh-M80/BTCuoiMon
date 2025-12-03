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

namespace BTCuoiMon
{
    public partial class Quanlyphongban : Form
    {
        public Quanlyphongban()
        {
            InitializeComponent();
        }
        PhongBan_BUS pbb = new PhongBan_BUS();
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pbb.deletePB(txtMaPB.Text);
            Quanlyphongban_Load(sender, e);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã phòng ban không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên phòng ban không được để trống !");
            else
            {
                try
                {
                    pbb.updatePB(txtMaPB.Text, txtTenPB.Text, int.Parse(txtSoNV.Text), txtMota.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Số nhân viên phải là kiểu số nguyên !" + ex.Message);
                }
            }
            Quanlyphongban_Load(sender, e);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int sonv = 0;

            // Chuyển string sang int, nếu nhập không hợp lệ sẽ để 0 hoặc báo lỗi
            if (!int.TryParse(txtSoNV.Text.Trim(), out sonv))
            {
                MessageBox.Show("Số nhân viên phải là số nguyên!");
                return; // dừng không insert
            }

            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã phòng ban không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên phòng ban không được để trống !");
            else
            {
                pbb.insertPB(txtMaPB.Text, txtTenPB.Text, sonv, txtMota.Text);
                Quanlyphongban_Load(sender, e);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void dgvPhongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPhongban.DataSource = pbb.Search(txtSearch.Text);
        }
      

        private void dgvPhongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPB.Text = dgvPhongban.Rows[index].Cells[0].Value.ToString();
                txtTenPB.Text = dgvPhongban.Rows[index].Cells[1].Value.ToString();
                txtSoNV.Text = dgvPhongban.Rows[index].Cells[2].Value.ToString();
                txtMota.Text = dgvPhongban.Rows[index].Cells[3].Value.ToString();
            }
        }
        public void LoadData()
        {
            dgvPhongban.DataSource = pbb.getPHONGBAN();
        }

        private void Quanlyphongban_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Quanlyphongban_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
