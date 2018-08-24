using System.Collections.Generic;
using TeamWork.SDK.Queries.Invoices;

namespace TeamWork.SDK.Queries.Queries.Invoices
{
    public class InvoiceResponse
    {
        public string STATUS { get; set; }
        public List<Invoice> invoices { get; set; }
    }
}
