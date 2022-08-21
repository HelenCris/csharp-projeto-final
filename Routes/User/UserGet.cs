using biblioteca.Model.Connection;
using biblioteca.Model.Repository;
using biblioteca.Model.Response;

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
            var userRepository = new UserRepository();
            List<UserResponse> users = userRepository.GetAllUser(context);
            return Results.Ok(users);
        }
    }
}