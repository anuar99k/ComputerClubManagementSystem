using Application.Contracts.Persistence.Repositories;
using Domain.Models;

namespace Infrastructure.Persistence.Repositories;

public class UsersRepository : GenericRepository<User>, IUsersRepository
{
    public UsersRepository(DataContext dataContext) : base(dataContext)
    {
    }
}