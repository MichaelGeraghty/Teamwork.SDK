using Newtonsoft.Json;
using System.Collections.Generic;

namespace TeamWork.SDK.Queries.TimeTotalsAcrossProjects
{
    public class TimeTotalsAcrossProjectsResponse
    {
        [JsonProperty("STATUS")]
        public string STATUS { get; set; }

        [JsonProperty("projects")]
        public List<TimeTotalsAcrossProjects> Projects { get; set; }
    }
}
