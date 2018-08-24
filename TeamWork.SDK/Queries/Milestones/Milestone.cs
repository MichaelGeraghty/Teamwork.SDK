using Newtonsoft.Json;
using System;
using TeamWork.SDK.Helper;
using TeamWork.SDK.Model;

namespace TeamWork.SDK.Queries.Milestones
{
    public class Milestone
    {
        [JsonIgnore]
        public string notify { get; set; }

        [JsonIgnore]
        public string CalendarItemID { get; set; }

        [JsonProperty("project-id", NullValueHandling = NullValueHandling.Ignore)]
        public int ProjectId { get; set; }

        [JsonProperty("canComplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool CanComplete { get; set; }

        [JsonProperty("responsible-party-id", NullValueHandling = NullValueHandling.Ignore)]
        public string responsiblePartyId { get; set; }
        public int ResponsiblePartId => Int32.Parse(responsiblePartyId);

        [JsonProperty("completer-id", NullValueHandling = NullValueHandling.Ignore)]
        public string completerId { get; set; }
        public int CompleterId
        {
            get { return completerId==null ? 0 : Int32.Parse(completerId); }
        }

        [JsonProperty("comments-count", NullValueHandling = NullValueHandling.Ignore)]
        public string commentsCount { get; set; }
        public int CommentsCount => Int32.Parse(commentsCount);

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool Private { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("completed-on", NullValueHandling = NullValueHandling.Ignore)]
        public string completedOn { get; set; }
        public DateTime CompletedOn => completedOn.ToDateTimeExactMax("yyyy-MM-ddTHH:mm:ssZ");

        [JsonProperty("created-on", NullValueHandling = NullValueHandling.Ignore)]
        public string createdOn { get; set; }
        public DateTime CreatedOn => createdOn.ToDateTimeExactMax("yyyy-MM-ddTHH:mm:ssZ");

        [JsonProperty("canEdit", NullValueHandling = NullValueHandling.Ignore)]
        public bool CanEdit { get; set; }

        [JsonProperty("responsible-party-type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponsiblePartyType { get; set; }

        [JsonProperty("isprivate", NullValueHandling = NullValueHandling.Ignore)]
        public string Isprivate { get; set; }

        [JsonProperty("company-name", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string id { get; set; }
        public int Id => Int32.Parse(id);

        [JsonProperty("last-changed-on", NullValueHandling = NullValueHandling.Ignore)]
        public string lastChangedOn { get; set; }
        public DateTime LastChangedOn => DateTime.Parse(lastChangedOn);


        [JsonProperty("completed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Completed { get; set; }

        [JsonProperty("reminder", NullValueHandling = NullValueHandling.Ignore)]
        public string Reminder { get; set; }

        [JsonProperty("tasklists", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Tasklists { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("responsible-party-firstname", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponsiblePartyFirstname { get; set; }

        [JsonProperty("completer-firstname", NullValueHandling = NullValueHandling.Ignore)]
        public string CompleterFirstname { get; set; }

        [JsonProperty("responsible-party-ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponsiblePartyIds { get; set; }

        [JsonProperty("responsible-party-names", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponsiblePartyNames { get; set; }

        [JsonProperty("responsible-party-lastname", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponsiblePartyLastname { get; set; }

        [JsonProperty("company-id", NullValueHandling = NullValueHandling.Ignore)]
        public string companyId { get; set; }
        public int CompanyId => Int32.Parse(companyId);

        [JsonProperty("creator-id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        [JsonProperty("completer-lastname", NullValueHandling = NullValueHandling.Ignore)]
        public string CompleterLastname { get; set; }

        [JsonProperty("project-name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        [JsonProperty("deadline", NullValueHandling = NullValueHandling.Ignore)]
        public string deadline { get; set; }
        public DateTime Deadline => deadline.ToDateTimeExactMax("yyyy-MM-dd");

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Tag[] Tags { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }
}
