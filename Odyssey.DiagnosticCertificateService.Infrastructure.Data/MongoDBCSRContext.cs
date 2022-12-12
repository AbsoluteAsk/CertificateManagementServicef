using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.Infrastructure.Data
{
    public class MongoDBCSRContext : IMongoDBCSRContext
    {
        private MongoClient _mongoClient;

        private IMongoDatabase _db;
        public MongoDBCSRContext(IConfiguration configuration)
        {
           _mongoClient = new MongoClient(
                 configuration.GetSection("CertificateManagementServiceDatabaseSetting:ConnectionString").Value);

           _db = _mongoClient.GetDatabase(
                configuration.GetSection("CertificateManagementServiceDatabaseSetting:DatabaseName").Value);
        }
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _db.GetCollection<T>(collectionName);
        }
    }
}
