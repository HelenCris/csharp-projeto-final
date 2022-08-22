using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using Repository;
using CSharpProjetoFinal;

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
            var bookRepository = new BookRepository();
            Book book = bookRepository.GetBookSingle(id, context);
            return Results.Ok(book);
        }
    }
}