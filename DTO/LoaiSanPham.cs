using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        public int MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        public LoaiSanPham(int MaLoaiSP, string TenLoaiSP)
        {
            this.MaLoaiSP = MaLoaiSP;
            this.TenLoaiSP = TenLoaiSP;
        }
    }


}
