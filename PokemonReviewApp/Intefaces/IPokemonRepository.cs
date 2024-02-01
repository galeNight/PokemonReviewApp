using PokemonReviewApp.Models;

namespace PokemonReviewApp.Intefaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
