using VatInvoice.Model;

namespace VatInvoice.Interface
{
    public interface IMakeInvoiceService
    {
        decimal GetVatSize(Customer customer, Vendor vendor);
    }
}
