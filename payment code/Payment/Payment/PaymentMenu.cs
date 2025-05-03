using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class PaymentMenu : Form
    {
        public PaymentMenu()
        {
            InitializeComponent();
        }

        private void PaymentMenu_Load(object sender, EventArgs e)
        {
            // This should get order information from the Order Menu GUI to place in the ListBox
        }

        private void BILLING_EQUALS_SHIPPING_CheckedChanged(object sender, EventArgs e)
        {
            billingNameLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_NAME.Visible = !BILLING_EQUALS_SHIPPING.Checked;

            billingAddressOneLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_ADDRESS_ONE.Visible = !BILLING_EQUALS_SHIPPING.Checked;

            billingAddressTwoLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_ADDRESS_TWO.Visible = !BILLING_EQUALS_SHIPPING.Checked;

            billingCityLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_CITY.Visible = !BILLING_EQUALS_SHIPPING.Checked;

            billingStateLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_STATE.Visible = !BILLING_EQUALS_SHIPPING.Checked;

            billingPostalLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_POSTAL.Visible = !BILLING_EQUALS_SHIPPING.Checked;

            billingCountryLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_COUNTRY.Visible = !BILLING_EQUALS_SHIPPING.Checked;

            billingPhoneLabel.Visible = !BILLING_EQUALS_SHIPPING.Checked;
            BILLING_PHONE.Visible = !BILLING_EQUALS_SHIPPING.Checked;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            // This should go back to the Order Menu GUI
        }

        private void AccountAutoFill_Click(object sender, EventArgs e)
        {
            // Use the json file to autofill payment details based off of account

            // ----[PLACEHOLDER CODE]----
            FULL_NAME.Text = "placeholder";
            ADDRESS_ONE.Text = "placeholder";
            ADDRESS_TWO.Text = "placeholder";
            CITY.Text = "placeholder";
            STATE.Text = "placeholder";
            POSTAL_CODE.Text = "placeholder";
            COUNTRY.Text = "placeholder";
            PHONE_NUMBER.Text = "placeholder";

            BILLING_NAME.Text = "placeholder";
            BILLING_ADDRESS_ONE.Text = "placeholder";
            BILLING_ADDRESS_TWO.Text = "placeholder";
            BILLING_CITY.Text = "placeholder";
            BILLING_STATE.Text = "placeholder";
            BILLING_POSTAL.Text = "placeholder";
            BILLING_COUNTRY.Text = "placeholder";
            BILLING_PHONE.Text = "placeholder";

            CARD_NUMBER.Text = "placeholder";
            NAME_ON_CARD.Text = "placeholder";
            EXPIRATION_DATE.Text = "placeholder";
            CVV.Text = "placeholder";

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FULL_NAME.Text)
                && !String.IsNullOrEmpty(ADDRESS_ONE.Text)
                && !String.IsNullOrEmpty(CITY.Text)
                && !String.IsNullOrEmpty(STATE.Text)
                && !String.IsNullOrEmpty(POSTAL_CODE.Text)
                && !String.IsNullOrEmpty(COUNTRY.Text)
                && !String.IsNullOrEmpty(BILLING_NAME.Text)
                && !String.IsNullOrEmpty(BILLING_ADDRESS_ONE.Text)
                && !String.IsNullOrEmpty(BILLING_CITY.Text)
                && !String.IsNullOrEmpty(BILLING_STATE.Text)
                && !String.IsNullOrEmpty(BILLING_POSTAL.Text)
                && !String.IsNullOrEmpty(BILLING_COUNTRY.Text)
                && !String.IsNullOrEmpty(CARD_NUMBER.Text)
                && !String.IsNullOrEmpty(NAME_ON_CARD.Text)
                && !String.IsNullOrEmpty(EXPIRATION_DATE.Text)
                && !String.IsNullOrEmpty(CVV.Text)
                )
            {
                // Save the payment information to the customer account
                // Send the customer to the billing page
            }
            else
            {
                PaymentDetailsError paymentDetailsError = new PaymentDetailsError();
                paymentDetailsError.Show();
            }

        }
    }
}
