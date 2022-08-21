using biblioteca.Model.Connection;
using CSharpProjetoFinal;

// criar o usuario
namespace biblioteca.Routes
{
  public class UserPost
    {
        public static string Template => "/user";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(User user, DatabaseConnection context)
        {
            var userRepository = new UserRepository();
            var userPost = new User();
            userPost = userRepository.CreateUser(user, context);
            
            return Results.Created($"/user/{user.Id}", user.Id);
        }
    }
}
