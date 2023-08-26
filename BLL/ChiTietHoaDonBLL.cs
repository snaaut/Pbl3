using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        public static ChiTietHoaDonBLL _instance;
        public static ChiTietHoaDonBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChiTietHoaDonBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllCTHD(string MaHD)
        {
            return ChiTietHoaDonDAL.Instance.LoadAllCTHD(MaHD);
        }
        public DataTable GetAllCTHD()
        {
            return ChiTietHoaDonDAL.Instance.GetAllCTHD();
        }
        public int GetYear(string date)
        {
            string[] str = date.Split(' ');
            string[] str1 = str[0].Split('/');
            return int.Parse(str1[2]);

        }
        public int GetMonth(string date)
        {
            string[] str = date.Split(' ');
            string[] str1 = str[0].Split('/');
            return int.Parse(str1[0]);
        }
        public long GetGiaNhapSP(string ma)
        {
               return SanPhamBLL.Instance.GetGiaNhapSP(ma);

        }
        //public long GetGiaNhapNC(string MaNC)
        //{
        //    return NhacCuDAL.Instance.GetGiaNhapNC(MaNC);
        //}
        //public long GetGiaNhapPK(string MaPK)
        //{
        //    return PhuKienDAL.Instance.GetGiaNhapPK(MaPK);
        //}
    }
}