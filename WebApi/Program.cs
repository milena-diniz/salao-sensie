using Microsoft.EntityFrameworkCore;
using WebApi;
using WebApi.Repositories;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("SalaoSensie")));
builder.Services.AddScoped<SchedulingService>();
builder.Services.AddScoped<CustomerRepository>();
builder.Services.AddScoped<SchedulingRepository>();
builder.Services.AddScoped<ServiceRepository>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
