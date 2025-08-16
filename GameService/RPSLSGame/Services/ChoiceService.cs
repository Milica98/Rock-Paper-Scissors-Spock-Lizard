using RPSLSGame.GameConfiguration;
using RPSLSGame.Interfaces;
using RPSLSGame.Models;

namespace RPSLSGame.Services
{
    public class ChoiceService(IRandomNumberService randomNumberService) : IChoiceService
    {
        public List<Choice> GetAllChoices()
        {
            return [.. GameConfig.winnerMap.Keys.Select((name, index) => new Choice() { Id = index + 1, Name = name})];
        }

        public Choice GetChoice(int id)
        {
            if (id > GameConfig.choiceMap.Count || id < 1)
                throw new IndexOutOfRangeException("Choice Id has to be number between (including) 1 and " + GameConfig.choiceMap.Count);
            return this.GetAllChoices()[id - 1];
        }

        public async Task<Choice> GetRandomChoiceAsync()
        {
            List<Choice> choices = this.GetAllChoices();
            int randomNum = await randomNumberService.GetRandomPositiveNumberAsync();
            int index = (randomNum - 1) % choices.Count;
            
            return choices[index];
        }
    }
}
