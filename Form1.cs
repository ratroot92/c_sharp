using System;
using System.Windows.Forms;

namespace first_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username= txt_username.Text;
            string userpassword= txt_userpassword.Text;
            Console.WriteLine(username);
            Console.WriteLine(userpassword);
            Connection_Class a = new Connection_Class();
            a.connection_start();


        }
    }
}
