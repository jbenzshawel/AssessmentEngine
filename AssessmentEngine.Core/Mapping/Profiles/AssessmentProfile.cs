using System.Linq;
using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Mapping.Implementation;
using AssessmentEngine.Domain.Entities;
using AutoMapper;

namespace AssessmentEngine.Core.Mapping.Profiles
{
    public class AssessmentProfile : Profile
    {
        public AssessmentProfile()
        {
            CreateMap<LookupTypeDTO, AssessmentType>()
                .ForMember(dest => dest.AssessmentVersions, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                ;
            CreateMap<AssessmentType, LookupTypeDTO>();

            CreateMap<LookupTypeDTO, BlockType>()
                .ForMember(dest => dest.AssessmentBlocks, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                ;

            CreateMap<BlockType, LookupTypeDTO>();
            CreateMap<ParticipantType, LookupTypeDTO>();

            CreateMap<BlockVersionDTO, BlockVersion>()
                .ForMember(dest => dest.BlockTypeId, opt => opt.MapFrom(src => src.BlockTypeId))
                .ForMember(dest => dest.BlockType, opt => opt.MapFrom(src => src.BlockType))
                .ForMember(dest => dest.AssessmentVersionId, opt => opt.Ignore())
                .ForMember(dest => dest.AssessmentVersion, opt => opt.Ignore())
                .IgnoreAuditColumns()
                ;
            CreateMap<BlockVersion, BlockVersionDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Uid, opt => opt.MapFrom(src => src.Uid))
                ;
            
            CreateMap<AssessmentVersionDTO, AssessmentVersion>()
                .ForMember(dest => dest.AssessmentType, opt => opt.MapFrom(src => src.AssessmentType))
                .ForMember(dest => dest.BlockVersions, opt => opt.MapFrom(src => src.BlockVersions.OrderBy(x => x.SortOrder)))
                .ForMember(dest => dest.ApplicationUserId, opt => opt.MapFrom(src => src.ParticipantUid))
                .ForMember(dest => dest.ApplicationUser, opt => opt.Ignore())
                .ForMember(dest => dest.ImageViewingTime, opt => opt.Ignore())
                .ForMember(dest => dest.CognitiveLoadViewingTime, opt => opt.Ignore())
                .ForMember(dest => dest.FixationCrossViewingTime, opt => opt.Ignore())
                .ForMember(dest => dest.Assessments, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Uid, opt => opt.Ignore())
                .ForMember(dest => dest.AssessmentTypeId, opt => opt.Ignore())
                ;
            CreateMap<AssessmentVersion, AssessmentVersionDTO>()
                .ForMember(dest => dest.ParticipantUid, opt => opt.MapFrom(src => src.ApplicationUserId))
                .ForMember(dest => dest.ParticipantId, opt => opt.MapFrom(src => src.ApplicationUser.ParticipantId))
                .ForMember(dest => dest.BlockVersions, opt => opt.MapFrom(src => src.BlockVersions))
                .ForMember(dest => dest.AllowEdit, opt => opt.MapFrom(src => !src.BlockVersions.Any(x => x.CompletedDate.HasValue)))
                .ForMember(dest => dest.CurrentBlockVersion, opt => opt.Ignore())
                .ForMember(dest => dest.NextBlockVersion, opt => opt.Ignore())
                .ForMember(dest => dest.ParticipantUrl, opt => opt.Ignore())
                .ForMember(dest => dest.IsCompleted, opt => opt.Ignore())
                ;
        }
    }
}
