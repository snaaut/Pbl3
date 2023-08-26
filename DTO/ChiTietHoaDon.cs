using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        string MaCTHD { get; set; }
        string MaHD { get; set; }
        string MaSP { get; set; }
        string TenSP { get; set; }
        long Gia { get; set; }
        int SoLuong { get; set; }
        DateTime NgayMua { get; set; }
        int ThoiGianBaoHanh { get; set; }
        public ChiTietHoaDon(string MaCTHD, string MaHD, string MaSP, string TenSP, long Gia, int SoLuong, DateTime NgayMua, int ThoiGianBaoHanh)
        {
            this.MaCTHD = MaCTHD;
            this.MaHD = MaHD;
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.Gia = Gia;
            this.SoLuong = SoLuong;
            this.NgayMua = NgayMua;
            this.ThoiGianBaoHanh = ThoiGianBaoHanh;
        }
    }
}
