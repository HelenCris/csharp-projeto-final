using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Repository;

namespace Service 
{
  public class UserService 
  {
    public IResult GetUserSingle(int id, DatabaseConnection context)
    {

        UserRepository userRepository = new UserRepository();

        User? user = userRepository.GetUserSingle(id, context);

        if(user == null)
            return Results.NotFound("Usuário não encontrado");
             
        return Results.Ok(user);
    }
}
}