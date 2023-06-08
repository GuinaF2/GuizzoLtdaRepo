using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class VeiculoModelo
    {
        private int idVeiculo;
        private string placa_motorista;
        private string tipo_veiculo;
        private string seguro_data;
        private string renavam;


        public VeiculoModelo()
        {
            idVeiculo = 0;
            placa_motorista = "";
            tipo_veiculo = "";
            seguro_data="";
            renavam = "";
        }

        public int CodVeiculo
        {
            get { return idVeiculo; }
            set { idVeiculo = value; }
        }

        public string PlacaVeiculo
        {
            get { return placa_motorista; }
            set { placa_motorista = value; }
        }
        public string TipoVeiculo
        {
            get { return tipo_veiculo; }
            set { tipo_veiculo = value; }
        }
 
        public string SeguroVeiculo
        {
            get { return seguro_data; }
            set { seguro_data = value; }
        }
        public string RenavamVeiculo
        {
            get { return renavam; }
            set { renavam = value; }
        }
    }
}
