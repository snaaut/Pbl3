using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HoaDonBLL
    {
        public static HoaDonBLL _instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAllHD()
        {
            return HoaDonDAL.Instance.LoadAllHD();
        }
        public void AddHD(HoaDon HD)
        {
            HoaDonDAL.Instance.AddHD(HD);
        }
        public void UpdateHD(HoaDon HD)
        {
            HoaDonDAL.Instance.UpdateHD(HD);
        }
        public void DeleteCTHD(string maHD)
        {
            HoaDonDAL.Instance.DeleteCTHD(maHD);
        }
        public void DeleteCTHD1(string maCTHD)
        {
            HoaDonDAL.Instance.DeleteCTHD1(maCTHD);
        }
        public DataTable GetKH()
        {
            return HoaDonDAL.Instance.GetKH();
        }
        public DataTable SetCBBLoaiSP()
        {
            return HoaDonDAL.Instance.SetCBBLoaiSP();
        }
        public DataTable SetCBBSP()
        {
            return HoaDonDAL.Instance.SetCBBSP();
        }
        public int CheckMaHD(string MaHD)
        {
            return HoaDonDAL.Instance.CheckMaHD(MaHD);
        }
        public DataTable SetMGG()
        {
            return HoaDonDAL.Instance.SetMGG();
        }
        public DataTable LoadSearch(string txt)
        {
            return HoaDonDAL.Instance.LoadSearch(txt);
        }
        public DataTable GetMaCTHD()
        {
            return HoaDonDAL.Instance.GetMaCTHD();
        }
        public void InsertNC(int ma)
        {
            HoaDonDAL.Instance.InsertNC(ma);
        }
        public void InsertPK(int ma)
        {
            HoaDonDAL.Instance.InsertPK(ma);
        }
        public void UpdateCTHD(string maHD, int SL, int maCTHD)
        {
            HoaDonDAL.Instance.UpdateCTHD(maHD, SL, maCTHD);
        }
        public void DeleteHD(string MaHD)
        {
            
                HoaDonDAL.Instance.DeleteHD(MaHD);
            
        }

    }
}