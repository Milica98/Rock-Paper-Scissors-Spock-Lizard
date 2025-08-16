using System.Text.Json.Serialization;

namespace GameService.Models
{
    public class RandomNumberResponse
    {
        [JsonPropertyName("random_number")]
        public int RandomNumber { get; set; }
    }
}
