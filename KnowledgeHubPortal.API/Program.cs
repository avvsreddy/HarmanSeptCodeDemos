
using KnowledgeHubPortal.Data;
using KnowledgeHubPortal.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortal.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Add DbContext
            builder.Services.AddDbContext<KnowledgeHubPortalDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("default")).UseLazyLoadingProxies();
            });


            //builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            //builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
