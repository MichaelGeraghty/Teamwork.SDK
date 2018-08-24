using System.Net;
using System.Threading.Tasks;
using TeamWork.SDK.TeamWorkService;

namespace TeamWork.SDK.Queries.TimeTotalsOnProject
{
    public class TimeHandler
    {
        private readonly Client _client;

        /// <summary>
        ///   Constructor for Time Handler
        /// </summary>
        /// <param name="client">TeamworkClient</param>
        public TimeHandler(Client client)
        {
            _client = client;
        }


        /// <summary>
        /// Get total time on project with a provided project id
        /// </summary>
        /// <param name="projectId">project id to be queried</param>
        /// <returns></returns>
        public async Task<TimeTotalsAcrossProjectsResponse> GetTotal_Time_On_Project_WthProjectID(int projectId)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var url = $"projects/{projectId}/time/total.json";
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
