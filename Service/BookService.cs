using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Repository;

namespace Service
{
  public class BookService 
  {
    public IResult GetSingleBook(int id, DatabaseConnection context)
    {

        BookRepository bookRepository = new BookRepository();

        Book? book = bookRepository.GetSingleBook(id, context);

        if (book == null) {
          return Results.NotFound("Livro não encontrado");
        }

        return Results.Ok(book);
    }

    public IResult GetAllBooks(DatabaseConnection context)
    {
        var booksRepository= new BookRepository();
        var books = booksRepository.GetAllBooks(context);
        return Results.Ok(books);
    }
  }
}