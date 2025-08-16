using GameService.Interfaces;
using GameService.Models;

namespace GameService.Services
{
    public class ChoiceService(IRandomNumberService randomNumberService) : IChoiceService
    {
        private readonly List<Choice> _choices = [
            new Choice(){Id = 1, Name = "rock"},
            new Choice(){Id = 2, Name = "paper"},
            new Choice(){Id = 3, Name = "scissors"},
            new Choice(){Id = 4, Name = "lizard"},
            new Choice(){Id = 5, Name = "spock"}
        ];

        public IEnumerable<Choice> GetAllChoices()
        {
            return _choices;
        }

        public async Task<Choice> GetRandomChoiceAsync()
        {
            int randomNum = await randomNumberService.GetRandomPositiveNumberAsync();
            int index = (randomNum - 1) % _choices.Count;
            
            return _choices[index];
        }
    }
}
