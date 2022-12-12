using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage.Models;
using static HomePage.Program;

namespace HomePage
{
    public partial class Rooms : Form
    {

        public Rooms()
        {
            InitializeComponent();
            
        }

         public string checkInDate;
         public string checkOutDate;
         public string roomAmount;
         public string roomType;
        

        private void Rooms_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            CustID.HotelroomID = rnd.Next(999);
            CustID.custID = rnd.Next(999);
            CustID.HotelReservationID = rnd.Next(999);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           checkInDate = dateTimePicker1.Text;
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "kingBed";
            queenBed.Checked = false;
            twoqueenBeds.Checked = false;
            twoTwinBeds.Checked = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            checkOutDate = dateTimePicker2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            bool checkInExists = context.Set<HotelRooms>().Any(r => r.checkIn == checkInDate);
            bool checkOutExists = context.Set<HotelRooms>().Any(r => r.checkOut == checkOutDate);
            if( checkInExists && checkOutExists == true)
            {
                var bedtype = context.Set<HotelRooms>().First(b => b.checkIn == checkInDate);
                label11.Text = "This " + bedtype.roomType + " is not available ";
                label11.Visible = true;
                 
            }
            else 
            { 
                label11.Visible = false;
                label11.Text = "All Rooms are available";
                label11.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomAmount = comboBox1.Text;
            
        }

        private void bookNow_Click(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            var roomDataBase = new HotelRooms();
            roomDataBase.roomType = roomType;
            roomDataBase.roomAmount = roomAmount;
            roomDataBase.checkOut = checkOutDate;
            roomDataBase.checkIn = checkInDate;
            roomDataBase.roomID = CustID.HotelroomID;
            context.Set<HotelRooms>().Add(roomDataBase);
            context.SaveChanges();
            this.Hide();
            checkout_page checkOutPage = new checkout_page();
            checkOutPage.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomAmount = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomAmount= comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomAmount= comboBox4.Text;
        }

        private void queenBed_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "queenBed";
            kingBed.Checked = false;
            twoqueenBeds.Checked = false;
            twoTwinBeds.Checked = false;
           
           
        }

        private void twoqueenBeds_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "queenBeds";
            kingBed.Checked = false;
            queenBed.Checked = false;
            twoTwinBeds.Checked = false;

        }

        private void twoTwinBeds_CheckedChanged(object sender, EventArgs e)
        {
            roomType = "twinBeds";
            kingBed.Checked = false;
            queenBed.Checked = false;
            twoqueenBeds.Checked = false;
        }

      
    }
}
