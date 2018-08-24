using System.Collections.Generic;
using System.Data;
using static TeamWork.SDK.Queries.TimeTotalsOnProject.Time;

namespace TeamWork.SDK.DataTables.TimeTracking
{
    public class Total_Time_On_Project
    {
        public static DataTable EntriesTable;

        public static void InitTable()
        {
            EntriesTable = new DataTable();

            EntriesTable.Columns.Add("Project Name", typeof(string));
            EntriesTable.Columns.Add("Project Id", typeof(int));
            EntriesTable.Columns.Add("Company Id", typeof(int));
            EntriesTable.Columns.Add("Company Name", typeof(string));
            EntriesTable.Columns.Add("Total Estimated Hours", typeof(float));
            EntriesTable.Columns.Add("Active Minutes Estimated", typeof(float));
            EntriesTable.Columns.Add("Total Mins Estimated", typeof(float));
            EntriesTable.Columns.Add("Active Hours Estimated", typeof(float));
            EntriesTable.Columns.Add("Completed Hours Estimated", typeof(float));
            EntriesTable.Columns.Add("Completed Mins Estimated", typeof(float));
            EntriesTable.Columns.Add("Total Mins Sum", typeof(float));
            EntriesTable.Columns.Add("Non Billed Mins Sum", typeof(float));
            EntriesTable.Columns.Add("Non Billable Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Total Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Billed Mins Sum", typeof(float));
            EntriesTable.Columns.Add("Billed Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Billable Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Non Billable Mins Sum", typeof(float));
            EntriesTable.Columns.Add("Non Billed Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Billable Mins Sum", typeof(float));
        }
        /// <summary>
        /// Fill Data Table with time totals
        /// </summary>
        /// <param name="TimeTotalProject">TimeProject[]</param>
        public static void FillTable(List<TimeProject> TimeTotalProject)
        {
            InitTable();
            foreach (TimeProject entry in TimeTotalProject)
            {
                EntriesTable.Rows.Add(entry.name, entry.id, entry.company.Id,entry.company.Name,entry.TimeEstimates.TotalHorsEstimated,entry.TimeEstimates.ActiveMinsEstimated
                    ,entry.TimeEstimates.TotalMinsEstimated,entry.TimeEstimates.ActiveHoursEstimated,entry.TimeEstimates.CompletedHoursEstimated,entry.TimeEstimates.CompletedMinsEstimated
                    ,entry.TimeTotals.TotalMinsSum,entry.TimeTotals.NonBilledMinsSum,entry.TimeTotals.NonBillableHoursSum,entry.TimeTotals.TotalHoursSum,entry.TimeTotals.BilledMinsSum
                    ,entry.TimeTotals.BilledHoursSum,entry.TimeTotals.BillableHoursSum,entry.TimeTotals.NonBillableMinsSum,entry.TimeTotals.NonBilledHoursSum,entry.TimeTotals.BillableMinsSum);
            }
        }
    }
}
