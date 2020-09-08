using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssessmentEngine.Core.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Areas.Tasks.ViewModels
{
    public class TaskVersionViewModel
    {
        public int TaskVersionId { get; set; }
        
        [Required]
        [Display(Name = "Version Name")]
        public string VersionName { get; set; }
        
        [Required]
        [Display(Name = "Task Type")]
        public int? AssessmentTypeId { get; set; }
        public IEnumerable<SelectListItem> AssessmentTypesLookup { get; set; }
        public IEnumerable<BlockVersionDTO> BlockVersions { get; set; }

    }
}