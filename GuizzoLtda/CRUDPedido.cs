﻿using Controle;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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

            var data = DateTime.Today;
            dtPedido.Text = data.ToString(@"yyyy-MM-dd");
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void CRUDPedido_Load_1(object sender, EventArgs e)
        {
            txtTipoPedido.Visible = false;
            txtVolume.Visible = false;
            txtIdPedido.Visible = false;
            txtIdMoto.Visible = false;
            txtIdCliente.Visible = false;

            label2.Visible = false;
            label3.Visible = false;
            dtPedido.Visible = false;
            labelidpedido.Visible = false;
            label4.Visible = false;
            label1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;



            us = usu.CarregaEmpresa(idcliente);

            dgPedido.DataSource = conexaosql.verDados("SELECT * FROM tb_pedido");
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            txtIdPedido.Text = String.Empty;
            txtIdCliente.Text = String.Empty;
            txtIdMoto.Text = String.Empty;
            txtVolume.Text = String.Empty;
            txtTipoPedido.Text = String.Empty;
            dtPedido.Text = String.Empty;

            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdPedido.Visible = true;
            txtIdCliente.Visible = true;
            txtIdMoto.Visible = true;
            txtVolume.Visible = true;
            dtPedido.Visible = true;
            txtTipoPedido.Visible = true;


            labelidpedido.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label1.Visible = true;

            dgPedido.Visible = true;

            txtTipoPedido.Enabled = true;
            txtIdMoto.Enabled = true;
            txtIdCliente.Enabled = true;
            txtTipoPedido.Enabled = true;
            dtPedido.Enabled = true;
            txtVolume.Enabled = true;
        }

        private void btnCad_Click_1(object sender, EventArgs e)
        {
            txtIdPedido.Text = String.Empty;
            txtIdCliente.Text = String.Empty;
            txtIdMoto.Text = String.Empty;
            txtVolume.Text = String.Empty;
            txtTipoPedido.Text = String.Empty;
            dtPedido.Text = String.Empty;


            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = true;

            txtIdPedido.Visible = true;
            txtIdCliente.Visible = true;
            txtIdMoto.Visible = true;
            txtVolume.Visible = true;
            dtPedido.Visible = true;
            txtTipoPedido.Visible = true;


            labelidpedido.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label1.Visible = true;

            dgPedido.Visible = false;

            txtTipoPedido.Enabled = true;
            txtIdMoto.Enabled = true;
            txtIdCliente.Enabled = true;
            txtTipoPedido.Enabled = true;
            dtPedido.Enabled = true;
            txtVolume.Enabled = true;
        }

        private void btnApaga_Click_1(object sender, EventArgs e)
        {
            txtIdPedido.Text = String.Empty;
            txtIdCliente.Text = String.Empty;
            txtIdMoto.Text = String.Empty;
            txtVolume.Text = String.Empty;
            txtTipoPedido.Text = String.Empty;
            dtPedido.Text = String.Empty;


            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;
            SaveCreate.Visible = false;

            txtIdPedido.Visible = true;
            txtIdCliente.Visible = true;
            txtIdMoto.Visible = true;
            txtVolume.Visible = true;
            dtPedido.Visible = true;
            txtTipoPedido.Visible = true;

            txtTipoPedido.Enabled = false;
            txtIdMoto.Enabled = false;
            txtIdCliente.Enabled = false;
            txtTipoPedido.Enabled = false;
            dtPedido.Enabled = false;
            txtVolume.Enabled = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            labelidpedido.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;

            dgPedido.Visible = true;
        }

        private void SaveCreate_Click_1(object sender, EventArgs e)
        {





            if (txtIdCliente.Text == "" || txtIdMoto.Text == "" || dtPedido.Text == "" || txtVolume.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos");
            }
            else
            {
                if (Controle.CadastrarPedido(PedidoModelo) >= 1)
                {
                    PedidoModelo.CodCliente = Convert.ToInt32(txtIdCliente.Text);
                    PedidoModelo.CodMotorista = Convert.ToInt32(txtIdMoto.Text);
                    PedidoModelo.PedidoData = dtPedido.Text;
                    PedidoModelo.PedidoVolumes = txtVolume.Text;
                    MessageBox.Show("Pedido Cadastrado Com Sucesso!");
                    CRUDPedido fpedidocrud = new CRUDPedido(us, idcliente);
                    this.Hide();
                    fpedidocrud.Show();
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
        }

        private void SaveDelete_Click_1(object sender, EventArgs e)
        {
            if (txtIdPedido.Text == "")
            {
                MessageBox.Show("Selecione o Id do Pedido");
                txtVolume.Text = String.Empty;
                txtTipoPedido.Text = String.Empty;
                txtIdMoto.Text = String.Empty;
                dtPedido.Text = String.Empty;
                txtIdPedido.Text = String.Empty;


            }
            else
            {
                PedidoModelo.CodPedido = Convert.ToInt32(txtIdPedido.Text);
                var resposta = DialogResult;
                resposta = MessageBox.Show("Tem certeza que deseja deletar o Pedido?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta == DialogResult.Yes)
                {
                    if (Controle.DeletarPedido(PedidoModelo) == true)
                    {
                        MessageBox.Show("Pedido deletado.");
                    }
                    CRUDPedido fpedidocrud = new CRUDPedido(us, idcliente);
                    this.Hide();
                    fpedidocrud.Show();
                }
                else if (resposta == DialogResult.No)
                {
                    MessageBox.Show("Processo cancelado.");
                }
            }

        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtIdMoto_Click_1(object sender, EventArgs e)
        {
            SelecionarMoto cselectmoto = new SelecionarMoto(us, idcliente);
            cselectmoto.ShowDialog();

            if (cselectmoto.DialogResult == DialogResult.OK)
            {
                txtIdMoto.Text = cselectmoto.idmoto.ToString();
            }
            else
            {
                MessageBox.Show("Erro. Verifique se selecionou um Veiculo corretamente.");
            }
        }

        private void txtIdCliente_Click_1(object sender, EventArgs e)
        {
            SelecionarCliente cselectemp = new SelecionarCliente();
            cselectemp.ShowDialog();

            if (cselectemp.DialogResult == DialogResult.OK)
            {
                txtIdCliente.Text = cselectemp.idemp.ToString();
            }
            else
            {
                MessageBox.Show("Erro. Verifique se selecionou um Veiculo corretamente.");
            }

        }

        private void txtIdMoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgPedido_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgPedido.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgPedido.CurrentRow.Selected = true;

                    txtIdPedido.Text = dgPedido.Rows[e.RowIndex].Cells["idpedido"].Value.ToString();
                    txtIdCliente.Text = dgPedido.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
                    txtIdMoto.Text = dgPedido.Rows[e.RowIndex].Cells["idmotorista"].Value.ToString();
                    dtPedido.Text = dgPedido.Rows[e.RowIndex].Cells["dtpedido"].Value.ToString();
                    txtVolume.Text = dgPedido.Rows[e.RowIndex].Cells["nmrvolumes"].Value.ToString();
                    txtTipoPedido.Text = dgPedido.Rows[e.RowIndex].Cells["statuspedido"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("Favor selecionar ID da Empresa");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do Pedido. \n\nERRO: " + ex.Message);
            }
        }

        private void SaveCreate_Click(object sender, EventArgs e)
        {

        }

        private void txtIdMoto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SaveUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTipoPedido.MaxLength = 50;
            //permite letras e espaços
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {//permite numeros sem espaço
            txtVolume.MaxLength = 4;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
