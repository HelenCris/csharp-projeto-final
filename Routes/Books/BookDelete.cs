using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using Service;
// Deletar Livro
namespace biblioteca.Routes
{
  public class BookDelete
    {
        public static string Template => "/book/{id}";
        public static string[] Methods => new string[] { HttpMethod.Delete.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, DatabaseConnection context)
        {
            var bookService = new BookService();
            var book = bookService.DeleteBook(id,  context);

            return book;
        }
    }
}