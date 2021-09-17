
namespace CarService.Services.Reviews
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using CarService.Data;
    using CarService.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ReviewsService : IReviewsService
    {
        private readonly ApplicationDbContext data;
        private readonly IMapper mapper;

        public ReviewsService(IMapper mapper,ApplicationDbContext data)
        {
            this.mapper = mapper;
            this.data = data;
        }

        public void CreateReview(string userId,string content)
        {
            var reviewData = new Review
            {
                UserId=userId,
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
            var reviews = this.data
                .Reviews
                .ProjectTo<ReviewServiceModel>(mapper.ConfigurationProvider)
                .ToList();

           // var reviews = this.data.Reviews
           //     .Select(x => new ReviewServiceModel
           //     {
           //         Id = x.Id,
           //         Content = x.Content,
           //         CreateOn = x.CreateOn,
           //     }).ToList();
           //

             return reviews;
        }
    }
}
