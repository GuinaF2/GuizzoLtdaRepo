namespace Modelos
{
    public class UsuarioModelo
    {
        //criação das variaveis protegidas
        private int idUsuario;
        private int cargo;
        private string nome;
        private string senha;

       

        //defino o construtor modelo usuario

        public UsuarioModelo()
        {
            idUsuario = 0;
            cargo = 0;
            nome = ""; 
            senha = "";            
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
        
        public string SenhaUser
        {
            get { return senha; }
            set { senha = value; }
        }
        public int CodCargo
        {
            get { return cargo; }
            set { cargo = value; } 
        }
    }
}
