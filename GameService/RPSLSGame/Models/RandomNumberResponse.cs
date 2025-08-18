using System.Text.Json.Serialization;

namespace RPSLSGame.Models
{
    public class RandomNumberResponse
    {
        [JsonPropertyName("random_number")]
        public int RandomNumber { get; set; }
    }
}
