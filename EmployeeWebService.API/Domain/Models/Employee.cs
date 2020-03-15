namespace EmployeeWebService.API.Domain.Models
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public string Department { get; set; }
        public string StartDate { get; set; }
        public float Salary { get; set; }
        public string Email { get; set; }

        public Employee()
        {
            
        }
    }
}