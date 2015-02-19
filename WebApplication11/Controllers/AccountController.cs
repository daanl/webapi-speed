using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication11.Controllers
{
    [RoutePrefix("account")]
    public class AccountController : ApiController
    {
        [HttpGet, Route("detail")]
        public string AccountDetails()
        {
            return "{ \"result\": \"success\"}";
        }
    }
}