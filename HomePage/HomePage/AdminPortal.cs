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
            HomePage homepage = new HomePage();
            homepage.Show();
        }
    }
}
