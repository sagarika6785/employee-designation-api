using Microsoft.Data.SqlClient;
using System.Data;

namespace Employee_api.Data
{
    public class EmployeeData
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;

        public static IConfiguration Configuration { get; set; }

        private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");  
        
            Configuration = builder.Build();
            return Configuration.GetConnectionString("Default");

        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            using (_connection = new SqlConnection(GetConnectionString()))
            {
                _command = _connection.CreateCommand();
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = "spGetAllEmployees";
                _connection.Open();
                SqlDataReader dr = _command.ExecuteReader();
                
                while (dr.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(dr["EmployeeId"]);
                    employee.EmployeeName = dr["EmployeeName"].ToString();
                    employee.Designation = dr["Designation"].ToString();
                    employee.PermanentAddress = dr["PermanentAddress"].ToString();
                    employee.CorrespondentAddress = dr["CorrespondentAddress"].ToString();
                    employeeList.Add(employee);

                }
                _connection.Close();
            }
            return employeeList;

        }
        
    }
}
