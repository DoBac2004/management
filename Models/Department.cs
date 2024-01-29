namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public int NumberOfEmployees { get; set; }

        // Thuộc tính điều hướng
        public List<Employee> Employees { get; set; }
    }
}
