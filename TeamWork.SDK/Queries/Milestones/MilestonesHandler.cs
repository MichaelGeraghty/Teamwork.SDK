using System.Net;
using System.Threading.Tasks;
using TeamWork.SDK.TeamWorkService;

namespace TeamWork.SDK.Queries.Milestones
{
    public class MilestonesHandler
    {
        private readonly Client _client;

        /// <summary>
        ///   Constructor for Milestone Handler
        /// </summary>
        /// <param name="client">TeamworkClient</param>
        public MilestonesHandler(Client client)
        {
            _client = client;
        }
        /// <summary>
        /// Get all milestones available to the user
        /// </summary>
        /// <returns></returns>
        public async Task<MilestonesResponse> GetAllMilestonesAsync(int page)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<MilestonesResponse>("milestones.json" + "?page=" + page, null);
                if (data.StatusCode == HttpStatusCode.OK) return (MilestonesResponse)data.ContentObj;
            }
            return null;
        }

    }
}
