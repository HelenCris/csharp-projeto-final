using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Repository;

namespace Service 
{
  public class UserService 
  {
    public IResult GetUserSingle(int id, DatabaseConnection context)
    {

        UserRepository userRepository = new UserRepository();

        User? user = userRepository.GetUserSingle(id, context);

        if(user == null)
            return Results.NotFound("Usuário não encontrado");
             
        return Results.Ok(user);
    }

    public IResult GetAllUsers(DatabaseConnection context)
    {
        var userRepository = new UserRepository();
        
        List<User> users = userRepository.GetAllUsers(context);
        
        return Results.Ok(users);
    }

     public IResult CreateUser(User user, DatabaseConnection context)
     {
      var userRepository = new UserRepository();
      var userPost = new User();
      userPost = userRepository.CreateUser(user, context);
      
      return Results.Created($"/user/{user.Id}", user.Id);
     }

     public IResult UpdateUser(int id, User userRequest, DatabaseConnection context)
     {
      var userRepository = new UserRepository();
      var user = userRepository.UpdateUser(id, userRequest, context);

      return Results.StatusCode(204);
     }

     public IResult DeleteUser(int id, DatabaseConnection context) 
     {
        var userRepository = new UserRepository();
        var user = userRepository.DeleteUser(id,  context);

        if(user == null)
            return Results.NotFound("Usuário não encontrado");

        return Results.StatusCode(200);
     }
  }
}