using Newtonsoft.Json;
using System;

namespace TeamWork.SDK.Model
{
    public class Category
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }
        public int Id
        {
            get { return id.Equals("") ? 0 : Int32.Parse(id);}
        }

        [JsonProperty("elements_count", NullValueHandling = NullValueHandling.Ignore)]
        public string ElementsCount { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("project-id", NullValueHandling = NullValueHandling.Ignore)]
        public int projectId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("parent-id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }
    }
}
