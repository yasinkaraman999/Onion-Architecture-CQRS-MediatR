using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;

namespace ProductApp.Persistence
{
	public static class ServiceRegistration
    {

		public static IServiceCollection AddPersistenceService(this IServiceCollection services)
		{
            services.AddDbContext<ApplicationDbContext>(opt=>opt.UseInMemoryDatabase("memoryDb"));
            services.AddTransient<IProductRepository, ProductRepository>();

			return services;
		}
	}
}

