using System.Linq;
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
                .ForMember(dest => dest.BlockTypeId, opt => opt.MapFrom(src => src.BlockTypeId))
                .ForMember(dest => dest.BlockType, opt => opt.MapFrom(src => src.BlockType))
                .IgnoreAuditColumns()
                ;
            CreateMap<BlockVersion, BlockVersionDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Uid, opt => opt.MapFrom(src => src.Uid))
                ;
            
            CreateMap<AssessmentVersionDTO, AssessmentVersion>()
                .ForMember(dest => dest.AssessmentType, opt => opt.MapFrom(src => src.AssessmentType))
                .ForMember(dest => dest.BlockVersions, opt => opt.MapFrom(src => src.BlockVersions))
                .ForMember(dest => dest.Assessments, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.Uid, opt => opt.Ignore())
                ;
            CreateMap<AssessmentVersion, AssessmentVersionDTO>()
                .ForMember(dest => dest.BlockVersions, opt => opt.MapFrom(src => src.BlockVersions))
                .ForMember(dest => dest.AllowDelete, opt => opt.MapFrom(src => src.Assessments.Any()))
                ;
        }
    }
}
