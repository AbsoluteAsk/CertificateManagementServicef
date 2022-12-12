
using MongoDB.Driver;
using System.Data.Common;
using System.Runtime;
using CMS.Database.UserDb;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Odyssey.DiagnosticCertificateService.Domain.MongoDb;

namespace CMS.DAL.MongoDb
{
    public class DbInitialization
    {
        public IMongoCollection<UserReq> _csrCollection;
       
        /// <summary>
        /// Get Connection String and Db name/Collection Name
        /// Create Connection
        /// </summary>
        /// <param name="DbSettings"></param>
        public DbInitialization(IConfiguration configuration) {

            var mongoClient = new MongoClient(configuration.GetSection("CMSDatabaseSettings:ConnectionString").Value);
            var mongoDatabase = mongoClient.GetDatabase(configuration.GetSection("CMSDatabaseSettings:CertificateManagementService").Value);
            _csrCollection = mongoDatabase.GetCollection<UserReq>(configuration.GetSection("CMSDatabaseSettings:CSRCollection").Value);
        }
    }
       
    }

