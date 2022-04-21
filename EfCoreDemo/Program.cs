using Newtonsoft.Json;

namespace EfCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //var users = GetUsers();
            //DisplayUsers(users);
            var db = new EfDbContext();

            var users = GetUsers();
            db.Users.AddRange(users);
            db.SaveChanges();

            Console.Clear();
            DisplayUsers(db.Users.ToList());
            Console.ReadKey();
        }

        private static void DisplayUsers(List<User> users)
        {
            
            Console.WriteLine(JsonConvert.SerializeObject(users, Formatting.Indented));
        }

        private static List<User> GetUsers()
        {
            var users = new List<User>();
            users.Add(new User { UserName = "ssswagatss", Age = 30, FirstName = "Swagat", LastName = "Swain" });
            users.Add(new User { UserName = "sonalis", Age = 25, FirstName = "Sonali", LastName = "Sahoo" });
            users.Add(new User { UserName = "bijayam", Age = 28, FirstName = "Bijaya", LastName = "Mishra" });
            users.Add(new User { UserName = "naibedyak", Age = 35, FirstName = "Naibedya", LastName = "Kar" });
            return users;
        }
    }
}