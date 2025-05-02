using System.Collections.Generic;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace PizzaOrderPage
{
    partial class Pizzaorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private ComboBox cmbSize;
        private ComboBox cmbBeverage;
        private CheckedListBox clbToppings;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
        private ComboBox cmbBeverageSize;
        private Label label3;
        private Label label4;
        private ComboBox cmbCrust;
        private Label label5;
        private Label label6;
        
    }
}
        

