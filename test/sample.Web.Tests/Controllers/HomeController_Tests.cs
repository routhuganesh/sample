using System.Threading.Tasks;
using sample.Models.TokenAuth;
using sample.Web.Controllers;
using Shouldly;
using Xunit;

namespace sample.Web.Tests.Controllers
{
    public class HomeController_Tests: sampleWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}