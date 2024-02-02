using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PokemonReviewApp.Models
{
    public class Owner
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }

        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
