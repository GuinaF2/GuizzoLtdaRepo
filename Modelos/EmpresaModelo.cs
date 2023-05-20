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
        private string cnpj;
        private int idendereco;
        private string razao_social;
        private string inscricao_estadual;
        private string logo;
        public EmpresaModelo() 
        {
            cnpj = "";
            idendereco = 0;
            razao_social = "";
            inscricao_estadual = "";
            logo = "";
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
    }
}
