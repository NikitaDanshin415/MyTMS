using System.Collections;
using System.Collections.Generic;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsList
{
    public class ProjectParticipantListVm
    {
        public IList<ProjectParticipantLookupDto> ProjectParticipant { get; set; }
    }
}