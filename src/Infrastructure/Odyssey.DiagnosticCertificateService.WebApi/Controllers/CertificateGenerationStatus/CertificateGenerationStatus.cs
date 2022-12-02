using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Odyssey.DiagnosticCertificateService.Application.Queries.CertificateRequest;
using Odyssey.DiagnosticCertificateService.Bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Odyssey.DiagnosticCertificateService.WebApi.Controllers.CertificateGenerationStatus
{
    [Route("api/v1/certificate/")]
    [ApiController]
    public class CertificateGenerationStatus : Controller
    {
  
        private readonly ILogger<CertificateGenerationStatus> _logger;
        public CertificateGenerationStatus(ILogger<CertificateGenerationStatus> logger)
        {
            _logger = logger;
        }

       
       
        // GET: 
        [HttpGet]
        [Route("status")]
        public async Task<IActionResult> Status()
        {
            //        var logClient = new AmazonCloudWatchLogsClient();
            //        var logGroupName = "/aws/weather-forecast-app";
            //        var logStreamName = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
            //        var existing = await logClient
            //            .DescribeLogGroupsAsync(new DescribeLogGroupsRequest()
            //            { LogGroupNamePrefix = logGroupName });
            //        var logGroupExists = existing.LogGroups.Any(l => l.LogGroupName == logGroupName);
            //        if (!logGroupExists)
            //            await logClient.CreateLogGroupAsync(new CreateLogGroupRequest(logGroupName));
            //        await logClient.CreateLogStreamAsync(new CreateLogStreamRequest(logGroupName, logStreamName));
            //        await logClient.PutLogEventsAsync(new PutLogEventsRequest()
            //        {
            //            LogGroupName = logGroupName,
            //            LogStreamName = logStreamName,
            //            LogEvents = new List<InputLogEvent>()
            //{
            //    new()
            //    {
            //        Message = $"Get CertificateStatusResponse {Response} ",
            //        Timestamp = DateTime.UtcNow
            //    }
            //}
            //        });

            _logger.LogDebug("Received Request with id as ");
            _logger.LogInformation("Processing your request");
            _logger.LogError("Some Errors occcured.");
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
