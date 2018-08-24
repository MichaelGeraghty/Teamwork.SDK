using System.Net;
using System.Threading.Tasks;
using TeamWork.SDK.TeamWorkService;

namespace TeamWork.SDK.Queries.Projects
{
    public class ProjectHandler
    {
        private readonly Client _client;

        /// <summary>
        ///   Constructor for Project Handler
        /// </summary>
        /// <param name="client">TeamworkClient</param>
        public ProjectHandler(Client client)
        {
            _client = client;
        }


        /// <summary>
        ///   Returns all projects the user has access to
        /// </summary>
        /// <returns></returns>
        public async Task<ProjectsResponse> GetAllProjectsAsync()
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<ProjectsResponse>("projects.json" + "?status=ALL", null);
                if (data.StatusCode == HttpStatusCode.NotModified) return (ProjectsResponse)data.ContentObj;
                if (data.StatusCode == HttpStatusCode.OK) return (ProjectsResponse)data.ContentObj;
            }
            return null;
        }
        /// <summary>
        /// Get all projects the user has access to after a provided date
        /// </summary>
        /// <param name="date">string format(yyyymmdd)</param>
        /// <returns></returns>
        public async Task<ProjectsResponse> GetAllProjectsCreatedAfterDateAsync(string date)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var url = $"projects.json" + "?updatedAfterDate=" + date;
                var endpoint = url.ToString();
                var data = await client.GetAsync<ProjectsResponse>(endpoint, null);
                if (data.StatusCode == HttpStatusCode.OK) return (ProjectsResponse)data.ContentObj;
            }
            return null;
        }
    }
}
