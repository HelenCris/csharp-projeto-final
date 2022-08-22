using biblioteca.Model.Connection;
using CSharpProjetoFinal;

namespace Repository 
{
  public class UserRepository 
  {
    public User GetUserSingle(int id, DatabaseConnection context)
    {
      var user = context.Users.Where(u => u.Id == id).First();
      
        var response = new User
        {
          Name = user.Name,
          Email = user.Email,
          Password = user.Password
        };
      
      return response;
    }

    public List<User> GetAllUser(DatabaseConnection context)
    {
      List<User> users = context.Users.ToList();
      return users;
    }

    public User CreateUser(User user, DatabaseConnection context) 
    {
      var newUser = new User
      {
        Name = user.Name,
        Email = user.Email,
        Password = user.Password
      };
      context.Users.Add(newUser);
      context.SaveChanges();

      return user;
    }

     public User UpdateUser(int id, User user, DatabaseConnection context)
      {
      var userUnique = context.Users.Where(u => u.Id == id).First();

      user.Name = user.Name != null ? user.Name : userUnique.Name;
      user.Email = user.Email != null ? user.Email : userUnique.Email; 
      user.Password = user.Password != null ? user.Password : userUnique.Password;

      context.SaveChanges();

      return userUnique;
      }

        public User DeleteUser(int id, DatabaseConnection context)
        {
        var user = context.Users.Where(u => u.Id == id).First();

        context.Users.Remove(user);
        context.SaveChanges();

        return user;
        }
  }
}
