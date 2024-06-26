﻿

using Microsoft.EntityFrameworkCore;
using VehicleRegistrationBE.Entities.DataContext;
using VehicleRegistrationBE.Repositories;

namespace VehicleRegistrationBE
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<MasterDBDataContext>(options => options.UseSqlServer(Configuration["ConnectionString:MasterConnection"]));
            services.AddDbContext<TransactionDBDataContext>(options => options.UseSqlServer(Configuration["ConnectionString:TransactionConnection"]));
            
            services.AddScoped<StorageLocationRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<DocumentRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
