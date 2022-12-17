using Business.Abstract;
using Business.Concrete;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
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
	public static class ServiceRegistration
	{
		public static IServiceCollection AddBusiness(this IServiceCollection services)
		{
			services.AddTransient<IServiceService, ServiceManager>();
			services.AddTransient<IContactService, ContactManager>();
			services.AddTransient<IAnimalCategoryService, AnimalCategoryManager>();
			services.AddTransient<ISpeciesService, SpeciesManager>();
			services.AddTransient<IVeterinerianService, VeterinerianManager>();
			services.AddTransient<IRolesService, RolesManager>();
			services.AddTransient<IPetService, PetManager>();

			
			return services;
		}
	}
}
