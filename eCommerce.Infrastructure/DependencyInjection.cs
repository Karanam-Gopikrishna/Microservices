using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.Repositories;

namespace eCommerce.Infrastructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension method to add infrastructure services to the DI container
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //Add services to the ioc container here
            //Infrastructure service often include data access, caching and other lower level components

            services.AddSingleton<iUsersRepository,UsersRepository>();
            return services;
        }
    }

}
