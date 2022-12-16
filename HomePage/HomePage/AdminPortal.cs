using HomePage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class AdminPortal : Form
    {
        
        public AdminPortal()
        {
            InitializeComponent();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = context.Set<CustomerInfo>().ToList();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = context.Set<CustomerInfo>().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = context.Set<HotelRooms>().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = context.Set<HotelReservations>().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homepage = new Form1();
            homepage.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int cellID;
            bool validInput = true;
        
            var reservation = new HotelReservations();
            try
            {
                cellID = int.Parse(dataGridView1.CurrentCell.Value.ToString());
            }
            catch(Exception ex) 
            {
                label1.Visible = true;
                label1.Text = "Please select the reservationID to cancel a reservation"; 
                validInput = false;
            }
            if (validInput) 
            {
                label1.Visible = true;
                cellID = int.Parse(dataGridView1.CurrentCell.Value.ToString());
                var context = new MyDBContext();
                bool reservationData = context.Set<HotelReservations>().Any(m => m.reservationID == cellID);
                if (reservationData) 
                { 
                    reservation.reservationID = cellID;
                    context.Remove(reservation);
                    context.SaveChanges();
                    label1.Text = "Reservation has been removed"; 
                }
            }
            
        }
    }
}
