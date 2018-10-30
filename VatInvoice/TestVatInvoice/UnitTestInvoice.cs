using NSubstitute;
using System;
using VatInvoice;
using VatInvoice.Interface;
using VatInvoice.Model;
using Xunit;

namespace TestVatInvoice
{
    public class UnitTestInvoice
    {
        IMakeInvoiceService _dataService;

        public UnitTestInvoice()
        {
            _dataService = Substitute.For<IMakeInvoiceService>();
        }
         Customer customer = new Customer()
         { Id = 11, FirstName = "Vladas",
            LastName = "Giedrikas",
            Country = "Lithuania",
            EuResident = true ,
            VatPayer = false
         };

        Vendor vendor = new Vendor()
        { Id = 1, CompanyName = "Travelers",
          VatPayer = true, Country = "Lithuania"
        };

        [Fact]
        public void When_Customer_And_Vendor_Are_From_The_Same_Country()
        {
           
            var amount = 1000;

            _dataService.CountTaxSum(customer, vendor, amount).Returns(210);
            var result = _dataService.CountTaxSum(customer, vendor, amount);

            Assert.Equal(result, _dataService.CountTaxSum(customer, vendor, amount));
        }
    }
}
