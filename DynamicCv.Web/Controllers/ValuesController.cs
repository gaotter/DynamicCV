using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DynamicCv.Services.Interfaces;
using DynamicCv.Services.Repositories;
using DynamicCv.Entities.CvEntities;

namespace DynamicCv.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ICvEntriesRepository _cvEnt;

        public ValuesController(ICvEntriesRepository cvEnt)
        {
            _cvEnt = cvEnt;
        }
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Entry>> Get()
        {
            var all = await _cvEnt.GetAllEntires();
            return all;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
