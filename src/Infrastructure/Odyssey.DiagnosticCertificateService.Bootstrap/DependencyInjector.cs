using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Odyssey.DiagnosticCertificateService.Domain.MongoDb;
using System;
using System.Runtime;

namespace Odyssey.DiagnosticCertificateService.Bootstrap
{
    public class DependencyInjector
    {
        private static IMongoCollection<UserReq> _csrCollection;

       

        public static IServiceCollection ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            MongoDb(services, configuration);
            return services;

        }

        public static void MongoDb(IServiceCollection services, IConfiguration configuration)
        {
            var mongoClient = new MongoClient(configuration.GetSection("CMSDatabaseSettings:ConnectionString").Value);
            var mongoDatabase = mongoClient.GetDatabase(configuration.GetSection("CMSDatabaseSettings:CertificateManagementService").Value);
            _csrCollection = mongoDatabase.GetCollection<UserReq>(configuration.GetSection("CMSDatabaseSettings:CSRCollection").Value);
        }
    }
}
