using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace EmployeeManagement.Tests.ApiTests
{
    public class EmployeeControllerApiTests
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;

        public EmployeeControllerApiTests()
        {
            _httpClient = new HttpClient();
            _baseAddress = "http://localhost:5001/api"; 
        }

        [Fact]
        public async Task GetEmployee_ValidId_ShouldReturnEmployee()
        {

            var employeeId = 1; 
            var requestUrl = $"{_baseAddress}/employees/{employeeId}";

            var response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();


            Assert.Contains("Mohamed", responseData); 
        }
    }
}
