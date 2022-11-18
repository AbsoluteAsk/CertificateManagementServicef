using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Odyssey.DiagnosticCertificateService.WebApi.Controllers.CertificateGenerationStatus
{
    [Route("api/v1/certificate/")]
    [ApiController]
    public class CertificateGenerationStatus : Controller
    {


        // GET: 
        [HttpGet]
        [Route("status")]
        public ActionResult Status(int id)
        {
            return Ok();
        }

       
        
    }
}
