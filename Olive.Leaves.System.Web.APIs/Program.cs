
using Olive.Leaves.System.Entities.DTOs.Leaves;
using Olive.Leaves.System.Entities.Entitites;
using Olive.Leaves.System.Services;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Services.Interfaces.IMapper;
using Olive.Leaves.System.Services.Interfaces.IRepositories;

using Olive.Leaves.System.Services.Repositories;
using Olive.Leaves.System.Web.APIs.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(builder.Configuration);
//builder.Services.AddScopedServices(builder.Configuration);
//builder.Services.AddSingleton<IMapper, Mapper>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("myAppCors", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
    });
});


builder.Services.AddScoped<ILeaveService, LeaveService>();

builder.Services.AddScoped<IBaseRepository<Leave>, BaseRepository<Leave>>();
//builder.Services.AddScoped<Olive.Leaves.System.Services.Interfaces.IMapper.IBaseMapper<Leave,LeaveDTO>, Olive.Leaves.System.Services.Mappers.BaseMapper<Leave, LeaveDTO>>();


var app = builder.Build();

app.AppUsings();
app.MapControllers();
app.UseCors("myAppCors");
app.Run();