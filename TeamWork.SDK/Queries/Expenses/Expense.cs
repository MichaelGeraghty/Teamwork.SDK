using Newtonsoft.Json;
using System;
using TeamWork.SDK.Helper;

namespace TeamWork.SDK.Queries.Expenses
{
    public class Expense
    {
        [JsonProperty(PropertyName = ("invoice-id"))]
        public string invoiceId { get; set; }
        public int InvoiceId
        {
            get { return invoiceId.Equals("") ? 0 : Int32.Parse(invoiceId); }
        }

        [JsonProperty(PropertyName = ("project-id"))]
        public string projectId { get; set; }
        public int ProjectId
        {
            get { return projectId.Equals("") ? 0 : Int32.Parse(projectId); }
        }

        public string name { get; set; }
        public string description { get; set; }

        [JsonProperty(PropertyName = ("created-by-user-firstname"))]
        public string createdByUserFirstname { get; set; }

        [JsonProperty(PropertyName = ("company-id"))]
        public string companyId { get; set; }

        [JsonProperty(PropertyName = ("project-name"))]
        public string projectName { get; set; }

        [JsonProperty(PropertyName = ("created-by-user-id"))]
        public string createdByUserId { get; set; }
        public int CreatedByUserId
        {
            get { return createdByUserId.Equals("") ? 0 : Int32.Parse(createdByUserId); }
        }

        [JsonProperty(PropertyName = ("created-by-user-lastname"))]
        public string createdByUserLastname { get; set; }

        public string id { get; set; }
        public int Id
        {
            get { return id.Equals("") ? 0 : Int32.Parse(id); }
        }

        public string date { get; set; }
        public DateTime Date
        {
            get { return date.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ"); }
        }

        [JsonProperty(PropertyName = ("company-name"))]
        public string companyName { get; set; }

        public string cost { get; set; }
        public float Cost
        {
            get { return cost.Equals("") ? 0 : float.Parse(cost); }
        }
    }
}
