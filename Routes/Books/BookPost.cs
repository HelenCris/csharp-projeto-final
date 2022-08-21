using biblioteca.Model.Connection;
using CSharpProjetoFinal;

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
            var bookRepository = new BookRepository();
            var bookPost = new Book();
            bookPost = bookRepository.CreateBook(book, context);
            
            return Results.Created($"/book/{book.Id}", book.Id);
        }
    }
}
