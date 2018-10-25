using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using partner.integration.Models;

namespace partner.integration.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        // POST api/Payment
     
        [HttpPost]
        public ActionResult<object> Post([FromBody] PaymentRequestModel value)
        {
           return new { ReferenceNumber = Guid.NewGuid() };
        
        }

        // POST api/Payment
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "up";
        }
    }
}
