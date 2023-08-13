using Microsoft.AspNetCore.Mvc;

namespace MailService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MailController :ControllerBase
    {
        private readonly IMailService _mailService;

        public MailController(IMailService mailService)
        {
                _mailService = mailService;
        }
        [HttpPost]
        public ActionResult SentEmail(string subject, string body, string mailAddress)
        { 
           _mailService.SendEmailWithMailKitPackage(subject, body, mailAddress);
            return Ok();    
        }
    }
}
