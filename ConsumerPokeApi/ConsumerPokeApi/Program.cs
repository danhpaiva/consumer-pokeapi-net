using ConsumerPokeApi.Models;
using System.Text.Json;
using static System.Console;

WriteLine("\nDigite o nome de um Pokemon: ");
string nome = ReadLine();

string url = $"https://pokeapi.co/api/v2/pokemon/{nome}";
using HttpClient client = new();

try
{
    HttpResponseMessage response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();

    string jsonResponse = await response.Content.ReadAsStringAsync();

    Pokemon? pokemon = JsonSerializer.Deserialize<Pokemon>(jsonResponse);

    WriteLine("\nRetorno da API: ");
    WriteLine($"Id: {pokemon.Id}");
    WriteLine($"Nome: {pokemon.Nome}");
    WriteLine($"Altura: {pokemon.Altura}");
    WriteLine($"Peso: {pokemon.Peso}");
}
catch (Exception ex)
{
    WriteLine($"Erro ao acessar a API: {ex.Message}");
}