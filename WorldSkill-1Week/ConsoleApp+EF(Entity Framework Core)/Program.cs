using System;
using System.Linq;

namespace ConsoleApp_EF_Entity_Framework_Core_ // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            using (WorldSkills1Context db = new WorldSkills1Context())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.ReadKey();
        }
    }
}