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
    public partial class FormResetMK : Form
    {
        public FormResetMK()
        {
            InitializeComponent();
        }

        private void gunaback_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            Hide();
        }

        private void butGuimaEmail_Click(object sender, EventArgs e)
        {
            string sendto = txtemail.Text;
            string checkemail;
            checkemail = NguoiDungBLL.Instance.CheckAndSendMailToReset(sendto);
            FormResetMK2 f = new FormResetMK2();
            f.Show();
            Hide();
        }
    }
}
