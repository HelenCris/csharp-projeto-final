using biblioteca.Model.Connection;
using CSharpProjetoFinal;

namespace Repository 
{
  public class UserRepository 
  {
    public User GetUserSingle(Login login, DatabaseConnection context)
    {
      
      User u = null;
      List<User> users = context.Users.ToList();
      foreach(User user in users) {
        if(user.Email == login.Email && user.Password == login.Password) {
          u = new User{Id = user.Id, Name = user.Name, Email = user.Email, Password = user.Password};
        }
      }

      return u;
    }

    public List<User> GetAllUsers(DatabaseConnection context)
    {
      List<User> users = context.Users.ToList();
      return users;
    }

    public User CreateUser(User user, DatabaseConnection context) 
    {
      context.Users.Add(user);
      context.SaveChanges();

      return user;
    }

     public User UpdateUser(int id, User user, DatabaseConnection context)
      {
      var userUnique = context.Users.Where(u => u.Id == id).First();

      userUnique.Name = user.Name != null ? user.Name : userUnique.Name;
      userUnique.Email = user.Email != null ? user.Email : userUnique.Email; 
      userUnique.Password = user.Password != null ? user.Password : userUnique.Password;

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
