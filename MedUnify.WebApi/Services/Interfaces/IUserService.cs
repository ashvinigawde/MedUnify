using MedUnify.WebApi.Data.Entities;

namespace MedUnify.WebApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> FindAsync(User user);
    }
}
