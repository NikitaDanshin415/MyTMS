using System.Collections.Generic;

namespace TMS.Application.ProjectRole.Queries.GetProjectRolesList
{
    public class ProjectRoleListVm
    {
        public IList<ProjectRoleLookupDto> ProjectRoles { get; set; }
    }
}