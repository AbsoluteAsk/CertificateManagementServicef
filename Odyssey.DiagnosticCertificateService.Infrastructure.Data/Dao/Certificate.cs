using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.Infrastructure.Data.Dao
{
    public class Certificate
    {
        public string? Id { get; set; }
        public string SecretVersionId { get; set; }
        public string SignedCertificate { get; set; }
        public string Expiry { get; set; }
        public DateTime GeneratedTime { get; set; }
    }
}
