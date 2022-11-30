using System.Data.SqlClient;
using HomePage.Models;

namespace HomePage
{
  
    public partial class Form1 : Form
    {

        SqlConnection serverConnect;
        string path = "Data Source =DESKTOP-UDAJ3HN\\SQLEXPRESS;Initial Catalog= Test_base;Integrated Security =True";
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            serverConnect = new SqlConnection(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            //serverConnect.Open();
            //string firstName = "Zed";
            //string query = "UPDATE EmployeeINFO SET FirstName = '"+firstName+"' WHERE EmployeeID = 1001";
            //cmd = new SqlCommand(query,serverConnect);
            //cmd.ExecuteNonQuery();
            //serverConnect.Close();

            var context = new MyDBContext();
            var employeeInfo = context.Set<EmployeeINFO>().First(m => m.EmployeeID == 1001);
            employeeInfo.FirstName = "Jeremy";
            context.SaveChanges();  

            //var abe = new EmployeeINFO();
            //abe.EmployeeID = 69;
            //abe.FirstName = "Zero";
            //abe.LastName = "Requiem";
            //context.Set<EmployeeINFO>().Add(abe);
            //context.SaveChanges();

            context.Set<EmployeeINFO>().Remove(employeeInfo);
            context.SaveChanges();
            


        }
    }
}