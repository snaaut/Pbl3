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
    public partial class FormNguoiDung : Form
    {
        DataBase DB = new DataBase();
        public FormNguoiDung()
        {
            InitializeComponent();
            Sender = new mydel1(GetText);
            string maND = labelMaND.Text;

            ShowData(maND);
        }
        public delegate void mydel1(string maND);
        public mydel1 Sender; // public Form2()
        private void GetText(string MaND)
        {
            labelMaND.Text = MaND;
        }
        private void butXoa_Click(object sender, EventArgs e)
        {
            string MaND = labelMaND.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NguoiDungBLL.Instance.DeleteND(MaND);
                Hide();                FormDangNhap f = new FormDangNhap();
                f.Show();
            }
        }
        private void ShowData(string MaND)
        {
            //string MaND = labelMaND.Text;
            //txtTenND.Text = MaND;
            txtTenND.Text = NguoiDungBLL.Instance.GetHoTenByMaND(MaND);
            txtTenDangNhap.Text = NguoiDungBLL.Instance.GetTenDangNhapByMaND(MaND);
            txtDiaChi.Text = NguoiDungBLL.Instance.GetDiaChiByMaND(MaND);
            txtCMND.Text = NguoiDungBLL.Instance.GetCMNDByMaND(MaND);
            guna2DateTimePicker1.Text = NguoiDungBLL.Instance.GetNgaySinhByMaND(MaND);
            checkBoxNam.Checked = NguoiDungBLL.Instance.GetGioiTinhByMaND(MaND);
            if (checkBoxNam.Checked == false)
            {
                checkBoxNu.Checked = true;
            }

            txtEmail.Text = NguoiDungBLL.Instance.GetEmailByMaND(MaND);
            //  txtMatKhau.Text = NguoiDungBLL.Instance.GetMatKhauByMaND(MaND);
            txtSDT.Text = NguoiDungBLL.Instance.GetSDTByMaND(MaND);

        }
        public void Clear()
        {
            txtTenND.Text ="";
            txtTenDangNhap.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            guna2DateTimePicker1.Text = "";
            //checkBoxNam.Checked = NguoiDungBLL.Instance.GetGioiTinhByMaND(MaND);
            //if (checkBoxNam.Checked == false)
            //{
            //    checkBoxNu.Checked = true;
            //}

            txtEmail.Text = "";
            //  txtMatKhau.Text = NguoiDungBLL.Instance.GetMatKhauByMaND(MaND);
            txtSDT.Text = "";
        }




        private void labelMaND_Click(object sender, EventArgs e)
        {
            string maND = labelMaND.Text;
            ShowData(maND);
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            string maND = labelMaND.Text;
            ShowData(maND);
        }

        private void butHideMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == false)
            {
                butViewMK.BringToFront();
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.PasswordChar = '●';
            }
        }

        private void butHideMKM_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.UseSystemPasswordChar == false)
            {
                butViewMKM.BringToFront();
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtMatKhauMoi.PasswordChar = '●';
            }
        }

        private void butHideNLMK_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.UseSystemPasswordChar == false)
            {
                butViewNLMK.BringToFront();
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.PasswordChar = '●';
            }
        }

        private void butViewMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                butHideMK.BringToFront();
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void butViewMKM_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.UseSystemPasswordChar == true)
            {
                butHideMKM.BringToFront();
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtMatKhauMoi.PasswordChar = '\0';
            }
        }

        private void butViewNLMK_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.UseSystemPasswordChar == true)
            {
                butHideNLMK.BringToFront();
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
        }

        private void butDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại");
            }
            else
            {
                if (NguoiDungBLL.Instance.CheckLogin(txtTenDangNhap.Text, txtMatKhau.Text) == false)
                {
                    MessageBox.Show("Mật khẩu cũ chưa chính xác. Vui lòng nhập lại");
                }
                else
                {
                    string MaND = labelMaND.Text;
                    string MatKhauMoi = txtMatKhauMoi.Text;

                    //string HoTen = txtTenND.Text;
                    //string SDT = txtSDT.Text;
                    //string DiaChi = txtDiaChi.Text;
                    //string CMND = txtCMND.Text;
                    //bool GioiTinh = checkBoxNam.Checked;
                    //DateTime NgaySinh = guna2DateTimePicker1.Value;
                    //string Email = txtEmail.Text;
                    //string TenDangNhap = txtTenDangNhap.Text;
                    //string MatKhau = txtMatKhau.Text;
                    //string MatKhauMoi = txtMatKhauMoi.Text;            
                    //txtEmail.Enabled = false;
                    //txtTenDangNhap.Enabled = false;
                    //NguoiDung ND = new NguoiDung(MaND, HoTen, SDT, DiaChi, CMND, GioiTinh, NgaySinh, Email, TenDangNhap, MatKhauMoi);
                    //NguoiDungBLL.Instance.UpdateND(ND);
                    NguoiDungBLL.Instance.UpdatePass(MaND, MatKhauMoi);
                    MessageBox.Show("Đổi mật khẩu thành công!");

                }

            }


        }

        private void checkBoxNam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNam.Checked == false)
            {
                checkBoxNu.Checked = true;
            }
            else
            {
                checkBoxNu.Checked = false;
            }
        }

        private void checkBoxNu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNu.Checked == false)
            {
                checkBoxNam.Checked = true;
            }
            else
            {
                checkBoxNam.Checked = false;
            }
        }

       

        private void butCapNhat_Click_1(object sender, EventArgs e)
        {
            string MaND = labelMaND.Text;
            string HoTen = txtTenND.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            string CMND = txtCMND.Text;
            bool GioiTinh = checkBoxNam.Checked;
            DateTime NgaySinh = guna2DateTimePicker1.Value;
            string Email = txtEmail.Text;
            string TenDangNhap = txtTenDangNhap.Text;
            //  string MatKhau = txtMatKhau.Text;
            txtEmail.Enabled = false;
            txtTenDangNhap.Enabled = false;
            //NguoiDung ND = new NguoiDung(MaND, HoTen, SDT, DiaChi, CMND, GioiTinh, NgaySinh, Email, TenDangNhap, MatKhau);
            NguoiDungBLL.Instance.UpdateND(MaND, HoTen, SDT, DiaChi, CMND, GioiTinh, NgaySinh, Email, TenDangNhap);
            MessageBox.Show("Cập nhật thông tin thành công!");

        }
    }
}
