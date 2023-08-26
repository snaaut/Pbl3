﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BLL;

namespace PBL3
{
    public partial class FormHoaDon : Form
    {
        DataBase DB = new DataBase();
        public FormHoaDon()
        {
            InitializeComponent();
            Sender = new mydel1(GetText);
            Sender2 = new mydel2(GetText2);
            dataGridViewHD.CurrentCell = null;
            ShowDGVHD();
            txtMaHD.Text = TangMa();
            HoaDonBLL.Instance.DeleteCTHD(txtMaHD.Text);
            SetCBBLoaiSP();
            //SetCBBSP();
            //SetCBB1();
             SetCBBNCPK();
        }
        public delegate void mydel1(string maND);
        public mydel1 Sender; // public Form2()
        private void GetText(string MaND)
        {
            labelMaND.Text = MaND;
            txtMaND.Text = MaND;

        }
        public delegate void mydel2(string MaND,string maKH,string TenKH, string SDT);
        public mydel2 Sender2; // public Form2()
        private void GetText2(string MaND,string MaKH,string TenKH,string SDT)
        {
            labelMaND.Text = MaND;
            txtMaND.Text = MaND;
            txtMaKH.Text = MaKH;
            txtTenKH.Text = TenKH;
            txtSDT.Text=SDT;

        }
        public void ShowDGVHD()
        {
            dataGridViewHD.DataSource = HoaDonBLL.Instance.LoadAllHD();
        }
        public void ShowDGVChiTietHD()
        {
            dataGridViewChiTietHD.DataSource = ChiTietHoaDonBLL.Instance.LoadAllCTHD(txtMaHD.Text);
        }
        public void ShowCTHD()
        {
            string maHD;
            if (dataGridViewHD.SelectedRows.Count > 0)
            {
                maHD = dataGridViewHD.SelectedRows[dataGridViewHD.SelectedRows.Count - 1].Cells[0].Value.ToString();
                dataGridViewChiTietHD.DataSource = ChiTietHoaDonBLL.Instance.LoadAllCTHD(maHD);
            }
            else MessageBox.Show("Chọn hóa đơn muốn xem chi tiết");

        }
        public void ShowCTHD1(string maHD)
        {
            dataGridViewChiTietHD.DataSource = ChiTietHoaDonBLL.Instance.LoadAllCTHD(maHD);
        }
        public void SetCBBLoaiSP()
        {
            cbbLoaiNC.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach (DataRow i in HoaDonBLL.Instance.SetCBBLoaiSP().Rows)
            {

                cbbLoaiNC.Items.Add(new CBBItem
                {

                    Value = Convert.ToInt32(i["MaLoaiSP"].ToString()),
                    Text = i["TenLoaiSP"].ToString()
                });

            }
        }
        public void SetCBBNCPK()
        {
            cbbLoaiNCPK.Items.Add(new CBBItem { Value = 0, Text = "All" });

            foreach (DataRow i in HoaDonBLL.Instance.SetCBBLoaiSP().Rows)
            {

                cbbLoaiNCPK.Items.Add(new CBBItem
                {

                    Value = Convert.ToInt32(i["MaLoaiSP"].ToString()),
                    Text = i["TenLoaiSP"].ToString()
                });

            }
        }
        public string TangMa()
        {
            string maHD = "";
            int sohang = dataGridViewHD.Rows.Count;
            string chuoi1 = "";
            int chuoi2 = 0;
            chuoi1 = Convert.ToString(dataGridViewHD.Rows[sohang - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi1.Remove(0, 2));
            if (chuoi2 < 9) maHD = "HD0" + (chuoi2 + 1).ToString();
            else maHD = "HD" + (chuoi2 + 1);
            return maHD;
        }


        private void butThemKH_Click(object sender, EventArgs e)
        {
            if (HoaDonBLL.Instance.CheckMaHD(txtMaHD.Text) == 0)
            {
                HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
                if (txtMaKH.Text.Length == 0 || txtTenKH.Text.Length == 0 || txtSDT.Text.Length == 0 || txtTongTien.Text.Length == 0 || txtMaGG.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
                else
                {
                    HoaDonBLL.Instance.AddHD(HD);
                    MessageBox.Show("Thêm thành công");
                    ShowDGVHD();
                    txtMaHD.Text = TangMa();
                    ShowCTHD1(txtMaHD.Text);

                }
            }
            else
            {
                HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
                HoaDonBLL.Instance.UpdateHD(HD);
                MessageBox.Show("Thêm thành công");
                ShowDGVHD();
                txtMaHD.Text = TangMa();
                ShowCTHD1(txtMaHD.Text);
            }
        }

        private void cbbLoaiNC_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbbTenNC.Items.Clear();
            cbbTenNC.ResetText();
            txtGiaNC.Text = "";
            txtMaNC.Text = "";
            if (cbbLoaiNC.SelectedItem.ToString() == "All")
            {
                foreach (DataRow i in HoaDonBLL.Instance.SetCBBSP().Rows)
                {
                    if (Convert.ToInt32(i["MaKieuSP"].ToString()) == 1)
                    {
                        cbbTenNC.Items.Add(i["TenSP"]);
                    }

                }
            }

            foreach (DataRow i in HoaDonBLL.Instance.SetCBBSP().Rows)
            {
                if (Convert.ToInt32(i["MaKieuSP"].ToString()) == 1)
                {
                    if (Convert.ToInt32(i["MaLoaiSP"]) == Convert.ToInt32(((CBBItem)cbbLoaiNC.SelectedItem).Value.ToString()))
                    {
                        cbbTenNC.Items.Add(i["TenSP"]);
                    }
                }
            }
        }

        //private void cbbLoaiNCPK_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // string query = "select * from PhuKien";
        //    cbbTenPK.Items.Clear();
        //    cbbTenPK.ResetText();
        //    txtGiaPK.Text = "";
        //    txtMaPK.Text = "";
        //    if (cbbLoaiNCPK.SelectedItem.ToString() == "All")
        //    {
        //        foreach (DataRow i in HoaDonBLL.Instance.SetCBBPK().Rows)
        //        {
        //            cbbTenPK.Items.Add(i["TenPK"]);
        //        }
        //    }

        //    foreach (DataRow i in HoaDonBLL.Instance.SetCBBPK().Rows)
        //    {
        //        if (i["LoaiNC"].ToString() == cbbLoaiNCPK.SelectedItem.ToString())
        //        {
        //            cbbTenPK.Items.Add(i["TenPK"]);
        //        }
        //    }

        //}

        //private void cbbTenPK_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //string query = "select * from PhuKien";
        //    foreach (DataRow i in HoaDonBLL.Instance.SetCBBPK().Rows)
        //    {
        //        if (i["TenPK"].ToString() == cbbTenPK.SelectedItem.ToString())
        //        {
        //            txtMaPK.Text = i["MaPK"].ToString();
        //            txtGiaPK.Text = i["GiaBan"].ToString();
        //        }
        //    }
        //}
        public int GetMaCTHD()
        {
            int MaCTHD = 0;
            // string query1 = "select * from ChiTietHoaDon where MaCTHD = (select max(MaCTHD) from ChiTietHoaDon)";
            foreach (DataRow i in HoaDonBLL.Instance.GetMaCTHD().Rows)
            {
                MaCTHD = Convert.ToInt32(i["MaCTHD"]);
            }
            return MaCTHD;
        }
        public void TongTien()
        {
            int TongTien = 0;
            for (int i = 0; i < dataGridViewChiTietHD.Rows.Count - 1; i++)
            {

                TongTien += Convert.ToInt32(dataGridViewChiTietHD.Rows[i].Cells[4].Value.ToString()) * Convert.ToInt32(dataGridViewChiTietHD.Rows[i].Cells[5].Value.ToString());



            }
            txtTongTien.Text = TongTien.ToString();

        }

        private void butThemPK_Click(object sender, EventArgs e)
        {

            if (txtMaKH.Text == "") MessageBox.Show("Vui lòng nhập mã khách hàng");
            else  if (Convert.ToInt32(numSoLuongPK.Value.ToString()) - SanPhamBLL.Instance.GetSoLuongSP(txtMaPK.Text) >= 0)
            {
                MessageBox.Show("Số lượng phụ kiện trong kho không còn đủ");
            }
            {
                if (HoaDonBLL.Instance.CheckMaHD(txtMaHD.Text) == 0)
                {

                    HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
                    HoaDonBLL.Instance.AddHD(HD);
                    HoaDonBLL.Instance.InsertNC(Convert.ToInt32(txtMaPK.Text));
                    SanPhamBLL.Instance.UpdateSLSP(Convert.ToInt32(txtMaPK.Text), GetSLPKThem());
                }
                else
                {

                    HoaDonBLL.Instance.InsertNC(Convert.ToInt32(txtMaPK.Text));
                    SanPhamBLL.Instance.UpdateSLSP(Convert.ToInt32(txtMaPK.Text), GetSLPKThem());
                }
                int MaCTHD = GetMaCTHD();
                HoaDonBLL.Instance.UpdateCTHD(txtMaHD.Text, Convert.ToInt32(numSoLuongPK.Value), MaCTHD);
                ShowDGVChiTietHD();
                TongTien();
            }
            //HoaDonBLL.Instance.InsertPK(Convert.ToInt32(txtMaPK.Text));
            //int MaCTHD = GetMaCTHD();
            //SanPhamBLL.Instance.UpdateSLSP(Convert.ToInt32(txtMaPK.Text), GetSLPKThem());
            //HoaDonBLL.Instance.UpdateCTHD(txtMaHD.Text, Convert.ToInt32(numSoLuongPK.Value), MaCTHD);
            //ShowDGVChiTietHD();
            //TongTien();


        }

        private void cbbTenNC_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            foreach (DataRow i in HoaDonBLL.Instance.SetCBBSP().Rows)
            {
                if (i["TenSP"].ToString() == cbbTenNC.SelectedItem.ToString())
                {
                    txtMaNC.Text = i["MaSP"].ToString();
                    txtGiaNC.Text = i["GiaBan"].ToString();
                }
            }
        }

