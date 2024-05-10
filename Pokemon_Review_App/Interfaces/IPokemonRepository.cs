using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);

        // Create
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        // Update
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);

        // Delete
        bool DeletePokemon(Pokemon pokemon);

        // Save
        bool Save();
    }
}
