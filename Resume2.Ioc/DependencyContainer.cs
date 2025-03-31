using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Resume2.Core.Services.Implementations;
using Resume2.Core.Services.Interfaces;
using Resume2.Data.Repositories;
using Resume2.Domain.Interfaces;

namespace Resume2.Ioc
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWebMainInfoRepository, WebMainInfoRepository>();
            services.AddScoped<IWebMainInfoService, WebMainInfoService>();

        }
    }
}
