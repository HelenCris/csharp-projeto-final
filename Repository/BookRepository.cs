using biblioteca.Model.Connection;
using CSharpProjetoFinal;

namespace Repository 
{
  public class BookRepository 
  {
    public Book GetSingleBook(int id, DatabaseConnection context)
    {
      var book = context.Books.Where(p => p.Id == id).FirstOrDefault();
      return book;
    }


    public List<Book> GetAllBooks(DatabaseConnection context)
    {
      List<Book> books = context.Books.ToList();
      
      return books;
    }

    public Book CreateBook(Book book, DatabaseConnection context) 
    {

      context.Books.Add(book);
      context.SaveChanges();

      return book;
    }

    public Book UpdateBook(int id, Book bookRequest, DatabaseConnection context) 
    { 
      var book = context.Books.Where(b => b.Id == id).First();
        book.Code_book = bookRequest.Code_book;
        book.Title_book = bookRequest.Title_book;
        book.Author = bookRequest.Author;
        book.Description_book = bookRequest.Description_book;

      context.SaveChanges();

      return book;
    }

    public Book DeleteBook(int id, DatabaseConnection context)
    {
      var book = context.Books.Where(b => b.Id == id).First();

      context.Books.Remove(book);
      context.SaveChanges();

      return book;
    }
  }
}
