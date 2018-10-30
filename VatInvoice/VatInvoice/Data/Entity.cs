using System;
using System.Collections.Generic;
using System.Text;
using VatInvoice.Model;

namespace VatInvoice.Data
{
    public class Entity
    {
        public List<Customer> customers = new List<Customer>()
           {
            new Customer() { Id = 11, FirstName = "Vladas", LastName = "Giedrikas", Country = "Lithuania", EuResident = true , VatPayer = false},
            new Customer() { Id = 12, FirstName = "Vardenis", LastName = "Pavardenis", Country = "India", EuResident = false, VatPayer = false },
            new Customer() { Id = 13, FirstName = "Jonas", LastName = "Jonaitis", Country = "France", EuResident = true, VatPayer = false },
            new Customer() { Id = 14, FirstName = "Petras", LastName = "Petraitis", Country = "Croatia", EuResident = true, VatPayer = true }
           };

        public List<Vendor> vendors = new List<Vendor>()
           {
            new Vendor() { Id = 1, CompanyName = "Travelers", VatPayer = true, Country = "Lithuania" },
            new Vendor() { Id = 2, CompanyName = "Flyer", VatPayer = false, Country = "Lithuania" }
           };

        public List<CountryVat> countryVat = new List<CountryVat>()
        {
            new CountryVat() {Country = "Poland", Vat = 18 },
            new CountryVat() {Country = "France", Vat = 25 },
            new CountryVat() {Country = "Lithuania", Vat = 21 },
            new CountryVat() {Country = "Croatia", Vat = 30 }
        };
    }
}
