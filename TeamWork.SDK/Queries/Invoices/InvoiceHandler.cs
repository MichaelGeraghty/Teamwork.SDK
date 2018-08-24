using System.Net;
using System.Threading.Tasks;
using TeamWork.SDK.Queries.Queries.Invoices;
using TeamWork.SDK.TeamWorkService;

namespace TeamWork.SDK.Queries.Invoices
{
    public class InvoiceHandler
    {
        private readonly Client _client;

        public InvoiceHandler(Client client)
        {
            _client = client;
        }

        public async Task<InvoiceResponse> GetAllInvoicesAsync()
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<InvoiceResponse>("invoices.json", null);
                if (data.StatusCode == HttpStatusCode.OK) return (InvoiceResponse)data.ContentObj;
            }
            return null;
        }
    }
}
