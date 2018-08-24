using System.Net;
using System.Threading.Tasks;
using TeamWork.SDK.TeamWorkService;

namespace TeamWork.SDK.Queries.TimeTotalsAcrossProjects
{
    public class TimeTotalsAcrossProjectsHandler
    {
        private readonly Client _client;

   
        public TimeTotalsAcrossProjectsHandler(Client client)
        {
            _client = client;
        }
        
        public async Task<TimeTotalsAcrossProjectsResponse> GetTotal_Time_On_Project()
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var url = $"projects/time/total.json" + "?projectType=ALL";
                var endpoint = url.ToString();
                var data = await client.GetAsync<TimeTotalsAcrossProjectsResponse>(endpoint, null);
                if (data.StatusCode == HttpStatusCode.OK)
                {
                    var response = (TimeTotalsAcrossProjectsResponse)data.ContentObj;
                    return response;
                }
            }
            return null;
        }
    }
}
