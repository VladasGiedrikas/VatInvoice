using System;
using System.Collections.Generic;
using System.Text;

namespace VatInvoice.Model
{
   public class Vendor
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public bool VatPayer { get; set; }
    }
}
