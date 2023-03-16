using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDexService
{
    public class Pokemon : IPokemon
    {
        HttpClient _httpClient;
        public Pokemon(HttpClient httpClient) 
        { 
            _httpClient = httpClient;
        }

        public async Task<string> GetPokemonByPokedexSize(int pokedexSize)
        {
            string content = string.Empty;
            try
            {
                HttpResponseMessage responseMessage = await _httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/" + pokedexSize + "/");
                if(responseMessage.IsSuccessStatusCode)
                {
                    content = await responseMessage.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                content = ex.Message;
            }
            return content;
        }
    }
}
