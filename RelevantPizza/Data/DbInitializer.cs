using System.Linq;
using RelevantPizza.Models;

namespace RelevantPizza.Data
{
    public class DbInitializer
    {
        public static void Initialize(PizzaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName = "Jessie", LastName = "Prescott", PhoneNumber = "123-123-1234", Role = Roles.Manager, Salary = 100000M}
                ,new Employee{FirstName = "Billy", LastName = "Smith", PhoneNumber = "123-123-1234", Role = Roles.AssistantManager, Salary = 40000M}
                ,new Employee{FirstName = "Johnathon", LastName = "Walsh", PhoneNumber = "123-123-1234", Role = Roles.Driver, Salary = 10000M}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }
    }
}
