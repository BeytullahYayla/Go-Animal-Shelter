using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public static class ServiceRegistraion
	{
		public static IServiceCollection AddBusiness(this IServiceCollection services)
		{
			services.AddTransient<IServiceService, ServiceManager>();

			return services;
		}
	}
}
