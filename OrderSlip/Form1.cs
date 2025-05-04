using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSlip
{
    public partial class OrderSlip : Form
    {
        private int orderNumber = 000;
        public OrderSlip()
        {
            InitializeComponent();
            string todaysDate = System.DateTime.Now.ToString();
            int orderNumber = getOrderNumber();
            string customerName = "Bobby";
            string address = "1553 East Bank Drive, Marietta, Georgia, 30068";
            string phone = "(609) 957-0222";
            Boolean delivery = false;
            string itemName = "Cheese Pizza";
            int quantity = 1;
            double total = 29.89;
            double subtotal = total;
            double deliveryFee = 5.99;
            double tax = 0.69;

            OrderDateVariable.Text = todaysDate;
            OrderNumberVariable.Text = orderNumber.ToString("D3");
            NameLabel.Text = customerName;
            Address.Text = AddressString(address);
            Phone.Text = phone;
            if (delivery == false)
                DeliveryMethod.Text = "Take Out";
            else
                DeliveryMethod.Text = "Delivery";
            Item.Text = itemName;
            Quantity.Text = quantity.ToString();
            Total.Text = total.ToString();
            Subtotal.Text = subtotal.ToString();
            DeliveryFee.Text = deliveryFee.ToString();
            Tax.Text = tax.ToString();
            FinalTotal.Text = (total + deliveryFee + tax).ToString();



        }

        public int getOrderNumber()
        {
            return (orderNumber + 1);
        }

        public string AddressString(string address)
        {
            var addressParts = address.Split(',');
            string street = addressParts[0];
            string city = addressParts[1];
            string state = addressParts[2]; 
            string zip = addressParts[3];

            return street + "\n" + city + ", " + state + "\n" + zip;

        }

        private void CustomerInfoTitle_Click(object sender, EventArgs e)
        {

        }

        private void OrderSummaryTitle_Click(object sender, EventArgs e)
        {

        }

        private void OrderDetails_Click(object sender, EventArgs e)
        {

        }

        private void ContinueShopping_Click(object sender, EventArgs e)
        {
            //HomePage home = new HomePage();
            //home.show();
            this.Close();
        }
    }
}
