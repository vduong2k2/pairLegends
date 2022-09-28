using Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Model.Database;

namespace pairLegendsCore
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
            builder.Services.AddDbContextFactory<PLContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DeployConnection"))
            );
            builder.Services.AddDbContext<PLContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DeployConnection"))
            );
            builder.Services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<PLContext>()
                .AddDefaultTokenProviders();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                
            }
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}