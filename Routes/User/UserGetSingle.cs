using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using Service;

// mostrar um usuario específico
namespace biblioteca.Routes
{
  public class UserGetSingle
    {
        public static string Template => "/user/{id}";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;
        public static IResult Action([FromRoute] int id, DatabaseConnection context)
        {
            var userService = new UserService();
            var user = userService.GetUserSingle(id, context);
            return user;
        }
   

        // public static IResult Action([FromRoute] int id, DatabaseConnection context)
        // {
        //     var userRepository = new UserRepository();
        //     User user = userRepository.GetUserSingle(id, context);
        //     return Results.Ok(user);
        // }
    }
}