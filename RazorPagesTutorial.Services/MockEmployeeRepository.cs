using RazorPagesTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace RazorPagesTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                 new Employee() { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@gmail.com", PhotoPath = "mary.jpg"},
                 new Employee() { Id = 2, Name = "John", Department= Dept.IT, Email = "john@gmail.com", PhotoPath= "john.jpg"},
                 new Employee(){ Id = 3, Name = "Sara", Department = Dept.IT, Email= "sara@gmail.com", PhotoPath= "sara.jpg"},
                 new Employee(){ Id = 3, Name = "David", Department = Dept.IT, Email= "david@gmail.com"}
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee updateEmployee)
        {
           Employee employee =  _employeeList.FirstOrDefault(e => e.Id == updateEmployee.Id);

            if(employee != null)
            {
                employee.Name = updateEmployee.Name;
                employee.Department = updateEmployee.Department;
                employee.Email = updateEmployee.Email;
            }
            return employee;
        }
    }
}
