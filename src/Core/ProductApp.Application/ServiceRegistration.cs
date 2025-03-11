using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper.Execution;
using AutoMapper;
using AutoMapper.Internal;

namespace ProductApp.Application
{
	public static class ServiceRegistration 
	{
		public static IServiceCollection AddApplicationRegistration(this IServiceCollection services)
		{
			var assm = Assembly.GetExecutingAssembly();

			services.AddAutoMapper(typeof(ServiceRegistration).Assembly);
			services.AddMediatR(opt=> opt.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));

			return services;
		}
	}
}

