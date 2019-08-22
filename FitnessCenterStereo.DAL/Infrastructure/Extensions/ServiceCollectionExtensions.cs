using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FitnessCenterStereo.DAL.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using System;

namespace FitnessCenterStereo.DAL.Interface.ServiceExtensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppDbContextExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
