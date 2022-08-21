using Microsoft.AspNetCore.Mvc;
using biblioteca.Model.Connection;
using biblioteca.Model.Repository;

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
            var bookRepository = new BookRepository();
            var book = bookRepository.DeleteBook(id,  context);

            return Results.StatusCode(200);
        }
    }
}