using System.Data.SqlClient;
using HomePage.Models;

namespace HomePage
{
  
    public partial class Form1 : Form
    {

       
        public Form1()
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Hide();
            Rooms roomPage = new Rooms();
            roomPage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //serverConnect.Open();
            //string firstName = "Zed";
            //string query = "UPDATE EmployeeINFO SET FirstName = '"+firstName+"' WHERE EmployeeID = 1001";
            //cmd = new SqlCommand(query,serverConnect);
            //cmd.ExecuteNonQuery();
            //serverConnect.Close();

            //var context = new MyDBContext();
            //var employeeInfo = context.Set<Customer>().First(m => m.CustomerID == 1001);
            //employeeInfo.firstName = "Jeremy";
            //context.SaveChanges();  

            //var abe = new EmployeeINFO();
            //abe.EmployeeID = 69;
            //abe.FirstName = "Zero";
            //abe.LastName = "Requiem";
            //context.Set<EmployeeINFO>().Add(abe);
            //context.SaveChanges();

            //context.Set<Customer>().Remove(employeeInfo);
            //context.SaveChanges();
            


        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage= new LoginPage();
            loginPage.Show();
        }
    }
}