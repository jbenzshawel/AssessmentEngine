using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssessmentEngine.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Areas.Tasks.ViewModels
{
    public class CounterBalancedVersionViewModel : TaskVersionViewModel
    {
        [Required]
        [Display(Name = "Version Group")]
        public int TaskVersionGroupId { get; set; }
        
        [Required]
        [Display(Name = "Counter-Balance Version")]
        public CounterBalanceTypes CounterBalanceType { get; set; }
        public IEnumerable<SelectListItem> CounterBalanceTypes { get; set; }
        public IEnumerable<SelectListItem> VersionGroups { get; set; }
    }
}