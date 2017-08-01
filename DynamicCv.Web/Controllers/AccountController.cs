using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Authentication;
using DynamicCv.Entities.CvEntities;

namespace DynamicCv.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    public class AccountController : Controller
    {
        [HttpGet]
        
        public IActionResult External(string provider)
        {
            var authProperties = new AuthenticationProperties
            {
                RedirectUri = "http://localhost:4200/"
            };

            return new ChallengeResult(provider, authProperties);
        }

        [HttpGet("login")] 
        public CvUser Login()
        {
            return new CvUser {
                LoginStatus = "NotLoggedIn"
            };
        }
    }
}