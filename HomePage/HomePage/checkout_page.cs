using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HomePage.Models;

namespace HomePage
{
    public partial class checkout_page : Form
    {   

        public checkout_page()
        {
            InitializeComponent();
        }

        private void checkout_page_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_goback_Click(object sender, EventArgs e)
        {

        }

        private void btn_cr_Click(object sender, EventArgs e)
        {
            var context = new MyDBContext();

            var newCus = new CustomerInfo();
            Random rnd = new Random();

            newCus.CustomerID = rnd.Next(999);
            newCus.FirstName = fName.Text;
            newCus.LastName = LastName.Text;
            newCus.Email = Email.Text;
            newCus.Phone = Phone.Text;
            newCus.Country = Country.Text;
            newCus.zipCode = zipCode.Text;
            newCus.Address1 = Address1.Text;
            newCus.Address2 = Address2.Text;
            newCus.City = City.Text;
            newCus.State = State.Text;

            newCus.cardNumber = cardNumber.Text;
            newCus.Exp = Exp.Text;
            newCus.nameCC = nameCC.Text;
            newCus.Cvv = cVV.Text;

            context.Set<CustomerInfo>().Add(newCus);
            context.SaveChanges();

            //var context = new MyDBContext();
            //var customerInfo = context.Set<CustomerInfo>().First(m => m.CustomerID == m.ID);
            //customerInfo.fname = fName.Text;
            //context.SaveChanges();
            ////MessageBox.Show(fName.Text.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exp_ValueChanged(object sender, EventArgs e)
        {
            Exp.Format = DateTimePickerFormat.Custom;
            Exp.CustomFormat = "MM yyyy";
        }
    }
}
