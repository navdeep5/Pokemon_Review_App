using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id);    

        // Create
        bool CreateCountry (Country country);

        // Update
        bool UpdateCountry (Country country);

        // Delete
        bool DeleteCountry(Country country);

        // Save
        bool Save();
    }
}
