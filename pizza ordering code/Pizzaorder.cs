using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderPage
{
    public partial class Pizzaorder : Form
    {
        // Constructor to initialize the form components
        public Pizzaorder()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            //this.Resize += Pizzaorder_Resize;
        }


        // Method to initialize and configure the form components
        private void InitializeComponent()
        {
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBeverageSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCrust = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.cmbSize.Location = new System.Drawing.Point(329, 152);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(333, 24);
            this.cmbSize.TabIndex = 0;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "Coca-Cola  ",
            "Sprite     ",
            "Dr Pepper  ",
            "Fanta      ",
            "Diet Coke  "});
            this.cmbBeverage.Location = new System.Drawing.Point(329, 306);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(333, 24);
            this.cmbBeverage.TabIndex = 1;
            this.cmbBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbBeverage_SelectedIndexChanged);
            // 
            // clbToppings
            // 
            this.clbToppings.BackColor = System.Drawing.Color.Tomato;
            this.clbToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbToppings.CheckOnClick = true;
            this.clbToppings.ForeColor = System.Drawing.Color.Black;
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Items.AddRange(new object[] {
            "Pepperoni     ",
            "Mushrooms     ",
            "Bacon         ",
            "Extra Cheese  ",
            "Pineapple     ",
            "Shrimp        ",
            "Chorizo       ",
            "Sopressata    "});
            this.clbToppings.Location = new System.Drawing.Point(1112, 172);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(267, 187);
            this.clbToppings.TabIndex = 2;
            this.clbToppings.ThreeDCheckBoxes = true;
            this.clbToppings.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Tomato;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.Location = new System.Drawing.Point(748, 440);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(199, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pizza Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Beverage\r\n";
            // 
            // cmbBeverageSize
            // 
            this.cmbBeverageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbBeverageSize.FormattingEnabled = true;
            this.cmbBeverageSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbBeverageSize.Location = new System.Drawing.Point(329, 387);
            this.cmbBeverageSize.Name = "cmbBeverageSize";
            this.cmbBeverageSize.Size = new System.Drawing.Size(333, 24);
            this.cmbBeverageSize.TabIndex = 8;
            this.cmbBeverageSize.SelectedIndexChanged += new System.EventHandler(this.cmbBeverageSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tomato;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Beverage Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pizza Crust";
            // 
            // cmbCrust
            // 
            this.cmbCrust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbCrust.FormattingEnabled = true;
            this.cmbCrust.Items.AddRange(new object[] {
            "Thin",
            "Filled",
            "Thick"});
            this.cmbCrust.Location = new System.Drawing.Point(329, 220);
            this.cmbCrust.Name = "cmbCrust";
            this.cmbCrust.Size = new System.Drawing.Size(333, 24);
            this.cmbCrust.TabIndex = 11;
            this.cmbCrust.SelectedIndexChanged += new System.EventHandler(this.cmbCrust_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tomato;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1234, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toppings List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Tomato;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(751, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Order Page";
            // 
            // Pizzaorder
            // 
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1735, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clbToppings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCrust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBeverageSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.cmbSize);
            this.Name = "Pizzaorder";
            this.Load += new System.EventHandler(this.Pizzaorder_Load);
            this.Resize += new System.EventHandler(this.Pizzaorder_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        // Event handler for when a topping is selected or deselected
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        // Event handler for form load
        private void Pizzaorder_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCrust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBeverageSize_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        // Event handler for the Submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve selected pizza size
            string size = cmbSize.SelectedItem?.ToString();

            // Retrieve selected crust type
            string crust = cmbCrust.SelectedItem?.ToString();

            // Retrieve selected toppings
            List<string> toppings = clbToppings.CheckedItems.Cast<string>().ToList();

            // Retrieve selected beverage and size
            string beverage = cmbBeverage.SelectedItem?.ToString();
            string beverageSize = cmbBeverageSize.SelectedItem?.ToString();

            // Validate selections
            if (string.IsNullOrEmpty(size) || string.IsNullOrEmpty(crust) || string.IsNullOrEmpty(beverage) || string.IsNullOrEmpty(beverageSize))
            {
                MessageBox.Show("Please select all options.");
                return;
            }
            // Validate the number of toppings
            if (toppings.Count > 4)
            {
                MessageBox.Show("You can select up to 4 toppings.");
                return;
            }

            // Define price maps
            var pizzaSizePrices = new Dictionary<string, double>
            {
                { "Small", 5 },
                { "Medium", 7 },
                { "Large", 9 },
                { "Extra Large", 11 }
            };

            var beverageSizePrices = new Dictionary<string, double>
            {
                { "Small", 1 },
                { "Medium", 1.5 },
                { "Large", 2 }
            };

            // Calculate total cost
            double total = 0;
            if (pizzaSizePrices.TryGetValue(size, out double pizzaPrice))
                total += pizzaPrice;

            if (beverageSizePrices.TryGetValue(beverageSize, out double beveragePrice))
                total += beveragePrice;

            total += toppings.Count * 2.50;

            // Display order summary with itemized prices
            string order =
                $"Order Summary:\n" +
                $"  Pizza:\n" +
                $"    Size: {size} - ${pizzaPrice:F2}\n" +
                $"    Crust: {crust}\n" +
                $"    Toppings:\n{string.Join("", toppings.Select(t => $"      - {t} - $2.50\n"))}" +
                $"  Beverage:\n" +
                $"    Type: {beverage}\n" +
                $"    Size: {beverageSize} - ${beveragePrice:F2}\n" +
                $"  Total: ${total:F2}";

            MessageBox.Show(order, "Order Summary");
            
            this.Hide();


            // Show the payment form
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();



        }
        // Event handler for form resize    
        private void Pizzaorder_Resize(object sender, EventArgs e)
        {
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;


        }
    }
}
