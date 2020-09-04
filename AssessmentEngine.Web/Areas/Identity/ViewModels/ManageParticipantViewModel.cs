using System.Collections.Generic;
using AssessmentEngine.Core.DTO;

namespace AssessmentEngine.Web.Areas.Identity.ViewModels
{
    public class ManageParticipantViewModel
    {
        public IEnumerable<UserDTO> Participants { get; set; }
    }
}