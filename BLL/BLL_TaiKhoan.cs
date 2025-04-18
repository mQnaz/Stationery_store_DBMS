using Quanlybanhang.DTO;
using Quanlybanhang.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quanlybanhang.BLL
{
    internal class BLL_TaiKhoan
    {
        DAL_TaiKhoan dal = new DAL_TaiKhoan();

        public DTO_TaiKhoan DangNhap(string tenDangNhap, string matKhau)
        {
            return dal.KiemTraDangNhap(tenDangNhap, matKhau);
        }
    }
}
