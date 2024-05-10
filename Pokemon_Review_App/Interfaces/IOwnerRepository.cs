using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnerOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int ownerId);

        // Create
        bool CreateOwner (Owner owner);

        // Update
        bool UpdateOwner(Owner owner);

        // Delete
        bool DeleteOwner(Owner owner);

        // Save
        bool Save();
    }
}
