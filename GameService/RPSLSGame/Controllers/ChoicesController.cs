using RPSLSGame.Interfaces;
using RPSLSGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace RPSLSGame.Controllers
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
