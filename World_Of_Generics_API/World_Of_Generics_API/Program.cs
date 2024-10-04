
using Microsoft.EntityFrameworkCore;
using World_Of_Generics_API.Data;
using World_Of_Generics_API.Models;
using World_Of_Generics_API.Repositories;
using AutoMapper;
using World_Of_Generics_API.DTOs;

namespace World_Of_Generics_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var services = builder.Services;

            services.AddDbContext<StoreDbContext>
                (
                   options =>
                   {
                       options.UseSqlServer("Data Source=LAPTOP-POPERAEM\\SQLEXPRESS;Initial Catalog= StoreGenerics;User Id=sa;Password=sa;Trusted_Connection=True;");
                   }
                );

            services.AddScoped<Repository<Product,ProductDTO>>();
            services.AddScoped<Repository<Category,CategoryDTO>>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



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
