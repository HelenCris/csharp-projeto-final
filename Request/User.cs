namespace CSharpProjetoFinal{
    // construtor da tabela usuario para a criação do banco de dados
    public class User
    {
        public long? Id { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }

        public string? Password { get; set; }
        


    // public User(
    //     string email_login,
    //     string password_login )
    // {
    //     Email_login = email_login;
    //     Password_login = password_login;
    // }
  }
}