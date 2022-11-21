using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Odyssey.DiagnosticCertificateService.Application.Queries.CertificateRequest;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.WebApi.Controllers.CertificateGenerationStatus
{
    [Route("api/v1/certificate/")]
    [ApiController]
    public class CertificateGenerationStatus : Controller
    {


        // GET: 
        [HttpGet]
        [Route("status")]
        public async Task<IActionResult> Status()
        {
            try
            {
                CertificateStatusResponse response = new CertificateStatusResponse
                {
                    Success = true
                };
                return Ok(response);
            }
            catch
            {
                Console.WriteLine("exeption caught");
            }
            return BadRequest();
        }
       
        
    }
}
