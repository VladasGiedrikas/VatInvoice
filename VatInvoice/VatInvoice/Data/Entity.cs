using System.Collections.Generic;
using VatInvoice.Model;

namespace VatInvoice.Data
{
    public class Entity
    {
        public List<CountryVat> countryVat = new List<CountryVat>()
        {
            new CountryVat() {Country = "Poland", Vat = 18 },
            new CountryVat() {Country = "France", Vat = 25 },
            new CountryVat() {Country = "Lithuania", Vat = 21 },
            new CountryVat() {Country = "Croatia", Vat = 30 }
        };
    }
}
