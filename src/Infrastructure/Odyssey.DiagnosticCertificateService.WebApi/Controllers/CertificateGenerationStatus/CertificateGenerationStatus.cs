using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using Odyssey.DiagnosticCertificateService.Application.Queries.CertificateRequest;
using Odyssey.DiagnosticCertificateService.Bootstrap;
using Odyssey.DiagnosticCertificateService.Domain.MongoDb;
using System;
using System.Net;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Odyssey.DiagnosticCertificateService.WebApi.Controllers.CertificateGenerationStatus
{
    [Route("api/v1/certificate/")]
    [ApiController]
    public class CertificateGenerationStatus : Controller
    {
        private object _csrCollection;

        public CertificateGenerationStatus()
        {
           
        }
       
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
