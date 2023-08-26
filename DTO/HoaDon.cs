using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public int MaND { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public long TongTien { get; set; }
        public string MaGG { get; set; }
        public long ThanhTien { get; set; }

        public HoaDon(string MaHD, int MaND, string MaKH, string TenKH, string SDT, long TongTien, string MaGG, long ThanhTien)
        {
            this.MaHD = MaHD;
            this.MaND = MaND;
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.SDT = SDT;
            this.TongTien = TongTien;
            this.MaGG = MaGG;
            this.ThanhTien = ThanhTien;

        }
    }
}
