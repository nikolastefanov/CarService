
namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Data.Models;
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
            var reviewData = new Review
            {
                Content=review.Content,
            };

           this.data.Reviews.Add(reviewData);
            this.data.SaveChanges();


            return RedirectToAction("AllReviews","Reviews");
        }

        public IActionResult AllReviews()
        {

            var reviewsAll = data.Reviews
                .Select(x => new ReviewViewModel
                {
                    Id = x.Id,
                    Content = x.Content,
                })
                .ToList();
           
            return this.View(reviewsAll);
        }
    }
}
