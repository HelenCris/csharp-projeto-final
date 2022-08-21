using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using biblioteca.Model.Repository;

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
            var userRepository = new UserRepository();
            var user = userRepository.DeleteUser(id,  context);

            return Results.StatusCode(200);
        }
    }
}