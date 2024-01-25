﻿using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gym { get; set; }
        public Country Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}
