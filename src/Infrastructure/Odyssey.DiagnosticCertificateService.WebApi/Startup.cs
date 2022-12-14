using Amazon.SQS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Odyssey.DiagnosticCertificateService.Bootstrap;
using Odyssey.DiagnosticCertificateService.Infrastructure.Data;
using Odyssey.DiagnosticCertificateService.Infrastructure.Data.MongoDB.CerificateRequestRepository;
using Odyssey.DiagnosticCertificateService.SQS.Helpers;
using Odyssey.DiagnosticCertificateService.SQS.Model;
using Odyssey.DiagnosticCertificateService.SQS.Service;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Log.Logger = new LoggerConfiguration()
       .ReadFrom.Configuration(configuration)
       .CreateLogger();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            var appSettingsSection = Configuration.GetSection("ServiceConfiguration");
            services.AddAWSService<IAmazonSQS>();
            services.Configure<ServiceConfiguration>(appSettingsSection);
            services.AddTransient<IAWSSQSService, AWSSQSService>();
            services.AddTransient<IAWSSQSHelper, AWSSQSHelper>();
            services.AddSingleton<CertificateRequestRepository>();
            services.AddSingleton<Queries>();
            services.AddSingleton<IMongoDBCSRContext, MongoDBCSRContext>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Odyssey.DiagnosticCertificateService.WebApi", Version = "v1" });
            });
            //DependencyInjector.ConfigureServices(services, Configuration);
            
  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Odyssey.DiagnosticCertificateService.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
