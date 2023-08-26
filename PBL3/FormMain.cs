using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Sender = new mydel1(GetText);
            

        }
        public delegate void mydel1(int MaND,string HoTen);
        public mydel1 Sender; // public Form2()
        private void GetText(int MaND,string HoTen)
        {
            labelMaND.Text = MaND.ToString();
            labelTenND.Text= HoTen.ToString();

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void butKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();
            OpenChildForm(f);
            f.d = new FormKhachHang.OpenForm(OpenChildForm);
            f.Sender2(labelMaND.Text);
        }

        public void butHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            OpenChildForm(f);
            string MaND=labelMaND.Text;
            f.Sender(MaND);
        }

        private void butNhacCu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhacCu());
        }

        private void butPhuKien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhuKien());
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            Close();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void butThongTin_Click(object sender, EventArgs e)
        {
            FormNguoiDung f=new FormNguoiDung();
            
            string MaND = labelMaND.Text;
            f.Sender(MaND);
            OpenChildForm(f);
            //f.LoadDataND();
        }

        private void butDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDoanhThu());
        }
    }
}