        private void load(DataGridViewRow row)
        {
            txtMaHD.Text = row.Cells[0].Value.ToString();
            txtMaND.Text = row.Cells[1].Value.ToString();
            txtMaKH.Text = row.Cells[2].Value.ToString();
            txtTenKH.Text = row.Cells[3].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            // txtTongTien.Text = row.Cells[5].Value.ToString();
            txtMaGG.Text = row.Cells[6].Value.ToString();
            // txtThanhTien.Text = row.Cells[7].Value.ToString();

        }


        public int GetMaSP()
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            int ma = Convert.ToInt32(row.Cells["MaSP"].Value.ToString());
            return ma;
        }
        //public string GetMaPK()
        //{
        //    DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
        //    string ma = row.Cells["MaSP"].Value.ToString();
        //    return ma;
        //}
        public int GetSLSPinDGV()
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            int sl = Convert.ToInt32(row.Cells["SoLuong"].Value.ToString());
            return sl;
        }
        public int GetSLPKinDGV()
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            int sl = Convert.ToInt32(row.Cells["SoLuong"].Value.ToString());
            return sl;
        }
        public int GetSLSPXoa()
        {
            int SL = 0;
            foreach (DataRow i in SanPhamBLL.Instance.LoadAllNC().Rows)
            {
                if (Convert.ToInt32(i["MaSP"].ToString()) == GetMaSP())
                {
                    SL = Convert.ToInt32(i["Soluong"]) + Convert.ToInt32(GetSLSPinDGV());
                   
                }
               
            }
            return SL;
        }
        public int GetSLPKXoa()
        {
            int SL = 0;
            foreach (DataRow i in SanPhamBLL.Instance.LoadAllPK().Rows)
            {
                if (Convert.ToInt32(i["MaSP"].ToString()) == GetMaSP())
                {
                    SL = Convert.ToInt32(i["Soluong"]) + Convert.ToInt32(GetSLPKinDGV());
                    // return SL;
                }
                // return SL;
            }
            return SL;
        }
        public int GetSLSPThem()
        {
            int SL = 0;
            foreach (DataRow i in SanPhamBLL.Instance.LoadAllNC().Rows)
            {
                if (i["MaSP"].ToString() == txtMaNC.Text)
                {
                    SL = Convert.ToInt32(i["Soluong"]) - Convert.ToInt32(numSoLuongNC.Value.ToString());
                    // return SL;
                }
                // return SL;
            }
            return SL;
        }
        public int GetSLPKThem()
        {
            int SL = 0;
            foreach (DataRow i in SanPhamBLL.Instance.LoadAllPK().Rows)
            {
                if (i["MaSP"].ToString() == txtMaPK.Text)
                {
                    SL = Convert.ToInt32(i["Soluong"]) - Convert.ToInt32(numSoLuongPK.Value.ToString());
                }
            }
            return SL;
        }





        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            foreach (DataRow i in HoaDonBLL.Instance.SetMGG().Rows)
            {
                if (i["MaGG"].ToString() == txtMaGG.Text)
                {
                    double chietkhau = Convert.ToDouble(i["ChietKhau"]);
                    labelChietKhau.Text = "-" + (chietkhau * Convert.ToInt32(txtTongTien.Text)).ToString() + "VND";
                    txtThanhTien.Text = (Convert.ToInt32(txtTongTien.Text) - (chietkhau * Convert.ToInt32(txtTongTien.Text))).ToString();
                }
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            string ma = row.Cells["MaCTHD"].Value.ToString();
            // TongTienXoa();
            //MessageBox.Show(GetSLNC().ToString());
            //MessageBox.Show(GetSLNCinDGV().ToString());
            //MessageBox.Show(GetMaNC());

            SanPhamBLL.Instance.UpdateSLSP(GetMaSP(), GetSLSPXoa());

            HoaDonBLL.Instance.DeleteCTHD1(ma);
            MessageBox.Show("Xóa thành công");
            ShowDGVChiTietHD();
            TongTien();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtTongTien.Text = "0";
            txtMaGG.Text = " ";
            txtThanhTien.Text = "0";
            labelChietKhau.Text = "-0VND";
        }
        private void butSuaHD_Click(object sender, EventArgs e)
        {
            //if (dataGridViewHD.SelectedRows.Count == 1)
            //{
            //    HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
            //    HoaDonBLL.Instance.UpdateHD(HD);
            //    MessageBox.Show("Đã Lưu thành công");
            //    ShowDGVHD();
            //    txtMaHD.Text = TangMa();
            //    clear();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn hóa đơn cần chỉnh sửa");
            //}
            if (HoaDonBLL.Instance.CheckMaHD(txtMaHD.Text) == 0)
            {
                HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
                if (txtMaKH.Text.Length == 0 || txtTenKH.Text.Length == 0 || txtSDT.Text.Length == 0   )
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }


                else if (txtTongTien.Text == "0")
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm muốn mua");

                }
                else
                {
                    HoaDonBLL.Instance.AddHD(HD);
                    MessageBox.Show("Thêm thành công");
                    ShowDGVHD();
                    txtMaHD.Text = TangMa();
                    ShowCTHD1(txtMaHD.Text);
                    clear();

                }
            }
            else
            {
                HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
                HoaDonBLL.Instance.UpdateHD(HD);
                MessageBox.Show("Cập nhật thành công");
                ShowDGVHD();
                txtMaHD.Text = TangMa();
                ShowCTHD1(txtMaHD.Text);
                clear();
            }
        }

        private void butThemHD_Click(object sender, EventArgs e)
        {
            txtMaND.Text = labelMaND.Text;
            txtMaHD.Text = TangMa();
            clear();
            ShowDGVChiTietHD();

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow i in HoaDonBLL.Instance.GetKH().Rows)
            {
                if (i["MaKH"].ToString() == txtMaKH.Text)
                {
                    txtTenKH.Text = i["TenKH"].ToString();
                    txtSDT.Text = i["SDT"].ToString();
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            string ma = row.Cells["MaCTHD"].Value.ToString();
            // TongTienXoa();
            //MessageBox.Show(GetSLNC().ToString());
            //MessageBox.Show(GetSLNCinDGV().ToString());
            //MessageBox.Show(GetMaNC());

            SanPhamBLL.Instance.UpdateSLSP(GetMaSP(), GetSLSPXoa());

            HoaDonBLL.Instance.DeleteCTHD1(ma);
            MessageBox.Show("Xóa thành công");
            ShowDGVChiTietHD();
            TongTien();
        }

        public void clearNC()
        {
            cbbLoaiNC.SelectedIndex = -1;
            cbbTenNC.SelectedIndex = -1;
            txtMaNC.Text = "";
            txtGiaNC.Text = "";
        }
        public void clearPK()
        {
            cbbLoaiNC.Text = "";
            cbbTenNC.Text="";
            txtMaNC.Text = "";
            txtGiaNC.Text = "";
        }
        private void butThemNC_Click(object sender, EventArgs e)
        {
            
            if (txtMaKH.Text == "") MessageBox.Show("Vui lòng nhập mã khách hàng");
            else if (Convert.ToInt32(numSoLuongNC.Value.ToString()) - SanPhamBLL.Instance.GetSoLuongSP(txtMaNC.Text)>=0)
            {
                MessageBox.Show("Số lượng nhạc cụ trong kho không còn đủ");
            }
            else
            {
                if (HoaDonBLL.Instance.CheckMaHD(txtMaHD.Text) == 0)
                {

                    HoaDon HD = new HoaDon(txtMaHD.Text, Convert.ToInt32(txtMaND.Text), txtMaKH.Text, txtTenKH.Text, txtSDT.Text, Convert.ToInt32(txtTongTien.Text), txtMaGG.Text, Convert.ToInt32(txtThanhTien.Text));
                    HoaDonBLL.Instance.AddHD(HD);
                    //HoaDonBLL.Instance.InsertNC(Convert.ToInt32(txtMaNC.Text));
                    SanPhamBLL.Instance.UpdateSLSP(Convert.ToInt32(txtMaNC.Text), GetSLSPThem());
                    //clearNC();
                    
                }
                else
                {

                    HoaDonBLL.Instance.InsertNC(Convert.ToInt32(txtMaNC.Text));
                    SanPhamBLL.Instance.UpdateSLSP(Convert.ToInt32(txtMaNC.Text), GetSLSPThem());
                }
                int MaCTHD = GetMaCTHD();
                //string query2 = "update ChiTietHoaDon set MaHD='" + txtMaHD.Text + "',SoLuong='" + numSoLuongNC.Value + "',NgayMua='" + DateTime.Now + "' where MaCTHD='" + MaCTHD + "'";
                //DB.EditData(query2);
                HoaDonBLL.Instance.UpdateCTHD(txtMaHD.Text, Convert.ToInt32(numSoLuongNC.Value), MaCTHD);
                ShowDGVChiTietHD();
                TongTien();
            }
        }

        private void dataGridViewHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridViewHD.Rows[e.RowIndex];
                load(row);
                ShowDGVChiTietHD();
                TongTien();

            }
            catch (Exception ex) { };
        }

        private void cbbLoaiNCPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenPK.Items.Clear();
            cbbTenPK.ResetText();
            txtGiaPK.Text = "";
            txtMaPK.Text = "";
            if (cbbLoaiNCPK.SelectedItem.ToString() == "All")
            {
                foreach (DataRow i in HoaDonBLL.Instance.SetCBBSP().Rows)
                {
                    if (Convert.ToInt32(i["MaKieuSP"].ToString()) == 2)
                    {
                        cbbTenPK.Items.Add(i["TenSP"]);
                    }

                }
            }

            foreach (DataRow i in HoaDonBLL.Instance.SetCBBSP().Rows)
            {
                if (Convert.ToInt32(i["MaKieuSP"].ToString()) == 2)
                {
                    if (Convert.ToInt32(i["MaLoaiSP"]) == Convert.ToInt32(((CBBItem)cbbLoaiNCPK.SelectedItem).Value.ToString()))
                    {
                        cbbTenPK.Items.Add(i["TenSP"]);
                    }
                }
            }
        }

        private void cbbTenPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow i in HoaDonBLL.Instance.SetCBBSP().Rows)
            {
                if (i["TenSP"].ToString() == cbbTenPK.SelectedItem.ToString())
                {
                    txtMaPK.Text = i["MaSP"].ToString();
                    txtGiaPK.Text = i["GiaBan"].ToString();
                }
            }
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChiTietHD.SelectedCells[0].OwningRow;
            string ma = row.Cells["MaCTHD"].Value.ToString();
            // TongTienXoa();
            //MessageBox.Show(GetSLNC().ToString());
            //MessageBox.Show(GetSLNCinDGV().ToString());
            //MessageBox.Show(GetMaNC());

            SanPhamBLL.Instance.UpdateSLSP (GetMaSP(), GetSLSPXoa());

            HoaDonBLL.Instance.DeleteCTHD1(ma);
            MessageBox.Show("Xóa thành công");
            ShowDGVChiTietHD();
            TongTien();
        }

        private void txtTimKiemHD_TextChanged(object sender, EventArgs e)
        {
            ShowDGV(txtTimKiemHD.Text);
        }
        public void ShowDGV(string txt)
        {
            if (txt == "") dataGridViewHD.DataSource = HoaDonBLL.Instance.LoadAllHD();
            else dataGridViewHD.DataSource = HoaDonBLL.Instance.LoadSearch(txt);
        }

        private void butXoaHD_Click(object sender, EventArgs e)
        {
            string MaHD;
            if (dataGridViewHD.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewHD.SelectedRows)
                    {
                        MaHD=row.Cells[0].Value.ToString();
                        HoaDonBLL.Instance.DeleteCTHD(MaHD);
                        HoaDonBLL.Instance.DeleteHD(MaHD);
                    }
                    
                    ShowDGVHD();
                    ShowCTHD1(txtMaHD.Text);
                    //clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa");
            }
        }
    }
}