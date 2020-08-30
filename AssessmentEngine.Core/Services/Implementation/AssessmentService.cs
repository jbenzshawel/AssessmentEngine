using AssessmentEngine.Core.Mapping.Abstraction;
using AssessmentEngine.Core.Services.Abstraction;
using AssessmentEngine.Infrastructure.Contexts;

namespace AssessmentEngine.Core.Services.Implementation
{
    public class AssessmentService : CrudServiceBase<ApplicationDbContext>, IAssessmentService
    {
        public AssessmentService(ApplicationDbContext dbContext, IMapperAdapter mapper) : base(dbContext, mapper)
        {
        }
    }
}