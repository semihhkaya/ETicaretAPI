using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    //IOC CONTAİNERRR //Autofac
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services) //IOC Extention fonk.
        {
            //Kodun içeriisne config ve conn string yazılmaz? //Json,txt, environment gibi nesnelerde tutulur.
            services.AddDbContext<ETicaretAPIDbContext>(options =>
            options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);

            services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
