using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Post2Get.Tests
{
    public class ApiTests
    {
        [Test]
        public async Task LocalhostHttps()
        {
            var http = new HttpClient();
            var response = await http.PostAsync("https://localhost:5001/WeatherForecast", null);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task LocalhostHttp()
        {
            var http = new HttpClient();
            var response = await http.PostAsync("http://localhost:5000/WeatherForecast", null);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task AzureHttps()
        {
            var http = new HttpClient();
            var response = await http.PostAsync("https://post2get.azurewebsites.net/WeatherForecast", null);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task AzureHttp()
        {
            var http = new HttpClient();
            var response = await http.PostAsync("http://post2get.azurewebsites.net/WeatherForecast", null);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.MethodNotAllowed));
        }
    }
}