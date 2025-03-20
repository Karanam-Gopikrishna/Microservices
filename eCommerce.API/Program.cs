using eCommerce.Infrastructure;
using eCommerce.Core;
using Microsoft.Extensions.DependencyInjection;
using eCommerce.API.Middlewares;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddCore();


//Add controllers to the service collection
builder.Services.AddControllers();


var app = builder.Build();


//Routing
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();


//Exception handling middleware
app.UseExceptionHandlingMiddleware();
app.Run();
