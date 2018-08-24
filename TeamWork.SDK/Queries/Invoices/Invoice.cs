using Newtonsoft.Json;
using System;
using TeamWork.SDK.Helper;

namespace TeamWork.SDK.Queries.Invoices
{
    public class Invoice
    {
        [JsonProperty(PropertyName = "project-id")]
        public string projectId { get; set; }
        public int ProjectId => Int32.Parse(projectId);

        [JsonProperty(PropertyName = "exported-by-user-id")]
        public string exportedByUserId { get; set; }
        public int ExportedByUserId => Int32.Parse(exportedByUserId);

        [JsonProperty(PropertyName = "created-by-user-firstname")]
        public string CreatedByUserFirstName { get; set; }

        public string Description { get; set; }

        [JsonProperty(PropertyName = "fixed-cost")]
        public string fixedCost { get; set; }

        public string status { get; set; }

        [JsonProperty(PropertyName = "date-created")]
        public string dateCreated { get; set; }
        public DateTime DateCreated => dateCreated.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        [JsonProperty(PropertyName = "exported-by-user-lastname")]
        public string exportedByUserLastName { get; set; }

        [JsonProperty(PropertyName = "po-number")]
        public string poNumber { get; set; }

        [JsonProperty(PropertyName = "project-name")]
        public string projectName { get; set; }

        [JsonProperty(PropertyName = "display-date")]
        public string displayDate { get; set; }
        public DateTime DisplayDate => dateCreated.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        [JsonProperty(PropertyName = "exported-date")]
        public string exportedDate { get; set; }
        public DateTime ExportedDate => exportedDate.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        [JsonProperty(PropertyName = "created-by-user-id")]
        public string createdByUserId { get; set; }
        public int CreatedByUserId => Int32.Parse(createdByUserId);

        [JsonProperty(PropertyName = "update-by-user-id")]
        public string updateByUserId { get; set; }
        public int UpdateByUserId => Int32.Parse(updateByUserId);

        [JsonProperty(PropertyName = "created-by-user-lastname")]
        public string CreatedByUserLastName { get; set; }

        [JsonProperty(PropertyName = "company-name")]
        public string companyName { get; set; }

        public string id { get; set; }
        public int Id => Int32.Parse(id);

        [JsonProperty(PropertyName = "date-updated")]
        public string dateUpdated { get; set; }
        public DateTime DateUpdated => dateUpdated.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        [JsonProperty(PropertyName = "edited-by-user-lastname")]
        public string editedByUserLastName { get; set; }

        [JsonProperty(PropertyName = "edited-by-user-firstname")]
        public string editedByUserfirstName { get; set; }

        [JsonProperty(PropertyName = "currency-code")]
        public string currencyCode { get; set; }

        [JsonProperty(PropertyName = "total-time")]
        public int totalTime { get; set; }

        [JsonProperty(PropertyName = "total-time-decimal")]
        public string totalTimeDecimal { get; set; }
        public float TotalTimeDecimal => float.Parse(totalTimeDecimal);

        [JsonProperty(PropertyName = "time-cost")]
        public string timeCost { get; set; }
        public float TimeCost => float.Parse(timeCost);

        [JsonProperty(PropertyName = "total-cost")]
        public string totalCost { get; set; }
        public float TotalCost => float.Parse(totalCost);

    }
}
