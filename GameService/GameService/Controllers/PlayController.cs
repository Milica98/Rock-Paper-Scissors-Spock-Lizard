using RPSLSGame.Models;
using Microsoft.AspNetCore.Mvc;
using RPSLSGame.Interfaces;

namespace RPSLSGame.Controllers
{
    [Route("play")]
    [ApiController]
    public class PlayController(IGameService gameService) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<PlayResult>> Post([FromBody] PlayRequest playRequest)
        {
            try
            {
                PlayResult playResult = await gameService.getResultAgainstComputer(playRequest.Player);
                return Ok(playResult);
            }
            catch (Exception ex) { 
                return StatusCode(500, ex.Message);
            }
        }
    }
}
