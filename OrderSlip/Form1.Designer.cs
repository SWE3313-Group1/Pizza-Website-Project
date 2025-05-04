namespace OrderSlip
{
    partial class OrderSlip
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.OrderInfo = new System.Windows.Forms.Label();
            this.CustomerInfoTitle = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.Label();
            this.OrderDetailsTitle = new System.Windows.Forms.Label();
            this.OrderDetails = new System.Windows.Forms.Label();
            this.OrderSummaryTitle = new System.Windows.Forms.Label();
            this.OrderSummary = new System.Windows.Forms.Label();
            this.ContinueShopping = new System.Windows.Forms.Button();
            this.OrderNumberVariable = new System.Windows.Forms.Label();
            this.OrderDateVariable = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.DeliveryMethod = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.Label();
            this.DeliveryFee = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.FinalTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Brown;
            this.Title.Location = new System.Drawing.Point(42, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(298, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Thank You For Your Order!";
            // 
            // OrderInfo
            // 
            this.OrderInfo.AutoSize = true;
            this.OrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderInfo.Location = new System.Drawing.Point(17, 76);
            this.OrderInfo.Name = "OrderInfo";
            this.OrderInfo.Size = new System.Drawing.Size(93, 39);
            this.OrderInfo.TabIndex = 1;
            this.OrderInfo.Text = "Order Number: \r\n\r\nOrder Date:\r\n";
            // 
            // CustomerInfoTitle
            // 
            this.CustomerInfoTitle.AutoSize = true;
            this.CustomerInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoTitle.ForeColor = System.Drawing.Color.Brown;
            this.CustomerInfoTitle.Location = new System.Drawing.Point(12, 151);
            this.CustomerInfoTitle.Name = "CustomerInfoTitle";
            this.CustomerInfoTitle.Size = new System.Drawing.Size(208, 24);
            this.CustomerInfoTitle.TabIndex = 2;
            this.CustomerInfoTitle.Text = "Customer Information";
            this.CustomerInfoTitle.Click += new System.EventHandler(this.CustomerInfoTitle_Click);
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.AutoSize = true;
            this.CustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfo.Location = new System.Drawing.Point(17, 175);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(56, 104);
            this.CustomerInfo.TabIndex = 3;
            this.CustomerInfo.Text = "Name:\r\n\r\nAddress:\r\n\r\n\r\n\r\n\r\nPhone:";
            // 
            // OrderDetailsTitle
            // 
            this.OrderDetailsTitle.AutoSize = true;
            this.OrderDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDetailsTitle.ForeColor = System.Drawing.Color.Brown;
            this.OrderDetailsTitle.Location = new System.Drawing.Point(12, 325);
            this.OrderDetailsTitle.Name = "OrderDetailsTitle";
            this.OrderDetailsTitle.Size = new System.Drawing.Size(132, 24);
            this.OrderDetailsTitle.TabIndex = 4;
            this.OrderDetailsTitle.Text = "Order Details";
            // 
            // OrderDetails
            // 
            this.OrderDetails.AutoSize = true;
            this.OrderDetails.Location = new System.Drawing.Point(17, 349);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Size = new System.Drawing.Size(90, 65);
            this.OrderDetails.TabIndex = 5;
            this.OrderDetails.Text = "Delivery Method: \r\n\r\nItem:\r\nQuantity:\r\nTotal:  $";
            this.OrderDetails.Click += new System.EventHandler(this.OrderDetails_Click);
            // 
            // OrderSummaryTitle
            // 
            this.OrderSummaryTitle.AutoSize = true;
            this.OrderSummaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummaryTitle.ForeColor = System.Drawing.Color.Brown;
            this.OrderSummaryTitle.Location = new System.Drawing.Point(12, 458);
            this.OrderSummaryTitle.Name = "OrderSummaryTitle";
            this.OrderSummaryTitle.Size = new System.Drawing.Size(157, 24);
            this.OrderSummaryTitle.TabIndex = 6;
            this.OrderSummaryTitle.Text = "Order Summary";
            this.OrderSummaryTitle.Click += new System.EventHandler(this.OrderSummaryTitle_Click);
            // 
            // OrderSummary
            // 
            this.OrderSummary.AutoSize = true;
            this.OrderSummary.Location = new System.Drawing.Point(17, 482);
            this.OrderSummary.Name = "OrderSummary";
            this.OrderSummary.Size = new System.Drawing.Size(78, 65);
            this.OrderSummary.TabIndex = 7;
            this.OrderSummary.Text = "Subtotal: $\r\nDelivery Fee: $\r\nTax: $\r\n\r\nTotal: $";
            // 
            // ContinueShopping
            // 
            this.ContinueShopping.BackColor = System.Drawing.Color.Brown;
            this.ContinueShopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueShopping.ForeColor = System.Drawing.Color.White;
            this.ContinueShopping.Location = new System.Drawing.Point(112, 573);
            this.ContinueShopping.Name = "ContinueShopping";
            this.ContinueShopping.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContinueShopping.Size = new System.Drawing.Size(129, 34);
            this.ContinueShopping.TabIndex = 8;
            this.ContinueShopping.Text = "Continue Shopping";
            this.ContinueShopping.UseVisualStyleBackColor = false;
            this.ContinueShopping.Click += new System.EventHandler(this.ContinueShopping_Click);
            // 
            // OrderNumberVariable
            // 
            this.OrderNumberVariable.AutoSize = true;
            this.OrderNumberVariable.Location = new System.Drawing.Point(109, 76);
            this.OrderNumberVariable.Name = "OrderNumberVariable";
            this.OrderNumberVariable.Size = new System.Drawing.Size(0, 13);
            this.OrderNumberVariable.TabIndex = 9;
            // 
            // OrderDateVariable
            // 
            this.OrderDateVariable.AutoSize = true;
            this.OrderDateVariable.Location = new System.Drawing.Point(90, 102);
            this.OrderDateVariable.Name = "OrderDateVariable";
            this.OrderDateVariable.Size = new System.Drawing.Size(0, 13);
            this.OrderDateVariable.TabIndex = 10;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(60, 175);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 11;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(17, 214);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(0, 13);
            this.Address.TabIndex = 12;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(60, 266);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(0, 13);
            this.Phone.TabIndex = 13;
            // 
            // DeliveryMethod
            // 
            this.DeliveryMethod.AutoSize = true;
            this.DeliveryMethod.Location = new System.Drawing.Point(100, 349);
            this.DeliveryMethod.Name = "DeliveryMethod";
            this.DeliveryMethod.Size = new System.Drawing.Size(0, 13);
            this.DeliveryMethod.TabIndex = 14;
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Location = new System.Drawing.Point(44, 376);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(0, 13);
            this.Item.TabIndex = 15;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(65, 388);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(0, 13);
            this.Quantity.TabIndex = 16;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(60, 401);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 13);
            this.Total.TabIndex = 17;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(72, 482);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(0, 13);
            this.Subtotal.TabIndex = 18;
            // 
            // DeliveryFee
            // 
            this.DeliveryFee.AutoSize = true;
            this.DeliveryFee.Location = new System.Drawing.Point(90, 495);
            this.DeliveryFee.Name = "DeliveryFee";
            this.DeliveryFee.Size = new System.Drawing.Size(0, 13);
            this.DeliveryFee.TabIndex = 19;
            // 
            // Tax
            // 
            this.Tax.AutoSize = true;
            this.Tax.Location = new System.Drawing.Point(56, 508);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(0, 13);
            this.Tax.TabIndex = 20;
            // 
            // FinalTotal
            // 
            this.FinalTotal.AutoSize = true;
            this.FinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalTotal.ForeColor = System.Drawing.Color.Brown;
            this.FinalTotal.Location = new System.Drawing.Point(55, 533);
            this.FinalTotal.Name = "FinalTotal";
            this.FinalTotal.Size = new System.Drawing.Size(0, 16);
            this.FinalTotal.TabIndex = 21;
            // 
            // OrderSlip
            // 
            this.ClientSize = new System.Drawing.Size(378, 632);
            this.Controls.Add(this.FinalTotal);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.DeliveryFee);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.DeliveryMethod);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.OrderDateVariable);
            this.Controls.Add(this.OrderNumberVariable);
            this.Controls.Add(this.ContinueShopping);
            this.Controls.Add(this.OrderSummary);
            this.Controls.Add(this.OrderSummaryTitle);
            this.Controls.Add(this.OrderDetails);
            this.Controls.Add(this.OrderDetailsTitle);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.CustomerInfoTitle);
            this.Controls.Add(this.OrderInfo);
            this.Controls.Add(this.Title);
            this.Name = "OrderSlip";
            this.Text = "Order Slip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label OrderInfo;
        private System.Windows.Forms.Label CustomerInfoTitle;
        private System.Windows.Forms.Label CustomerInfo;
        private System.Windows.Forms.Label OrderDetailsTitle;
        private System.Windows.Forms.Label OrderDetails;
        private System.Windows.Forms.Label OrderSummaryTitle;
        private System.Windows.Forms.Label OrderSummary;
        private System.Windows.Forms.Button ContinueShopping;
        private System.Windows.Forms.Label OrderNumberVariable;
        private System.Windows.Forms.Label OrderDateVariable;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label DeliveryMethod;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label DeliveryFee;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label FinalTotal;

        #endregion
    }
}

