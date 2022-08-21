namespace CSharpProjetoFinal{
    // construtor da tabela usuario para a criação do banco de dados
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email_login { get; set; }

        public string Password_login { get; set; }
        

        public User(
            string name,
            string email_login,
            string password_login 
            )
            {
                Name = name; 
                Email_login = email_login;
                Password_login = password_login;
            }
      
    }
}