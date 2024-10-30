using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemNamespace
{
    internal class DiscountedItem : Item
    {
        private double item_discount, discounted_price, payment_amount, change;

        public DiscountedItem(string name, double price, int quantity, double discount) : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        public override double getTotalPrice()
        {
            double discountItem = item_discount * 0.01;
            double result = discountItem * item_price;
            this.discounted_price = (item_price - result) * item_quantity;
            double finalDiscount = this.discounted_price;
            return finalDiscount;
        }

        public override void setPayment(double amount)
        {

            if (payment_amount < 0)
            {
                throw new Exception("Please enter a valid payment amount.");
            }
            else
            {
                this.payment_amount = amount;
            } 
        }

        public double getChange()
        {

            if (this.discounted_price == 0)
            {
                getTotalPrice(); 
            }
            this.change = this.payment_amount - this.discounted_price;

            if (this.change < 0)
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return 0.00;
            }
            else
            {
             return this.change;

            }  
        }
    }
}
