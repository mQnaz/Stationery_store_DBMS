using Quanlybanhang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlybanhang.DAL
{
    internal class DAL_HangHoa
    {
        DBHelper db = new DBHelper();

        // Lấy toàn bộ hàng hóa
        public DataTable GetAllHangHoa()
        {
            string sql = "SELECT * FROM HANG_HOA";
            return db.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
        }

        // Thêm hàng hóa 
        public bool InsertHangHoa(DTO_HangHoa hh, ref string error)
        {
            string sql = $"INSERT INTO HANG_HOA (MaSanPham, TenSP, DonViTinh, MoTa) " +
                         $"VALUES (N'{hh.MaSanPham}', N'{hh.TenSP}', N'{hh.DonViTinh}', N'{hh.MoTa}')";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        // Cập nhật hàng hóa
        public bool UpdateHangHoa(DTO_HangHoa hh, ref string error)
        {
            string sql = $"UPDATE HANG_HOA " +
                         $"SET TenSP = N'{hh.TenSP}', DonViTinh = N'{hh.DonViTinh}', MoTa = N'{hh.MoTa}' " +
                         $"WHERE MaSanPham = N'{hh.MaSanPham}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }

        // Xóa hàng hóa
        public bool DeleteHangHoa(string maSP, ref string error)
        {
            string sql = $"DELETE FROM HANG_HOA WHERE MaSanPham = N'{maSP}'";
            return db.MyExecuteNonQuery(sql, CommandType.Text, ref error);
        }
    }
}

 