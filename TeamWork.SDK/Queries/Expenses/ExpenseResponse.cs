using System.Collections.Generic;

namespace TeamWork.SDK.Queries.Expenses
{
    public class ExpenseResponse
    {
        public string STATUS { get; set; }
        public List<Expense> expenses { get; set; }
    }
}
