using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Service;

// atualizar o usuario
namespace biblioteca.Routes
{
  public class UserPut
    {
        public static string Template => "/user/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, User userRequest, DatabaseConnection context)
        {
            var userService = new UserService();
            var user = userService.UpdateUser(id, userRequest, context);

            return user;
        }
    }
}