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
            var customerInfo = context.Set<Customer>().FirstOrDefault(m => m.customerID == 123);

            firstName.Text = customerInfo.firstName;
            lastName.Text = customerInfo.lastName;
            email.Text = customerInfo.email;
            phoneNumber.Text = customerInfo.phoneNumber.ToString();
            country.Text = customerInfo.country;
            zipCode.Text = customerInfo.zipCode.ToString();
            address1.Text = customerInfo.firstAddress;
            address2.Text = customerInfo.secondAddress;
            city.Text = customerInfo.city;
            state.Text = customerInfo.country;
            cardNumber.Text = customerInfo.cardNumber.ToString();
            date.Text = customerInfo.expMonth;
            cvv.Text = customerInfo.cvv.ToString();
            nameOnCard.Text = customerInfo.nameOnCard;

        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }
    }
}
