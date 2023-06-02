namespace Employee_api.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee> {
                new Employee
                {
                    EmployeeId = 1,
                    EmployeeName = "Ram",
                    Designation = "Engineering",
                    PermanentAddress = "Jagatsinghpur",
                    CorrespondentAddress = "Cuttack"
                },
                new Employee
                {
                    EmployeeId = 2,
                    EmployeeName = "Shyam",
                    Designation = "Angular",
                    PermanentAddress = "Cuttack",
                    CorrespondentAddress = "Jagatsinghpur"
                }
            };
        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employee>? DeleteEmployee(int EmployeeId)
        {
            var employee = employees.Find(n => n.EmployeeId == EmployeeId);
            if (employee == null)
                return null;

            employees.Remove(employee);
            return employees;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee? GetSingleEmployee(int EmployeeId)
        {
            var employee = employees.Find(n => n.EmployeeId == EmployeeId);
            if (employee == null)
                return null;
            return employee;
        }

        public List<Employee>? UpdateEmployee(int EmployeeId, Employee request)
        {
            var employee = employees.Find(n => n.EmployeeId == EmployeeId);
            if (employee == null)
                return null;
            employee.EmployeeName = request.EmployeeName;
            employee.Designation = request.Designation;
            employee.PermanentAddress = request.PermanentAddress;
            employee.CorrespondentAddress = request.CorrespondentAddress;
            return employees;
        }
    }
}

   
