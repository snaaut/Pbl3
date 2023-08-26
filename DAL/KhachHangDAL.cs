using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class KhachHangDAL : DataBase
    {
        public static KhachHangDAL _instance;
        public static KhachHangDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KhachHangDAL();
                return _instance;
            }
            set { }
        }
        public DataTable LoadAll()
        {
            string query = "select * from KhachHang ";
            return LoadData(query);
        }
        public DataTable LoadSearch(string txt)
        {
            string query = "Select  * from KhachHang where TenKH like N'%" + txt + "%'";
            return LoadData(query);
        }
        public string AddKH(KhachHang KH)
        {
            string query = "Insert into KhachHang (MaKH,TenKH,DiaChi,SDT) values (N'" + KH.MaKH + "',N'" + KH.TenKH + "',N'" + KH.DiaChi + "','" + KH.SDT + "')";
            EditData(query);
            return query;
        }
        public string UpdateKH(KhachHang KH)
        {
            string query = "Update KhachHang set TenKH = N'" + KH.TenKH + "', DiaChi = N'" + KH.DiaChi + "', SDT = N'" + KH.SDT + "' where MaKH = N'" + KH.MaKH + "'";
            EditData(query);
            return query;
        }
        public string DeleteKH(string MaKH)
        {
            string query = "Delete from KhachHang where MaKH ='" + MaKH + "'";
            EditData(query);
            return query;
        }
    }
}
