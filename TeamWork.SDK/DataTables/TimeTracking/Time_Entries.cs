using System;
using System.Collections.Generic;
using System.Data;
using TeamWork.SDK.Queries.TimeTracking;

namespace TeamWork.SDK.DataTables.TimeTracking
{
    public class Time_Entries
    {
        public static DataTable EntriesTable;

        public static void InitTable()
        {
            EntriesTable = new DataTable();

            EntriesTable.Columns.Add("Id", typeof(int));
            EntriesTable.Columns.Add("DateTime", typeof(DateTime));
            EntriesTable.Columns.Add("DateUserPerspective", typeof(DateTime));
            EntriesTable.Columns.Add("HasStartTime", typeof(bool));
            EntriesTable.Columns.Add("CreatedAt", typeof(DateTime));
            EntriesTable.Columns.Add("UpdatedDate", typeof(DateTime));
            EntriesTable.Columns.Add("ProjectName", typeof(string));
            EntriesTable.Columns.Add("ProjectId", typeof(int));
            EntriesTable.Columns.Add("ProjectStatus", typeof(string));
            EntriesTable.Columns.Add("UserFirstName", typeof(string));
            EntriesTable.Columns.Add("UserLastName", typeof(string));
            EntriesTable.Columns.Add("UserId", typeof(int));
            EntriesTable.Columns.Add("CanEdit", typeof(bool));
            EntriesTable.Columns.Add("EstimateEntriesTableime", typeof(string));
            EntriesTable.Columns.Add("ParentTaskName", typeof(string));
            EntriesTable.Columns.Add("ParentTaskId", typeof(int));
            EntriesTable.Columns.Add("TodoListId", typeof(int));
            EntriesTable.Columns.Add("TodoListName", typeof(string));
            EntriesTable.Columns.Add("TodoItemId", typeof(int));
            EntriesTable.Columns.Add("TodoItemName", typeof(string));
            EntriesTable.Columns.Add("TaskListId", typeof(int));
            EntriesTable.Columns.Add("TaskIsPrivate", typeof(string));
            EntriesTable.Columns.Add("Description", typeof(string));
            EntriesTable.Columns.Add("CompanyName", typeof(string));
            EntriesTable.Columns.Add("CompanyId", typeof(int));
            EntriesTable.Columns.Add("Billable", typeof(string));
            EntriesTable.Columns.Add("Billed", typeof(string));
            EntriesTable.Columns.Add("Hours", typeof(int));
            EntriesTable.Columns.Add("Minutes", typeof(int));
        }
        /// <summary>
        /// Fill table with time entries
        /// </summary>
        /// <param name="TimeEntries">List<TimeEntry></param>
        public static void FillTable(List<TimeEntry> TimeEntries)
        {
            InitTable();
            foreach(TimeEntry entry in TimeEntries)
            {
                EntriesTable.Rows.Add(
                    entry.Id,
                    entry.Date,
                    entry.DateUserPerspective,
                    entry.HasStartTime,
                    entry.CreatedAt,
                    entry.UpdatedDate,
                    entry.projectName,
                    entry.ProjectId,
                    entry.projectStatus,
                    entry.personFirstName,
                    entry.personLastName,
                    entry.PersonId,
                    entry.canEdit,
                    entry.taskEstimatedTime,
                    entry.parentTaskName,
                    entry.ParentTaskId,
                    entry.TodoListId,
                    entry.todoListName,
                    entry.TodoItemId,
                    entry.todoItemName,
                    entry.TaskListId,
                    entry.taskIsPrivate,
                    entry.description,
                    entry.companyName,
                    entry.CompanyId,
                    entry.isBillable,
                    entry.isBilled,
                    entry.Hours,
                    entry.Minutes
                    );
            }
        }
    }
}
