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
    public partial class FormResetMK2 : Form
    {
        public FormResetMK2()
        {
            InitializeComponent();
        }

        private void butDangNhap_Click(object sender, EventArgs e)
        {
            string otp = txtcode.Text;
            if (NguoiDungBLL.Instance.CheckOTP(otp))
            {

                FormResetMK3 f = new FormResetMK3();
                f.Show();
                Hide();
            }
            else
            {
                labelfail.Text = "Mã bảo mật không chính xác. Thử lại.";
                txtcode.Text = "";
            }
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormResetMK f = new FormResetMK();
            f.Show();
            Hide();
        }

       
    }
}
