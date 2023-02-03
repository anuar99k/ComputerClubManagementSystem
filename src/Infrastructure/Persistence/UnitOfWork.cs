using Application.Contracts.Persistence;
using Application.Contracts.Persistence.Repositories;
using Infrastructure.Persistence.Repositories;

namespace Infrastructure.Persistence;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContext _dataContext;
    private bool _disposed;

    public UnitOfWork(DataContext dataContext)
    {
        _dataContext = dataContext;
        UsersRepository = new UsersRepository(_dataContext);
    }

    public IUsersRepository UsersRepository { get; }
    
    public async Task<int> SaveAsync()
    {
        return await _dataContext.SaveChangesAsync();
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _dataContext.Dispose();
            }
        }
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}