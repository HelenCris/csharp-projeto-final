using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Service;

// atualizar os livros
namespace biblioteca.Routes
{
  public class BookPut
    {
        public static string Template => "/book/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, Book bookRequest, DatabaseConnection context)
        {
            var bookService = new BookService();
            var book = bookService.UpdateBook(id, bookRequest, context);

            return book;
        }
    }
}