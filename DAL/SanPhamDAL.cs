using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        public class SanPhamDAL : DataBase
        {
            public static SanPhamDAL _instance;
            public static SanPhamDAL Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new SanPhamDAL();
                    return _instance;
                }
                set { }
            }
            public DataBase DB = new DataBase();
        public DataTable SetCBB()
        {
            string query = "select * from LoaiSanPham";
            return LoadData(query);
        }
        public DataTable LoadSanPham()
        {
            string query = "select SanPham.MaSP, SanPham.TenSP, KieuSanPham.TenKieuSP ,LoaiSanPham.TenLoaiSP,SanPham.Soluong,SanPham.GiaNhap,SanPham.GiaBan,SanPham.ThoiGianBaoHanh FROM((SanPham INNER JOIN KieuSanPham ON SanPham.MaKieuSP = KieuSanPham.MaKieuSP) INNER JOIN LoaiSanPham ON SanPham.MaLoaiSP = LoaiSanPham.MaLoaiSP)";
            return LoadData(query);
        }
        public DataTable LoadNhacCu()
        {
            string query = "select SanPham.MaSP, SanPham.TenSP, KieuSanPham.TenKieuSP ,LoaiSanPham.TenLoaiSP,SanPham.Soluong,SanPham.GiaNhap,SanPham.GiaBan,SanPham.ThoiGianBaoHanh FROM((SanPham INNER JOIN KieuSanPham ON SanPham.MaKieuSP = KieuSanPham.MaKieuSP) INNER JOIN LoaiSanPham ON SanPham.MaLoaiSP = LoaiSanPham.MaLoaiSP)";
            DataTable data1 = LoadData(query);
            DataTable data2 = new DataTable();
            data2 = data1.Clone();
            foreach (DataRow i in data1.Rows)
            {
                if (i["TenKieuSP"].ToString() == "Nhạc cụ")
                {
                    data2.ImportRow(i);
                }
            }
            return data2;
        }
        public DataTable LoadPhuKien()
        {
            string query = "select SanPham.MaSP, SanPham.TenSP, KieuSanPham.TenKieuSP ,LoaiSanPham.TenLoaiSP,SanPham.Soluong,SanPham.GiaNhap,SanPham.GiaBan,SanPham.ThoiGianBaoHanh FROM((SanPham INNER JOIN KieuSanPham ON SanPham.MaKieuSP = KieuSanPham.MaKieuSP) INNER JOIN LoaiSanPham ON SanPham.MaLoaiSP = LoaiSanPham.MaLoaiSP)";
            DataTable data1 = LoadData(query);
            DataTable data2 = new DataTable();
            data2 = data1.Clone();
            foreach (DataRow i in data1.Rows)
            {
                if (i["TenKieuSP"].ToString() == "Phụ kiện")
                {
                    data2.ImportRow(i);
                }
            }
            return data2;
        }
        public DataTable LoadSearchSP(string txt)
        {
            string query = "Select  * from SanPham where TenSP like N'%" + txt + "%'";
            return LoadData(query);
        }
        public string AddSP(SanPham SP)
        {
            string query = "Insert into SanPham (TenSP,MaKieuSP,MaLoaiSP,Soluong,GiaNhap,GiaBan,ThoiGianBaoHanh) values (N'" + SP.TenSP + "',N'" + SP.MaKieuSP + "','" + SP.MaLoaiSP + "',N'" + SP.SoLuong + "',N'" + SP.GiaNhap + "',N'" + SP.GiaBan + "',N'" + SP.ThoiGianBaoHanh + "')";
            EditData(query);
            return query;
        }
        public string UpdateSP(SanPham SP, int ma)
        {
            string query = "Update SanPham set TenSP = N'" + SP.TenSP + "',MaKieuSP = N'" + SP.MaKieuSP+ "',MaLoaiSP='" + SP.MaLoaiSP + "', Soluong = N'" + SP.SoLuong + "', GiaNhap = N'" + SP.GiaNhap + "', GiaBan = N'" + SP.GiaBan + "', ThoiGianBaoHanh = N'" + SP.ThoiGianBaoHanh + "' where MaSP = N'" + ma + "'";
            EditData(query);
            return query;
        }
        public long GetGiaNhapSP(string MaSP)
        {
            string query = "Select * from SanPham";
            //int ma;
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaSP"].ToString() == MaSP)
                {
                    return Convert.ToInt32(i["GiaNhap"].ToString());
                }
            }
            return -1;
        }
        public void UpdateSLSP(int MaSP, int SL)
        {
            string query = "Update SanPham set Soluong='" + SL + "' where MaSP='" + MaSP + "' ";
            EditData(query);
        }
        public int GetSoLuongSP(string MaSP)
        {
            string query = "Select * from SanPham";
            
            foreach (DataRow i in DB.LoadData(query).Rows)
            {
                if (i["MaSP"].ToString() == MaSP)
                {
                    return Convert.ToInt32(i["SoLuong"].ToString());
                }
            }
            return -1;
        }

    }
}