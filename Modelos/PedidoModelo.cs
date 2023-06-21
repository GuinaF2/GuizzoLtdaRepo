using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PedidoModelo
    {
        private int idPedido;
        private int idCliente;
        private int idMotorista;
        private string nmrvolumes;
        private string pedidovalor;
        private string statuspedido;
        private string datapedido;

        public PedidoModelo()
        {
            idPedido = 0;
            idMotorista = 0;
            idCliente = 0;
            nmrvolumes = "";
            pedidovalor = "";
            statuspedido = "";
            datapedido = "";
        }

        public int CodPedido
        {
            get { return idPedido; }
            set { idPedido = value; }

        }
        public int CodMotorista
        {
            get { return idMotorista; }
            set { idMotorista = value; }
        }
        public int CodCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string PedidoVolumes
        {
            get { return nmrvolumes; }
            set { nmrvolumes = value; }

        }
        public string PedidoData
        {
            get { return datapedido; }
            set { datapedido = value; }

        }
        public string PedidoStatus
        {
            get { return statuspedido; }
            set { statuspedido = value; }

        }
        public string ValorPedido
        {
            get { return pedidovalor; }
            set { pedidovalor = value; }
        }

    }
}
