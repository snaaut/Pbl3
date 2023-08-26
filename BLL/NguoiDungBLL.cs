using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguoiDungBLL
    {
        public static NguoiDungBLL _instance;
        public static NguoiDungBLL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NguoiDungBLL();
                return _instance;
            }
            set { }
        }
        private static readonly string _from = "nhaccuptl@gmail.com"; // Email của Sender (của bạn)
        private static readonly string _pass = "mfkrdeplkcdnuhro"; // Mật khẩu Email của Sender (của bạn)
        private static string content;
        public string email_employee { get; set; }
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void AddND(NguoiDungNoMaND ND)
        {
            NguoiDungDAL.Instance.AddND(ND);
        }
        public bool CheckLogin(string TenDangNhap, string MatKhau)
        {
            return (NguoiDungDAL.Instance.CheckLogin(TenDangNhap, MatKhau));
        }
        public bool CheckAdd(NguoiDungNoMaND ND)
        {
            return NguoiDungDAL.Instance.CheckAdd(ND);
        }
        public bool CheckTenDangNhap(NguoiDungNoMaND ND)
        {
            return NguoiDungDAL.Instance.CheckTenDangNhap(ND);
        }
        public bool CheckSDT(NguoiDungNoMaND ND)
        {
            return NguoiDungDAL.Instance.CheckSDT(ND);
        }
        public bool CheckEmail(NguoiDungNoMaND ND)
        {
            return NguoiDungDAL.Instance.CheckEmail(ND);
        }
        public int GetMaND(string TenDangNhap)
        {
            return NguoiDungDAL.Instance.GetMaND(TenDangNhap);
        }
        public string GetHoTen(string TenDangNhap)
        {
            return NguoiDungDAL.Instance.GetHoTen(TenDangNhap);
        }

        public bool CheckOTP(string otp)
        {
            if (otp == content) return true;
            return false;
        }
        public string GetEmail(string email)
        {
            return NguoiDungDAL.Instance.GetEmail(email);
        }
        public void SendEmail(string email, string content, string subject)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(_from);
            mail.To.Add(email_employee);
            mail.IsBodyHtml = true;
            mail.Body = content;
            mail.Subject = subject;
            mail.Priority = MailPriority.High;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        public string CheckAndSendMailToReset(string email)
        {
            //if (GetEmail(email)) return "Email không hợp lệ! Địa chỉ email chưa được đăng ký!";
            string check = NguoiDungDAL.Instance.CheckMailToReset(email);
            email_employee = email;
            content = RandomNumber(99999, 1000000).ToString();
            string NoiDung = "<p>Xin chào,<p> <p>Để xác nhận tài khoản, vui lòng nhập mã OTP sau:  " + content + "<p>"
                + "<p>Sau khi xác nhận gmail bạn tiếp tục bổ sung đầy đủ các thông tin và Chọn Đổi mật khẩu.<p>"
                + " <p>Cảm ơn bạn đã sử dụng dịch vụ của Nhạc cụ PTL<p>";
            SendEmail(email_employee, NoiDung,"YÊU CẦU ĐẶT LẠI MẬT KHẨU");
            return check;
        }
        public bool CheckMailToDangKy(string email)
        {
            return NguoiDungDAL.Instance.CheckMailToDangKy(email);
        }
        public string SendMailToDangky(string email)
        {
            string check = NguoiDungDAL.Instance.CheckMailToReset(email);
            email_employee = email;
            content = RandomNumber(99999, 1000000).ToString();
            string NoiDung = "<p>Xin chào,<p> <p>Để xác nhận tài khoản, vui lòng nhập mã OTP sau:  " + content + "<p>"
                + "<p>Sau khi xác nhận gmail bạn tiếp tục bổ sung đầy đủ các thông tin và Chọn Đăng ký.<p>"
                + " <p>Cảm ơn bạn đã sử dụng dịch vụ của Nhạc cụ PTL<p>";
            //content = RandomNumber(99999, 1000000).ToString();
            SendEmail(email_employee, NoiDung, "YÊU CẦU XÁC NHẬN ĐĂNG KÝ TÀI KHOẢN");
            return check;
        }
        public string ResetPass(string newpass)
        {
            return NguoiDungDAL.Instance.ResetPass(newpass, email_employee);
        }
        public string DeleteND(string MaND)
        {
            return NguoiDungDAL.Instance.DeleteND(MaND);
        }
        public string UpdateND(string MaND, string HoTen, string SDT, string DiaChi, string CMND, bool GioiTinh, DateTime NgaySinh, string Email, string TenDangNhap)

        {
            return NguoiDungDAL.Instance.UpdateND(MaND, HoTen, SDT, DiaChi, CMND, GioiTinh, NgaySinh, Email, TenDangNhap);
        }
        public string UpdatePass(string MaND, string MatKhau)
        {
            return NguoiDungDAL.Instance.UpdatePass(MaND, MatKhau);
        }
        public string GetHoTenByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetHoTenByMaND(MaND);
        }
        public string GetSDTByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetSDTByMaND(MaND);
        }
        public string GetEmailByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetEmailByMaND(MaND);
        }
        public string GetTenDangNhapByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetTenDangNhapByMaND(MaND);
        }
        public string GetMatKhauByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetMatKhauByMaND(MaND);
        }
        public string GetDiaChiByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetDiaChiByMaND(MaND);
        }
        public string GetCMNDByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetCMNDByMaND(MaND);
        }
        public string GetNgaySinhByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetNgaySinhByMaND(MaND);
        }
        public bool GetGioiTinhByMaND(string MaND)
        {
            return NguoiDungDAL.Instance.GetGioiTinhByMaND(MaND);
        }
    }
}
