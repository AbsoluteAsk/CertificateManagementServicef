using Odyssey.DiagnosticCertificateService.Infrastructure.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.Infrastructure.Data.MongoDB.CerificateRequestRepository
{
    public class Queries
    {
        private CertificateRequestRepository _repository;

        public Queries(CertificateRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<Task> CreateCSR(CertificateRequest newCSR)
        {
            newCSR.Id = "21";
           return await Task.FromResult(_repository.CreateAsync(newCSR));
            
        }
        public Task<CertificateRequest> FindCSR(string id)
        {
            return _repository.GetAsync(id);
        }
    }
}
