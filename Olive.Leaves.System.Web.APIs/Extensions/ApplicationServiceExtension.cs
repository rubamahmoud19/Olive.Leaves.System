using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Data;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Services;
using Olive.Leaves.System.Web.APIs.Middleware;
using Olive.Leaves.System.Entities.Entitites;
using Olive.Leaves.System.Entities.DTOs.Leaves;
//using Olive.Leaves.System.Services.Mappers;
using Olive.Leaves.System.Services.Interfaces.IMapper;
using Olive.Leaves.System.Services.Interfaces.IRepositories;
using Olive.Leaves.System.Services.Repositories;



namespace Olive.Leaves.System.Web.APIs.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICompanySettingsService, CompanySettingsService>();
            //  services.AddScoped<ILeaveService, LeaveService>();
            //  services.AddScoped<IFilterService<LeaveDTO>, FilterService<Leave, LeaveDTO>>();
            // services.AddScoped<IBaseMapper<Leave,LeaveDTO>, BaseMapper<Leave, LeaveDTO>>();
            //services.AddScoped<IBaseRepository<Leave>, BaseRepository<Leave>>();
            //services.AddScoped<IMapper, Mapper>();
            
            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
            services.AddHttpContextAccessor();
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

        public static IApplicationBuilder AppUsings(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();

            return app;
        }
    }
}

