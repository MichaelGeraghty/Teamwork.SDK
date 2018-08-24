using System;
using System.Collections.Generic;
using System.Data;
using TeamWork.SDK.Queries.Invoices;

namespace TeamWork.SDK.DataTables.Invoices
{
    public class Invoices
    {
        public static DataTable EntriesTable;

        public static void InitTable()
        {
            EntriesTable = new DataTable();

            EntriesTable.Columns.Add("Id", typeof(int));
            EntriesTable.Columns.Add("Project Name", typeof(string));
            EntriesTable.Columns.Add("Project Id", typeof(int));
            EntriesTable.Columns.Add("Company Name", typeof(string));
            EntriesTable.Columns.Add("Creator Id", typeof(int));
            EntriesTable.Columns.Add("Creator Last Name", typeof(string));
            EntriesTable.Columns.Add("Date Created", typeof(DateTime));
            EntriesTable.Columns.Add("Display Date", typeof(DateTime));
            EntriesTable.Columns.Add("Status", typeof(string));
            EntriesTable.Columns.Add("Total Time", typeof(float));
            EntriesTable.Columns.Add("Time Cost", typeof(float));
            EntriesTable.Columns.Add("Total Cost", typeof(float));
        }
        /// <summary>
        /// Fill table with invoices
        /// </summary>
        /// <param name="invoices">List<Invoice></param>
        public static void FillTable(List<Invoice> invoices)
        {
            InitTable();
            foreach (Invoice entry in invoices)
            {
                EntriesTable.Rows.Add(entry.Id,entry.projectName,entry.ProjectId,entry.companyName,entry.CreatedByUserId,entry.CreatedByUserLastName,entry.DateCreated,entry.DisplayDate,
                    entry.status,entry.TotalTimeDecimal,entry.TimeCost,entry.TimeCost);
            }
        }
    }
}
