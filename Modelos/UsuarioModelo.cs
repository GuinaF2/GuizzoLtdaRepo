namespace Modelos
{
    public class UsuarioModelo
    {
        //criação das variaveis protegidas
        private int idUsuario;
        private int cargo;
        private string nome;
        private string cpf;
        private string contato;
        private string dtnasc;
        private string senha;

        private int idEndereco;
        private string rua;
        private string bairro;
        private string cep;
        private string numero;
        private string complemento;

        private string cnpj;
        private string razao_social;
        private string inscricao_estadual;

        //defino o construtor modelo usuario

        public UsuarioModelo()
        {
            idUsuario = 0;
            cargo = 0;
            nome = ""; 
            cpf = "";
            contato = "";
            senha = "";
            dtnasc = "";

            idEndereco = 0;
            rua = "";
            bairro = "";
            cep = "";
            numero = "";
            complemento = "";

            cnpj = "";
            razao_social = "";
            inscricao_estadual = "";
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
            get { return cargo; }
            set { cargo = value; } 
            
        }

        public int CodEndereco
        {
            get { return idEndereco; }
            set { idEndereco = value; }

        }
        public string RuaUser
        {
            get { return rua; }
            set { rua = value; }

        }
        public string BairroUser
        {
            get { return bairro; }
            set { bairro = value; }

        }
        public string CepUser
        {
            get { return cep; }
            set { cep = value; }

        }

        public string NmrUser
        {
            get { return numero; }
            set { numero = value; }

        }
        public string CompUser
        {
            get { return complemento; }
            set { complemento = value; }

        }
        public string CnpjUser
        {
            get { return cnpj; }
            set { cnpj = value; }

        }
        public string RazaoSocialUser
        {
            get { return razao_social; }
            set { razao_social = value; }

        }
        public string InscEstadUser
        {
            get { return inscricao_estadual; }
            set { inscricao_estadual = value; }

        }


    }
}
