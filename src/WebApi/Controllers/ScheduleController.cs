using Application.Dtos;
using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {
        private readonly IDoScheduleUseCase _useCase;

        public ScheduleController(IDoScheduleUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public IActionResult Scheduling(DoScheduleDto dto) 
        {
            try
            {
                var result = _useCase.Schedule(dto);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);   
            }
        }
    }
}
