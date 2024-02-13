using Autofac.Extensions.DependencyInjection;
using Autofac;
using Prueba.Application.Cores.Contexts;
using Prueba.Infrastructure.Cores.Contexts;
using Prueba.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Infrastructure
builder.Services.AddInfrastructureServices(builder.Configuration);

// Application
builder.Services.AddApplicationService();
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(options =>
    {
        options.RegisterModule(new InfrastructureAutofactModule());
        options.RegisterModule(new ApplicationAutofacModule());
    });

// Api
builder.Services.AddTransient<ExceptionMiddleware>();

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
