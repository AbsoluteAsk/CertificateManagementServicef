using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.SQS.Model
{
    public class ServiceConfiguration
    {
        public AWSSQS AWSSQS { get; set; }
    }
    public class AWSSQS
    {
        public string QueueUrl { get; set; }
    }
}
