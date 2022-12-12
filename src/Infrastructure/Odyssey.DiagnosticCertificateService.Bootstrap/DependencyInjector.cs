using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Odyssey.DiagnosticCertificateService.Domain.MongoDb;
using Odyssey.DiagnosticCertificateService.Infrastructure.Data;
using System;
using System.Runtime;

namespace Odyssey.DiagnosticCertificateService.Bootstrap
{
    public class DependencyInjector
    {
        private static IMongoCollection<UserReq> _csrCollection;

       

        public static IServiceCollection ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            MongoDbServiceInjection(services, configuration);
            return services;

        }

        public static void MongoDbServiceInjection(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IMongoDBCSRContext, MongoDBCSRContext>();
        }
    }
}
