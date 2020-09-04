using AssessmentEngine.Core.DTO;
using AssessmentEngine.Core.Mapping.Implementation;
using AssessmentEngine.Core.Services.Implementation;
using AssessmentEngine.Domain.Entities;
using AutoMapper;

namespace AssessmentEngine.Core.Mapping.Profiles
{
    public class AssessmentProfile : Profile
    {
        public AssessmentProfile()
        {
            // CreateMap<AssessmentDTO, Assessment>()
            //     .ForMember(dest => dest.AssessmentVersion, opt => opt.Ignore())
            //     .ForMember(dest => dest.AssessmentParticipants, opt => opt.Ignore())
            //     ;
            // CreateMap<Assessment, AssessmentDTO>();

            CreateMap<AssessmentTypeDTO, AssessmentType>()
                .ForMember(dest => dest.AssessmentVersions, opt => opt.Ignore())
                .IgnoreAuditColumns()
                ;
            CreateMap<AssessmentType, AssessmentTypeDTO>();

            CreateMap<BlockTypeDTO, BlockType>()
                .ForMember(dest => dest.AssessmentBlocks, opt => opt.Ignore())
                .IgnoreAuditColumns()
                ;
            CreateMap<BlockType, BlockTypeDTO>();
            
            CreateMap<BlockVersionDTO, BlockVersion>()
                .IgnoreAuditColumns()
                ;
            CreateMap<BlockVersion, BlockVersionDTO>();
            
            CreateMap<AssessmentVersionDTO, AssessmentVersion>()
                .ForMember(dest => dest.AssessmentType, opt => opt.MapFrom(src => src.AssessmentType))
                .ForMember(dest => dest.BlockVersions, opt => opt.MapFrom(src => src.BlockVersions))
                .ForMember(dest => dest.Assessments, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                ;
            CreateMap<AssessmentVersion, AssessmentVersionDTO>();
        }
    }
}
