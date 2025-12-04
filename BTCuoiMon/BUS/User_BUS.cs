using BTCuoiMon.DB;
using BTCuoiMon.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiMon.BUS
{
    class User_BUS
    {
        User_DTO U = new User_DTO();
        ConnectDB da = new ConnectDB();
        public DataTable getUser(string username, string password)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM DANGNHAP WHERE username=@username AND passwor=@password"; // chú ý passwor

            using (SqlConnection conn = da.getConnect()) // dùng hàm getConnect() sẵn có
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataAdapter daAdapter = new SqlDataAdapter(cmd);
                    daAdapter.Fill(dt);
                }
            }

            return dt;
        }
        public void insertUser(String username, String pass, String manv)
        {
            String sql = "insert into DANGNHAP values('" + username + "','" + pass + "','" + manv + "')";
            da.ExcuteNonQuery(sql);
        }

    }
}
