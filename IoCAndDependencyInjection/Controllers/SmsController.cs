using IoCAndDependencyInjection.SmsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IoCAndDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private readonly ISmsService _smsService;  
        public SmsController(ISmsService smsService)
        {
            _smsService = smsService;   
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            _smsService.SendSms();
            return Ok();    
        }
    }
}
