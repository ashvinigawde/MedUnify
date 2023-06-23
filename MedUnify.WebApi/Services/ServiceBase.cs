using MedUnify.WebApi.Data;

namespace MedUnify.WebApi.Services
{
    public abstract class ServiceBase
    {
        protected readonly MedUnifyDbContext _dbContext;
        public ServiceBase(MedUnifyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
