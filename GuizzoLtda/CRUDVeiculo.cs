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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuizzoLtda
{
    public partial class CRUDVeiculo : Form
    {
        Conexao conexaosql = new Conexao();
        VeiculoModelo VeiculoModelo = new VeiculoModelo();
        VeiculoControle Controle = new VeiculoControle();
        int id;
        public CRUDVeiculo()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdVeic.Visible = true;
            txtPlaca.Visible = true;
            cbTipo.Visible = true;
            dataSeguro.Visible = true;
            txtRenavam.Visible = true;

            labelrenavam.Visible = true;
            labelIdVeic.Visible = true;
            labelplaca.Visible = true;
            labeltipo.Visible = true;
            labelseguro.Visible = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = true;

            txtIdVeic.Visible = true;
            txtPlaca.Visible = true;
            cbTipo.Visible = true;
            dataSeguro.Visible = true;
            txtRenavam.Visible = true;

            labelrenavam.Visible = true;
            labelIdVeic.Visible = true;
            labelplaca.Visible = true;
            labeltipo.Visible = true;
            labelseguro.Visible = true;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;
            SaveCreate.Visible = false;

            txtIdVeic.Visible = true;
            txtPlaca.Visible = true;
            cbTipo.Visible = true;
            dataSeguro.Visible = true;
            txtRenavam.Visible = true;

            labelrenavam.Visible = true;
            labelIdVeic.Visible = true;
            labelplaca.Visible = true;
            labeltipo.Visible = true;
            labelseguro.Visible = true;
        }

        private void CRUDVeiculo_Load(object sender, EventArgs e)
        {
            dataGridVeiculo.DataSource = conexaosql.verDados("SELECT * FROM tb_veiculo");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdVeic.Visible = false;
            txtPlaca.Visible = false;
            cbTipo.Visible = false;
            dataSeguro.Visible = false;
            txtRenavam.Visible = false;

            labelrenavam.Visible = false;
            labelIdVeic.Visible = false;
            labelseguro.Visible = false;
            labelplaca.Visible = false;
            labeltipo.Visible = false;
        }

        private void SaveDelete_Click(object sender, EventArgs e)
        {
            VeiculoModelo.CodVeiculo = Convert.ToInt32(txtIdVeic.Text);
            var resposta = DialogResult;
            resposta = MessageBox.Show("Tem certeza que deseja deletar o Veiculo?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (Controle.DeletarVeiculo(VeiculoModelo) == true)
                {
                    MessageBox.Show("Veiculo deletado.");
                }
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Processo cancelado.");
            }

        }

        private void SaveCreate_Click(object sender, EventArgs e)
        {
            VeiculoModelo.PlacaVeiculo = txtPlaca.Text;
            VeiculoModelo.TipoVeiculo = cbTipo.Text;
            VeiculoModelo.SeguroVeiculo = dataSeguro.Text;
            VeiculoModelo.RenavamVeiculo = txtRenavam.Text;

            if (dataSeguro.Text == "" || txtPlaca.Text == "" || cbTipo.Text == "" || txtRenavam.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!");
            }
            else
            {
                if (Controle.CadastrarVeiculo(VeiculoModelo) >= 1)
                {
                    MessageBox.Show("Veiculo Cadastrado Com Sucesso!");
                    CRUDVeiculo fveiculocrud = new CRUDVeiculo();
                    this.Hide();
                    fveiculocrud.Show();
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            VeiculoModelo.CodVeiculo = Convert.ToInt32(txtIdVeic.Text);
            VeiculoModelo.PlacaVeiculo = txtPlaca.Text;
            VeiculoModelo.TipoVeiculo = cbTipo.Text;
            VeiculoModelo.SeguroVeiculo = dataSeguro.Text;
            VeiculoModelo.RenavamVeiculo = txtRenavam.Text;

            if (Controle.AtualizarVeiculo(VeiculoModelo) == true)
            {
                MessageBox.Show("Cadastro Atualizado.");

                CRUDVeiculo fveiculocrud = new CRUDVeiculo();
                this.Hide();
                fveiculocrud.Show();
            }
            else
            {
                MessageBox.Show("Erro na atualização.");
            }
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void dataGridVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridVeiculo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridVeiculo.CurrentRow.Selected = true;

                    txtIdVeic.Text = dataGridVeiculo.Rows[e.RowIndex].Cells["idveiculo"].Value.ToString();
                    txtPlaca.Text = dataGridVeiculo.Rows[e.RowIndex].Cells["placa_motorista"].Value.ToString();
                    cbTipo.Text = dataGridVeiculo.Rows[e.RowIndex].Cells["tipo_veiculo"].Value.ToString();
                    dataSeguro.Text = dataGridVeiculo.Rows[e.RowIndex].Cells["seguro_data"].Value.ToString();
                    txtRenavam.Text = dataGridVeiculo.Rows[e.RowIndex].Cells["renavam"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("Favor selecionar ID do Veiculo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do Veiculo. \n\nERRO: " + ex.Message);
            }
        }

        private void dataGridVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataSeguro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void dataSeguro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataSeguro.MaxLength = 8;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dataSeguro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataSeguro_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            dataSeguro.MaxLength = 8;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
