using System;
using System.Collections.Generic;
using System.Text;
using VatInvoice.Model;

namespace VatInvoice.Interface
{
    public interface IMakeInvoiceService
    {
        //Customer GetCustomer(int id);
       // Vendor GetVendor(int id);
       // decimal GetVatSize(int VendorId, int CustomerId);
       // decimal GetCountryVat(string country);
        decimal CountTaxSum(Customer customer, Vendor vendor, decimal SumPaidForItem);
    }
}
