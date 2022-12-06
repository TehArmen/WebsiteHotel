namespace HomePage.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int cardNumber { get; set; }

        public string nameOnCard { get; set; }

        public int cvv { get; set; }

        public string expMonth { get; set; }
        public string email { get; set; }

        public string firstAddress { get; set; }

        public string secondAddress { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int zipCode { get; set; }
        public string phoneNumber { get; set; }

        
    }
}
