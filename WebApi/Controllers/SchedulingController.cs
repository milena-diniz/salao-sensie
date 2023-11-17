using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using WebApi.DTO;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchedulingController : ControllerBase
    {
        private SchedulingService _schedulingService;

        public SchedulingController(SchedulingService schedulingService)
        {
            _schedulingService = schedulingService;
        }

        [HttpPost]
        public IActionResult Scheduling(SchedulingDto request) 
        {
            try
            {
                var result = _schedulingService.Create(request);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);   
            }
        }
    }
}
