using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Web.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Areas.Tasks.ViewModels
{
    public class TaskVersionViewModel
    {
        public int TaskVersionId { get; set; }
        public Guid TaskVersionUid { get; set; }
        [Required]
        [Display(Name = "Version Name")]
        public string VersionName { get; set; }
        
        [Display(Name = "Task Type")]
        public int? AssessmentTypeId { get; set; }
        
        [Required]
        [Display(Name = "Participant")]
        public Guid? ParticipantUid { get; set; }
        public string ParticipantId { get; set; }
        public IEnumerable<SelectListItem> Participants { get; set; }
        public IEnumerable<SelectListItem> AssessmentTypesLookup { get; set; }
        public IEnumerable<BlockVersionDTO> BlockVersions { get; set; }
        
        public string ParticipantUrl { get; set; }
        public PageActions PageAction { get; set; }
    }
}