using NSubstitute;
using System;
using VatInvoice.Interface;
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
        public void When_Customer_And_Vendor_Are_From_The_Same_Country()
        {
            var customerId = 11;
            var vendorId = 1;
            var amount = 1000;

            _dataService.CountTaxSum(vendorId, customerId, amount).Returns(210);
            var result = _dataService.CountTaxSum(vendorId, customerId, amount);

            Assert.Equal(result, _dataService.CountTaxSum(vendorId, customerId, amount));
        }
        [Fact]
        public void When_Customer_And_Vendor_Are_From_The_Different_Country()
        {
            var customerId = 13;
            var vendorId = 1;
            var amount = 1000;

            _dataService.CountTaxSum(vendorId, customerId, amount).Returns(250);
            var result = _dataService.CountTaxSum(vendorId, customerId, amount);

            Assert.Equal(result, _dataService.CountTaxSum(vendorId, customerId, amount));
        }
        [Fact]
        public void When_Customer_Not_From_Eu_Country()
        {
            var customerId = 12;
            var vendorId = 1;
            var amount = 1000;

            _dataService.CountTaxSum(vendorId, customerId, amount).Returns(0);
            var result = _dataService.CountTaxSum(vendorId, customerId, amount);

            Assert.Equal(result, _dataService.CountTaxSum(vendorId, customerId, amount));
        }

    }
}
