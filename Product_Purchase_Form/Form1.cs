using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public static string name1, pass;
        String name = "Nusrat Jahan";
        String ID = "180104020";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            name1 = username.Text;
            pass = password.Text;

            if (name1 == name && pass == ID)
            {
                Purchase login = new Purchase();
                login.Show();
                this.Hide();
            }
            else
               MessageBox.Show("The username or password you entered is incorrect,Try Again");

        }

        
    }
   
}

