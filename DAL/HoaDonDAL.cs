﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL : DataBase
    {
        public static HoaDonDAL _instance;
        public static HoaDonDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoaDonDAL();
                return _instance;
            }
            set { }
        }
        public DataTable GetKH()
        {
            string query = "select * from KhachHang";
            return LoadData(query);
        }
        public DataTable SetMGG()
        {
            string query = "select * from MaGiamGia";
            return LoadData(query);
        }

        public DataTable LoadSearch(string txt)
        {
            string query = "Select  * from HoaDon where TenKH like N'%" + txt + "%' or SDT like '%"+txt+"%' ";
            return LoadData(query);
        }
        public DataTable LoadAllHD()
        {
            string query = "select * from HoaDon ";
            return LoadData(query);

        }
        public void AddHD(HoaDon HD)
        {
            string query = "Insert into HoaDon (MaHD,MaND,MaKH,TenKH,SDT,TongTien,MaGG,ThanhTien) values (N'" + HD.MaHD + "',N'" + HD.MaND + "',N'" + HD.MaKH + "',N'" + HD.TenKH + "','" + HD.SDT + "',N'" + HD.TongTien + "','" + HD.MaGG + "','" + HD.ThanhTien + "')";
            EditData(query);
            // return query;
        }
        public void UpdateHD(HoaDon HD)
        {
            string query = "Update HoaDon set MaND = N'" + HD.MaND + "', MaKH = '" + HD.MaKH + "',TenKH = N'" + HD.TenKH + "', SDT = N'" + HD.SDT + "',TongTien = '" + HD.TongTien + "',MaGG='" + HD.MaGG + "',ThanhTien='" + HD.ThanhTien + "' where MaHD = N'" + HD.MaHD + "'";
            EditData(query);
        }
        public void DeleteCTHD(string MaHD)
        {
            string query = "Delete from ChiTietHoaDon where MaHD ='" + MaHD + "'";
            EditData(query);
            // return query;
        }
        public void DeleteCTHD1(string MaCTHD)
        {
            string query = "Delete from ChiTietHoaDon where MaCTHD ='" + MaCTHD + "'";
            EditData(query);
            // return query;
        }
        public DataTable SetCBBLoaiSP()
        {
            //string query = "select SanPham.MaSP, SanPham.TenSP, KieuSanPham.TenKieuSP ,LoaiSanPham.TenLoaiSP,SanPham.Soluong,SanPham.GiaNhap,SanPham.GiaBan,SanPham.ThoiGianBaoHanh FROM((SanPham INNER JOIN KieuSanPham ON SanPham.MaKieuSP = KieuSanPham.MaKieuSP) INNER JOIN LoaiSanPham ON SanPham.MaLoaiSP = LoaiSanPham.MaLoaiSP)";

             string query = "select * from LoaiSanPham";
            return LoadData(query);
        }
        public DataTable SetCBBSP()
        {
            string query = "select * from SanPham";
            return LoadData(query);
        }
        public int CheckMaHD(string MaHD)
        {
            string query = "select * from HoaDon";
            foreach (DataRow i in LoadData(query).Rows)
            {
                if (i["MaHD"].ToString() == MaHD) return 1;

            }
            return 0;


        }
        public DataTable GetMaCTHD()
        {
            string query = "select * from ChiTietHoaDon where MaCTHD = (select max(MaCTHD) from ChiTietHoaDon)";
            return LoadData(query);
        }

        public void InsertNC(int ma)
        {
            string query = "insert into ChiTietHoaDon (MaSP,TenSP,GiaSP,ThoiGianBaoHanh) select MaSP,TenSP,GiaBan,ThoiGianBaoHanh from SanPham where MaSP='" + ma + "'";
            EditData(query);
        }
        public void InsertPK(int ma)
        {
            string query = "insert into ChiTietHoaDon (MaSP,TenSP,GiaSP,ThoiGianBaoHanh) select MaSP,TenSP,GiaBan,ThoiGianBaoHanh from SanPham where MaPK='" + ma + "'";
            EditData(query);
        }
        public void UpdateCTHD(string maHD, int SL, int MaCTHD)
        {
            string query = "update ChiTietHoaDon set MaHD='" + maHD + "',SoLuong='" + SL + "',NgayMua='" + DateTime.Now + "' where MaCTHD='" + MaCTHD + "'";
            EditData(query);
        }
        public string DeleteHD(string MaHD)
        {
            string query = "Delete from HoaDon where MaHD ='" + MaHD + "'";
            EditData(query);
            return query;
        }


    }
}