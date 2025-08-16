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
        public IEnumerable<Choice> Get()
        {
            return choiceService.GetAllChoices();
        }
    }
}
