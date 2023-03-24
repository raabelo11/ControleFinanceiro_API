using ControleFinanceiroApplication.Interfaces;
using ControleFinanceiroApplication.Mappings;
using ControleFinanceiroInfrastructure.Repositories;
using ControleFinanceiroApplication.UseCases;
using ControleFinanceiroInfrastructure.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ControleFinanceiro_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build();
                });
            });

            services.AddDbContext<ControleFinanceiroContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("ConexaoBD")));

            services.AddControllers();
            services.AddScoped<IDespesaUseCase, DespesaUseCase>();
            services.AddScoped<IControleDespesaRepository, ControleDespesaRepository>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ControleFinanceiro_API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ControleFinanceiro_API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("EnableCORS");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
