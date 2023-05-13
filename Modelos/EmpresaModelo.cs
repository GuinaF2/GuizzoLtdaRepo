using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EmpresaModelo
    {
        private string cnpj;
        private string razao_social;
        private string inscricao_estadual;
        public EmpresaModelo() 
        {
            cnpj = "";
            razao_social = "";
            inscricao_estadual = "";
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
