using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlybanhang.DTO;
namespace Quanlybanhang.DAL
{
    internal class DAL_TaiKhoan
    {
        DBHelper db = new DBHelper();

        public DTO_TaiKhoan KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            DTO_TaiKhoan tk = null;
            string query = "SELECT * FROM TAI_KHOAN WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

            using (SqlConnection conn = db.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tk = new DTO_TaiKhoan
                    {
                        TenDangNhap = reader["TenDangNhap"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        LoaiTaiKhoan = reader["LoaiTaiKhoan"].ToString(),
                        MaNhanVien = reader["MaNhanVien"].ToString()
                    };
                }
            }

            return tk;
        }
    }
}
