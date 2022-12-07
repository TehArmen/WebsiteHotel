namespace HomePage
{
    using HomePage.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myContext = new MyDBContext();

            var credentials = myContext.Set<LoginPortal>().FirstOrDefault();
            if (credentials.username == textBox1.Text && credentials.pass == textBox2.Text)
            {
            var context = new MyDBContext();
           // var credentials = context.Set<LoginPortal>().FirstOrDefault(m => m.userID == 155);
            if (credentials.username == textBox1.Text && credentials.pass == textBox2.Text) 
            { 
                this.Hide();
                AdminPortal admin = new AdminPortal();
                admin.Show();
            }
            else { label1.Show(); }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

    
    }
}
