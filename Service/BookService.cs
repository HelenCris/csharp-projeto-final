using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Repository;

namespace Service
{
  public class BookService 
  {
    public IResult GetSingleBook(int id, DatabaseConnection context)
    {

        BookRepository bookRepository = new BookRepository();

        Book? book = bookRepository.GetSingleBook(id, context);

        if (book == null) {
          return Results.NotFound("Livro não encontrado");
        }

        return Results.Ok(book);

        // User? user = userRepository.GetUserSingle(id, context);

        // if(user == null)
        //     return Results.NotFound("Usuário não encontrado");
             
        // return Results.Ok(user);
    }

    // public IResult GetAllBooks(DatabaseConnection context)
    // {
        // var userRepository = new UserRepository();
        
        // List<User> users = userRepository.GetAllUsers(context);
        
        // return Results.Ok(users);
    // }
  }
}