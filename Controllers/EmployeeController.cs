using Employee_api.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            return _employeeService.GetAllEmployees();
        }
        [HttpGet("{EmployeeId}")]
        public async Task<ActionResult<Employee>> GetSingleEmployee(int EmployeeId)
        {
            var result = _employeeService.GetSingleEmployee(EmployeeId);
            if (result == null)
                return NotFound("Employee not found");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            var result = _employeeService.AddEmployee(employee);
            return Ok(result);
        }

        [HttpPut("{EmployeeId}")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(int EmployeeId, Employee request)
        {
            var result = _employeeService.UpdateEmployee(EmployeeId, request);
            if (result == null)
                return NotFound("Employee not found");
            return Ok(result);
        }
        [HttpDelete("{EmployeeId}")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployee(int EmployeeId)
        {
            var result = _employeeService.DeleteEmployee(EmployeeId);
            if (result == null)
                return NotFound("Employee not found");
            return Ok(result);




        }
    }
}
