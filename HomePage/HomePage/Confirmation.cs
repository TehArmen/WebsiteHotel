using HomePage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace HomePage
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent(); 
           
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            var context = new MyDBContext();
            var customerInfo = context.Set<CustomerInfo>().FirstOrDefault(m => m.CustomerID == 389);

            firstName.Text = customerInfo.FirstName;
            lastName.Text = customerInfo.LastName;
            email.Text = customerInfo.Email;
            phoneNumber.Text = customerInfo.Phone.ToString();
            country.Text = customerInfo.Country;
            zipCode.Text = customerInfo.zipCode.ToString();
            address1.Text = customerInfo.Address1;
            address2.Text = customerInfo.Address2;
            city.Text = customerInfo.City;
            state.Text = customerInfo.State;
            cardNumber.Text = customerInfo.cardNumber.ToString();
            date.Text = customerInfo.Exp;
            cvv.Text = customerInfo.Cvv.ToString();
            nameOnCard.Text = customerInfo.nameCC;

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            label18.Text = Program.CustID.custID.ToString();
        }
        private void btn_confirmation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation_Completed Conf = new Reservation_Completed();
            Conf.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                btn_confirmation.Enabled = true;
            }
            else
            { btn_confirmation.Enabled = false; }

        }
        };
    }
