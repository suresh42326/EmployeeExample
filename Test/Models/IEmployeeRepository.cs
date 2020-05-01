using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        Employee AddEmployee(Employee employee);
        Employee GetEmployee(int EmployeeId);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

    }
}
