using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        public static SanPhamBLL _instance;
        public static SanPhamBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SanPhamBLL();
                return _instance;
            }
            set { }
        }
        public DataTable SetCBB()
        {
            return SanPhamDAL.Instance.SetCBB();
        }
      
        public DataTable LoadAllNC()
        {
            return SanPhamDAL.Instance.LoadNhacCu();
        }
        public DataTable LoadAllPK()
        {
            return SanPhamDAL.Instance.LoadPhuKien();
        }
        public DataTable LoadSearchSP(string txt)
        {
            return SanPhamDAL.Instance.LoadSearchSP(txt);
        }

        public void AddSP(SanPham SP)
        {
            SanPhamDAL.Instance.AddSP(SP);
        }
        public void UpdateSP(SanPham SP, int ma)
        {
            SanPhamDAL.Instance.UpdateSP(SP, ma);
        }
        public long GetGiaNhapSP(string ma)
        {
            return SanPhamDAL.Instance.GetGiaNhapSP(ma);
        }
        public int GetSoLuongSP(string ma)
        {
            return SanPhamDAL.Instance.GetSoLuongSP(ma);
        }
        public void UpdateSLSP(int MaSP, int SL)
        {
            SanPhamDAL.Instance.UpdateSLSP(MaSP, SL);
        }
    }
}