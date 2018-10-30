using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VatInvoice.Data;
using VatInvoice.Interface;
using VatInvoice.Model;

namespace VatInvoice.Service
{
   public class MakeInvoiceService : IMakeInvoiceService
    {
        private Entity _data;

        public MakeInvoiceService(Entity data)
        {
            _data = data;
        }

        // count what sum will be paid according to vat size and sum customer paid
        public decimal CountTaxSum(Customer customer, Vendor vendor, decimal SumPaidForItem)
        {
            decimal vat = 0; // value added tax

            if (customer.EuResident == true && vendor.VatPayer == true) // according to country
            {
                var countrytax = _data.countryVat.Find(x => x.Country == customer.Country);
                vat = countrytax.Vat;              
            }

            if (customer.EuResident == true && customer.Country == vendor.Country && vendor.VatPayer == true) // according to country
            {
                var countrytax =  _data.countryVat.Find(x => x.Country == customer.Country);
                vat =  countrytax.Vat;
            }
            return SumPaidForItem * vat / 100;

        }
    }
}
