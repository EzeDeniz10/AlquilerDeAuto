using AlquilerDeAutos.AcessoDatos;
using AlquilerDeAutos.Controladora;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AlquilerDeAuto.Api
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

            builder.Services.AddDbContext<AlquilerAutoContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });
            builder.Services.AddScoped<IFormaDePagoService, FormaDePagoService>();
            builder.Services.AddScoped<ITipoCombustibleService, TipoCombustibleService>();
            builder.Services.AddScoped<IVehiculoService, VehiculoService>();

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