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
using System.Net.Mail;
using static HomePage.Program;
using Microsoft.EntityFrameworkCore.Scaffolding;
using FluentEmail.Core;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace HomePage
{
    public partial class Reservation_Completed : Form
    {
        public Reservation_Completed()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        private void label3_Click(object sender, EventArgs e)
        {
            //var context = new MyDBContext();
            //var reservationNum = context.Set<HotelReservations>().FirstOrDefault(m => m.reservationID == CustID.HotelReservationID);
            //label3.Text = reservationNum.reservationID.ToString();
        }

        private void Reservation_Completed_Load(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            var reservationNum = context.Set<HotelReservations>().FirstOrDefault(m => m.reservationID == CustID.HotelReservationID);
            var emailInfo = context.Set<CustomerInfo>().FirstOrDefault(m => m.CustomerID == CustID.custID);
            
            label3.Text = reservationNum.reservationID.ToString();
            label5.Text = emailInfo.Email;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("hotelwebsite07@gmail.com");
                mail.To.Add(label5.Text);
                mail.Subject = "Test Sending Mail";
                mail.Body = "<h1> This is body </h1>";
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
    }
}
