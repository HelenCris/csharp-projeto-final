using biblioteca.Model.Connection;
using CSharpProjetoFinal;

public class UserRepository 
{
  public User CreateUser(User user, DatabaseConnection context) 
  {
    var NewUser = new User
    {
      Email_login = user.Email_login,
      Password_login = user.Password_login
    };
    context.Users.Add(NewUser);
    context.SaveChanges();

    return user;
  }
}


//  // criação do Usuario
//   app.MapPost("/user", (User user, DatabaseConnection context) => {
//       var NewUser = new User(
//           user.Name,
//           user.Email_login,
//           user.Password_login
//       );

//       context.Users.Add(NewUser);
//       context.SaveChanges();
//       return Results.StatusCode(201);
//   });