using HomeServicesPlatform.Bussiness.DTOs;
using HomeServicesPlatform.Bussiness.Entities;
using HomeServicesPlatform.Bussiness.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeServicesPlatform.Controllers
{
    [ApiController]
    [Route("api/DryCleaners")]
    public class DryCleanersController : ControllerBase
    {
        private readonly DryCleanerService dryCleanerService;

        public DryCleanersController(DryCleanerService dryCleanerService)
        {
            this.dryCleanerService = dryCleanerService;
        }

        [HttpGet("/get-all")]
        public IActionResult GetAll()
        {
            IEnumerable<DryCleaners> result = dryCleanerService.GetAll();
            return Ok(result);
        }

        [HttpGet("/get-by-id/{cleanerId}")]
        public IActionResult GetById(int cleanerId)
        {
            DryCleanersDto result = dryCleanerService.GetById(cleanerId);
            if (result == null)
            {
                return BadRequest("Dry cleaner not fount");
            }

            return Ok(result);
        }

        [HttpPost("/add")]
        public IActionResult Add(DryCleaners dryCleaner)
        {
            dryCleanerService.AddDryCleaner(dryCleaner);
            return Ok();
        }

        [HttpPut("/edit/{cleanerId}")]
        public IActionResult Edit(int cleanerId, string newName)
        {
            dryCleanerService.EditCleanersName(cleanerId, newName);
            return Ok();
        }

        [HttpDelete("/delete/{cleanerId}")]
        public IActionResult Delete(int cleanerId)
        {
            dryCleanerService.DeleteCleaner(cleanerId);
            return Ok();
        }
    }
}
