using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.Infrastructure.Data.Dao
{
    public class CertificateRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }



        public string? ECUId { get; set; }



        public string RequestId { get; set; }
        public string RequestUserId { get; set; }
        public string RequestStatus { get; set; }



        [BsonDateTimeOptions]
        public DateTime RequestTime { get; set; } = DateTime.Now;
        public string UserDiagRole { get; set; }
        public string UserType { get; set; }
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public string? CSR { get; set; }
        public Certificate Certificate { get; set; }
    }
}
