using Application.Contracts.Persistence.Repositories;

namespace Application.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    IUsersRepository UsersRepository { get; }
    Task<int> SaveAsync();
}