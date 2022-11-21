using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.Domain.MongoDb
{
  
        public class UserReq
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string userId { get; set; } = string.Empty;


            public string[] ECUIdentifier { get; set; }


            public bool has_gen_req { get; set; }
        }
    }

