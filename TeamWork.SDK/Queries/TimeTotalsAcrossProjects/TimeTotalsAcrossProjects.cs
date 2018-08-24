using Newtonsoft.Json;
using System;
using TeamWork.SDK.Model;

namespace TeamWork.SDK.Queries.TimeTotalsAcrossProjects
{
    public class TimeTotalsAcrossProjects
    {
       
        [JsonProperty("company")]
        public Company company { get; set; }

        public string name { get; set; }
        public string totalNonBilledMins { get; set; }
        public int TotalNonBilledMins
        {
            get { return Int32.Parse(totalNonBilledMins); }
        }

        public string totalBillableHours { get; set; }
        public float TotalBillableHours
        {
            get { return float.Parse(totalBillableHours); }
        }

        public string totalBillableMins { get; set; }
        public int TotalBillableMins
        {
            get { return Int32.Parse(totalBillableMins); }
        }

        public string totalNonBillableMins { get; set; }
        public int TotalNonBillableMins
        {
            get { return Int32.Parse(totalNonBillableMins); }
        }

        public string totalMins { get; set; }
        public int TotalMins
        {
            get { return Int32.Parse(totalMins); }
        }

        public string totalNonBillableHours { get; set; }
        public float TotalNonBillableHours
        {
            get { return float.Parse(totalNonBillableHours); }
        }

        public string totalBilledHours { get; set; }
        public float TotalBilledHours
        {
            get { return float.Parse(totalBilledHours); }
        }

        public string totalHours { get; set; }
        public float TotalHours
        {
            get { return float.Parse(totalHours); }
        }

        public string totalNonBilledHours { get; set; }
        public float TotalNonBilledHours
        {
            get { return float.Parse(totalBilledHours); }
        }

        public string id { get; set; }
        public int Id
        {
            get { return Int32.Parse(id); }
        }

        public string totalBilledTime { get; set; }
        public float TotalBilledTime
        {
            get { return float.Parse(totalBilledTime); }
        }

        public string totalBilledMins { get; set; }
        public int TotalBilledMins
        {
            get { return Int32.Parse(totalBilledMins); }
        }
    }
}
