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
    public partial class FormResetMK3 : Form
    {
        public FormResetMK3()
        {
            InitializeComponent();
        }

        private void buttoneyes2_Click(object sender, EventArgs e)
        {
            if (txtnewpass.UseSystemPasswordChar == false)
            {
                buttoneyes1.BringToFront();
                txtnewpass.UseSystemPasswordChar = true;
                txtnewpass.PasswordChar = '●';
            }
        }

        private void buttoneyes1_Click(object sender, EventArgs e)
        {
            if (txtnewpass.UseSystemPasswordChar == true)
            {
                buttoneyes2.BringToFront();
                txtnewpass.UseSystemPasswordChar = false;
                txtnewpass.PasswordChar = '\0';

            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormResetMK2 f = new FormResetMK2();
            f.Show();
            Hide();
        }

        private void butThaydoiMK_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text != txtconfirmpass.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp! Vui lòng nhập lại!");
            }    
            else
            {
                NguoiDungBLL.Instance.ResetPass(txtnewpass.Text);
                FormDangNhap f = new FormDangNhap();
                f.Show();
                Hide();
            }    
        }
    }
}
