using Olive.Leaves.System.Web.APIs.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(builder.Configuration);
//builder.Services.AddScopedServices(builder.Configuration);

var app = builder.Build();

app.AppUsings();
app.MapControllers();
app.Run();