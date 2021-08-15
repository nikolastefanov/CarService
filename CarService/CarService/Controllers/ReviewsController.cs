
namespace CarService.Controllers
{
    using CarService.Infrastructure;
    using CarService.Models.Reviews;
    using CarService.Services.Reviews;
    using Ganss.XSS;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    using static WebConstants;
    public class ReviewsController : Controller
    {
        private const int ItemsPerPage = 2;
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
            var sanitizer = new HtmlSanitizer();

            var userId = this.User.GetId();

            var newContent = sanitizer.Sanitize(review.Content);
            

            reviewsService.CreateReview(userId,newContent);

            return RedirectToAction("AllReviews","Reviews");
        }

        public IActionResult AllReviews()
        {

             var sanitizer = new HtmlSanitizer();

            var reviewsAll = reviewsService
                .GetAllReview()
                .Select(x => new ReviewViewModel
                {
                    Id = x.Id,
                    SanContent =sanitizer.Sanitize(x.Content),
                    CreateOn = x.CreateOn.ToString()
                })
                .ToList();

            if (reviewsAll == null)
            {
                return this.NotFound();
            }

            var count = reviewsAll.Count();

           // var reviews=reviewsAll
           //     .Skip()
           //     .Take()
           //
              //  var cars = carsQuery
              //  .Skip((query.CurrentPage - 1) * AllCarsQueryModel.CarsPerPage)
              //  .Take(AllCarsQueryModel.CarsPerPage)
               // .Select....

            return this.View(reviewsAll);
        }

        [Authorize(Roles = AdministratorRoleName)]
        public ActionResult Delete(int reviewId)
        {
            reviewsService.DeleteReview(reviewId);

            return RedirectToAction("AllReviews");
        }
    }
}
