namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Rank { get; set; }

        // Khóa ngoại
        public int DepartmentId { get; set; }

        // Thuộc tính điều hướng
        public Department Department { get; set; }
    }
}
