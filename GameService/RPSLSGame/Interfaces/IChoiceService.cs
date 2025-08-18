using RPSLSGame.Models;

namespace RPSLSGame.Interfaces
{
    public interface IChoiceService
    {
        public List<Choice> GetAllChoices();

        public Task<Choice> GetRandomChoiceAsync();

        public Choice GetChoice(int id);
    }
}
