﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class ChiTietHoaDonDAL : DataBase
    {
        public static ChiTietHoaDonDAL _instance;
        public static ChiTietHoaDonDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChiTietHoaDonDAL();
                return _instance;
            }
            set { }
        }

        public DataTable LoadAllCTHD(string MaHD)
        {
            string query = "select * from ChiTietHoaDon where MaHD='" + MaHD + "' ";
            return LoadData(query);
        }
        public DataTable GetAllCTHD()
        {
            return LoadData("select * from ChiTietHoaDon");
        }
    }
}