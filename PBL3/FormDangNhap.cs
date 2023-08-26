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
namespace PBL3
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void buttoneyes1_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                butHideMK.BringToFront();
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void butDangKy_Click(object sender, EventArgs e)
        {
            Hide();
            FormDangKy f = new FormDangKy();
            f.Show();
        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;
            if (!NguoiDungBLL.Instance.CheckLogin(TenDangNhap, MatKhau))
            {
                MessageBox.Show("Tên Đăng Nhập hoặc Mặt Khẩu không hợp lệ!");
            }
            else
            {
                int MaND=GetMaND(TenDangNhap);
                string HoTen=GetHoTen(TenDangNhap);
                MessageBox.Show("Đăng nhập thành công!");
                Hide();
                FormMain f = new FormMain();
                f.Sender(MaND,HoTen);
                f.Show();
            }

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
        public int GetMaND(string TenDangNhap)
        {
            return NguoiDungBLL.Instance.GetMaND(TenDangNhap);
        }
        public string GetHoTen(string TenDangNhap)
        {
            return NguoiDungBLL.Instance.GetHoTen(TenDangNhap);
        }
        

        private void lbQuenMK_Click(object sender, EventArgs e)
        {
            FormResetMK f = new FormResetMK();
            f.Show();
            Hide();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
