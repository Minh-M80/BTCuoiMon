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
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Quanlynhanvien frmnv = new Quanlynhanvien();
            frmnv.Show();
            this.Hide();
        }


        private void btnDuan_Click(object sender, EventArgs e)
        {
            Quanlyduan frmda = new Quanlyduan();
            frmda.Show();
            this.Hide();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            Quanlyphongban frmpb = new Quanlyphongban();
            frmpb.LoadData();
            frmpb.Show();
            this.Hide();
        }
    }
}
