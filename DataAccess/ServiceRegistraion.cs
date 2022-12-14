using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public static class ServiceRegistraion
	{
		public static IServiceCollection AddDataAccess(this IServiceCollection services)
		{
			services.AddTransient<IServiceDal, EfServiceDal>();

			return services;
		}
	}
}
