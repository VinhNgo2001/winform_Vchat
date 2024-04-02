using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace testLogin
{
    public partial class Form_forgotps : Form
    {
        public Form_forgotps()
        {
            InitializeComponent();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Mật khẩu đã được gửi về Email của bạn!!!");
        }
        public void SendEmail(string toAddress, string subject, string body)
        {
            string fromAddress = "your_email@example.com";
            string fromPassword = "your_email_password";

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.example.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress, fromPassword)
            };

            MailMessage mail = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            smtp.Send(mail);
        }
    }
}
