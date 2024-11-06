using System.Xml.Serialization;

namespace EfCoreStudent
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var Menu = new Menu();
            var dbContext = new DbContextStudent();
            while (true)
            {
                Console.WriteLine("Välj vad du vill göra (1-3)");
                Console.WriteLine("1. Registrera ny student");
                Console.WriteLine("2. Ändra student");
                Console.WriteLine("3. Lista alla studenter");
                Console.WriteLine("4. Avsluta");
                int val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        Menu.RegisterNewStudent();
                        break;

                    case 2:
                        Menu.ChangeStudent();
                        break;

                    case 3:
                        Menu.ListAllStudents();
                        break;

                    case 4:
                        Console.WriteLine("Tack o hej! :)");
                        return;

                    default:
                        Console.WriteLine("Någonting gick fel...");
                        return;
                }
            }
        }
    }

}
