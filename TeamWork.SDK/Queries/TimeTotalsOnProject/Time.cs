using Newtonsoft.Json;
using TeamWork.SDK.Model;

namespace TeamWork.SDK.Queries.TimeTotalsOnProject
{
    public class Time
    {
        public class TimeEstimates
        {
            [JsonProperty("total-hours-estimated")]
            public string totalHoursEstimated { get; set; }
            public float TotalHorsEstimated => float.Parse(totalHoursEstimated);

            [JsonProperty("active-mins-estimated")]
            public string activeMinsEstimated { get; set; }
            public float ActiveMinsEstimated => float.Parse(activeMinsEstimated);

            [JsonProperty("total-mins-estimated")]
            public string totalMinsEstimated { get; set; }
            public float TotalMinsEstimated => float.Parse(totalMinsEstimated);

            [JsonProperty("active-hours-estimated")]
            public string activeHoursEstimated { get; set; }
            public float ActiveHoursEstimated => float.Parse(activeHoursEstimated);

            [JsonProperty("completed-hours-estimated")]
            public string completedHoursEstimated { get; set; }
            public float CompletedHoursEstimated => float.Parse(completedHoursEstimated);

            [JsonProperty("completed-mins-estimated")]
            public string completedMinsEstimated { get; set; }
            public float CompletedMinsEstimated => float.Parse(completedMinsEstimated);
        }

        public class TimeTotals
        {

            [JsonProperty("total-mins-sum")]
            public string totalMinsSum { get; set; }
            public float TotalMinsSum => float.Parse(totalMinsSum);

            [JsonProperty("non-billed-mins-sum")]
            public string nonBilledMinsSum { get; set; }
            public float NonBilledMinsSum => float.Parse(nonBilledMinsSum);

            [JsonProperty("non-billable-hours-sum")]
            public string nonBillableHoursSum { get; set; }
            public float NonBillableHoursSum => float.Parse(nonBillableHoursSum);


            [JsonProperty("total-hours-sum")]
            public string totalHoursSum { get; set; }
            public float TotalHoursSum => float.Parse(totalHoursSum);

            [JsonProperty("billed-mins-sum")]
            public string billedMinsSum { get; set; }
            public float BilledMinsSum => float.Parse(billedMinsSum);

            [JsonProperty("billed-hours-sum")]
            public string billedHoursSum { get; set; }
            public float BilledHoursSum => float.Parse(billedHoursSum);

            [JsonProperty("billable-hours-sum")]
            public string billableHoursSum { get; set; }
            public float BillableHoursSum => float.Parse(billableHoursSum);

            [JsonProperty("non-billable-mins-sum")]
            public string nonBillableMinsSum { get; set; }
            public float NonBillableMinsSum => float.Parse(nonBillableMinsSum);

            [JsonProperty("non-billed-hours-sum")]
            public string nonBilledHoursSum { get; set; }
            public float NonBilledHoursSum => float.Parse(nonBilledHoursSum);

            [JsonProperty("billable-mins-sum")]
            public string billableMinsSum { get; set; }
            public float BillableMinsSum => float.Parse(billableMinsSum);
        }

        public partial class TimeProject
        {
            [JsonProperty("time-estimates")]
            public TimeEstimates TimeEstimates { get; set; }

            public string name { get; set; }

            public int id { get; set; }

            [JsonProperty("time-totals")]
            public TimeTotals TimeTotals { get; set; }

            [JsonProperty("company")]
            public Company company { get; set; }

        }
    }
}
