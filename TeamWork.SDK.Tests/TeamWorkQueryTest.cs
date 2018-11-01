using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamWork.SDK.Helper;
using TeamWork.SDK.Queries.Expenses;
using TeamWork.SDK.Queries.Invoices;
using TeamWork.SDK.Queries.Milestones;
using TeamWork.SDK.Queries.Projects;
using TeamWork.SDK.Queries.TimeTotalsAcrossProjects;
using TeamWork.SDK.Queries.TimeTotalsOnProject;
using TeamWork.SDK.Queries.TimeTracking;
using TeamWork.SDK.TeamWorkService;
using static TeamWork.SDK.Queries.TimeTotalsOnProject.Time;

namespace TeamWork.SDK.Tests
{
    [TestClass]
    public class TeamWorkQueryTest
    {
        private Client client;
        private Credentials credentials = new Credentials();

        private List<Project> Projects = new List<Project>();
        private List<TimeEntry> TimeEntries = new List<TimeEntry>();
        private List<Milestone> Milestones = new List<Milestone>();
        private List<Invoice> Invoices = new List<Invoice>();
        private List<TimeProject> TimeTotalProject = new List<TimeProject>();
        private List<TimeTotalsAcrossProjects> TimeTotalsAcrossProjects = new List<TimeTotalsAcrossProjects>();
        private List<Expense> Expenses = new List<Expense>();

        [TestMethod]
        public async Task TestGet_AllProjects()
        {
            client = new Client();
            client.Init(credentials.ApiKey,credentials.InstallationName);

            var data = await new ProjectHandler(client).GetAllProjectsAsync();
            Projects = data.projects;
            //Fill datatable
            DataTables.Projects.Total_Projects.FillTable(Projects);
        }

        [TestMethod]
        public async Task TestProjectsCreated_After_Date()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);

            var data = await new ProjectHandler(client).GetAllProjectsCreatedAfterDateAsync("20170603");
            Projects = data.projects;
            //Fill datatable
            DataTables.Projects.Total_Projects.FillTable(Projects);
        }

        [TestMethod]
        public async Task TestTime_Entries_RetrieveAll()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);
            var page = 1;
            var count = 0;
            do
            {
                var data = await new TimeEntryHandler(client).GetAllTime_EntriesAsync(page);
                TimeEntries.AddRange(data.timeEntries);
                var max = TimeEntries.Count-1;
                if (count == max)
                    break;
                count = TimeEntries.Count - 1;
                page++;
            }
            while (true);
            //Fill datatable
            DataTables.TimeTracking.Time_Entries.FillTable(TimeEntries);
        }

        [TestMethod]
        public async Task TestTime_Entries_RetrieveAll_BetweenDateRange()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);
            var page = 1;
            var count = 0;
            do
            {
                var data = await new TimeEntryHandler(client).GetAllTime_Entries_InDateRangeAsync(page,"20180801","20180807");
                TimeEntries.AddRange(data.timeEntries);
                var max = TimeEntries.Count - 1;
                if (count == max)
                    break;
                count = TimeEntries.Count - 1;
                page++;
            }
            while (true);
            //Fill datatable
            DataTables.TimeTracking.Time_Entries.FillTable(TimeEntries);
        }

        [TestMethod]
        public async Task TestTime_Entries_WithUserId()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);
            var page = 1;
            var userId = 199585;
            var count = 0;
            do
            {
                var data = await new TimeEntryHandler(client).GetAllTime_EntriesAsync_WithID(userId, page);
                TimeEntries.AddRange(data.timeEntries);
                var max = TimeEntries.Count - 1;
                if (count == max)
                    break;
                count = TimeEntries.Count - 1;
                page++;
            }
            while (true);
            //Fill datatable
            DataTables.TimeTracking.Time_Entries.FillTable(TimeEntries);
        }

        [TestMethod]
        public async Task TestTime_Entries_Billable()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);
            var page = 1;
            var billable = "billable";
            var count = 0;
            do
            {
                var data = await new TimeEntryHandler(client).GetAllTime_EntriesAsync_Billable(billable, page);
                TimeEntries.AddRange(data.timeEntries);
                var max = TimeEntries.Count - 1;
                if (count == max)
                    break;
                count = TimeEntries.Count - 1;
                page++;
            }
            while (true);
            //Fill datatable
            DataTables.TimeTracking.Time_Entries.FillTable(TimeEntries);
        }

        [TestMethod]
        public async Task TestTime_Entries_ForProjectID()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);
            var page = 1;
            var projectId = 314124;
            var count = 0;
            do
            {
                var data = await new TimeEntryHandler(client).GetAllTime_EntriesAsync_ForProject(projectId, page);
                TimeEntries.AddRange(data.timeEntries);
                var max = TimeEntries.Count - 1;
                if (count == max)
                    break;
                count = TimeEntries.Count - 1;
                page++;
            }
            while (true);
            //Fill datatable
            DataTables.TimeTracking.Time_Entries.FillTable(TimeEntries);
        }

        [TestMethod]
        public async Task TestTotal_Time_On_Project_WthProjectID()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);
            var projectId = 243641;

            var data = await new TimeHandler(client).GetTotal_Time_On_Project_WthProjectID(projectId);
            TimeTotalProject = data.Projects;
            //Fill datatable
            DataTables.TimeTracking.Total_Time_On_Project.FillTable(TimeTotalProject);
        }

        [TestMethod]
        public async Task TestTotal_Time_Across_Projects()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);

          
                var data = await new TimeTotalsAcrossProjectsHandler(client).GetTotal_Time_On_Project();
                TimeTotalsAcrossProjects = data.Projects;

            //Fill datatable
            DataTables.TimeTracking.Total_Time_Across_Projects.FillTable(TimeTotalsAcrossProjects);
        }

        [TestMethod]
        public async Task TestGet_All_Milestones()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);

            var page = 1;
            var count = 0;
            do
            {
                var data = await new MilestonesHandler(client).GetAllMilestonesAsync(page);
                Milestones.AddRange(data.milestones);
                var max = Milestones.Count - 1;
                if (count == max)
                    break;
                count = Milestones.Count - 1;
                page++;
            }
            while (true);
            //Fill datatable
            DataTables.Milestones.Total_Milestones.FillTable(Milestones);
        }

        [TestMethod]
        public async Task TestGet_All_Invoices()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);

            var data = await new InvoiceHandler(client).GetAllInvoicesAsync();
            Invoices.AddRange(data.invoices);
              
            //Fill datatable
            DataTables.Invoices.Invoices.FillTable(Invoices);
        }

        [TestMethod]
        public async Task TestGet_All_Expenses()
        {
            client = new Client();
            client.Init(credentials.ApiKey, credentials.InstallationName);

            var data = await new ExpenseHandler(client).GetAllExpensesAsync();
            Expenses.AddRange(data.expenses);

            //Fill datatable
            DataTables.Expenses.Total_Expenses.FillTable(Expenses);
        }
    }
}
