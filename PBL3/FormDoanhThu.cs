using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace PBL3
{
    public partial class FormDoanhThu : Form
    {
        public FormDoanhThu()
        {
            InitializeComponent();
            SetCBB();
            //SetChart(2022);
        }
        public DataBase DB = new DataBase();
        public void SetChart(int year)
        {
            DataTable DT = ChiTietHoaDonBLL.Instance.GetAllCTHD();
            long[] dt = new long[13];
            chart1.Series[0].Points.Clear();
            for (int i = 1; i <= 12; i++)
            {
                dt[i] = 0;
            }
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (ChiTietHoaDonBLL.Instance.GetYear(DT.Rows[i]["NgayMua"].ToString()) == year)
                {
                    dt[Convert.ToInt32(ChiTietHoaDonBLL.Instance.GetMonth(DT.Rows[i]["NgayMua"].ToString()))] += (Convert.ToInt64(DT.Rows[i]["GiaSP"]) - Convert.ToInt64(SanPhamBLL.Instance.GetGiaNhapSP(DT.Rows[i]["MaSP"].ToString()))) * Convert.ToInt32(DT.Rows[i]["Soluong"].ToString());//- gia goc
                }
            }
            for (int i = 1; i <= 12; i++)
            {
                chart1.Series[0].Points.AddXY("Tháng" + i, dt[i]);
            }
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series[0]["DrawingStyle"] = "Cylinder";
        }
        public void ClearChart()
        {
            long[] dt = new long[13];
            for (int i = 1; i <= 12; i++)
            {
                dt[i] = 0;
            }
            for (int i = 1; i <= 12; i++)
            {
                chart1.Series[0].Points.AddXY("Tháng" + i, dt[i]);
            }
        }
        public void SetCBB()
        {
            DataTable DT = ChiTietHoaDonBLL.Instance.GetAllCTHD();
            List<string> year = new List<string>();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                year.Add(ChiTietHoaDonBLL.Instance.GetYear(DT.Rows[i]["NgayMua"].ToString()).ToString());
            }
            foreach (string i in year.Distinct())
            {
                cbbDoanhThuTheoNam.Items.Add(i);
            }

            //string query = "select distinct LoaiNC from NhacCu";
            //foreach (DataRow i in DB.LoadData(query).Rows)
            //{

            //    cbbDoanhThuTheoNam.Items.Add(new CBBItem
            //    {

            //        Value = i["LoaiNC"].ToString(),
            //        Text = i["LoaiNC"].ToString()
            //    });

            //}
        }

      

        private void cbbDoanhThuTheoNam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetChart(Convert.ToInt32(cbbDoanhThuTheoNam.Text));
        }
    }
}