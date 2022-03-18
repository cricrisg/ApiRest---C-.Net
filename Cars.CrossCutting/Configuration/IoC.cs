using Cars.Application.Contracts.Services;
using Cars.Application.Services;
using Cars.DataAccess.Contracts.Repositories;
using Cars.DataAccess.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.CrossCutting.Configuration
{
    public static class IoC
    {

        public static IServiceCollection Register(this IServiceCollection services)
        {
            //AddRegistration(services);
            AddServices(services);
            AddRepositories(services);
            return services;
        }

        //public static IServiceCollection AddRegistration(this IServiceCollection services)
        //{
        //    return services;
        //}

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            //ICarServices carServices=new CarServices();, esto es lo mismo que el addtrnsient 
            services.AddTransient<ICarServices, CarServices>();
            services.AddTransient<IUserServices, UserServices>();
            return services;
        }


        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //ICarRepository carRepository=new CarRepository();, esto es lo mismo que el addtrnsient 
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }




    }
}
