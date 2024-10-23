using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoAnASP.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public string Login(string username, string password)
        {
            return "Success";
        }
    }
}
