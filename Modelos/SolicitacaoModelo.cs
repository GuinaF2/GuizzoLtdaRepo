using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class SolicitacaoModelo
    {
        private int idSolicitacao;
        private int idFuncionario;
        private string tipo_solicit;
        private string descricao;
        private string status;
        private string nomeuser;

        public SolicitacaoModelo()
        {
            idSolicitacao = 0;
            idFuncionario = 0;
            tipo_solicit = "";
            descricao = "";
            status = "";
            nomeuser = "";
        }
        public int CodSolicitacao
        {
            get { return idSolicitacao; }
            set { idSolicitacao = value; }
        }
        public int CodFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }
        public string TipoSolicitacao
        {
            get { return tipo_solicit; }
            set { tipo_solicit = value; }
        }
        public string NomeUser
        {
            get { return nomeuser; }
            set { nomeuser = value; }
        }
        public string DescSolicitacao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public string StatusSolicitacao
        {
            get { return status; }
            set { status= value; }
        }
    }
}

