using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Service;
// criar o livro
namespace biblioteca.Routes
{
  public class BookPost
    {
        public static string Template => "/book";
        public static string[] Methods => new string[] {HttpMethod.Post.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action(Book book, DatabaseConnection context)
        {        
            var bookService = new BookService();
            var bookPost = bookService.CreateBook(book, context);
            return bookPost; 
        }
    }
}
