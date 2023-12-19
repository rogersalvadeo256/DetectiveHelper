using DetectiveHelper.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Reflection;
using DetectiveHelper.Repository.Interface.Base;
using Microsoft.EntityFrameworkCore.Internal;
using DetectiveHelper.Facade.Interface.Base;
using DetectiveHelper.Facade.Rules.Base;
using DetectiveHelper.Facade.Interface.Internal;
using DetectiveHelper.Facade.Rules.Internal;
using DetectiveHelper.Repository.Rules.Internal;
using DetectiveHelper.Repository.Interface.Internal;
using DetectiveHelper.Business.Interface.Internal;
using DetectiveHelper.Business.Rules.Internal;
using DetectiveHelper.Repository.Mapper;
using DetectiveHelper.Business.Interface.Base;

namespace DetectiveHelper.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configurar o Entity Framework
            var connectionString = builder.Configuration.GetConnectionString("Prod");
            builder.Services.AddDbContext<DetectiveDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddAutoMapper(typeof(MappingProfile));


            AddRepository(builder.Services);
            AddBusiness(builder.Services);
            AddFacade(builder.Services);

            // Adicionar serviços ao contêiner.
            builder.Services.AddControllers();
            // Saiba mais sobre a configuração do Swagger/OpenAPI em https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configurar o pipeline de solicitações HTTP.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();

        }

        public static void AddRepository(IServiceCollection services)
        {
            //services.AddScoped<IUserRepository, UserRepository>();

            var baseRepositoryType = typeof(IBaseRepository<>);


            services.Scan(scan => scan
                .FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
                .AddClasses(classes => classes.Where(type =>
                    type.GetInterfaces().Any(i =>
                        i.IsGenericType &&
                        i.GetGenericTypeDefinition() == baseRepositoryType)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        }
        private static void AddBusiness(IServiceCollection services)
        {
            var baseBusinessType = typeof(IBaseBusiness<>);


            services.Scan(scan => scan
                .FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
                .AddClasses(classes => classes.Where(type =>
                    type.GetInterfaces().Any(i =>
                        i.IsGenericType &&
                        i.GetGenericTypeDefinition() == baseBusinessType)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }
        private static void AddFacade(IServiceCollection services)
        {
            var baseFacadeType = typeof(IBaseFacade<>);


            services.Scan(scan => scan
                .FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
                .AddClasses(classes => classes.Where(type =>
                    type.GetInterfaces().Any(i =>
                        i.IsGenericType &&
                        i.GetGenericTypeDefinition() == baseFacadeType)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }
    }
}