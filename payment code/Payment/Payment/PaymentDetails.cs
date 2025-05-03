using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    internal class PaymentDetails
    {
        public string fullName {  get; set; }
        public string addressOne { get; set; }
        public string addressTwo { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string phoneNumber { get; set; }

        public string billingFullName { get; set; }
        public string billingAddressOne { get; set; }
        public string billingAddressTwo { get; set; }
        public string billingCity { get; set; }
        public string billingState { get; set; }
        public string billingPostalCode { get; set; }
        public string billingCountry { get; set; }
        public string billingPhoneNumber { get; set; }

        public string cardNumber { get; set; }
        public string nameOnCard { get; set; }
        public string expirationDate { get; set; }
        public string cardVerificationValue { get; set; }
    }
}
