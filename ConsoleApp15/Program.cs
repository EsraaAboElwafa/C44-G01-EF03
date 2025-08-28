using ConsoleApp15.Data.Models;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new ITIDbContext();

            var dept = new Department { Name = "CS", HiringDate = DateTime.Now };
            context.Departments.Add(dept);
            context.SaveChanges();

            var departments = context.Departments.ToList();
            foreach (var d in departments)
                Console.WriteLine(d.Name);

            var depToUpdate = context.Departments.First();
            depToUpdate.Name = "Computer Science";
            context.SaveChanges();

            var depToDelete = context.Departments.First();
            context.Departments.Remove(depToDelete);
            context.SaveChanges();
        }
    }
}
