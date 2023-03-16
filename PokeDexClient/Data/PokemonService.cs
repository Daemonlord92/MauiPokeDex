using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PokedexClient.Data
{
    public class PokemonService
    {
        private readonly HttpClient httpClient;

        public PokemonService()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<Pokemon> GetRandomPokemon(int pokedexIndex)
        {
            var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/" + pokedexIndex + "/");
            response.EnsureSuccessStatusCode();
            var pokemon = await response.Content.ReadFromJsonAsync<Pokemon>();
            return pokemon;
        }

        public async Task<Berry> GetBerry(int berryIndex)
        {
            var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/berry/" + berryIndex + "/");
            response.EnsureSuccessStatusCode();
            var berry = await response.Content.ReadFromJsonAsync<Berry>();
            return berry;
        }
    }
}
