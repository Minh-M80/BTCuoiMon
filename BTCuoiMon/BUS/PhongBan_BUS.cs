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
        //public void deletePB(String maPb)
        //{
        //    String sql = "delete PHONGBAN where maPb='" + maPb + "'";
        //    try
        //    {
        //        dt.ExcuteNonQuery(sql);
        //        MessageBox.Show("Xóa thành công !");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Lỗi CSDL !" + ex.Message);

        //    }
        //}
        public DataTable getNhanVienTheoPB(string maPb)
        {
            string sql = "SELECT maNv FROM NHANVIEN WHERE pbNv='" + maPb + "'";
            return dt.getTable(sql);
        }
        public void deletePB(String maPb)
        {
            // 1. Lấy danh sách nhân viên thuộc phòng ban
            DataTable nvTable = getNhanVienTheoPB(maPb);

            if (nvTable.Rows.Count > 0)
            {
                //  KIỂM TRA ADMIN 
                // Kiểm tra trong bảng DANGNHAP xem có tài khoản admin thuộc các nhân viên này không
                string sqlCheckAdmin =
                    "SELECT * FROM DANGNHAP " +
                    "WHERE username='admin' AND id_Nv IN (SELECT maNv FROM NHANVIEN WHERE pbNv='" + maPb + "')";

                DataTable adminCheck = dt.getTable(sqlCheckAdmin);

                if (adminCheck.Rows.Count > 0)
                {
                    // Nếu có tài khoản admin trong phòng ban → không cho xóa
                    MessageBox.Show("Không thể xóa phòng ban vì có admin chính !");
                    return;
                }
                //  HẾT KIỂM TRA ADMIN 

                // Ghép danh sách nhân viên
                string list = "";
                foreach (DataRow r in nvTable.Rows)
                {
                    list += r["maNv"].ToString() + "\n";
                }

                DialogResult dr = MessageBox.Show(
                    "Phòng ban này có nhân viên:\n" + list +
                    "\nBạn có muốn xóa toàn bộ nhân viên này và phòng ban không?",
                    "Xác nhận",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (dr == DialogResult.OK)
                {
                    // 2. Xóa tài khoản đăng nhập của các nhân viên
                    string sqlDelDN =
                        "DELETE FROM DANGNHAP WHERE id_Nv IN (SELECT maNv FROM NHANVIEN WHERE pbNv='" + maPb + "')";
                    dt.ExcuteNonQuery(sqlDelDN);

                    // 3. Xóa nhân viên
                    string sqlDelNV = "DELETE FROM NHANVIEN WHERE pbNv='" + maPb + "'";
                    dt.ExcuteNonQuery(sqlDelNV);

                    // 4. Xóa phòng ban
                    string sqlDelPB = "DELETE FROM PHONGBAN WHERE maPb='" + maPb + "'";
                    dt.ExcuteNonQuery(sqlDelPB);

                    MessageBox.Show("Đã xóa phòng ban và toàn bộ nhân viên liên quan!");
                }
            }
            else
            {
                // Không có nhân viên trong phòng ban → xóa trực tiếp
                string sqlDelPB = "DELETE FROM PHONGBAN WHERE maPb='" + maPb + "'";
                dt.ExcuteNonQuery(sqlDelPB);
                MessageBox.Show("Xóa phòng ban thành công!");
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
