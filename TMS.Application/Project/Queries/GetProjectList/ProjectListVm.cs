using System.Collections;
using System.Collections.Generic;

namespace TMS.Application.Project.Queries.GetProjectList
{
    public class ProjectListVm
    {
        public IList<ProjectLookupDto> Projects { get; set; }
    }
}