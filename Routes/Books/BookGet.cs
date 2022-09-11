using biblioteca.Model.Connection;
using Service;

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
            var booksService = new BookService();
            var books = booksService.GetAllBooks(context);
            return books;
        }
    }
}