namespace CSharpProjetoFinal{
    // construtor da tabela livros para a criação do banco de dados

    public class Book
    {
        public long Id { get; set; }
        public string Code_book { get; set; }
        public string Title_book { get; set; }
        public string Author { get; set; }
        public string Description_book { get; set; }

        // public Book(
        //     string code_book,
        //     string title_book, 
        //     string author, 
        //     string description_book
        //     )
        //     {
        //         Code_book = code_book; 
        //         Title_book = title_book;
        //         Author = author;
        //         Description_book = description_book;
        //     }
      
    }
}