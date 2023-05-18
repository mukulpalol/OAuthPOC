namespace JwtDemo.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { UserName = "Ramu", Email = "ramuemail@gmail.com", Password = "password", Name = "Ramu", Role = "Admin" },
            new UserModel() { UserName = "Shyamu", Email = "shyamuemail@gmail.com", Password = "password", Name = "Shyamu", Role = "User" }
        };
    }
}
