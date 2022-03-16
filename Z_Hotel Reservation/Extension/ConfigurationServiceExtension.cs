using Microsoft.Extensions.DependencyInjection;
using Repository.Implementation;
using Repository.Interface;
using Services.Implemenation;
using Services.Interface;

namespace TestApplication.Extension
{
    public static class ConfigurationServiceExtension
    {
         public static void configurationRepositoryMethod(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped(typeof(IRoomRepository),typeof(RoomRepository));
            services.AddScoped(typeof(IUntityOfWork), typeof( UntityOfWork));
        }
        public static void configurationServicesMethod(this IServiceCollection services)
        {
            services.AddScoped(typeof(IMealService), typeof(MealService));
            services.AddScoped(typeof(IRoomService), typeof( RoomService));

        }
    }
}