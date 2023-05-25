using Altic_Shaw_Net6_Api.Entities;
using Altic_Shaw_Net6_Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AlaticShawContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Altic_Shaw")));

// Add Auto Mapper to translate
builder.Services.AddAutoMapper(typeof(Program));
//Lift cycle DI: AddSingleton(),AddTransient(), AddScoped();
builder.Services.AddScoped<IProductRepository,  ProductRepository>();

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
