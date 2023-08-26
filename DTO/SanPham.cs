using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public string TenSP { get; set; }
        public int MaKieuSP { get; set; }
        public int MaLoaiSP { get; set; }
        public int SoLuong { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public SanPham( string TenSP, int MaKieuSP, int MaLoaiSP, int SoLuong, int GiaNhap, int GiaBan, int ThoiGianBaoHanh)
        {

            this.TenSP = TenSP;
            this.MaKieuSP = MaKieuSP;
            this.MaLoaiSP = MaLoaiSP;
            this.SoLuong = SoLuong;
            this.GiaNhap = GiaNhap;
            this.GiaBan = GiaBan;
            this.ThoiGianBaoHanh = ThoiGianBaoHanh;
        }

    }
}

