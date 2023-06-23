using MedUnify.WebApi.Data;
using MedUnify.WebApi.Data.Entities;
using MedUnify.WebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MedUnify.WebApi.Services
{
    public class UserService : ServiceBase, IUserService
    {
        public UserService(MedUnifyDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<User?> FindAsync(User user)
        {
            return await _dbContext.User.FirstOrDefaultAsync(x => x.Username == user.Username && x.Password == user.Password);
        }
    }
}
