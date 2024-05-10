using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfAPokemon(int pokeId);
        bool ReviewExists(int reviewId);

        // Create
        bool CreateReview(Review review);

        // Update
        bool UpdateReview(Review review);

        // Delete
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);

        // Save
        bool Save();
    }
}
