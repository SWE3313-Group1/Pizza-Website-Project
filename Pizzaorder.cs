using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderPage
{
    public partial class Pizzaorder : Form
    {
        public Pizzaorder()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
            "small",
            "medium",
            "large",
            "jumbo"});
            this.cmbSize.Location = new System.Drawing.Point(214, 100);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 24);
            this.cmbSize.TabIndex = 0;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "Coca-Cola",
            "Sprite",
            "Dr Pepper",
            "Fanta",
            "Diet Coke"});
            this.cmbBeverage.Location = new System.Drawing.Point(214, 216);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(121, 24);
            this.cmbBeverage.TabIndex = 1;
            this.cmbBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbBeverage_SelectedIndexChanged);
            // 
            // clbToppings
            // 
            this.clbToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clbToppings.ForeColor = System.Drawing.Color.Black;
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Items.AddRange(new object[] {
            "Pepperoni   \t+$2.50",
            "Mushrooms\t+$2.50",
            "Bacon\t\t+$2.50",
            "Extra Cheese\t+$2.50",
            "Pineapple\t+$2.50",
            "Shrimp\t\t+$2.50",
            "Chorizo\t\t+$2.50",
            "Sopressata\t+$2.50"});
            this.clbToppings.Location = new System.Drawing.Point(539, 131);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(202, 140);
            this.clbToppings.TabIndex = 2;
            this.clbToppings.ThreeDCheckBoxes = true;
            this.clbToppings.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubmit.Location = new System.Drawing.Point(311, 334);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(199, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pizza Size";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 216);
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
            this.cmbBeverageSize.Location = new System.Drawing.Point(214, 269);
            this.cmbBeverageSize.Name = "cmbBeverageSize";
            this.cmbBeverageSize.Size = new System.Drawing.Size(121, 24);
            this.cmbBeverageSize.TabIndex = 8;
            this.cmbBeverageSize.SelectedIndexChanged += new System.EventHandler(this.cmbBeverageSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Beverage Size";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 159);
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
            this.cmbCrust.Location = new System.Drawing.Point(214, 159);
            this.cmbCrust.Name = "cmbCrust";
            this.cmbCrust.Size = new System.Drawing.Size(121, 24);
            this.cmbCrust.TabIndex = 11;
            this.cmbCrust.SelectedIndexChanged += new System.EventHandler(this.cmbCrust_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toppings List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Order Page";
            // 
            // Pizzaorder
            // 
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(825, 415);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCrust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBeverageSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.clbToppings);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.label1);
            this.Name = "Pizzaorder";
            this.Load += new System.EventHandler(this.Pizzaorder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pizzaorder_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string size = cmbSize.SelectedItem?.ToString();
            string crust = cmbCrust.SelectedItem?.ToString();
            List<string> toppings = clbToppings.CheckedItems.Cast<string>().ToList();
            string beverage = cmbBeverage.SelectedItem?.ToString();
            string beverageSize = cmbBeverageSize.SelectedItem?.ToString();

            if (toppings.Count > 4)
            {
                MessageBox.Show("You can select up to 4 toppings.");
                return;
            }

            double total = 0;
            if (size == "Small") total += 5;
            else if (size == "Medium") total += 7;
            else if (size == "Large") total += 9;
            else if (size == "Extra Large") total += 11;

            total += toppings.Count * 0.75;

            if (beverageSize == "Small") total += 1;
            else if (beverageSize == "Medium") total += 1.5;
            else if (beverageSize == "Large") total += 2;

            string order = $"Pizza Size: {size}\nCrust: {crust}\nToppings: {string.Join(", ", toppings)}\n" +
                           $"Beverage: {beverage} ({beverageSize})\nTotal: ${total:F2}";

        }
    }
}
