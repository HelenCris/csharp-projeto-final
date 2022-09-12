using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using Service;

// deletar usuario
namespace biblioteca.Routes
{
  public class UserDelete
    {
        public static string Template => "/user/{id}";
        public static string[] Methods => new string[] { HttpMethod.Delete.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, DatabaseConnection context)
        {
            var userService = new UserService();
            var user = userService.DeleteUser(id,  context);

            return user;
        }
    }
}