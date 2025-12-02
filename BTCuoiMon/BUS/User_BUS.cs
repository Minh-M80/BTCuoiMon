using BTCuoiMon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTCuoiMon.DB;

namespace BTCuoiMon.BUS
{
    class User_BUS
    {
        User_DTO U = new User_DTO();
        ConnectDB da = new ConnectDB();
        public DataTable getUser(String condition)
        {
            DataTable dt = null;
            String sql = "Select * from DANGNHAP where " + condition;
            dt = da.getTable(sql);
            return dt;
        }
        public void insertUser(String username, String pass, String manv)
        {
            String sql = "insert into DANGNHAP values('" + username + "','" + pass + "','" + manv + "')";
            da.ExcuteNonQuery(sql);
        }
    }
}
