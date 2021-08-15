
namespace CarService.Test.Routing
{
    using CarService.Controllers;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class WorksControllerTest
    {
        [Fact]
        public void AddWorksRouteShouldBeMapped()
           => MyRouting
               .Configuration()
               .ShouldMap("/Works/AddWorks?issueId=3&carId=1")
               .To<WorksController>(c => c.AddWorks(3,1,null));

        [Fact]
        public void AllWorksRouteShouldBeMapped()
          => MyRouting
              .Configuration()
              .ShouldMap("/Works/AllWorks?issueId=2&carId=1")
              .To<WorksController>(c => c.AllWorks(2, 1));

        [Fact]
        public void EditWorksRouteShouldBeMapped()
         => MyRouting
             .Configuration()
             .ShouldMap("/Works/EditWorks?workId=1&issueId=2&carId=1")
             .To<WorksController>(c => c.EditWorks(1,2, 1));

        [Fact]
        public void DeleteWorksRouteShouldBeMapped()
        => MyRouting
            .Configuration()
            .ShouldMap("/Works/DeleteWorks?workId=1&issueId=2&carId=1")
            .To<WorksController>(c => c.DeleteWorks(1, 2, 1));


    }
}
