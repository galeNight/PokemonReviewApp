using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Models
{
    public class Category
    {
        //[Key] this key word Marks a property as the primary key of the entity.
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] Specifies that the database will generate values for the property, typically for an identity column.
        // and together the make a unik identity in from c# when a mirgration i done

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
