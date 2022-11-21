using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;

namespace Odyssey.DiagnosticCertificateService.Bootstrap
{
    public class DependencyInjector
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            MongoDb(services, configuration);
            return services;

        }

        private static void MongoDb(IServiceCollection services, IConfiguration configuration)
        {
            var mongoClient = new MongoClient(configuration.GetSection("CMSDatabaseSettings:ConnectionString").Value);
            var mongoDatabase = new MongoClient(configuration.GetSection("CMSDatabaseSettings:CertificateManagementService").Value);

           

            throw new NotImplementedException();
        }
    }
}
