using System;
using System.Collections.Generic;
using System.Data;
using TeamWork.SDK.Queries.Projects;

namespace TeamWork.SDK.DataTables.Projects
{
    public class Total_Projects
    {
        public static DataTable EntriesTable;

        public static void InitTable()
        {
            EntriesTable = new DataTable();

            EntriesTable.Columns.Add("Company Name", typeof(string));
            EntriesTable.Columns.Add("Company Id", typeof(int));
            EntriesTable.Columns.Add("Starred", typeof(bool));
            EntriesTable.Columns.Add("Project Name", typeof(string));
            EntriesTable.Columns.Add("Project Id", typeof(int));
            EntriesTable.Columns.Add("Category Name", typeof(string));
            EntriesTable.Columns.Add("Category Id", typeof(int));//unresolved issue when passing as type of int
            EntriesTable.Columns.Add("Description", typeof(string));
            EntriesTable.Columns.Add("Status", typeof(string));
            EntriesTable.Columns.Add("Created On", typeof(DateTime));
            EntriesTable.Columns.Add("Start Date", typeof(DateTime));
            EntriesTable.Columns.Add("End Date", typeof(DateTime));
            EntriesTable.Columns.Add("Last Changed On", typeof(DateTime));
        }
        /// <summary>
        /// Fill Data Table with Projects
        /// </summary>
        /// <param name="Projects">List<Project></param>
        public static void FillTable(List<Project> Projects)
        {
            InitTable();
            foreach (Project entry in Projects)
            {
                EntriesTable.Rows.Add(entry.company.Name,entry.company.Id,entry.starred,entry.name,
                    entry.id,entry.category.Name,entry.category.Id,entry.description,entry.status,
                    entry.CreatedOn,entry.StartDate,entry.EndDate,entry.LastChangedOn);
            }
        }
    }
}
