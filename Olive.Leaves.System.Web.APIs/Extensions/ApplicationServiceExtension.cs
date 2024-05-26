using Microsoft.EntityFrameworkCore;
using Olive.Leaves.System.Data;
using Olive.Leaves.System.Services.Interfaces;
using Olive.Leaves.System.Services;
using Olive.Leaves.System.Web.APIs.Middleware;


namespace Olive.Leaves.System.Web.APIs.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICompanySettingsService, CompanySettingsService>();
            services.AddScoped<ILeaveService, LeaveService>();
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

