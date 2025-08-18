namespace RPSLSGame.Interfaces
{
    public interface IRandomNumberService
    {
        public Task<int> GetRandomPositiveNumberAsync();
    }
}
