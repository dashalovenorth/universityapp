namespace UniversityApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}