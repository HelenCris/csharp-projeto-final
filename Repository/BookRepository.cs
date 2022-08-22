using biblioteca.Model.Connection;
using CSharpProjetoFinal;

namespace Repository 
{
  public class BookRepository 
{
  public Book CreateBook(Book book, DatabaseConnection context) 
  {
    var newBook = new Book
    {
      Code_book = book.Code_book,
      Title_book = book.Title_book,
      Author = book.Author,
      Description_book = book.Description_book,
    };
    context.Books.Add(newBook);
    context.SaveChanges();

    return book;
  }
}
}
