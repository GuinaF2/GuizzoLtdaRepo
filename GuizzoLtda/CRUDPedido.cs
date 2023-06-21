using Controle;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuizzoLtda
{
    public partial class CRUDPedido : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        Conexao conexaosql = new Conexao();
        PedidoModelo PedidoModelo = new PedidoModelo();
        PedidoControle Controle = new PedidoControle();
        int id;
        public CRUDPedido(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void CRUDPedido_Load(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);

            dgPedido.DataSource = conexaosql.verDados("SELECT * FROM tb_pedido");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdPedido.Visible = true;
            txtIdCliente.Visible = true;
            txtIdMoto.Visible = true;
            txtVolume.Visible = true;
            txtDataPed.Visible = true;
            txtTipoPedido.Visible = true;

            labelidpedido.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            dgPedido.Visible = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = true;

            txtIdPedido.Visible = true;
            txtIdCliente.Visible = true;
            txtIdMoto.Visible = true;
            txtVolume.Visible = true;
            txtDataPed.Visible = true;
            txtTipoPedido.Visible = true;

            labelidpedido.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            dgPedido.Visible = false;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;
            SaveCreate.Visible = false;

            txtIdPedido.Visible = true;
            txtIdCliente.Visible = true;
            txtIdMoto.Visible = true;
            txtVolume.Visible = true;
            txtDataPed.Visible = true;
            txtTipoPedido.Visible = true;

            labelidpedido.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;

            dgPedido.Visible = true;
        }
    }
}
