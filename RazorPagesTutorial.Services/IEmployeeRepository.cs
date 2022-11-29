using RazorPagesTutorial.Models;

namespace RazorPagesTutorial.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);

        Employee Update(Employee updateEmployee);
    }
}