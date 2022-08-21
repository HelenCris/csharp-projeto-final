using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using biblioteca.Model.Repository;
using biblioteca.Model.Request;

// atualizar os livros
namespace biblioteca.Routes
{
    public class BookPut
    {
        public static string Template => "/book/{id}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString()};
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute]int id, BookRequest bookRequest, DatabaseConnection context)
        {
            var bookRepository = new BookRepository();
            var book = bookRepository.UpdateBook(id, bookRequest, context);

            return Results.StatusCode(204);
        }
    }
}