using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Repository;


//mostrar todos os livros
namespace biblioteca.Routes
{
    public class BookGet
    {
        public static string Template => "/book";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(DatabaseConnection context)
        {
            var bookRepository = new BookRepository();
            List<Book> books = bookRepository.GetAllBook(context);
            return Results.Ok(books);
        }
    }
}