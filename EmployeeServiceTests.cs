using Moq;
using Xunit;
using EmployeeManagement.Services;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Tests
{
    public class EmployeeServiceTests
    {
        private readonly EmployeeService _service;
        private readonly Mock<IEmployeeRepository> _mockRepository;

        public EmployeeServiceTests()
        {
            _mockRepository = new Mock<IEmployeeRepository>();
            _service = new EmployeeService(_mockRepository.Object);
        }

        [Fact]
        public void GetEmployees_ReturnsAllEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Mohamed" },
                new Employee { Id = 2, Name = "Basheer" }
            };
            _mockRepository.Setup(repo => repo.GetAllEmployees()).Returns(employees);

            var result = _service.GetEmployees().ToList();

            Assert.Equal(2, result.Count);
            Assert.Equal("Mohamed", result[0].Name);
            Assert.Equal("Basheer", result[1].Name);
        }
    }
}
