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
using System.Xml.Linq;
using static HomePage.Program;

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
            
            newCus.CustomerID = CustID.custID;
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
            ///
            this.Hide();
            Confirmation Conf = new Confirmation();
            Conf.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void Exp_ValueChanged(object sender, EventArgs e)
        {
            setButtonVisibility();

            Exp.Format = DateTimePickerFormat.Custom;
            Exp.CustomFormat = "MM yyyy";
        }

        private void setButtonVisibility()
        {
            if ((fName.Text != String.Empty) && (LastName.Text != String.Empty) && 
                (Email.Text != String.Empty) && (Phone.Text != String.Empty) && 
                (Country.Text != String.Empty) && (zipCode.Text != String.Empty) &&
                (Address1.Text != String.Empty) && (Address2.Text != String.Empty) &&
                (City.Text != String.Empty) && (State.Text != String.Empty) &&
                (cardNumber.Text != String.Empty) && (nameCC.Text != String.Empty) &&
                (cVV.Text != String.Empty))

            {
                btn_cr.Enabled = true;
            }
            else
            { btn_cr.Enabled = false; }

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void Country_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void zipCode_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void Address1_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void Address2_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void City_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void State_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void cardNumber_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void nameCC_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void cVV_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            
        }
    }
}
