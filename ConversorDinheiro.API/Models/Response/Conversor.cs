using System.Text.Json.Serialization;

namespace ConversorDinheiro.API.Models.Response
{
    public class Conversor : Base
    {
        [JsonPropertyName("amount")]
        public double amount { get; set; }
    }
}
