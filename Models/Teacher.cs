namespace UniversityApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}