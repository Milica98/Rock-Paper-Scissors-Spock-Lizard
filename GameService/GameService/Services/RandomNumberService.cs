using GameService.Interfaces;
using GameService.Models;

namespace GameService.Services
{
    public class RandomNumberService(HttpClient httpClient) : IRandomNumberService
    {
        public async Task<int> GetRandomPositiveNumberAsync()
        { 
            try{
                RandomNumberResponse? response = await httpClient.GetFromJsonAsync<RandomNumberResponse>("https://codechallenge.boohma.com/random");
                if(response?.RandomNumber == null || response.RandomNumber < 1)
                {
                    throw new Exception("Invalid response from https://codechallenge.boohma.com/random");
                }
                return response.RandomNumber;
            }
            catch(Exception ex){
                throw new Exception("Error on getting response from https://codechallenge.boohma.com/random", ex);
            }
        }
    }
}
