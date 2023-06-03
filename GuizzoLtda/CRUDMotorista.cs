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
    public partial class CRUDMotorista : Form
    {
        Conexao conexaosql = new Conexao();
        MotoristaModelo MotoristaModelo = new MotoristaModelo();
        MotoristaControle Controle = new MotoristaControle();
        int id;
        public CRUDMotorista()
        {
            InitializeComponent();
        }

        private void SaveDelete_Click(object sender, EventArgs e)
        {
            MotoristaModelo.CodMotorista = Convert.ToInt32(txtIdMoto.Text);
            var resposta = DialogResult;
            resposta = MessageBox.Show("Tem certeza que deseja deletar o Motorista?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (Controle.DeletarMotorista(MotoristaModelo) == true)
                {
                    MessageBox.Show("Usuário deletado.");
                }
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Processo cancelado.");
            }
            CRUDVeiculo fadmincrud = new CRUDVeiculo();
            this.Hide();
            fadmincrud.Show();
        }

        private void SaveCreate_Click(object sender, EventArgs e)
        {
            MotoristaModelo.cpfMotorista = txtCpf.Text;
            MotoristaModelo.RgMotorista = txtRg.Text;
            MotoristaModelo.nomeMotorista=txtNome.Text;

            if (txtCpf.Text == "" || txtRg.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Erro no cadastro.");
            }
            else
            {
                if (Controle.CadastrarMotorista(MotoristaModelo) >= 1)
                {
                    MessageBox.Show("Motorista Cadastrado Com Sucesso!");
                    CRUDMotorista fmotoristacrud = new CRUDMotorista();
                    this.Hide();
                    fmotoristacrud.Show();
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            MotoristaModelo.CodVeiculo = Convert.ToInt32(txtIdMoto.Text);
            MotoristaModelo.cpfMotorista = txtCpf.Text;
            MotoristaModelo.RgMotorista = txtRg.Text;
            MotoristaModelo.nomeMotorista = txtNome.Text; 

            if (Controle.AtualizarMotorista(MotoristaModelo) == true)
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

        private void CRUDMotorista_Load(object sender, EventArgs e)
        {
            dataGridMotorista.DataSource = conexaosql.verDados("SELECT * FROM tb_motorista");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdMoto.Visible = false;
            txtIdVeiculo.Visible = false;
            txtNome.Visible = false;
            txtCpf.Visible = false;
            txtRg.Visible = false;

            labelIdMoto.Visible = false;
            labelIdVeiculo.Visible = false;
            labelcpf.Visible = false;
            labelNome.Visible = false;
            labelrg.Visible = false;
        }

        private void dataGridMotorista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridMotorista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridMotorista.CurrentRow.Selected = true;

                    txtIdMoto.Text = dataGridMotorista.Rows[e.RowIndex].Cells["idmotorista"].Value.ToString();
                    txtIdVeiculo.Text = dataGridMotorista.Rows[e.RowIndex].Cells["idveiculo"].Value.ToString();
                    txtCpf.Text = dataGridMotorista.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                    txtNome.Text = dataGridMotorista.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                    txtRg.Text = dataGridMotorista.Rows[e.RowIndex].Cells["registrogeral"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("Favor selecionar ID do Motorista");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do Motorista. \n\nERRO: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdVeiculo.Visible = true;
            txtIdMoto.Visible = true;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtRg.Visible = true;

            labelIdVeiculo.Visible = true;
            labelNome.Visible = true;
            labelIdMoto.Visible = true;
            labelcpf.Visible = true;
            labelrg.Visible = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = true;

            txtIdVeiculo.Visible = true;
            txtIdMoto.Visible = true;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtRg.Visible = true;

            labelNome.Visible = true;
            labelIdVeiculo.Visible = true;
            labelIdMoto.Visible = true;
            labelcpf.Visible = true;
            labelrg.Visible = true;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;
            SaveCreate.Visible = false;

            txtIdVeiculo.Visible = true;
            txtIdMoto.Visible = true;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtRg.Visible = true;

            labelNome.Visible = true;
            labelIdVeiculo.Visible = true;
            labelIdMoto.Visible = true;
            labelcpf.Visible = true;
            labelrg.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void txtIdVeiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridMotorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
