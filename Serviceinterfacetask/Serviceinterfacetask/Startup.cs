using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serviceinterfacetask.Models;
using Serviceinterfacetask.Service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviceinterfacetask
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
            services.AddControllers();
            services.AddScoped<IService<Student>, StudentService>();
            services.AddScoped<IService<Teacher>, TeacherService>();
            //services.AddSwaggerGen(gen =>
            //{
            //    gen.SwaggerDoc("v2.0", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Student and teacher", Version = "v2.0" });
            //});
            services.AddSwaggerGen(gen =>
            {
                gen.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo{ Title = "studentapi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
           

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(ui =>
            {
                ui.SwaggerEndpoint("/swagger/v1/swagger.json", "student ");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
