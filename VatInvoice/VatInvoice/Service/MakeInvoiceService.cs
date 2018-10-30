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


        public Customer GetCustomer(int id) // get customer info by id
        {
            var user = _data.customers.FirstOrDefault(x => x.Id == id);
            return user;

        }
        public Vendor GetVendor(int id) // get vendor info by id
        {
            var vendor = _data.vendors.FirstOrDefault(x => x.Id == id);
            return vendor;
        }

        // get the vat size acording to customer and vendor living country  
        public decimal GetVatSize(int VendorId, int CustomerId)
        {
            var customer = GetCustomer(CustomerId);
            var vendor = GetVendor(VendorId);
            decimal vat = 0; // value added tax

            if (customer.EuResident == true && vendor.VatPayer == true) // according to country
            {
                var countrytax = GetCountryVat(customer.Country);
                vat = countrytax;
                return vat;
            }

            if (customer.EuResident == true && customer.Country == vendor.Country && vendor.VatPayer == true) // according to country
            {
                return GetCountryVat(customer.Country);
            }

            return vat; // 0
        }

        public decimal GetCountryVat(string country) // get vat size according to country
        {
            var findCountry = _data.countryVat.Find(x => x.Country == country);
            return findCountry.Vat;
        }

        // count what sum will be paid according to vat size and sum customer paid
        public decimal CountTaxSum(int VendorId, int CustomerId, decimal SumPaidForItem)
        {
            return SumPaidForItem * GetVatSize(VendorId, CustomerId) / 100;

        }
    }
}
