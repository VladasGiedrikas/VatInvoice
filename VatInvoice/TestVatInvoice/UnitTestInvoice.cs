using NSubstitute;
using System;
using VatInvoice;
using VatInvoice.Interface;
using VatInvoice.Model;
using VatInvoice.Service;
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
   

        [Fact]
        public void CountTaxSum_WhenCustomerAndVendorAreFromTheSameCountry()
        {
            Customer customer = new Customer()
            {
                FirstName = "Vladas",
                Country = "Lithuania",
                EuResident = true,
                VatPayer = false
            };

            Vendor vendor = new Vendor()
            {
                CompanyName = "Travelers",
                VatPayer = true,
                Country = "Lithuania"
            };
        

            _dataService.GetVatSize(customer, vendor).Returns(21);
            var result = _dataService.GetVatSize(customer, vendor);

            Assert.Equal(result, _dataService.GetVatSize(customer, vendor));
        }
        [Fact]
        public void Class_CountTaxSum_WhenCustomerAndVendorAreFromTheSameCountry()
        {
            Customer customer = new Customer()
            {
                FirstName = "Vladas",
                Country = "Lithuania",
                EuResident = true,
                VatPayer = false
            };

            Vendor vendor = new Vendor()
            {
                CompanyName = "Travelers",
                VatPayer = true,
                Country = "Lithuania"
            };

            var _dataService = new MakeInvoiceService();



            var result = _dataService.GetVatSize(customer, vendor);

            Assert.Equal(21, result);
        }
    }
}
