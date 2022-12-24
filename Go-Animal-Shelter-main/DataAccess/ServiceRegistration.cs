using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ServiceRegistration
	{
		public static IServiceCollection AddDataAccess(this IServiceCollection services)
		{
			services.AddTransient<IServiceDal, EfServiceDal>();
			services.AddTransient<IContactDal, EfContactDal>();
			services.AddTransient<IAnimalCategoryDal, EfAnimalCategoryDal>();
			services.AddTransient<ISpeciesDal, EfSpeciesDal>();
			services.AddTransient<IVeterinerianDal, EfVeterinerianDal>();
		
			services.AddTransient<IUsersDal, EfUsersDal>();

			return services;
		}
	}
}
