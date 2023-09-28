using AwesomeNet.Unit35;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ControllerTests
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public async Task CheckStatus_OK()
        {
            WebApplicationFactory<Startup> webhost = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(_ =>{ });
            HttpClient httpClient = webhost.CreateClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync("home/check_status");
            Assert.AreEqual(HttpStatusCode.OK, responseMessage.StatusCode);

        }
    }
}