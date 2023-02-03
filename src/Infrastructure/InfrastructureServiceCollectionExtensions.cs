using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Application.Contracts.Persistence;
using Application.Contracts.Persistence.Repositories;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public static class InfrastructureServiceCollectionExtensions
{
    public static void AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<DataContext>(options =>
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

            options.UseInMemoryDatabase(nameof(DataContext));

            // options.UseSqlServer(connectionString,
            //     sqlOptions =>
            //     {
            //         sqlOptions.MigrationsAssembly(typeof(InfrastructureServiceCollectionExtensions).GetTypeInfo().Assembly.GetName().Name);
            //     });
        });

        services.AddScoped<IDataContext>(provider => provider.GetRequiredService<DataContext>());
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}