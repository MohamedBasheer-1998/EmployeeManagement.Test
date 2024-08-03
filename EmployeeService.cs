using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }

    public class EmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _repository.GetAllEmployees();
        }
    }
}
