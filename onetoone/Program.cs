using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace onetoone
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                // User user1 = new User() { Login = "rvn", Password = "1234" };
                // User user2 = new User() { Login = "liza", Password = "pass" };
                // db.Users.Add(user1);
                // db.Users.Add(user2);
                // db.SaveChanges();
                // UserProfile prof1 = new UserProfile() { Id = user1.Id, Name = "Illia", Age = 20 };
                // UserProfile prof2 = new UserProfile() { Id = user2.Id, Name = "Liza", Age = 19 };
                // db.UserProfiles.Add(prof1);
                // db.UserProfiles.Add(prof2);
                // db.SaveChanges();
                var users = db.Users.Include("Profile").ToList();
                foreach(var user in users)
                    Console.WriteLine($"{user.Login}-{user.Password}-{user.Profile.Name}-{user.Profile.Age}");
                
            }
        }
    }
}