using highblood.IServices;
using highblood.Model;
using highblood.Services;
using highblood.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace highblood
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
            services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IUserinformationServices, UserinformationServices>();
            services.AddScoped<IhealthDataServices, healthDataServices>();
            services.AddScoped<IDoctorServices, DoctorServices>();
            services.AddScoped<IArticleServices, ArticleServices>();
            services.AddScoped<IVideoServices, VideoServices>();
            services.AddScoped<ISyyServices, SyyServices>();
            services.AddScoped<IShouJianXiangServices, ShouJianXiangServices>();
            services.AddScoped<IFollowupServices, FollowupServices>();
            services.AddScoped<IDocloginServices, DocloginServices>();
            services.AddScoped<IAppointmentServices, AppointmentServices>();
            services.AddScoped<IApplyServices, ApplyServices>();
            services.AddScoped<ICasehistoryServices, CasehistoryServices>();
            services.AddScoped<IBodydataServices, BodydataServices>();
            services.AddScoped<IFormulationServices, FormulationServices>();
            services.AddScoped<IuserdynamicsServices, userdynamicsServices>();
            services.AddCorsSetup();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "highblood", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "highblood v1"));
            }
            app.UseCors("AllRequsets");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
