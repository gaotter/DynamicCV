using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using DynamicCv.Entities.CvEntities;
using DynamicCv.Services.Interfaces;

namespace DynamicCv.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/CvEntires")]
    public class CvEntiresController : Controller
    {
        private ICvEntriesRepository _entryService;
        public CvEntiresController(ICvEntriesRepository entryService)
        {
            _entryService = entryService;
        }
        [HttpGet]
        public async Task<IEnumerable<Entry>> Get()
        {
            return await _entryService.GetAllEntires();
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Entry entry)
        {
            var status = await _entryService.UpdateEntry(entry);

            if (status == Common.Enums.Statuses.NotFound)
                return BadRequest();

            return Ok(entry);
        }
    }
}