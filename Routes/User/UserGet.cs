using biblioteca.Model.Connection;
using Service;

//mostrar todos os usuarios
namespace biblioteca.Routes
{
  public class UserGet
    {
        public static string Template => "/user";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(DatabaseConnection context)
        {
            var userService = new UserService();
            var users = userService.GetAllUsers(context);
            return users;

        }
    }
}