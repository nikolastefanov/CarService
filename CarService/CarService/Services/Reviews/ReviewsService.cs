
namespace CarService.Services.Reviews
{
    using CarService.Data;
    using CarService.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ReviewsService : IReviewsService
    {
        private readonly ApplicationDbContext data;

        public ReviewsService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public void CreateReview(string content)
        {
            var reviewData = new Review
            {
                Content = content,
                CreateOn = DateTime.UtcNow,
            };

            this.data.Reviews.Add(reviewData);

            this.data.SaveChanges();
        }

        public void DeleteReview(int reviewId)
        {
            var review = this.data
                .Reviews
                .Where(x => x.Id == reviewId)
                .FirstOrDefault();

            this.data.Reviews.Remove(review);

            this.data.SaveChanges();
        }

        public IEnumerable<ReviewServiceModel> GetAllReview()
        {
            var reviews = this.data.Reviews
                .Select(x => new ReviewServiceModel
                {
                    Id = x.Id,
                    Content = x.Content,
                    CreateOn = x.CreateOn,
                }).ToList();


            return reviews;
        }
    }
}
