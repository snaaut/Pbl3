using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;


namespace PBL3
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            txtcode.Enabled = false;
        }
        
        private void butDangKy_Click(object sender, EventArgs e)
        {
            NguoiDungNoMaND ND = new NguoiDungNoMaND(txtHoTen.Text, txtSDT.Text,txtDiaChi.Text,txtCMND.Text,CheckboxNam.Checked,DatetimeNgaySinh.Value, txtemail.Text, txtTenDangNhap.Text, txtMatKhau.Text);

            string HT = txtHoTen.Text;
            string SDT = txtSDT.Text;
            string Email = txtemail.Text;
            string TDN = txtTenDangNhap.Text;
            string MK = txtMatKhau.Text;
            string DiaChi=txtDiaChi.Text;
            string CMND = txtCMND.Text;
            DateTime NgaySinh = DatetimeNgaySinh.Value;
            bool GioiTinh = CheckboxNam.Checked;
            if (txtHoTen.Text.Length == 0 || txtSDT.Text.Length == 0|| txtemail.Text.Length == 0 || txtTenDangNhap.Text.Length == 0 || txtMatKhau.Text.Length == 0 || txtNhapLaiMatKhau.Text.Length == 0||txtDiaChi.Text.Length==0||txtCMND.Text.Length==0)
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin!");
            }
            else
            {
                if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp!");
                }
                else
                {
                    if (NguoiDungBLL.Instance.CheckTenDangNhap(ND))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    }
                    else
                    {
                        if (NguoiDungBLL.Instance.CheckSDT(ND))
                        {
                            MessageBox.Show("Số điện thoại đã được sử dụng!");
                        }
                        else
                        {
                            if(txtcode.Text.Length == 0)
                            {
                                MessageBox.Show("Vui lòng xác thực Email của bạn!");
                            }
                            else
                            {
                                {
                                    NguoiDungBLL.Instance.AddND(ND);
                                    MessageBox.Show("Chúc mừng bạn đăng kí tài khoản thành công!");
                                    FormDangNhap f = new FormDangNhap();
                                    f.Show();
                                    Hide();
                                }
                            }
                        }    
                    }
                }
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

        private void butViewNLMK_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.UseSystemPasswordChar == true)
            {
                butHideNLMK.BringToFront();
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.PasswordChar = '\0';
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

        private void butHideNLMK_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMatKhau.UseSystemPasswordChar == false)
            {
                butViewNLMK.BringToFront();
                txtNhapLaiMatKhau.UseSystemPasswordChar = true;
                txtNhapLaiMatKhau.PasswordChar = '●';
            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string sendto = txtemail.Text;

            if(txtemail.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Email để xác thực!");
            }
            else
            {
                if (NguoiDungBLL.Instance.CheckMailToDangKy(sendto))
                {
                    MessageBox.Show("Email của bạn đã tồn tại.Vui lòng nhập lại Email khác! ");
                }
                else
                {
                    txtcode.Enabled = true;
                    string checkemail;
                    checkemail = NguoiDungBLL.Instance.SendMailToDangky(sendto);
                    MessageBox.Show("Gửi mã xác thực thành công");
                }
            } 
                
        }

        private void butXnMa_Click(object sender, EventArgs e)
        {
            string otp = txtcode.Text;
            if (NguoiDungBLL.Instance.CheckOTP(otp))
            {
               MessageBox.Show( "Xác thực Email thành công!");
                
            }
            else
            {
                MessageBox.Show("Mã bảo mật không chính xác!Thử lại!");
                txtcode.Text = "";
            }
        }

        private void CheckboxNam_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxNam.Checked == false)
            {
                CheckboxNu.Checked = true;
            }
            else
            {
                CheckboxNu.Checked = false;
            }
        }

        private void CheckboxNu_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxNu.Checked == false)
            {
                CheckboxNam.Checked = true;
            }
            else
            {
                CheckboxNam.Checked = false;
            }
        }

        //private void txtHoTen_TextChanged(object sender, EventArgs e)
        //{
        //    NguoiDungNoMaND ND = new NguoiDungNoMaND(txtHoTen.Text, txtSDT.Text, txtemail.Text, txtTenDangNhap.Text, txtMatKhau.Text);
        //    if (NguoiDungBLL.Instance.CheckTenDangNhap(ND))
        //    {
        //        MessageBox.Show("Tên đăng nhập đã tồn tại!");
        //    }
        //}
    }
}
