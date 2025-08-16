using RPSLSGame.Models;

namespace RPSLSGame.Interfaces
{
    public interface IGameService
    {
        public Task<PlayResult> getResultAgainstComputer(int playerChoice);
    }
}
