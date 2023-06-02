using System.Text.Json.Serialization; 

namespace Employee_api.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string PermanentAddress { get; set; }
        public string CorrespondentAddress { get; set; }
    }
}
