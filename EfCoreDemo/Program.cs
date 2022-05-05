using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EfCoreDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var db = new EfDbContext();
            var data = db.RawSqlQuery<List<Dictionary<string, object>>>("EXEC FetchDynamicData");
            DisplayUsers(data);
            var dataw=db.Users.Count();
            Console.ReadKey();
        }

        private static bool IsNameStartsWithS(User u)
        {
            //if(u == null)
            //    return false;

            //if(!string.IsNullOrEmpty(u.UserName) && (u.UserName.StartsWith("s") || u.UserName.StartsWith("S")))
            //    return true;
            //return false;


            //if (u !=null & !string.IsNullOrEmpty(u.UserName) && (u.UserName.StartsWith("s") || u.UserName.StartsWith("S")))
            //    return true;
            //else
            //    return false;

            return u != null & !string.IsNullOrEmpty(u.UserName) && (u.UserName.ToLower().StartsWith("s"));
        }

        private static void DisplayUsers(object value)
        {
            Console.WriteLine(JsonConvert.SerializeObject(value, Formatting.Indented));
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