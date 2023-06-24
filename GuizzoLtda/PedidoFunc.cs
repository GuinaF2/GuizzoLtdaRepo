using Controle;
using Modelos;
using MySql.Data.MySqlClient;
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
    public partial class PedidoFunc : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        Conexao conexaosql = new Conexao();
        PedidoModelo PedidoModelo = new PedidoModelo();
        PedidoControle Controle = new PedidoControle();
        public PedidoFunc(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void cbAberto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAberto.Checked)
            {
                cbEncerrado.Checked = false;
            }
        }

        private void cbEncerrado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEncerrado.Checked)
            {
                cbAberto.Checked = false;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (cbAberto.Checked)
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT `idpedido`, `statuspedido`, `nmrvolumes`, `valorpedido` FROM `tb_pedido` WHERE `dtpedido` BETWEEN @d1 AND @d2 AND statuspedido='PENDENTE'", con);

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = dtPedido.Value;
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = dtPedido2.Value;

                dtgPedido.Visible = true;
                labelDtPedido.Visible = false;
                cbAberto.Visible = false;
                cbEncerrado.Visible = false;
                btnConfirma.Visible = false;
            }
            if (cbEncerrado.Checked)
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT `idpedido`, `statuspedido`, `nmrvolumes`, `valorpedido` FROM `tb_pedido` WHERE `dtpedido` BETWEEN @d1 AND @d2 AND statuspedido='PENDENTE'", con);

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = dtPedido.Value;
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = dtPedido2.Value;

                dtgPedido.Visible = true;
                labelDtPedido.Visible = false;
                cbAberto.Visible = false;
                cbEncerrado.Visible = false;
                btnConfirma.Visible = false;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PedidoFunc_Load(object sender, EventArgs e)
        {
            dtgPedido.DataSource = conexaosql.verDados("SELECT * FROM tb_pedido");
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenufunc = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenufunc.Show();
        }
    }
}
