using Microsoft.EntityFrameworkCore;
using Repository;
using UnitOfWork;
using MediatR;
using System.Reflection;
using Domain.Models;
using CQRS.Commands.WarehouseComand;
using OMS_API.Config;
using Autofac.Extensions.DependencyInjection;
using Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Services.AddControllers();
builder.Services.RegisterDependencyInjection();
//builder.RegisterType<MasterUnitOfWork>().As<IMasterUnitOfWork>().InstancePerLifetimeScope();

builder.Services.AddMediatR(typeof(Program).Assembly);
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(typeof(AddWarehouseCommand).GetTypeInfo().Assembly);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<APIOMSContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OMSContext")));
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IUriService>(o =>
{
    var accessor = o.GetRequiredService<IHttpContextAccessor>();
    var request = accessor.HttpContext.Request;
    var uri = string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
    return new UriService(uri);
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
