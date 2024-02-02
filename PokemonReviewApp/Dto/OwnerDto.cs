using System.Text.Json.Serialization;

namespace PokemonReviewApp.Dto
{
    public class OwnerDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gym { get; set; }
    }
}
