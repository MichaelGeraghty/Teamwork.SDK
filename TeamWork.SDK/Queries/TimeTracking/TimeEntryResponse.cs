using Newtonsoft.Json;
using System.Collections.Generic;

namespace TeamWork.SDK.Queries.TimeTracking
{
    public class TimeEntryResponse
    {
        public string STATUS { get; set; }
        [JsonProperty(PropertyName = "time-entries")]
        public List<TimeEntry> timeEntries { get; set; }
    }
}
