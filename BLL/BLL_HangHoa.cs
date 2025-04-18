using Quanlybanhang.DAL;
using Quanlybanhang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlybanhang.BLL
{
    internal class BL_HangHoa
    {
        DAL_HangHoa dalHH = new DAL_HangHoa();

        // Lấy tất cả hàng hóa
        public DataTable LayDanhSachHangHoa()
        {
            return dalHH.GetAllHangHoa();
        }

        // Thêm hàng hóa
        public bool ThemHangHoa(DTO_HangHoa hh, ref string error)
        {
            if (string.IsNullOrEmpty(hh.MaSanPham) || string.IsNullOrEmpty(hh.TenSP))
            {
                error = "Mã sản phẩm và Tên sản phẩm không được để trống!";
                return false;
            }

            return dalHH.InsertHangHoa(hh, ref error);
        }

        // Sửa hàng hóa
        public bool SuaHangHoa(DTO_HangHoa hh, ref string error)
        {
            return dalHH.UpdateHangHoa(hh, ref error);
        }

        // Xóa hàng hóa
        public bool XoaHangHoa(string maSP, ref string error)
        {
            return dalHH.DeleteHangHoa(maSP, ref error);
        }
    }
}

