using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using biblioteca.Model.Repository;
using biblioteca.Model.Request;

// atualizar o usuario
namespace biblioteca.Routes
{
    public class UserPut
    {
        public static string Template => "/user/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, UserRequest userRequest, DatabaseConnection context)
        {
            var userRepository = new UserRepository();
            var user = userRepository.UpdateUser(id, userRequest, context);

            return Results.StatusCode(204);
        }
    }
}