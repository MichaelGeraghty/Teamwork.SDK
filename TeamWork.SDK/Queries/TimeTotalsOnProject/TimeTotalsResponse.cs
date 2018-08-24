using Newtonsoft.Json;
using System.Collections.Generic;
using static TeamWork.SDK.Queries.TimeTotalsOnProject.Time;

namespace TeamWork.SDK.Queries.TimeTotalsOnProject
{
    public class TimeTotalsAcrossProjectsResponse
    {
        [JsonProperty("STATUS")]
        public string STATUS { get; set; }

        [JsonProperty("projects")]
        public List<TimeProject> Projects { get; set; }
    }
}
