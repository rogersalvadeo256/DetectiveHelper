using DetectiveHelper.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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

            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


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
    }
}