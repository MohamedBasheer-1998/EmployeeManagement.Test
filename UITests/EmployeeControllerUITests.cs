using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement.Tests.UITests
{
    public class EmployeeControllerUITests : IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly string _baseAddress;

        public EmployeeControllerUITests()
        {
            _driver = new ChromeDriver();
            _baseAddress = "http://localhost:5000";
        }

        [Fact]
        public void CreateEmployee_ValidData_ShouldCreateEmployeeAndRedirectToIndex()
        {
            _driver.Navigate().GoToUrl($"{_baseAddress}/Employee/Create");

            var nameField = _driver.FindElement(By.Name("Name"));
            var dobField = _driver.FindElement(By.Name("DateOfBirth"));
            var positionField = _driver.FindElement(By.Name("Position"));
            var addressField = _driver.FindElement(By.Name("Address"));
            var submitButton = _driver.FindElement(By.CssSelector("button[type='submit']"));

            nameField.SendKeys("Mohamed");
            dobField.SendKeys("1998-07-07");
            positionField.SendKeys("Software Engineer");
            addressField.SendKeys("Kadayanallur");
            submitButton.Click();

            var currentUrl = _driver.Url;
            Assert.Equal($"{_baseAddress}/Employee/Index", currentUrl);

            var employeeTable = _driver.FindElement(By.CssSelector("table"));
            Assert.Contains("Mohamed", employeeTable.Text);
        }

        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
