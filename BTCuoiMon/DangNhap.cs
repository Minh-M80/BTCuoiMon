using BTCuoiMon.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCuoiMon
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void frmdangky_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangKy frmdk = new DangKy();
            frmdk.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
            frmdk.Show();
            this.Hide();
        }
        private void frmmhc_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        User_BUS ub = new User_BUS();

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            String condition;
            condition = " username ='" + txtUsername.Text + "' AND password ='" + txtPassword.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = ub.getUser(txtUsername.Text,txtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    ManHinhChinh frmmhc = new ManHinhChinh();
                    frmmhc.FormClosed += new FormClosedEventHandler(frmmhc_Closed);
                    frmmhc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công , mời bạn đăng ký !");
                    DangKy frmdk = new DangKy();
                    frmdk.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
                    frmdk.Show();
                    this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL !");
            }
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void DangNhap_Load(object sender, EventArgs e)
        //{

        //}
    }
}
