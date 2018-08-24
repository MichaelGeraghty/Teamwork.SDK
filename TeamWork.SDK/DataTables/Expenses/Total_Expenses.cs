using System;
using System.Collections.Generic;
using System.Data;
using TeamWork.SDK.Queries.Expenses;

namespace TeamWork.SDK.DataTables.Expenses
{
    public class Total_Expenses
    {
        public static DataTable EntriesTable;

        public static void InitTable()
        {
            EntriesTable = new DataTable();

            EntriesTable.Columns.Add("Id", typeof(int));
            EntriesTable.Columns.Add("Project Id", typeof(int));
            EntriesTable.Columns.Add("Project Name", typeof(string));
            EntriesTable.Columns.Add("Name", typeof(string));
            EntriesTable.Columns.Add("Description", typeof(string));
            EntriesTable.Columns.Add("First Name", typeof(string));
            EntriesTable.Columns.Add("Last Name", typeof(string));
            EntriesTable.Columns.Add("User Id", typeof(int));
            EntriesTable.Columns.Add("Company Id", typeof(int));
            EntriesTable.Columns.Add("Company Name", typeof(string));
            EntriesTable.Columns.Add("Invoice Id", typeof(int));
            EntriesTable.Columns.Add("Date", typeof(DateTime));
            EntriesTable.Columns.Add("Cost", typeof(float));

        }
        /// <summary>
        /// Fill table with invoices
        /// </summary>
        /// <param name="expenses">List<Expense></param>
        public static void FillTable(List<Expense> expenses)
        {
            InitTable();
            foreach (Expense entry in expenses)
            {
                EntriesTable.Rows.Add(entry.Id,entry.ProjectId,entry.projectName,entry.name,entry.description,entry.createdByUserFirstname,
                    entry.createdByUserLastname,entry.CreatedByUserId,entry.companyId,entry.companyName, entry.InvoiceId,entry.Date,entry.Cost);
            }
        }
    }
}
