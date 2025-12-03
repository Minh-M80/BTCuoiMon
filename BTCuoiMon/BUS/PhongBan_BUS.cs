using BTCuoiMon.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCuoiMon.BUS
{
    public class PhongBan_BUS
    {
        ConnectDB dt = new ConnectDB();
        public DataTable getPHONGBAN()
        {
            //Console.WriteLine("Hello");
            DataTable da = null;
            String sql = "Select * from PHONGBAN ";

            da = dt.getTable(sql);
            
            return da;
        }
        public void insertPB(String maPb, String tenPb, int sonvPb, String motaPb)
        {
            String sql = " insert into PHONGBAN values('" + maPb + "',N'" + tenPb + "','" + sonvPb + "',N'" + motaPb + "')";
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
        public void updatePB(String maPb, String tenPb, int sonvPb, String motaPb)
        {
            String sql = "UPDATE PHONGBAN set tenPb=N'" + tenPb + "',sonvPb='" + sonvPb + "',motaPb=N'" + motaPb + "' where maPb='" + maPb + "'";
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
        public void deletePB(String maPb)
        {
            String sql = "delete PHONGBAN where maPb='" + maPb + "'";
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
            String sql = "Select * from PHONGBAN where maPb like N'%" + condi + "%' OR tenPb like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
    }
}
