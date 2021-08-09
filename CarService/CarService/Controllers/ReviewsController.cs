
namespace CarService.Controllers
{
    using CarService.Infrastructure;
    using CarService.Models.Reviews;
    using CarService.Services.Reviews;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;


    public class ReviewsController : Controller
    {
        private readonly IReviewsService reviewsService;

        public ReviewsController(IReviewsService reviewsService)
        {
            this.reviewsService = reviewsService;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(ReviewInputFormModel review)
        {
            var userId = this.User.GetId();

            reviewsService.CreateReview(userId,review.Content);

            return RedirectToAction("AllReviews","Reviews");
        }

        public IActionResult AllReviews()
        {

            var reviewsAll = reviewsService
                .GetAllReview()
                .Select(x => new ReviewViewModel
                {
                    Id = x.Id,
                    Content = x.Content,
                    CreateOn = x.CreateOn.ToString()
                })
                .ToList();
                
           
            return this.View(reviewsAll);
        }

        [Authorize]
        public ActionResult Delete(int reviewId)
        {
            reviewsService.DeleteReview(reviewId);

            return RedirectToAction("AllReviews");
        }
    }
}
