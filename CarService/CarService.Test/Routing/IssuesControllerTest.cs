
namespace CarService.Test.Routing
{
    using CarService.Controllers;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class IssuesControllerTest
    {
        [Fact]
        public void AddIssueRouteShouldBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap("/Issues/AddIssue?carId=1")
                .To<IssuesController>(c => c.AddIssue(1));

        [Fact]
        public void AllIssueRouteShouldBeMapped()
          => MyRouting
              .Configuration()
              .ShouldMap("/Issues/AllIssues?carId=1")
              .To<IssuesController>(c => c.AllIssues(1));


        [Fact]
        public void EditIssueRouteShouldBeMapped()
          => MyRouting
              .Configuration()
              .ShouldMap("/Issues/EditIssue?issueId=1&carId=1")
              .To<IssuesController>(c => c.EditIssue(1,1));
    }
}
