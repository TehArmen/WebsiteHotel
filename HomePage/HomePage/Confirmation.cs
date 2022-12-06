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
            var customerInfo = context.Set<CustomerInfo>().FirstOrDefault(m => m.CustomerID == 155);

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
    }
}
