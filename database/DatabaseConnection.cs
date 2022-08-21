using Microsoft.EntityFrameworkCore;
using CSharpProjetoFinal;

namespace biblioteca.Model.Connection {
   public class DatabaseConnection : DbContext 
   {
      public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}
      public DbSet<Book> Users { get; set; } 
      public DbSet<Book> Books { get; set; }           
   }
}