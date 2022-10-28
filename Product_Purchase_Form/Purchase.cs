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
using System.ComponentModel.DataAnnotations;

namespace Assignment2
{
    public partial class Purchase : Form

    {
        double Rupee = 0.86;
        double US_Dollar = 0.012;
        double Canadian_Dollar = 0.015;
        double Japanese_Yen=1.22;
        public static float Price1, Price2, Price3, Price4, Price5;
        public static int Amount1, Amount2, Amount3, Amount4, Amount5;
        public static float Product1, Product2, Product3, Product4, Product5;

        public object ProductBindingSource { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {


            if (price1.Text == "")
            {
                MessageBox.Show("Product1 price is empty,Try Again");
            }

            else
            {
                Price1 = float.Parse(price1.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }

            
            if (price2.Text == "")
            {
                MessageBox.Show("Product2 price is empty,Try Again");
            }

            else
            {
                Price2 = float.Parse(price2.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }

            
            if (price3.Text == "")
            {
                MessageBox.Show("Product3 price is empty,Try Again");
            }

            else
            {
                Price3 = float.Parse(price3.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }


            if (price4.Text == "")
            {
                MessageBox.Show("Product4 price is empty,Try Again");
            }

            else
            {
                Price4 = float.Parse(price4.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }


            if (price5.Text == "")
            {
                MessageBox.Show("Product5 price is empty,Try Again");
            }

            else
            {
                Price5 = float.Parse(price5.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }


            if (amount1.Text == "")
            {
                MessageBox.Show("Product1 amount is empty,Try Again");
            }

            else
            {
                Amount1 = Int32.Parse(amount1.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }


            if (amount2.Text == "")
            {
                MessageBox.Show("Product2 amount is empty,Try Again");
            }

            else
            {
                Amount2 = Int32.Parse(amount2.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }


            if (amount3.Text == "")
            {
                MessageBox.Show("Product3 amount is empty,Try Again");
            }

            else
            {
                Amount3 = Int32.Parse(amount3.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }



            if (amount4.Text == "")
            {
                MessageBox.Show("Product4 amount is empty,Try Again");
            }

            else
            {
                Amount4 = Int32.Parse(amount4.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }



            if (amount5.Text == "")
            {
                MessageBox.Show("Product5 amount is empty,Try Again");
            }

            else
            {
                Amount5 = Int32.Parse(amount5.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            }


            if (Price1 >= 1 && Price1 <= 100  && Amount1 >= 1 && Amount1 <= 10)
            {
                Product1 = Price1 * Amount1;
            }

            else 
            {
                MessageBox.Show("Product1 price or amount is invalid,Try Again");
            }



            if (Price2 >= 1 && Price2 <= 100 && Amount2 >= 1 && Amount2 <= 10)
            {
                Product2 = Price2 * Amount2;
            }

            else
            {
                MessageBox.Show("Product2 price or amount is invalid,Try Again");
            }



            if (Price3 >= 1 && Price3 <= 100 && Amount3 >= 1 && Amount3 <= 10)
            {
                Product3 = Price3 * Amount3;
            }

            else
            {
                MessageBox.Show("Product3 price or amount is invalid,Try Again");
            }



            if (Price4 >= 1 && Price4 <= 100 && Amount4 >= 1 && Amount4 <= 10)
            {
                Product4 = Price4 * Amount4;
            }

            else
            {
                MessageBox.Show("Product4 price or amount is invalid,Try Again");
            }



            if (Price5 >= 1 && Price5 <= 100 && Amount5 >= 1 && Amount5 <= 10)
            {
                Product5 = Price5 * Amount5;
            }

            else
            {
                MessageBox.Show("Product5 price or amount is invalid,Try Again");
            }



            double total = Product1 + Product2 + Product3 + Product4 + Product5;
            totalprice.Text = System.Convert.ToString(total);

            if (comboBox1.Text == "Rupee")
            {
                totalprice.Text = System.Convert.ToString(total * Rupee);
            }


            else if (comboBox1.Text == "US Dollar")
            {
                totalprice.Text = System.Convert.ToString(total * US_Dollar);
            }


            else if (comboBox1.Text == "Canadian Dollar")
            {
                totalprice.Text = System.Convert.ToString(total * Canadian_Dollar);
            }


           else if(comboBox1.Text == "Japanese Yen")
            {
                totalprice.Text = System.Convert.ToString(total * Japanese_Yen);
            }

            
            
        }

        
        
        public Purchase()
        {
            InitializeComponent();
        }


        private void Purchase_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.name1;
            textBox2.Text = Form1.pass;
           
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;

            textBox2.ReadOnly = true;
            textBox2.Enabled = false;

            comboBox1.SelectedIndex = 0;

        }
    }
}
