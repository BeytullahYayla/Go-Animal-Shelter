using Business;
using Business.Abstract;
using Business.Concrete;
using DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DependencyResolving
builder.Services.AddSingleton<IServiceService,ServiceManager>();	
builder.Services.AddSingleton<IServiceDal,EfServiceDal>();
builder.Services.AddSingleton<IPetDal,EfPetDal>();
builder.Services.AddSingleton<IPetService, PetManager>();
builder.Services.AddDbContext<Context>();
builder.Services.AddSingleton<IContactDal,EfContactDal>();
builder.Services.AddSingleton<IAnimalCategoryDal,EfAnimalCategoryDal>();
builder.Services.AddSingleton<IAnimalCategoryService,AnimalCategoryManager>();

builder.Services.AddSingleton<ISpeciesDal, EfSpeciesDal>();
builder.Services.AddSingleton<ISpeciesService, SpeciesManager>();
builder.Services.AddSingleton<IPetOwnerDal, EfPetOwnerDal>();
builder.Services.AddSingleton<IPetOwnerService,PetOwnerManager>();
builder.Services.AddSingleton<IVeterinerianDal, EfVeterinerianDal>();
builder.Services.AddSingleton<IVeterinerianService,VeterinerianManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.UseAuthorization();

app.MapControllers();

app.Run();
