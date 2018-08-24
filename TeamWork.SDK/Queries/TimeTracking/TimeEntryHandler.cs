using System.Net;
using System.Threading.Tasks;
using TeamWork.SDK.TeamWorkService;

namespace TeamWork.SDK.Queries.TimeTracking
{
    public class TimeEntryHandler
    {
        private readonly Client _client;
   
        public TimeEntryHandler(Client client)
        {
            _client = client;
        }
        /// <summary>
        /// Get all time entries
        /// </summary>
        /// <param name="page">int page index</param>
        /// <param name="pageSize">int page size / number of results per page</param>
        /// <returns></returns>
        public async Task<TimeEntryResponse> GetAllTime_EntriesAsync(int page)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<TimeEntryResponse>("time_entries.json" + "?page=" +page+ "&pageSize=500" + "&projectType=ALL" + "&sortorder=DESC", null);
                if (data.StatusCode == HttpStatusCode.OK)
                {
                    var response = (TimeEntryResponse)data.ContentObj;
                    return response;
                }
            }
            return null;
        }
        /// <summary>
        /// Get all time entries in a provided date range
        /// </summary>
        /// <param name="page">int page index</param>
        /// <param name="pageSize">int page size / number of results per page</param>
        /// <param name="dateFrom">string date from yyyymmdd</param>
        /// <param name="dateTo">string date to yyyymmdd</param>
        /// <returns></returns>
        public async Task<TimeEntryResponse> GetAllTime_Entries_InDateRangeAsync(int page,string dateFrom,string dateTo)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<TimeEntryResponse>("time_entries.json" + "?page=" + page + "&pageSize=500" + "&fromDate=" + dateFrom + "&toDate=" + dateTo + "&projectType=ALL" + "&sortorder=DESC", null);
                if (data.StatusCode == HttpStatusCode.OK)
                {
                    var response = (TimeEntryResponse)data.ContentObj;
                    return response;
                }
            }
            return null;
        }
        /// <summary>
        /// Get all time entries for an individual providing user's id
        /// </summary>
        /// <param name="userId">int user to be queried id</param>
        /// <param name="page">int page index</param>
        /// <param name="pageSize">int page size / number of results per page</param>
        /// <returns></returns>
        public async Task<TimeEntryResponse> GetAllTime_EntriesAsync_WithID(int userId, int page)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<TimeEntryResponse>("time_entries.json" + "?userId=" + userId + "&page=" + page + "&pageSize=500" + "&projectType=ALL" + "&sortorder=DESC", null);
                if (data.StatusCode == HttpStatusCode.OK)
                {
                    var response = (TimeEntryResponse)data.ContentObj;
                    return response;
                }
            }
            return null;
        }

        public async Task<TimeEntryResponse> GetAllTime_EntriesAsync_Billable(string billable, int page)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var data = await client.GetAsync<TimeEntryResponse>("time_entries.json" + "?billableType=" + billable + "&page=" + page + "&pageSize=500" + "&projectType=ALL" + "&sortorder=DESC", null);
                if (data.StatusCode == HttpStatusCode.OK)
                {
                    var response = (TimeEntryResponse)data.ContentObj;
                    return response;
                }
            }
            return null;
        }
        /// <summary>
        /// Get all time entries for a project providing a project id
        /// </summary>
        /// <param name="projectId">project id to be queried</param>
        /// <param name="page">int page index</param>
        /// <param name="pageSize">int page size / number of results per page</param>
        /// <returns></returns>
        public async Task<TimeEntryResponse> GetAllTime_EntriesAsync_ForProject(int projectId, int page)
        {
            using (var client = new AuthorisedHttpClient(_client))
            {
                var url = $"projects/{projectId}/time_entries.json" + "?page=" + page + "&pageSize=500" + "&projectType=ALL" + "&sortorder=DESC";
                var endpoint = url.ToString();
                var data = await client.GetAsync<TimeEntryResponse>(endpoint, null);
                if (data.StatusCode == HttpStatusCode.OK)
                {
                    var response = (TimeEntryResponse)data.ContentObj;
                    return response;
                }
            }
            return null;
        }
    }
}
