namespace GameService.Interfaces
{
    public interface IRandomNumberService
    {
        public Task<int> GetRandomPositiveNumberAsync();
    }
}
