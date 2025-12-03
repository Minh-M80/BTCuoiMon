using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTCuoiMon.DB;

namespace BTCuoiMon.BUS
{
    class DuAn_BUS
    {
        ConnectDB dt = new ConnectDB();
        public DataTable getDUAN()
        {
            DataTable da = null;
            String sql = "Select * from DUAN ";
            da = dt.getTable(sql);
            return da;
        }
        public void insertDA(String maDA, String tenDA, int sonvDa, String motaDa)
        {
            String sql = " insert into DUAN values('" + maDA + "',N'" + tenDA + "','" + sonvDa + "',N'" + motaDa + "')";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void updateDA(String maDA, String tenDA, int sonvDa, String motaDa)
        {
            String sql = "UPDATE DUAN set tenDa=N'" + tenDA + "',sonvDa='" + sonvDa + "',motaDa=N'" + motaDa + "' where maDa='" + maDA + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteDA(String maDA)
        {
            String sql = "delete DUAN where maDa='" + maDA + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL !" + ex.Message);

            }
        }
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from DUAN where maDA like N'%" + condi + "%' OR tenDA like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
    }
}
