//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace storeManager.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public string CustomerNum { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string Sex { get; set; }
        public Nullable<int> CustomerTypeID { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CustomerName { get; set; }
        public string ContactPerson { get; set; }
        public string PostalAddress { get; set; }
        public string LocationAdress { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> CustomerSince { get; set; }
        public string Salutation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int CustomerID { get; set; }
    }
}
