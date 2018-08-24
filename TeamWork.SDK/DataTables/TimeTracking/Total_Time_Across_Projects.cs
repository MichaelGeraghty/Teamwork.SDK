using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TeamWork.SDK.Queries.TimeTotalsAcrossProjects;

namespace TeamWork.SDK.DataTables.TimeTracking
{
    public class Total_Time_Across_Projects
    {
        public static DataTable EntriesTable;

        public static void InitTable()
        {
            EntriesTable = new DataTable();

            EntriesTable.Columns.Add("Project Name", typeof(string));
            EntriesTable.Columns.Add("Project Id", typeof(int));
            EntriesTable.Columns.Add("Company Id", typeof(int));
            EntriesTable.Columns.Add("Company Name", typeof(string));
            EntriesTable.Columns.Add("Total Mins", typeof(float));
            EntriesTable.Columns.Add("Non Billed Mins", typeof(float));
            EntriesTable.Columns.Add("Billed Mins Sum", typeof(float));
            EntriesTable.Columns.Add("Total Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Non Billed Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Billed Hours Sum", typeof(float));
            EntriesTable.Columns.Add("Non Billable Mins Sum", typeof(float));
            EntriesTable.Columns.Add("Billable Mins Sum", typeof(float));
            EntriesTable.Columns.Add("Non Billable Hours", typeof(float)); 
            EntriesTable.Columns.Add("Billable Hours Sum", typeof(float));
        }

        public static void FillTable(List<TimeTotalsAcrossProjects> TimeTotalProjects)
        {
            InitTable();
            foreach (TimeTotalsAcrossProjects entry in TimeTotalProjects)
            {
                EntriesTable.Rows.Add(entry.name,entry.Id,entry.company.Id,entry.company.Name,entry.TotalMins,entry.TotalNonBilledMins,entry.TotalNonBilledMins,
                    entry.TotalHours,entry.TotalNonBilledHours,entry.TotalBilledHours,entry.TotalNonBillableMins,entry.TotalBillableMins,entry.TotalBillableHours);
            }
        }
    }
}
