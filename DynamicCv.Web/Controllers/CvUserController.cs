using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DynamicCv.Services.Interfaces;
using DynamicCv.Entities.CvEntities;

namespace DynamicCv.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CvUserController : Controller
    {
        private IUserRepsitory _userRep;

        public CvUserController(IUserRepsitory userRep)
        {
            _userRep = userRep;
        }

        [HttpGet]
        public async Task<CvUser> Get()
        {
            return await _userRep.GetUser("gaotter@gmail.com");
        }
    }
}