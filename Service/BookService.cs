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

    public  IResult CreateBook(Book book, DatabaseConnection context) 
    {
        var bookRepository = new BookRepository();
        var bookPost = new Book();
        bookPost = bookRepository.CreateBook(book, context);
            
        return Results.Created($"/book/{book.Id}", book.Id);
    }

    public IResult UpdateBook(int id, Book bookRequest, DatabaseConnection context)
     {
      var bookRepository = new BookRepository();
      var book = bookRepository.UpdateBook(id, bookRequest, context);

      return Results.StatusCode(204);
     }

     public IResult DeleteBook(int id, DatabaseConnection context) 
     {
        var bookRepository = new BookRepository();
        var book = bookRepository.DeleteBook(id,  context);

        if (book == null) {
          return Results.NotFound("Livro não encontrado");
        }

        return Results.StatusCode(200);
     }
  }
}