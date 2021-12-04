using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssessmentEngine.Core.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Areas.Tasks.ViewModels
{
    public class CreateGroupViewModel
    {
        [Required]
        [Display(Name = "Group Name")]
        public string TaskVersionName { get; set; }

        [Required]
        [Display(Name = "Task Type")]
        public int AssessmentTypeId { get; set; }

        public virtual IEnumerable<TaskVersionGroupBlockDTO> TaskVersionGroupBlocks { get; set; }
        public IEnumerable<SelectListItem> AssessmentTypesLookup { get; set; }
    }
}