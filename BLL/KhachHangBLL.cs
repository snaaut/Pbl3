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
    public class KhachHangBLL
    {
        public static KhachHangBLL _instance;
        public static KhachHangBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KhachHangBLL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAll()
        {
            return KhachHangDAL.Instance.LoadAll();
        }
        public DataTable LoadSearch(string txt)
        {
            return KhachHangDAL.Instance.LoadSearch(txt);
        }
        public void AddKH(KhachHang KH)
        {
            KhachHangDAL.Instance.AddKH(KH);
        }
        public void UpdateKH(KhachHang KH)
        {
            KhachHangDAL.Instance.UpdateKH(KH);
        }
        public void DeleteKH(List<string> MaKH)
        {
            foreach (string i in MaKH)
            {
                KhachHangDAL.Instance.DeleteKH(i);
            }
        }

    }
}

