using GameService.Interfaces;
using GameService.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameService.Controllers
{
    [Route("")]
    [ApiController]
    public class ChoicesController(IChoiceService choiceService) : ControllerBase
    {
        [HttpGet("choices")]
        public ActionResult<IEnumerable<Choice>> GetChoices()
        {
            IEnumerable<Choice> choices = choiceService.GetAllChoices();
            return Ok(choices);
        }

        [HttpGet("choice")]
        public async Task<ActionResult<Choice>> GetChoice()
        {
            try
            {
                Choice choice = await choiceService.GetRandomChoiceAsync();
                return Ok(choice);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
