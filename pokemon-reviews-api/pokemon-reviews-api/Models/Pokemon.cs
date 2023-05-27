﻿namespace pokemon_reviews_api.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set;}

        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategory { get; set; }
    }
}
