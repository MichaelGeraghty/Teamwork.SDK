using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TeamWork.SDK.Helper;
using TeamWork.SDK.Queries.Milestones;
using TeamWork.SDK.Model;

namespace TeamWork.SDK.Queries.Projects
{
    public partial class Project
    {
        public Company company { get; set; }
        public bool starred { get; set; }
        public string name { get; set; }

        [JsonProperty(PropertyName = "show-announcement")]
        public bool ShowAnnouncement { get; set; }

        public string announcement { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public bool isProjectAdmin { get; set; }

        [JsonProperty(PropertyName = "created-on")]
        public string createdon { get; set; }
        public DateTime CreatedOn => createdon.ToDateTimeExactMin("yyyy-MM-ddTHH:mm:ssZ");

        public Category category { get; set; }

        [JsonProperty(PropertyName = "start-page ")]
        public string Startpage { get; set; }

        public string startDate { get; set; }
        [JsonIgnore]
        public DateTime StartDate
        {
            get { return DateTimeExtensions.ToDateTimeExactMin(startDate); }
        }

        public string logo { get; set; }
        public bool notifyeveryone { get; set; }
        public string id { get; set; }
        public int Id
        {
            get { return Int32.Parse(id); }
        }

        [JsonProperty("last-changed-on", NullValueHandling = NullValueHandling.Ignore)]
        public string lastChangedOn;
        [JsonIgnore]
        public DateTime LastChangedOn
        {
            get { return DateTime.Parse(lastChangedOn); }
        }

        public string endDate { get; set; }

        [JsonIgnore]
        public DateTime EndDate
        {
            get { return DateTimeExtensions.ToDateTimeExactMax(endDate); }
        }
        
        public Permissions permissions { get; set; }

        public List<Milestone> Milestones { get; set; }
        public List<TodoList> Tasklists { get; set; }
        public List<Person> People { get; set; }

        public string CalendarItemID { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Tag[] Tags { get; set; }

        [JsonIgnore]
        public double TaskCount
        {
            get
            {
                if (Tasklists == null) return 0;
                return Tasklists.Sum(p => p.TodoItems.Count());
            }
        }
        [JsonIgnore]
        public double TaskCountCompleted
        {
            get
            {
                if (Tasklists == null) return 0;
                return Tasklists.Sum(p => p.TodoItems.Count(i => i.Completed));
            }
        }
        [JsonIgnore]
        public int MilestoneCount
        {
            get
            {
                if (Milestones == null) return 0;
                return Milestones.Count();
            }
        }
        [JsonIgnore]
        public int MilestoneCountCompleted
        {
            get
            {
                if (Milestones == null) return 0;
                return Milestones.Count(p => p.Completed);
            }
        }

        [JsonIgnore]
        public double Progress
        {
            get
            {
                if (TaskCountCompleted > 0) return Math.Round(TaskCountCompleted / TaskCount * 100, 0);
                return 0;
            }
        }

        [JsonIgnore]
        public Milestone UpcomingMilestone
        {
            get
            {
                return Milestones?.OrderBy(p => p.Deadline).Take(1).First();
            }

        }

        [JsonIgnore]
        private DateTime lastSynchronized { get; set; }
        [JsonIgnore]
        public DateTime LastSynchronized
        {
            get { return lastSynchronized; }
            set { lastSynchronized = value; }

        }

        public void SetProjectEmailAddressCode(string code)
        {

        }
    }
}
