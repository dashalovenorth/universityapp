using UniversityApp.Data;
using UniversityApp.Models;

public static class DbInitializer
{
    public static void Initialize(UniversityContext context)
    {
        context.Database.EnsureCreated();

        if (context.Teachers.Any())
        {
            return; // База данных уже инициализирована
        }

        var teachers = new Teacher[]
        {
            new Teacher { Name = "Иванов И.И." },
            new Teacher { Name = "Петров П.П." }
        };
        context.Teachers.AddRange(teachers);
        context.SaveChanges();
    }
}