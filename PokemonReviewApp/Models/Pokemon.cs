using System.Text.Json.Serialization;

namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public ICollection<Review> Reviews { get; set; } // nested interties
        public ICollection<PokemonOwner> pokemonOwners { get; set; }
        public ICollection<PokemonCategory> pokemonCategories { get; set; }

    }
}