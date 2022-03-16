using Microsoft.Extensions.DependencyInjection;
using Repository.Implementation;
using Repository.Interface;

namespace TestApplication.Extension
{
    public static class ConfigurationServiceExtension
    {
         public static void configurationRepositoryMethod(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped(typeof(IRoomRepository<>),typeof(RoomRepository<>));
            services.AddScoped(IUntityOfWork,UntityOfWork);
        }
        public static void configurationServicesMethod(this IServiceCollection services)
        {
            services.AddScoped(IMealService,MealService);
            services.AddScoped(IRoomService,RoomService);

        }
    }
}