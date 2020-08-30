using Assessment.Core.Mapping.Abstraction;
using Assessment.Core.Services.Abstraction;
using Assessment.Infrastructure.Contexts;

namespace Assessment.Core.Services.Implementation
{
    public class AssessmentService : CrudServiceBase<ApplicationDbContext>, IAssessmentService
    {
        public AssessmentService(ApplicationDbContext dbContext, IMapperAdapter mapper) : base(dbContext, mapper)
        {
        }
    }
}