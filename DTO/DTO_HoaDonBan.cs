using System;

namespace Quanlybanhang.DTO
{
    internal class DTO_HoaDonBan
    {
        public string MaHoaDonBan { get; set; }
        public string MaNhanVien { get; set; }
        public string MaHinhThucThanhToan { get; set; }
        public string MaKhachHang { get; set; }
        public DateTime NgayBan { get; set; }
        public TimeSpan GioBan { get; set; }
    }
}