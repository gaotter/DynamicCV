using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DynamicCv.Services.Interfaces;
using DynamicCv.Entities.CvEntities;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DynamicCv.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CvUserController : Controller
    {
        private IUserRepsitory _userRep;
        private IHttpContextAccessor _httpConextAccessor;

        public CvUserController(IUserRepsitory userRep, IHttpContextAccessor httpConextAccessor)
        {
            _userRep = userRep;
            _httpConextAccessor = httpConextAccessor;
        }

        [HttpGet]
        [Authorize]
        public async Task<CvUser> Get()
        {
            var userid = _httpConextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
           
            return await _userRep.GetUser(userid);
        }
    }
}