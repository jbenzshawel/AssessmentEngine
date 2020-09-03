using System.Collections.Generic;
using AssessmentEngine.Core.DTO.Identity;

namespace AssessmentEngine.Web.Areas.Identity.Models
{
    public class ManageParticipantViewModel
    {
        public IEnumerable<User> Participants { get; set; }
    }
}