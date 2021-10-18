using System;
using System.Linq;
namespace workWithDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // добавление данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };
                // добавляем их в бд
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            // получение данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }
    }
}