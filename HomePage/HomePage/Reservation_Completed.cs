using HomePage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using HomePage.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using static HomePage.Program;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore.Scaffolding;
=======
>>>>>>> parent of fb4442a (Admin and Reservation edits)

namespace HomePage
{
    public partial class Reservation_Completed : Form
    {
        public Reservation_Completed()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void Reservation_Completed_Load(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            var cusInfo = context.Set<CustomerInfo>().FirstOrDefault(m => m.CustomerID == CustID.custID);

            codeConf.Text = cusInfo.CustomerID.ToString();
            email.Text = cusInfo.Email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var context = new MyDBContext();
            var emailInfo = context.Set<CustomerInfo>().FirstOrDefault(m => m.CustomerID == CustID.custID);

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("hotelwebsite07@gmail.com");
                mail.To.Add(emailInfo.Email);
                mail.Subject = "Test Sending Mail";
                mail.Body = "<h1> This is 2nd copy </h1>";
                mail.IsBodyHtml = true;

                using System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("hotelwebsite07@gmail.com", "tjexthsrlruaetgl");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
   
        }
=======
>>>>>>> parent of fb4442a (Admin and Reservation edits)
    }
}
