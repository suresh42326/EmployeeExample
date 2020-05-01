using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository { get; }

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: Employee
        public ActionResult Index()
        {
            var employees = _employeeRepository.GetEmployees();
            return Ok(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = _employeeRepository.GetEmployee(id);
            return Ok(employee);
        }

        // GET: Employee/Create
        public ActionResult Create(Employee employee)
        {
            var emp = _employeeRepository.AddEmployee(employee);
            return Ok(emp);
        }


        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee employee)
        {
            try
            {
                _employeeRepository.DeleteEmployee(employee);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}