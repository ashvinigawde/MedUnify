using MedUnify.WebApi.Data;
using MedUnify.WebApi.Data.Entities;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedUnify.WebApi.Services
{
    public class OrganisationService : ServiceBase, IOrganisationService
    {
        public OrganisationService(MedUnifyDbContext dbContext) : base(dbContext)
        {
        }

       public async Task<List<Organization>> GetAll()
        {
            return await _dbContext.Organizations.ToListAsync();
        }

    }
}
