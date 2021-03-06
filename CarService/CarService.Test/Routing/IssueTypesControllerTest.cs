
namespace CarService.Test.Routing
{

    using CarService.Controllers;
    using CarService.Models.IssueTypes;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class IssueTypesControllerTest
    {
        [Fact]
        public void GetIndexIssueTypeShouldBeMapped()
           => MyRouting
               .Configuration()
               .ShouldMap("/IssueTypes/IndexIssueType")
               .To<IssueTypesController>(c => c.IndexIssueType());

        [Fact]
        public void GetAddIssueTypeShouldBeMapped()
           => MyRouting
               .Configuration()
               .ShouldMap("/IssueTypes/AddIssueType")
               .To<IssueTypesController>(c => c.AddIssueType());


        [Fact]
        public void PostAddIssueTypeShouldBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap(request => request
                    .WithPath("/IssueTypes/AddIssueType")
                    .WithMethod(HttpMethod.Post))
                .To<IssueTypesController>(c => c.AddIssueType(With.Any<IssueTypeViewModel>()));

        [Fact]
        public void GetEditIssueTypeShouldBeMapped()
           => MyRouting
               .Configuration()
               .ShouldMap("/IssueTypes/EditIssueType?issueTypeId=1")
               .To<IssueTypesController>(c => c.EditIssueType(1));



        [Theory]
        [InlineData(1)]
        public void PostEditIssueTypeShouldBeMapped(int issuetypeId)
             => MyRouting
                 .Configuration()
                 .ShouldMap(request => request
                     .WithLocation($"/IssueTypes/EditIssueType?issueTypeId={issuetypeId}")            
                     .WithMethod(HttpMethod.Post))
                     .To<IssueTypesController>(c => c.EditIssueType(issuetypeId, With.Any<IssueTypeViewModel>()));
                  

    }
}
