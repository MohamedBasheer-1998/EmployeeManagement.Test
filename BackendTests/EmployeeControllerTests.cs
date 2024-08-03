//using Microsoft.AspNetCore.Mvc.Testing;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Xunit;

//namespace EmployeeManagement.Tests.BackendTests
//{
//    public class EmployeeControllerTests : IClassFixture<WebApplicationFactory<EmployeeManagement.Startup>>
//    {
//        private readonly HttpClient _client;

//        public EmployeeControllerTests(WebApplicationFactory<EmployeeManagement.Startup> factory)
//        {
//            _client = factory.CreateClient();
//        }

//        [Fact]
//        public async Task Index_ReturnsSuccessStatusCode()
//        {
//            var response = await _client.GetAsync("/Employee/Index");
//            response.EnsureSuccessStatusCode();
//        }
//    }
//}
