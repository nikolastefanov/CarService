
namespace CarService.Controllers
{
    using CarService.Models.Reviews;
    using CarService.Services.Reviews;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;


    public class ReviewsController : Controller
    {
        private readonly IReviewsService reviewsService;

        public ReviewsController(IReviewsService reviewsService)
        {
            this.reviewsService = reviewsService;
        }

        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(ReviewInputFormModel review)
        {           

            reviewsService.CreateReview(review.Content);

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

        public ActionResult Delete(int reviewId)
        {
            reviewsService.DeleteReview(reviewId);

            return RedirectToAction("AllReviews");
        }
    }
}
