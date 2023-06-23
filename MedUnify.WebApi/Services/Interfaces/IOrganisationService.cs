using MedUnify.WebApi.Data.Entities;

namespace MedUnify.WebApi.Services.Interfaces
{
    public interface IOrganisationService
    {
        Task<List<Organization>> GetAll();

    }
}
