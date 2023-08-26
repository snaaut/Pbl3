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
using DTO;
using DAL;

namespace PBL3
{
    public partial class FormNhacCu : Form
    {
        public FormNhacCu()
        {
            InitializeComponent();
            ShowDGV();
            SetCBBSP();
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = SanPhamBLL.Instance.LoadAllNC();
        }
        public void ShowDGV(string txt)
        {
            if (txt == "All") dataGridView1.DataSource = SanPhamBLL.Instance.LoadAllNC();
            else dataGridView1.DataSource = SanPhamBLL.Instance.LoadSearchSP(txt);

        }
        public void clear()
        {
            // txtMaSP.Text = "";
            cbbLoaiSP.SelectedIndex = -1;
            txtTenNC.Text = "";
            numSoLuongNC.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtTGBH.Text = "";
        }

        public void SetCBBSP()
        {
            foreach (DataRow i in SanPhamBLL.Instance.SetCBB().Rows)
            {
              //  MessageBox.Show(i["MaLoaiSP"].ToString());
                cbbLoaiSP.Items.Add(new CBBItem
                {
                    Value = Convert.ToInt32(i["MaLoaiSP"].ToString()),
                    Text = i["TenLoaiSP"].ToString()
                });
            }
        }
       

        //private void butXoaNC_Click_1(object sender, EventArgs e)
        //{
        //    //List<int> MaSP = new List<int>();
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
        //        if (dr == DialogResult.Yes)
        //        {
        //            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        //            {
        //                 int MaSP=(Convert.ToInt32(row.Cells[0].Value.ToString()));
        //                NhacCuBLL.Instance.DeleteNC(MaSP);
        //            }
        //            ShowDGV();
        //            clear();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn hàng để xóa");
        //    }
        //}

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtTenNC.Text = row.Cells[1].Value.ToString();
                cbbLoaiSP.Text = row.Cells[3].Value.ToString();
                numSoLuongNC.Text = row.Cells[4].Value.ToString();
                //numSoLuongSP.Text = row.Cells[3].Value.ToString();
                txtGiaNhap.Text = row.Cells[5].Value.ToString();
                txtGiaBan.Text = row.Cells[6].Value.ToString();
                txtTGBH.Text = row.Cells[7].Value.ToString();


                //txtMaSP.Enabled = false;
            }
        }

        private void butThemNC_Click(object sender, EventArgs e)
        {
            if (cbbLoaiSP.Text.Length == 0 || txtTenNC.Text.Length == 0||txtGiaBan.Text.Length==0||txtGiaNhap.Text.Length==0)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                SanPham SP = new SanPham(txtTenNC.Text, 1, Convert.ToInt32(((CBBItem)cbbLoaiSP.SelectedItem).Value.ToString()), Convert.ToInt32(numSoLuongNC.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtTGBH.Text));
                SanPhamBLL.Instance.AddSP(SP);
                MessageBox.Show("Thêm thành công");
                ShowDGV();
                clear();

            }
        }
        public int GetMaSP()
        {
            DataGridViewRow row = dataGridView1.SelectedCells[0].OwningRow;
            int ma = Convert.ToInt32(row.Cells["MaSP"].Value.ToString());
            return ma;
        }

        private void butSuaNC_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SanPham SP = new SanPham(txtTenNC.Text, 1, Convert.ToInt32(((CBBItem)cbbLoaiSP.SelectedItem).Value.ToString()), Convert.ToInt32(numSoLuongNC.Text), Convert.ToInt32(txtGiaNhap.Text), Convert.ToInt32(txtGiaBan.Text), Convert.ToInt32(txtTGBH.Text));
                SanPhamBLL.Instance.UpdateSP(SP,GetMaSP());
                ShowDGV();
                MessageBox.Show("Sửa thành công");
                clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhạc cụ cần sửa");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowDGV(txtSearch.Text);
        }
    }
}
