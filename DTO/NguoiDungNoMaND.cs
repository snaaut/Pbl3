using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungNoMaND
    {
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }

        public NguoiDungNoMaND(string HoTen, string SDT,string DiaChi, string CMND,bool GioiTinh, DateTime NgaySinh,string Email, string TenDangNhap, string MatKhau)
        {
            
            this.HoTen = HoTen;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
            this.CMND = CMND;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.Email = Email;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }
    }
}
