
using RPSLSGame.GameConfiguration;
using RPSLSGame.Interfaces;
using RPSLSGame.Models;

namespace RPSLSGame.Services
{
    public class GameService(IChoiceService choiceService) : IGameService
    {
        public async Task<PlayResult> getResultAgainstComputer(int playerChoiceId)
        {
            Choice computerChoice = (await choiceService.GetRandomChoiceAsync());
            string result;

            if (playerChoiceId != computerChoice.Id)
            {
                Choice playerChoice = choiceService.GetChoice(playerChoiceId);

                if (GameConfig.winnerMap[playerChoice.Name].Contains(computerChoice.Name))
                    result = "win";
                else
                    result = "lose";
            }
            else
            {
                result = "tie";
            }

            return new PlayResult() { Computer = computerChoice.Id, Player = playerChoiceId, Results = result };
        }
    }
}
