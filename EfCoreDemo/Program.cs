namespace EfCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var users = GetUsers();
            DisplayUsers(users);
            Console.ReadKey();
        }

        private static void DisplayUsers(List<User> users)
        {
            foreach (var u in users)
            {
                Console.WriteLine($"Name-{u.LastName} {u.LastName} | Age-{u.Age} | UserName-{u.UserName}");
            }
        }

        private static List<User> GetUsers()
        {
            var users = new List<User>();
            users.Add(new User { UserId = 1, UserName = "ssswagatss", Age = 30, FirstName = "Swagat", LastName = "Swain" });
            users.Add(new User { UserId = 2, UserName = "sonalis", Age = 25, FirstName = "Sonali", LastName = "Sahoo" });
            users.Add(new User { UserId = 2, UserName = "bijayam", Age = 28, FirstName = "Bijaya", LastName = "Mishra" });
            users.Add(new User { UserId = 2, UserName = "naibedyak", Age = 35, FirstName = "Naibedya", LastName = "Kar" });
            return users;
        }
    }
}