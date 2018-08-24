using System.Net;
using System.Threading.Tasks;
using TeamWork.SDK.TeamWorkService;

namespace TeamWork.SDK.Queries.Expenses
{
    public class ExpenseHandler
    {
        private readonly Client _client;

        public ExpenseHandler(Client client)
        {
            _client = client;
        }

        public async Task<ExpenseResponse> GetAllExpensesAsync()
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<ExpenseResponse>("expenses.json", null);
                if (data.StatusCode == HttpStatusCode.OK) return (ExpenseResponse)data.ContentObj;
            }
            return null;
        }
    }
}
