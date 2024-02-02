using PokemonReviewApp.Models;

namespace PokemonReviewApp.Intefaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal getPokemonRating(int pokeId);
        bool PokemonExist(int pokeId);
        bool CreatePokemon (int ownerid,int categoryId,Pokemon pokemon);
        bool Save();

    }
}
