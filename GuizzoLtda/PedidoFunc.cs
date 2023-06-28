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
            if (cbAberto.Checked == true)
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT `idpedido`,'idcliente', `statuspedido`, `nmrvolumes`, `valorpedido` FROM `tb_pedido` WHERE `dtpedido` BETWEEN @d1 AND @d2 and statuspedido = 'Pendente'", con);

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = dateTimePicker2.Value;

                DataTable SearchDataTable = new DataTable();
                using (MySqlDataAdapter adaptor = new MySqlDataAdapter(command))
                {
                    adaptor.Fill(SearchDataTable);
                }
                dtgPedido.DataSource = SearchDataTable;


                dtgPedido.Visible = true;
                button1.Visible = true;

                btnVoltar.Enabled = true;
                dateTimePicker2.Visible = false;
                dateTimePicker1.Visible = false;
                label1.Visible = false;
                labelDtPedido.Visible = false;
                cbAberto.Visible = false;
                cbEncerrado.Visible = false;
                btnConfirma.Visible = false;
            }
            if (cbEncerrado.Checked == true)
            {
                conexaosql = new Conexao();
                MySqlConnection con = conexaosql.getConexao();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT `idpedido`, `dtpedido`, `idcliente`, `statuspedido`,`nmrvolumes`,`valorpedido` FROM `tb_pedido` WHERE `dtpedido` BETWEEN @d1 AND @d2 AND statuspedido='Aprovada'", con);
                command.Parameters.Add("@d1", MySqlDbType.Date).Value = dateTimePicker1.Text;
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = dateTimePicker2.Text;

                DataTable SearchDataTable = new DataTable();
                using (MySqlDataAdapter adaptor = new MySqlDataAdapter(command))
                {
                    adaptor.Fill(SearchDataTable);
                }
                dtgPedido.DataSource = SearchDataTable;

                dtgPedido.Visible = true;
                button1.Visible = true;

                button1.Visible = false;
                btnVoltar.Enabled = true;
                dateTimePicker2.Visible = false;
                dateTimePicker1.Visible = false;
                label1.Visible = false;
                labelDtPedido.Visible = false;
                cbAberto.Visible = false;
                cbEncerrado.Visible = false;
                btnConfirma.Visible = false;
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
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
            us = usu.CarregaEmpresa(idcliente);
            dtgPedido.DataSource = conexaosql.verDados("SELECT * FROM tb_pedido");
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenufunc = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenufunc.Show();
        }

        private void dtgPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgPedido.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dtgPedido.CurrentRow.Selected = true;

                    txtIdPedido.Text = dtgPedido.Rows[e.RowIndex].Cells["idpedido"].Value.ToString();
                    txtIdCliente.Text = dtgPedido.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
                    txtNmrVolumes.Text = dtgPedido.Rows[e.RowIndex].Cells["nmrvolumes"].Value.ToString();
                    txtStatusPedido.Text = dtgPedido.Rows[e.RowIndex].Cells["statuspedido"].Value.ToString();
                    txtValorPedido.Text = dtgPedido.Rows[e.RowIndex].Cells["valorpedido"].Value.ToString();
                    txtDtPedido.Text = dtgPedido.Rows[e.RowIndex].Cells["dtpedido"].Value.ToString();


                }
                else
                {
                    MessageBox.Show("Favor selecionar ID da Requisição");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID da Solicitação. \n\nERRO\t\t: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtValorPedido.Text == "" || txtStatusPedido.Text == "" || txtNmrVolumes.Text == "" || txtIdPedido.Text == "")
            {
                MessageBox.Show("Favor selecionar um pedido.");
            }
            else
            {
                PedidoModelo.CodPedido = Convert.ToInt32(txtIdPedido.Text);
                PedidoModelo.PedidoStatus = "Aprovada";

                if (Controle.AprovarPedido(PedidoModelo) == true)
                {
                    MessageBox.Show("Pedido Aprovado.");
                    PedidoFunc fadminsol = new PedidoFunc(us, idcliente);
                    this.Hide();
                    fadminsol.Show();
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {


            dtgPedido.Visible = false;
            button1.Visible = false;
            btnVoltar.Enabled = false;

            dateTimePicker2.Visible = true;
            dateTimePicker1.Visible = true;
            label1.Visible = true;
            labelDtPedido.Visible = true;
            cbAberto.Visible = true;
            cbEncerrado.Visible = true;
            btnConfirma.Visible = true;
        }

        private void dtgPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
