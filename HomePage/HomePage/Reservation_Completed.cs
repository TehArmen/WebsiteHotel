using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using static HomePage.Program;

namespace HomePage
{
    public partial class Reservation_Completed : Form
    {
        public Reservation_Completed()
        {
            InitializeComponent();
        }

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
            label3.Visible = true; 
            label3.Text = reservationNum.reservationID.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
