using System.Collections.Generic;

namespace TeamWork.SDK.Queries.Milestones
{
    public class MilestonesResponse
    {
        public string STATUS { get; set; }
        public List<Milestone> milestones { get; set; }
    }
}
