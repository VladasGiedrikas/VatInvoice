using VatInvoice.Data;
using VatInvoice.Interface;
using VatInvoice.Model;

namespace VatInvoice.Service
{
    public class MakeInvoiceService : IMakeInvoiceService
    {
        // count what sum will be paid according to vat size and sum customer paid
        public decimal GetVatSize(Customer customer, Vendor vendor)
        {
            var _data = new Entity();

            decimal vat = 0; // value added tax 0 if other case not act

            if (customer.EuResident == true && vendor.VatPayer == true) // according to country
            {
                var countrytax = _data.countryVat.Find(x => x.Country == customer.Country);  //get vat size by country from entity
                vat = countrytax.Vat;              
            }

            if (customer.EuResident == true && customer.Country == vendor.Country && vendor.VatPayer == true) // according to country
            {
                var countrytax =  _data.countryVat.Find(x => x.Country == customer.Country); //get vat size by country from entity
                vat =  countrytax.Vat;
            }
            return vat;

        }
    }
}
