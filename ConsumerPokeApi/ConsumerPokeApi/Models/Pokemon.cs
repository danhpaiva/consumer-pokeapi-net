using System.Text.Json.Serialization;

namespace ConsumerPokeApi.Models;

public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("height")]
    public int Altura { get; set; }
    [JsonPropertyName("weight")]
    public int Peso { get; set; }
}
