using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDbContext _context { get; }

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }


        public void DeleteEmployee(Employee employee)
        {
            _context.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetEmployee(int EmployeeId)
        {
            return _context.Employees.Find(EmployeeId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            var employeeChanged = _context.Employees.Attach(employee);
            employeeChanged.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employee;

        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
