using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EmpresaModelo
    {
        private int idcliente;
        private string cnpj;
        private int idendereco;
        private string razao_social;
        private string inscricao_estadual;
        private string statuscadastro;
        private string logo;
        public EmpresaModelo() 
        {
            idcliente = 0;
            cnpj = "";
            idendereco = 0;
            razao_social = "";
            inscricao_estadual = "";
            statuscadastro = "";

            logo = "";
        }
        public int CodCliente
        {
            get { return idcliente; }
            set { idcliente = value; }

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
        public int CodEndereco
        {
            get { return idendereco; }
            set { idendereco = value; }

        }
        public string LogoEmpresa
        {
            get { return logo; }
            set { logo = value; }

        }
        public string StatusCadastro
        {
            get { return statuscadastro; }
            set { statuscadastro = value; }

        }
    }
}
