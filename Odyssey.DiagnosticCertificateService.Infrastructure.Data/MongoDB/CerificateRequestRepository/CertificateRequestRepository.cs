using MongoDB.Driver;
using Odyssey.DiagnosticCertificateService.Infrastructure.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.Infrastructure.Data.MongoDB.CerificateRequestRepository
{
    public class CertificateRequestRepository
    {
        private IMongoDBCSRContext _mongoDBCSRContext;
        private IMongoCollection<CertificateRequest> _dbCSRCollection;

        public CertificateRequestRepository(IMongoDBCSRContext context)
        {
            _mongoDBCSRContext = context;
            _dbCSRCollection = _mongoDBCSRContext.GetCollection<CertificateRequest>(typeof(CertificateRequest).Name);

        }

        public async Task<CertificateRequest> Get(string id) => await _dbCSRCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        public async Task<List<CertificateRequest>> GetAsync() =>
          await _dbCSRCollection.Find(_ => true).ToListAsync();

        public async Task CreateAsync(CertificateRequest newCSR)
        {
             await _dbCSRCollection.InsertOneAsync(newCSR);
           
        }

        public async Task<CertificateRequest> GetAsync(string id) =>
            await _dbCSRCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    }   
}
