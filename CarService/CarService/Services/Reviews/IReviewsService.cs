
namespace CarService.Services.Reviews
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public interface IReviewsService
    {
        void CreateReview(string userId,string content);

        IEnumerable<ReviewServiceModel> GetAllReview();

        void DeleteReview(int reviewId);

    }
}
