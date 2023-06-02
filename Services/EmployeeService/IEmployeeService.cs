using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Metrics;

namespace Employee_api.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployee();
        Employee? GetSingleEmployee(int EmployeeId);
        List<Employee> AddEmployee(Employee employee);
        List<Employee>? UpdateEmployee(int EmployeeId, Employee request);
        List<Employee>? DeleteEmployee(int EmployeeId);
    }
    
}

