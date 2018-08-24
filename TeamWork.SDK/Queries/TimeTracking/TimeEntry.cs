using Newtonsoft.Json;
using System;
using TeamWork.SDK.Helper;
using TeamWork.SDK.Model;

namespace TeamWork.SDK.Queries.TimeTracking
{

    public partial class TimeEntry
    {
        [JsonProperty(PropertyName = "project-id")]
        public string projectId { get; set; }
        public int ProjectId => Int32.Parse(projectId);

        public string isBillable { get; set; }
        public string taskListId { get; set; }
        public int TaskListId
        {
            get { return taskListId.Equals("") ? 0 : Int32.Parse(taskListId); }
        }

        [JsonProperty(PropertyName = "todo-list-name")]
        public string todoListName { get; set; }

        [JsonProperty(PropertyName = "todo-item-name")]
        public string todoItemName { get; set; }

        public string isBilled { get; set; }

        [JsonProperty(PropertyName = "updated-date")]
        public string updatedDate { get; set; }
        public DateTime UpdatedDate => updatedDate.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        [JsonProperty(PropertyName = "todo-list-id")]
        public string todoListId { get; set; }
        public int TodoListId
        {
            get { return todoListId.Equals("") ? 0 : Int32.Parse(todoListId); }
        }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Tag[] Tags { get; set; }

        public bool canEdit { get; set; }
        public string taskEstimatedTime { get; set; }

        [JsonProperty(PropertyName = "company-name")]
        public string companyName { get; set; }

        public string id { get; set; }
        public int Id => Int32.Parse(id);

        public string invoiceNo { get; set; }
        public int InvoiceNo
        {
            get { return minutes.Equals("") ? 0 : Int32.Parse(invoiceNo); }
        }

        [JsonProperty(PropertyName = "person-last-name")]
        public string personLastName { get; set; }

        public string parentTaskName { get; set; }
        public string dateUserPerspective { get; set; }
        public DateTime DateUserPerspective => dateUserPerspective.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        public string minutes { get; set; }
        public int Minutes
        {
            get { return minutes.Equals("") ? 0 : Int32.Parse(minutes); }
        }

        [JsonProperty(PropertyName = "person-first-name")]
        public string personFirstName { get; set; }

        public string description { get; set; }

        [JsonProperty(PropertyName = "ticket-id")]
        public string ticketId { get; set; }
        public int TicketId
        {
            get { return ticketId.Equals("") ? 0 : Int32.Parse(ticketId); }
        }

        public string createdAt { get; set; }
        public DateTime CreatedAt => createdAt.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        public string taskIsPrivate { get; set; }
        public string parentTaskId { get; set; }
        public int ParentTaskId => Int32.Parse(parentTaskId);

        [JsonProperty(PropertyName = "company-id")]
        public string companyId { get; set; }
        public int CompanyId => Int32.Parse(companyId);

        [JsonProperty(PropertyName = "project-status")]
        public string projectStatus { get; set; }

        [JsonProperty(PropertyName = "person-id")]
        public string personId { get; set; }
        public int PersonId
        {
            get { return todoItemId.Equals("") ? 0 : Int32.Parse(personId); }
        }

        [JsonProperty(PropertyName = "project-name")]
        public string projectName {get; set;}

        [JsonProperty("task-tags", NullValueHandling = NullValueHandling.Ignore)]
        public Tag[] taskTags { get; set; }

        public string taskIsSubTask { get; set; }

        [JsonProperty(PropertyName = "todo-item-id")]
        public string todoItemId { get; set; }
        public int TodoItemId
        {
            get { return todoItemId.Equals("") ? 0 : Int32.Parse(todoItemId); }
        }

        public string date { get; set; }
        public DateTime Date => date.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");


        [JsonProperty(PropertyName = "has-start-time")]
        public string hasStartTime { get; set; }
        public bool? HasStartTime
        {
            get { return hasStartTime.Equals("1") ? true : false; }
        }

        public string hours { get; set; }
        public int Hours
        {
            get { return Int32.Parse(hours); }
        }
    }
}
