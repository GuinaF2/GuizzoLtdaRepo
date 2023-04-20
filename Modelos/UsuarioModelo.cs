namespace Modelos
{
    public class UsuarioModelo
    {
        //criação das variaveis protegidas
        private int idUsuario;
        private string cpf;
        private string email;
        private string nome;
        private string telefone;
        private string senha;
        //defino o construtor modelo usuario

        public UsuarioModelo()
        {
            idUsuario = 0;
            cpf = "";
            email = "";
            telefone = "";
            nome = "";
            senha = "";
        }

        public int CodUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }

        }
        public string CpfUser
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string EmailUser
        {
            get { return email; }
            set { email = value; }
        }
        public string NomeUser
        {
            get { return nome; }
            set { nome = value; }

        }
        public string FoneUser
        {
            get { return telefone; }
            set { telefone = value; }

        }
        public string SenhaUser
        {
            get { return senha; }
            set { senha = value; }

        }

    }
}
