using HomeServicesPlatform.Bussiness.DTOs;
using HomeServicesPlatform.Bussiness.Entities;
using HomeServicesPlatform.Bussiness.Services;
using HomeServicesPlatform.DataAccess.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace HomeServicesPlatform.Controllers
{
    [ApiController]
    [Route("api/DryCleaners")]
    public class DryCleanersController : ControllerBase
    {
        private readonly DryCleanerService dryCleanerService;

        public DryCleanersController()
        {
            this.dryCleanerService = dryCleanerService = new DryCleanerService(new LiteDbDryCleanersRepository());
        }

        [HttpGet("/get-all")]
        public IActionResult GetAll()
        {
            IEnumerable<DryCleaners> result = dryCleanerService.GetAll();
            if ( !result.Any())
            {
                return BadRequest("No dry cleaners found");
            }
            return Ok(result);
        }

        [HttpGet("/get-by-id/{cleanerId}")]
        public IActionResult GetById(int cleanerId)
        {
            DryCleanersDto result = dryCleanerService.GetById(cleanerId);

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
