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
            //var credentials = context.Set<CustomerInfo>().FirstOrDefault(m => m.CustomerID == 192);
            dataGridView1.DataSource = context.Set<CustomerInfo>().ToList();

            

        }
    }
}
