using System;

namespace VatInvoice
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string Country { get; set; }
        public bool EuResident { get; set; }
        public bool VatPayer { get; set; }
    }
}
