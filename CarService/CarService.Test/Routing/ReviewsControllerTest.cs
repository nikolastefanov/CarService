
namespace CarService.Test.Routing
{
    using CarService.Controllers;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class ReviewsControllerTest
    {
        [Fact]
        public void CreateReviewsRouteShouldBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap("/Reviews/Create")
                .To<ReviewsController>(c => c.Create());


        [Fact]
        public void AllReviewsRouteShouldBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap("/Reviews/AllReviews")
                .To<ReviewsController>(c => c.AllReviews());
    }
}
