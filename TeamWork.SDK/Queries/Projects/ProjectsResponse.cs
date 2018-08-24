using System.Collections.Generic;

namespace TeamWork.SDK.Queries.Projects
{
    public class ProjectsResponse
    {
        public string STATUS { get; set; }
        public List<Project> projects { get; set; }
    }
}
