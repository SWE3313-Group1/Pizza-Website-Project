using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Prompt the user for quantity, size, and toppings of the pizza
            string itemName = "CheesyRon"; // Correctly declare a variable to store the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50 };
                var sizeInput = new ComboBox() { Left = 250, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large", "Extra Large" });

                var toppingsLabel = new Label() { Text = "Toppings (Select up to 4):", Left = 10, Top = 90, Width = 200 };
                var toppingsList = new CheckedListBox() { Left = 10, Top = 120, Width = 200, Height = 100 };
                toppingsList.Items.AddRange(new string[]
                {
            "Pepperoni", "Mushrooms", "Onions", "Sausage", "Bacon", "Extra Cheese", "Black Olives", "Green Peppers"
                });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 230, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(toppingsLabel);
                inputForm.Controls.Add(toppingsList);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    int pricePerPizza = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerPizza = 5;
                            break;
                        case "Medium":
                            pricePerPizza = 7;
                            break;
                        case "Large":
                            pricePerPizza = 9;
                            break;
                        case "Extra Large":
                            pricePerPizza = 11;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Validate and calculate topping price
                    var selectedToppings = toppingsList.CheckedItems.Cast<string>().ToList();
                    if (selectedToppings.Count > 4)
                    {
                        MessageBox.Show("You can select up to 4 toppings only.");
                        return;
                    }
                    double toppingsPrice = selectedToppings.Count * 0.75;

                    // Calculate total price
                    double totalPrice = (pricePerPizza + toppingsPrice) * quantity;

                    // Display order summary
                    string toppingsSummary = selectedToppings.Count > 0
                        ? string.Join(", ", selectedToppings)
                        : "No toppings";
                    MessageBox.Show($"{quantity} {size} {itemName}(s) with toppings: {toppingsSummary} have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It has been added to the order!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Prompt the user for quantity, size, and toppings of the pizza
            string itemName = "Double Olive"; // Correctly declare a variable to store the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50 };
                var sizeInput = new ComboBox() { Left = 250, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large", "Extra Large" });

                var toppingsLabel = new Label() { Text = "Toppings (Select up to 4):", Left = 10, Top = 90, Width = 200 };
                var toppingsList = new CheckedListBox() { Left = 10, Top = 120, Width = 200, Height = 100 };
                toppingsList.Items.AddRange(new string[]
                {
            "Pepperoni", "Mushrooms", "Onions", "Sausage", "Bacon", "Extra Cheese", "Black Olives", "Green Peppers"
                });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 230, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(toppingsLabel);
                inputForm.Controls.Add(toppingsList);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    int pricePerPizza = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerPizza = 5;
                            break;
                        case "Medium":
                            pricePerPizza = 7;
                            break;
                        case "Large":
                            pricePerPizza = 9;
                            break;
                        case "Extra Large":
                            pricePerPizza = 11;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Validate and calculate topping price
                    var selectedToppings = toppingsList.CheckedItems.Cast<string>().ToList();
                    if (selectedToppings.Count > 4)
                    {
                        MessageBox.Show("You can select up to 4 toppings only.");
                        return;
                    }
                    double toppingsPrice = selectedToppings.Count * 0.75;

                    // Calculate total price
                    double totalPrice = (pricePerPizza + toppingsPrice) * quantity;

                    // Display order summary
                    string toppingsSummary = selectedToppings.Count > 0
                        ? string.Join(", ", selectedToppings)
                        : "No toppings";
                    MessageBox.Show($"{quantity} {size} {itemName}(s) with toppings: {toppingsSummary} have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Prompt the user for quantity, size, and toppings of the pizza
            string itemName = "Garden"; // Correctly declare a variable to store the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50 };
                var sizeInput = new ComboBox() { Left = 250, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large", "Extra Large" });

                var toppingsLabel = new Label() { Text = "Toppings (Select up to 4):", Left = 10, Top = 90, Width = 200 };
                var toppingsList = new CheckedListBox() { Left = 10, Top = 120, Width = 200, Height = 100 };
                toppingsList.Items.AddRange(new string[]
                {
            "Pepperoni", "Mushrooms", "Onions", "Sausage", "Bacon", "Extra Cheese", "Black Olives", "Green Peppers"
                });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 230, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(toppingsLabel);
                inputForm.Controls.Add(toppingsList);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    int pricePerPizza = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerPizza = 5;
                            break;
                        case "Medium":
                            pricePerPizza = 7;
                            break;
                        case "Large":
                            pricePerPizza = 9;
                            break;
                        case "Extra Large":
                            pricePerPizza = 11;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Validate and calculate topping price
                    var selectedToppings = toppingsList.CheckedItems.Cast<string>().ToList();
                    if (selectedToppings.Count > 4)
                    {
                        MessageBox.Show("You can select up to 4 toppings only.");
                        return;
                    }
                    double toppingsPrice = selectedToppings.Count * 0.75;

                    // Calculate total price
                    double totalPrice = (pricePerPizza + toppingsPrice) * quantity;

                    // Display order summary
                    string toppingsSummary = selectedToppings.Count > 0
                        ? string.Join(", ", selectedToppings)
                        : "No toppings";
                    MessageBox.Show($"{quantity} {size} {itemName}(s) with toppings: {toppingsSummary} have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Prompt the user for quantity, size, and toppings of the pizza
            string itemName = "Deluxe"; // Correctly declare a variable to store the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50 };
                var sizeInput = new ComboBox() { Left = 250, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large", "Extra Large" });

                var toppingsLabel = new Label() { Text = "Toppings (Select up to 4):", Left = 10, Top = 90, Width = 200 };
                var toppingsList = new CheckedListBox() { Left = 10, Top = 120, Width = 200, Height = 100 };
                toppingsList.Items.AddRange(new string[]
                {
            "Pepperoni", "Mushrooms", "Onions", "Sausage", "Bacon", "Extra Cheese", "Black Olives", "Green Peppers"
                });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 230, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(toppingsLabel);
                inputForm.Controls.Add(toppingsList);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    int pricePerPizza = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerPizza = 5;
                            break;
                        case "Medium":
                            pricePerPizza = 7;
                            break;
                        case "Large":
                            pricePerPizza = 9;
                            break;
                        case "Extra Large":
                            pricePerPizza = 11;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Validate and calculate topping price
                    var selectedToppings = toppingsList.CheckedItems.Cast<string>().ToList();
                    if (selectedToppings.Count > 4)
                    {
                        MessageBox.Show("You can select up to 4 toppings only.");
                        return;
                    }
                    double toppingsPrice = selectedToppings.Count * 0.75;

                    // Calculate total price
                    double totalPrice = (pricePerPizza + toppingsPrice) * quantity;

                    // Display order summary
                    string toppingsSummary = selectedToppings.Count > 0
                        ? string.Join(", ", selectedToppings)
                        : "No toppings";
                    MessageBox.Show($"{quantity} {size} {itemName}(s) with toppings: {toppingsSummary} have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Prompt the user for quantity and size of the beverage
            string itemName = "Water"; // Declare the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50, Width = 80 };
                var sizeInput = new ComboBox() { Left = 100, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large" });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 100, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    double pricePerBeverage = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerBeverage = 1.0;
                            break;
                        case "Medium":
                            pricePerBeverage = 1.5;
                            break;
                        case "Large":
                            pricePerBeverage = 2.0;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Calculate total price
                    double totalPrice = pricePerBeverage * quantity;

                    // Display order summary
                    MessageBox.Show($"{quantity} {size} {itemName}(s) have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Call the button2_Click method to handle the event
            button2_Click(sender, e);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Prompt the user for quantity and size of the beverage
            string itemName = "Fanta"; // Declare the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50, Width = 80 };
                var sizeInput = new ComboBox() { Left = 100, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large" });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 100, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    double pricePerBeverage = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerBeverage = 1.0;
                            break;
                        case "Medium":
                            pricePerBeverage = 1.5;
                            break;
                        case "Large":
                            pricePerBeverage = 2.0;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Calculate total price
                    double totalPrice = pricePerBeverage * quantity;

                    // Display order summary
                    MessageBox.Show($"{quantity} {size} {itemName}(s) have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Prompt the user for quantity and size of the beverage
            string itemName = "Sprite"; // Declare the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50, Width = 80 };
                var sizeInput = new ComboBox() { Left = 100, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large" });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 100, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    double pricePerBeverage = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerBeverage = 1.0;
                            break;
                        case "Medium":
                            pricePerBeverage = 1.5;
                            break;
                        case "Large":
                            pricePerBeverage = 2.0;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Calculate total price
                    double totalPrice = pricePerBeverage * quantity;

                    // Display order summary
                    MessageBox.Show($"{quantity} {size} {itemName}(s) have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Prompt the user for quantity and size of the beverage
            string itemName = "Pepsi"; // Declare the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50, Width = 80 };
                var sizeInput = new ComboBox() { Left = 100, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large" });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 100, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    double pricePerBeverage = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerBeverage = 1.0;
                            break;
                        case "Medium":
                            pricePerBeverage = 1.5;
                            break;
                        case "Large":
                            pricePerBeverage = 2.0;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Calculate total price
                    double totalPrice = pricePerBeverage * quantity;

                    // Display order summary
                    MessageBox.Show($"{quantity} {size} {itemName}(s) have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Prompt the user for quantity and size of the beverage
            string itemName = "Lemonade"; // Declare the item name
            using (var inputForm = new Form())
            {
                inputForm.Text = "Order Details";

                var quantityLabel = new Label() { Text = "Quantity:", Left = 10, Top = 10, Width = 80 };
                var quantityInput = new NumericUpDown() { Left = 100, Top = 10, Width = 50 };

                var sizeLabel = new Label() { Text = "Sizes:", Left = 10, Top = 50, Width = 80 };
                var sizeInput = new ComboBox() { Left = 100, Top = 50, Width = 100 };
                sizeInput.Items.AddRange(new string[] { "Small", "Medium", "Large" });

                var confirmButton = new Button() { Text = "Confirm", Left = 100, Top = 100, Width = 100 };
                confirmButton.DialogResult = DialogResult.OK;

                inputForm.Controls.Add(quantityLabel);
                inputForm.Controls.Add(quantityInput);
                inputForm.Controls.Add(sizeLabel);
                inputForm.Controls.Add(sizeInput);
                inputForm.Controls.Add(confirmButton);

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = (int)quantityInput.Value;
                    string size = sizeInput.SelectedItem?.ToString() ?? "Unknown";

                    // Pricing logic for size
                    double pricePerBeverage = 0;
                    switch (size)
                    {
                        case "Small":
                            pricePerBeverage = 1.0;
                            break;
                        case "Medium":
                            pricePerBeverage = 1.5;
                            break;
                        case "Large":
                            pricePerBeverage = 2.0;
                            break;
                        default:
                            MessageBox.Show("Invalid size selected.");
                            return;
                    }

                    // Calculate total price
                    double totalPrice = pricePerBeverage * quantity;

                    // Display order summary
                    MessageBox.Show($"{quantity} {size} {itemName}(s) have been added to the order! Total Price: ${totalPrice:F2}");
                }
            }
        }
    }
}
