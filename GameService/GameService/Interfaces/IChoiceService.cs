using GameService.Models;

namespace GameService.Interfaces
{
    public interface IChoiceService
    {
        public IEnumerable<Choice> GetAllChoices();
    }
}
