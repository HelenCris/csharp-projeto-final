using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using Service;

// mostrar um livro específico
namespace biblioteca.Routes
{
  public class BookGetSingle
    {
        public static string Template => "/book/{id}";
        public static string[] Methods => new string[] {HttpMethod.Get.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] int id, DatabaseConnection context)
        {
            var bookService = new BookService();
            var book = bookService.GetSingleBook(id, context);
            return book;
        }
    }
}