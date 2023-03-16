using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeDexService
{
    public interface IPokemon
    {
        Task<string> GetPokemonByPokedexSize(int pokedexSize);
    }
}
