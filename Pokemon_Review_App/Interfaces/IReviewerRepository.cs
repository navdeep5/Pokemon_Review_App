using Pokemon_Review_App.Models;

namespace Pokemon_Review_App.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);

        // Create
        bool CreateReviewer(Reviewer reviewer);

        // Update
        bool UpdateReviewer(Reviewer reviewer);

        // Delete
        bool DeleteReviewer(Reviewer reviewer);

        // Save
        bool Save();
    }
}
