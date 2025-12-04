using BTCuoiMon.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace BTCuoiMon.BUS
{
    class NhanVien_BUS
    {
        ConnectDB dt = new ConnectDB();
        public DataTable getNhanvien()
        {
            DataTable da = null;
            String sql = "Select * from NhanVien ";
            da = dt.getTable(sql);
            return da;
        }
        //public void insertNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String mapb, String mada)
        //{
        //    String sql = " insert into NHANVIEN values('" + manv + "',N'" + tennv + "','" + luong + "',N'" + diachi + "','" + ngaysinh + "','" + mada + "','" + mapb + "')";
        //    try
        //    {
        //        dt.ExcuteNonQuery(sql);
        //        MessageBox.Show("Thêm thành công !");
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Thêm thất bại !");
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void insertNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String mapb, String mada)
        {
            // ================================================
            // 1. KIỂM TRA PHÒNG BAN CÓ FULL NHÂN VIÊN CHƯA?
            // ================================================
            // Lấy số lượng tối đa
            String sqlMaxPB = "SELECT sonvPb FROM PHONGBAN WHERE maPb = '" + mapb + "'";
            DataTable dtMaxPB = dt.getTable(sqlMaxPB);

            if (dtMaxPB.Rows.Count == 0)
            {
                MessageBox.Show("Phòng ban không tồn tại!");
                return;
            }

            int maxPB = int.Parse(dtMaxPB.Rows[0][0].ToString());

            // Đếm số nhân viên hiện tại
            String sqlCountPB = "SELECT COUNT(*) FROM NHANVIEN WHERE pbNv = '" + mapb + "'";
            DataTable dtCountPB = dt.getTable(sqlCountPB);
            int currentPB = int.Parse(dtCountPB.Rows[0][0].ToString());

            if (currentPB >= maxPB)
            {
                MessageBox.Show("Phòng ban này đã đủ nhân viên (FULL)!");
                return;
            }
            // ================================================
            // 2. KIỂM TRA DỰ ÁN CÓ FULL NHÂN VIÊN CHƯA?
            // ================================================
            String sqlMaxDA = "SELECT sonvDa FROM DUAN WHERE maDa = '" + mada + "'";
            DataTable dtMaxDA = dt.getTable(sqlMaxDA);

            if (dtMaxDA.Rows.Count == 0)
            {
                MessageBox.Show("Dự án không tồn tại!");
                return;
            }

            int maxDA = int.Parse(dtMaxDA.Rows[0][0].ToString());

            String sqlCountDA = "SELECT COUNT(*) FROM NHANVIEN WHERE daNv = '" + mada + "'";
            DataTable dtCountDA = dt.getTable(sqlCountDA);
            int currentDA = int.Parse(dtCountDA.Rows[0][0].ToString());

            if (currentDA >= maxDA)
            {
                MessageBox.Show("Dự án này đã đủ nhân viên (FULL)!");
                return;
            }

            // ================================================
            // 3. THÊM NHÂN VIÊN
            // ================================================
            String sql = "insert into NHANVIEN values('" + manv + "',N'" + tennv + "','" + luong + "',N'" + diachi + "','" + ngaysinh + "','" + mada + "','" + mapb + "')";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại!");
                MessageBox.Show(ex.Message);
            }
        }

        public void updateNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String mapb, String mada)
        {
            String sqlMaxPB = "SELECT sonvPb FROM PHONGBAN WHERE maPb = '" + mapb + "'";
            DataTable dtMaxPB = dt.getTable(sqlMaxPB);

            if (dtMaxPB.Rows.Count == 0)
            {
                MessageBox.Show("Phòng ban không tồn tại!");
                return;
            }

            int maxPB = int.Parse(dtMaxPB.Rows[0][0].ToString());

            // Đếm số nhân viên hiện tại
            String sqlCountPB = "SELECT COUNT(*) FROM NHANVIEN WHERE pbNv = '" + mapb + "'";
            DataTable dtCountPB = dt.getTable(sqlCountPB);
            int currentPB = int.Parse(dtCountPB.Rows[0][0].ToString());

            if (currentPB >= maxPB)
            {
                MessageBox.Show("Phòng ban này đã đủ nhân viên (FULL)!");
                return;
            }
            // ================================================
            // 2. KIỂM TRA DỰ ÁN CÓ FULL NHÂN VIÊN CHƯA?
            // ================================================
            String sqlMaxDA = "SELECT sonvDa FROM DUAN WHERE maDa = '" + mada + "'";
            DataTable dtMaxDA = dt.getTable(sqlMaxDA);

            if (dtMaxDA.Rows.Count == 0)
            {
                MessageBox.Show("Dự án không tồn tại!");
                return;
            }

            int maxDA = int.Parse(dtMaxDA.Rows[0][0].ToString());

            String sqlCountDA = "SELECT COUNT(*) FROM NHANVIEN WHERE daNv = '" + mada + "'";
            DataTable dtCountDA = dt.getTable(sqlCountDA);
            int currentDA = int.Parse(dtCountDA.Rows[0][0].ToString());

            if (currentDA >= maxDA)
            {
                MessageBox.Show("Dự án này đã đủ nhân viên (FULL)!");
                return;
            }

            String sql = "UPDATE NHANVIEN SET tenNv=N'" + tennv + "', luongNv='" + luong + "', diachiNv=N'" + diachi + "', ngaysinhNv='" + ngaysinh + "', daNv='" + mada + "', pbNv='" + mapb + "' WHERE maNv='" + manv + "'";
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
        public void deleteNV(String manv)
        {
            String sqlDeleteDangNhap = "DELETE FROM DANGNHAP WHERE id_Nv='" + manv + "'";

            String sqlDeleteNhanVien = "DELETE FROM NHANVIEN WHERE maNv='" + manv + "'";

            try
            {
                // Thực thi lệnh xóa bảng con
                dt.ExcuteNonQuery(sqlDeleteDangNhap);

                // Thực thi lệnh xóa bảng cha
                dt.ExcuteNonQuery(sqlDeleteNhanVien);

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
            String sql = "Select * from NhanVien where maNv like N'%" + condi + "%' OR tenNv like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
        public String selectPB(String mapb)
        {
            String tenpb;
            String sql = "select tenPb from PHONGBAN where maPb='" + mapb + "'";
            tenpb = dt.ExcuteScalar(sql);
            return tenpb;
        }
        public String selectDA(String mada)
        {
            String tenda;
            String sql = "select tenDa from DUAN where maDa='" + mada + "'";
            tenda = dt.ExcuteScalar(sql);
            return tenda;
        }
    }
}
