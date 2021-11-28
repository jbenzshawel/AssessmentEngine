using AssessmentEngine.Core.Common;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Domain.Enums;

namespace AssessmentEngine.Web.Areas.Tasks.ViewModels
{
    public class EFTViewModel : RandomizedTaskVersionViewModel
    {
        public BlockTypes BlockType { get; set; }
        public EFTSettings Settings { get; set; }
        public BlockVersionDTO CurrentBlockVersion { get; set; }
        public BlockVersionDTO NextBlockVersion { get; set; }
        public bool IsCompleted { get; set; }
    }
}