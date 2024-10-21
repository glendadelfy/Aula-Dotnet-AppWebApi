namespace AppWebApi.Model
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; } 
        public string endereco { get; set; }


        public UsuarioModel MockList()
        {
            var user = new UsuarioModel()
            {
                id = 1,
                nome = "Glenda Delfy",
                dataNascimento = new DateTime(2004,08,15),
                email = "glendadelfy20@gmail.com",
                endereco = "Rua abc123"
            };
            return user;
        }
        public UsuarioModel MockUpdate(UsuarioModel _user)
        {
            if (_user.id == 1 )
            {
                return _user;

            }
            else
            {
                return new UsuarioModel();
            }
        }
    }
}
