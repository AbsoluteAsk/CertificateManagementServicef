using MongoDB.Driver;

namespace Odyssey.DiagnosticCertificateService.Infrastructure.Data
{
    public interface IMongoDBCSRContext
    {
        public IMongoCollection<T> GetCollection<T>(string collectionName);

    }
}