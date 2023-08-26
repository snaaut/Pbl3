using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NguoiDungDAL : DataBase
    {
        public static NguoiDungDAL _instance;
        public static NguoiDungDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NguoiDungDAL();
                return _instance;
            }
            set { }
        }
        public DataBase DB = new DataBase();
        public bool CheckAdd(NguoiDungNoMaND ND)
        {
            bool check = false;
            string query = "Select SDT from NguoiDung where SDT = '" + ND.SDT + "'";
            if (LoadData(query).Rows.Count > 0) check = true;
            query = "Select TenDangNhap from NguoiDung where TenDangNhap = '" + ND.TenDangNhap + "'";
            if (LoadData(query).Rows.Count > 0) check = true;
            return check;
        }
        public string AddND(NguoiDungNoMaND ND)
        {
            string query = "Insert into NguoiDung (HoTen,SDT,DiaChi, CMND, GioiTinh, NgaySinh, Email,TenDangNhap,MatKhau) values (N'" + ND.HoTen + "',N'" + ND.SDT + "',N'" + ND.DiaChi + "','" + ND.CMND + "','" + ND.GioiTinh + "','" + ND.NgaySinh + "','" + ND.Email + "',N'" + ND.TenDangNhap + "','" + ND.MatKhau + "')";
            EditData(query);
            return query;
        }
        public bool CheckLogin(string TenDangNhap, string MatKhau)
        {
            bool check = false;
            string query = "Select * from NguoiDung where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'";
            if (LoadData(query).Rows.Count > 0) check = true;
            return check;
        }
        public bool CheckSDT(NguoiDungNoMaND ND)
        {
            bool check = false;
            string query = "Select SDT from NguoiDung where SDT = '" + ND.SDT + "'";
            if (LoadData(query).Rows.Count > 0) check = true;
            return check;
        }
        public bool CheckTenDangNhap(NguoiDungNoMaND ND)
        {
            bool check = false;
            string query = "Select TenDangNhap from NguoiDung where TenDangNhap = '" + ND.TenDangNhap + "'";
            if (LoadData(query).Rows.Count > 0) check = true;
            return check;
        }
        public bool CheckEmail(NguoiDungNoMaND ND)
        {
            bool check = false;
            string query = "Select Email from NguoiDung where Email = '" + ND.Email + "'";
            if (LoadData(query).Rows.Count > 0) check = true;
            return check;
        }
        public int GetMaND(string TenDangNhap)
        {
            string query = "Select * from NguoiDung";
            //int ma;
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["TenDangNhap"].ToString() == TenDangNhap)
                {
                    return Convert.ToInt32(i["MaND"].ToString());
                }
            }
            return -1;

        }
        public string GetHoTen(string TenDangNhap)
        {
            string query = "Select * from NguoiDung";
            //int ma;
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["TenDangNhap"].ToString() == TenDangNhap)
                {
                    return (i["HoTen"].ToString());
                }
            }
            return "";
        }
        public string GetEmail(string TenDangNhap)
        {
            string query = "Select * from NguoiDung";
            //int ma;
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["TenDangNhap"].ToString() == TenDangNhap)
                {
                    return (i["Email"].ToString());
                }
            }
            return "";
        }
        public string ResetPass(string newpass, string email)
        {
            string query = "Update NguoiDung Set MatKhau = '" + newpass + "' Where email = '" + email + "';";
            EditData(query);
            return query;
        }

        public string CheckMailToReset(string email)
        {
            string query = "Select * from NguoiDung where Email = '" + email + "'";
            if (LoadData(query).Rows.Count == 0) return "Email không hợp lệ! Địa chỉ email chưa được đăng ký!";
            return query;

        }
        public bool CheckMailToDangKy(string email)
        {
            bool check = false;
            string query = "Select * from NguoiDung where Email = '" + email + "'";
            if (LoadData(query).Rows.Count > 0) check = true;
            return check;

        }
        public string DeleteND(string MaND)
        {
            string query = "Delete from NguoiDung where MaND ='" + MaND + "'";
            EditData(query);
            return query;
        }
        public string UpdateND(string MaND, string HoTen, string SDT, string DiaChi, string CMND, bool GioiTinh, DateTime NgaySinh, string Email, string TenDangNhap)
        {
            string query = "Update NguoiDung set HoTen = N'" + HoTen + "', SDT = N'" + SDT + "',DiaChi =N'" + DiaChi + "', CMND ='" + CMND + "',GioiTinh ='" + GioiTinh + "', NgaySinh = '" + NgaySinh + "', Email = N'" + Email + "', TenDangNhap = N'" + TenDangNhap + "'    where MaND = N'" + MaND + "'";
            EditData(query);
            return query;
        }
        public string UpdatePass(string MaND, string MatKhau)
        {
            string query = "Update NguoiDung set MatKhau = N'" + MatKhau + "' where MaND='" + MaND + "'";
            EditData(query);
            return query;
        }
        public string GetHoTenByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["HoTen"].ToString();
                }
            }
            return "";
        }
        public string GetSDTByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["SDT"].ToString();
                }
            }
            return "";
        }
        public string GetEmailByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["Email"].ToString();
                }
            }
            return "";
        }
        public string GetTenDangNhapByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["TenDangNhap"].ToString();
                }
            }
            return "";
        }
        public string GetMatKhauByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["MatKhau"].ToString();
                }
            }
            return "";
        }
        public string GetDiaChiByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["DiaChi"].ToString();
                }
            }
            return "";
        }
        public string GetCMNDByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["CMND"].ToString();
                }
            }
            return "";
        }
        public string GetNgaySinhByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return i["NgaySinh"].ToString();
                }
            }
            return "";
        }
        public bool GetGioiTinhByMaND(string MaND)
        {
            string query = "Select * from NguoiDung";
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaND"].ToString() == MaND)
                {
                    return Convert.ToBoolean(i["GioiTinh"].ToString());
                }
            }
            return false;
        }
    }
}
