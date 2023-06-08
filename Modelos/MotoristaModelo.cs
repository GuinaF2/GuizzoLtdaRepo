using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class MotoristaModelo
    {
        private int idMotorista;
        private int idVeiculo;
        private string nome;
        private string cpf;
        private string registrogeral;
        private string carteiramotorista;
        private string tipocarteira;

        public MotoristaModelo()
        {
            idMotorista = 0;
            idVeiculo= 0;
            nome = "";
            cpf = "";
            registrogeral = "";
            carteiramotorista = "";
            tipocarteira = "";
        }

        public int CodMotorista
        {
            get { return idMotorista; }
            set { idMotorista = value; }

        }
        public int CodVeiculo
        {
            get { return idVeiculo; }
            set { idVeiculo = value; }

        }
        public string nomeMotorista
        {
            get { return nome; }
            set { nome = value; }

        }
        public string cpfMotorista
        {
            get { return cpf; }
            set { cpf = value; }

        }
        public string RgMotorista
        {
            get { return registrogeral; }
            set { registrogeral = value; }

        }
        public string CnhMotorista
        {
            get { return carteiramotorista; }
            set { carteiramotorista = value; }
        }
        public string TipoCnhMotorista
        {
            get { return tipocarteira; }
            set { tipocarteira = value; }
        }
    }
}
