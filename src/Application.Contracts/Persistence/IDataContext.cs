using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Contracts.Persistence;

public interface IDataContext
{
    public DbSet<User> Users { get; set; }
}