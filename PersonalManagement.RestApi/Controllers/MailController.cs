using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailSystem.Application;
using MailSystem.Application.Command;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonalManagement.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailApplication _mailApplication;

        public MailController(IMailApplication mailApplication)
        {
            _mailApplication = mailApplication;
        }

        [HttpGet]
        public List<string> Get()
        {
            return new List<string> {" some value", "some value 2"};
        }

        [HttpPost]
        public void Post([FromBody] ComposeMail command)
        {
            _mailApplication.Compose(command);
        }
    }
}