
namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Models.Reviews;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext data;

        public ReviewsController(ApplicationDbContext data)
        {
            this.data = data;
        }
        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult Create(ReviewInputFormModel review)
        {
            var reviewData = new ReviewInputFormModel
            {
                Content=review.Content,
            };

           // data.Reviews.Add(reviewData);
            data.SaveChanges();


            return this.View();
        }

        public IActionResult AllReviews()
        {

           // var reviewsAll = data.Reviews
           //     .Select(x => new ReviewAllViewModel
           //     {
           //         
           //         
           //     });
           //
            return this.View();
        }
    }
}
