using System.Data.SqlClient;
using HomePage.Models;

namespace HomePage
{
  
    public partial class HomePage : Form
    {

       
        public HomePage()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Confirmation confirmpage = new Confirmation();
            confirmpage.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rooms roomPage = new Rooms();
            this.Hide();
            roomPage.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage= new LoginPage();
            loginPage.Show();
        }
    }
}