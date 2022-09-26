using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Service;

// mostrar um usuario específico
namespace biblioteca.Routes
{
  public class UserGetSingle
    {
        public static string Template => "/user/login";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;
        public static IResult Action(Login login, DatabaseConnection context)
        {
            var userService = new UserService();
            var user = userService.GetUserSingle(login, context);
            return user;
        }
   
    }
}