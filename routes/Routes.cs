using biblioteca.Model.Connection;
using CSharpProjetoFinal;
using Microsoft.AspNetCore.Mvc;



  var app = builder.Build();

  app.MapGet("/user", (DatabaseConnection context) => {
    List<User> Users = context.Users.ToList();
    return Results.Ok(Users);
  });

  app.MapGet("/book", (DatabaseConnection context) => {

      List<Book> Books = context.Books.ToList();
      return Results.Ok(Books);
  });


  // criação do Usuario
  app.MapPost("/user", (User user, DatabaseConnection context) => {
      var NewUser = new User(
          user.Name,
          user.Email_login,
          user.Password_login
      );

      context.Users.Add(NewUser);
      context.SaveChanges();
      return Results.StatusCode(201);
  });

  // criação dos livros
  app.MapPost("/book", (Book book, DatabaseConnection context) => {
      var NewBook = new Book(
          book.Code_book,
          book.Title_book,
          book.Author,
          book.Description_book
      );
      context.Books.Add(NewBook);
      context.SaveChanges();
      return Results.StatusCode(201);
  });


  // Atualização do Usuario
  app.MapPut("/user/{id}", ([FromRoute] int id, User user, DatabaseConnection context) => {

      User UpdateUser = context.Users.Where(u => u.Id == id).First();

          UpdateUser.Name = user.Name;
          UpdateUser.Email_login = user.Email_login;
          UpdateUser.Password_login = user.Password_login;

      context.SaveChanges();
      return Results.StatusCode(204);
  });

  // Atualização do livro
  app.MapPut("/book/{id}", ([FromRoute] int id, Book book, DatabaseConnection context) => {

      Book UpdateBook = context.Books.Where(b => b.Id == id).First();

          UpdateBook.Code_book = book.Code_book;
          UpdateBook.Title_book = book.Title_book;
          UpdateBook.Author = book.Author;
          UpdateBook.Description_book = book.Description_book;

      context.SaveChanges();
      return Results.StatusCode(204);
  });


  // Deletar Usuario
  app.MapDelete("/user/{id}", ([FromRoute] int id, DatabaseConnection context) => {

      User DeleteUser = context.Users.Where(u => u.Id == id).First();

      context.Users.Remove(DeleteUser);
      context.SaveChanges();
      return Results.StatusCode(200);
  });

  // Deletar Livro
  app.MapDelete("/book/{id}", ([FromRoute] int id, DatabaseConnection context) => {

      Book DeleteBook = context.Books.Where(b => b.Id == id).First();

      context.Books.Remove(DeleteBook);
      context.SaveChanges();
      return Results.StatusCode(200);
  });


