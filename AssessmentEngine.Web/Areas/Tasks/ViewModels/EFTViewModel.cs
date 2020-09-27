using AssessmentEngine.Core.Common;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Web.Areas.Tasks.ViewModels
{
    public class EFTViewModel : TaskVersionViewModel
    {
        public BlockTypes BlockType { get; set; }
        public EFTSettings Settings { get; set; }
    }
}