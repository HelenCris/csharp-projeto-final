using biblioteca.Model.Connection;
using CSharpProjetoFinal;

public class BookRepository 
{
  public Book CreateBook(Book book, DatabaseConnection context) 
  {
    var NewBook = new Book
    {
      Code_book = book.Code_book,
      Title_book = book.Title_book,
      Author = book.Author,
      Description_book = book.Description_book,
    };
    context.Books.Add(NewBook);
    context.SaveChanges();

    return book;
  }
}