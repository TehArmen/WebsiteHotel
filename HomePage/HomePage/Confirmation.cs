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
using static HomePage.Program;


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
            var customerInfo = context.Set<CustomerInfo>().FirstOrDefault(m => m.CustomerID == CustID.custID);

            firstName.Text = customerInfo.FirstName;
            lastName.Text = customerInfo.LastName;
            email.Text = customerInfo.Email;
            phoneNumber.Text = customerInfo.Phone;
            country.Text = customerInfo.Country;
            zipCode.Text = customerInfo.zipCode;
            address1.Text = customerInfo.Address1;
            address2.Text = customerInfo.Address2;
            city.Text = customerInfo.City;
            state.Text = customerInfo.State;
            cardNumber.Text = customerInfo.cardNumber;
            date.Text = customerInfo.Exp;
            cvv.Text = customerInfo.Cvv;
            nameOnCard.Text = customerInfo.nameCC;

        }

        private void lastName_Click(object sender, EventArgs e)
        {

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
