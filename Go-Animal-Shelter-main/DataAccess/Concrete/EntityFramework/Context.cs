﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccess.Concrete.EntityFramework
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(@"Host=localhost;Database=AnimalShelter;Username=postgres;Password=Beytullah.123");
		}
		public DbSet<Service> Services { get; set; }
		public DbSet<AnimalCategory> AnimalCategories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Species> Species { get; set; }
		public DbSet<Veterinerian> Veterinerians { get; set;}
		public DbSet<Pet> Pets { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<PetOwner> PetsOwners { get; set; }

		public DbSet<OperationClaim> OperationClaims { get; set; }

		public DbSet<OperationClaimUser> UserOperationClaims { get; set; }
	}
}
