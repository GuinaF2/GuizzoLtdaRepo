namespace Modelos
{
    public class UsuarioModelo
    {
        //criação das variaveis protegidas
        private int idUsuario;
        private string nome;
        private string cpf;
        private string contato;
        private string dtnasc;
        private string senha;
        //defino o construtor modelo usuario

        public UsuarioModelo()
        {
            idUsuario = 0;
            nome = ""; 
            cpf = "";
            contato = "";
            senha = "";
            dtnasc = "";
        }

        public int CodUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }

        }
        public string NomeUser
        {
            get { return nome; }
            set { nome = value; }

        }
        public string CpfUser
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string ContatoUser
        {
            get { return contato; }
            set { contato = value; }
        }
        public string NascimentoUser
        {
            get { return dtnasc; }
            set { dtnasc = value; }
        }
        public string SenhaUser
        {
            get { return senha; }
            set { senha = value; }

        }
        public int CodCargo
        {
            get { return CodCargo; }
            set { CodCargo = value; } 
            
        }

    }
}
