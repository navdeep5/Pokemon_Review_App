using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface ICategoryRepository
    {
        // Get
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExists(int id);
        
        // Create
        bool CreateCategory(Category category);

        // Update
        bool UpdateCategory(Category category);

        // Delete
        bool DeleteCategory(Category category);

        // Save
        bool Save();

    }
}
