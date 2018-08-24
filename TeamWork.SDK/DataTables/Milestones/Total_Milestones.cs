using System;
using System.Collections.Generic;
using System.Data;
using TeamWork.SDK.Queries.Milestones;

namespace TeamWork.SDK.DataTables.Milestones
{
    public class Total_Milestones
    {
        public static DataTable EntriesTable;

        public static void InitTable()
        {
            EntriesTable = new DataTable();

            EntriesTable.Columns.Add("Id", typeof(int));
            EntriesTable.Columns.Add("Title", typeof(string));
            EntriesTable.Columns.Add("Project Id",typeof(int));
            EntriesTable.Columns.Add("Project Name", typeof(string));
            EntriesTable.Columns.Add("Can Complete", typeof(bool));
            EntriesTable.Columns.Add("Completer Id", typeof(int));
            EntriesTable.Columns.Add("Comments Count", typeof(int));
            EntriesTable.Columns.Add("Private", typeof(bool));
            EntriesTable.Columns.Add("Status", typeof(string));
            EntriesTable.Columns.Add("Created On", typeof(DateTime));
            EntriesTable.Columns.Add("Completed On", typeof(DateTime));
            EntriesTable.Columns.Add("Can Edit", typeof(bool));
            EntriesTable.Columns.Add("Company Name", typeof(string));
            EntriesTable.Columns.Add("Company Id", typeof(int));
            EntriesTable.Columns.Add("Last Changed On", typeof(DateTime));
            EntriesTable.Columns.Add("Completed", typeof(bool));
            EntriesTable.Columns.Add("Description", typeof(string));
            EntriesTable.Columns.Add("Responsible Party Id", typeof(int));
            EntriesTable.Columns.Add("Responsible Party Type", typeof(string));
            EntriesTable.Columns.Add("Responsible Party First Name", typeof(string));
            EntriesTable.Columns.Add("Responsible Party Last Name", typeof(string));
            EntriesTable.Columns.Add("Deadline", typeof(DateTime));

        }

        /// <summary>
        /// Fill Data Table with Milestones
        /// </summary>
        /// <param name="Milestones">List<Milestone>List<Milestone></param>
        public static void FillTable(List<Milestone> Milestones)
        {
            InitTable();
            foreach (Milestone entry in Milestones)
            {
                EntriesTable.Rows.Add(entry.Id, entry.Title, entry.ProjectId,entry.ProjectName,entry.CanComplete
                    ,1,entry.CommentsCount,entry.Private,entry.Status,entry.CreatedOn
                    ,entry.CompletedOn,entry.CanEdit,entry.CompanyName, entry.CompanyId,entry.LastChangedOn,entry.Completed,
                    entry.Description,entry.ResponsiblePartId,entry.ResponsiblePartyType,entry.ResponsiblePartyFirstname,
                    entry.ResponsiblePartyLastname,entry.Deadline);
            }
        }
    }
}
