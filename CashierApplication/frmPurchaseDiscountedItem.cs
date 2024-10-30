using System;
using ItemNamespace;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = textBox1.Text;
                int discountItem = int.Parse(textBox2.Text);
                double price = double.Parse(textBox5.Text);
                int quantityItem = int.Parse(textBox3.Text);

                if (itemName == "" || discountItem <0 || discountItem > 100 || price <0 || quantityItem < 0)
                {
                    MessageBox.Show("An error has occured! Please enter the valid input on each box.");
                } else
                {
                    DiscountedItem d = new DiscountedItem(itemName, price, quantityItem, discountItem);

                    label6.Text = $"$ {Convert.ToString(d.getTotalPrice())}";
                }
 
            }
            catch (Exception)
            {

                MessageBox.Show("An error has occured! Please enter the valid input on each box.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = textBox1.Text;
                int discountItem = int.Parse(textBox2.Text);
                double price = double.Parse(textBox5.Text);
                int quantityItem = int.Parse(textBox3.Text);
                double payment = double.Parse(textBox4.Text);

                DiscountedItem d2 = new DiscountedItem(itemName, price, quantityItem, discountItem);
                d2.setPayment(payment);

                label4.Text = $"$ {Convert.ToString(d2.getChange())}";
            }
            catch (Exception)
            {
                textBox4.Text = "";
                MessageBox.Show("An error has occured! Please enter the valid input on each box.");
            }
        }
    }
}
