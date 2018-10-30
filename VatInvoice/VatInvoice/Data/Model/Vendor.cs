using System;
using System.Collections.Generic;
using System.Text;

namespace VatInvoice.Model
{
   public class Vendor
    {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public bool VatPayer { get; set; }
    }
}
