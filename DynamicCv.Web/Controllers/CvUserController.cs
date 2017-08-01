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
using Knowit.Amende.Helpers.Extensions;

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
            _httpConextAccessor.HttpContext.User.Claims.ForEach(c => Console.WriteLine($"Type: {c.Type} Value: {c.Value}"));
            var picture = GetClaimValueByType("picture", _httpConextAccessor.HttpContext.User.Claims, 1);

            var user = await _userRep.GetUser(userid);

            user.PictureUrl = picture;

            return user;
        }


        private string GetClaimValueByType(string type, IEnumerable<Claim> claims, int index = 0)
        {
            var foundClaim = index == 0 ? claims.FirstOrDefault(c => c.Type == type) : claims.Where(c => c.Type == type).ToList()[index];
            return foundClaim != null ? foundClaim.Value : "";
        }
    }
}