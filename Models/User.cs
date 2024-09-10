namespace CookieAuthDemo.Models
{
    public class User
    {
        public string Password { get; set; }
        public string UserName { get; set; }
    }
    public static class UserStore
    {
        public static List<User> Users = new List<User>
    {
        new User { UserName = "testuser", Password = "password123" }  // Sample user
    };

        public static User ValidateUser(string username, string password)
        {
            return Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }

}
