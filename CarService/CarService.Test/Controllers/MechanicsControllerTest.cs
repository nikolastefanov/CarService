
namespace CarService.Test.Controllers
{
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Models.Cars;
    using CarService.Models.IssueTypes;
    using CarService.Models.Mechanics;
    using MyTested.AspNetCore.Mvc;
    using System.Linq;
    using Xunit;

    using static WebConstants;
    public class MechanicsControllerTest
    {
        [Fact]
        public void GetBecomeShouldBeForAuthorizedUsersAndReturnView()
           => MyController<MechanicsController>
               .Instance()
               .Calling(c => c.Become())
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
               .AndAlso()
               .ShouldReturn()
               .View();


        [Theory]
        [InlineData("Mechanic", "0888888888")]
        public void PostBecomeShouldBeForAuthorizedUsersAndReturnRedirectWithValidModel(
            string mechanicName,
            string phoneNumber)
            => MyController<MechanicsController>
                .Instance(controller => controller
                    .WithUser())
                .Calling(c => c.Become(new BecomeMechanicViewModel
                {
                    FullName = mechanicName,
                    PhoneNumber = phoneNumber
                }))
                .ShouldHave()
                .ActionAttributes(attributes => attributes
                    .RestrictingForHttpMethod(HttpMethod.Post)
                    .RestrictingForAuthorizedRequests())
                .ValidModelState()
                .Data(data => data
                    .WithSet<Mechanic>(mechanics => mechanics
                        .Any(m =>
                            m.FullName == mechanicName &&
                            m.PhoneNumber == phoneNumber &&
                            m.UserId == TestUser.Identifier)))
            .AndAlso()
            .ShouldReturn()
            .RedirectToAction("IndexIssueType", "IssueTypes");
    }

}

