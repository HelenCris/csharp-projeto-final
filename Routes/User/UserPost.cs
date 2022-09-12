using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Service;

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

            var userService = new UserService();
            var userPost = userService.CreateUser(user, context);
            return userPost;           
            
        }
    }
}
