using GameService.Interfaces;
using GameService.Models;

namespace GameService.Services
{
    public class ChoiceService : IChoiceService
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
    }
}
