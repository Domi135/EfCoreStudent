using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreStudent
{
    internal class Menu
    {
        public DbContext dbContext = new DbContextStudent();
        
        public void RegisterNewStudent()
        {
            Console.WriteLine("Skriv in info");
            Console.Write("Namn: ");
            string firstName = Console.ReadLine();
            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine();
            Console.Write("Stad: ");
            string city = Console.ReadLine();
            var student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                City = city
            };
            dbContext.Add(student);
            dbContext.SaveChanges();
        }

        public void ChangeStudent()
        {
            var dbContext = new DbContextStudent();
            Console.WriteLine("Skriv namnet på studenten du vill ändra på");        //här kan jag göra valet lite djupare o försöka välja en specifik student ist
            string nameOfStudent = Console.ReadLine();
            var changedStudent = dbContext.Students.Where(s => s.FirstName == nameOfStudent).FirstOrDefault<Student>();
            Console.Write("Nytt namn: ");
            string firstName = Console.ReadLine();
            Console.Write("Nytt efternamn: ");
            string lastName = Console.ReadLine();
            Console.Write("Ny stad: ");
            string city = Console.ReadLine();
            changedStudent.FirstName = firstName;
            changedStudent.LastName = lastName;
            changedStudent.City = city;
            dbContext.SaveChanges();
        }

        public void ListAllStudents()
        {
            var dbContext = new DbContextStudent();
            foreach (var item in dbContext.Students)
            {
                Console.WriteLine($"Student id: {item.StudentId}, {item.FirstName} {item.LastName} {item.City}");
            }
        }
    }
}
