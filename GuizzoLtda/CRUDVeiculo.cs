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

            txtPlaca.Visible = true;
            txtRota.Visible = true;
            txtTipo.Visible = true;
            dataSeguro.Visible = true;

            labelplaca.Visible = true;
            labelrota.Visible = true;
            labeltipo.Visible = true;
            labelseguro.Visible = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = true;

            txtPlaca.Visible = true;
            txtRota.Visible = true;
            txtTipo.Visible = true;
            dataSeguro.Visible = true;

            labelplaca.Visible = true;
            labelrota.Visible = true;
            labeltipo.Visible = true;
            labelseguro.Visible = true;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;
            SaveCreate.Visible = false;

            txtPlaca.Visible = true;
            txtRota.Visible = true;
            txtTipo.Visible = true;
            dataSeguro.Visible = true;

            labelplaca.Visible = true;
            labelrota.Visible = true;
            labeltipo.Visible = true;
            labelseguro.Visible = true;
        }

        private void CRUDVeiculo_Load(object sender, EventArgs e)
        {
            dataGridVeiculo.DataSource = conexaosql.verDados("SELECT * FROM tb_veiculo");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtPlaca.Visible = false;
            txtTipo.Visible = false;
            txtRota.Visible = false;
            dataSeguro.Visible = false;

            labelseguro.Visible = false;
            labelplaca.Visible = false;
            labeltipo.Visible = false;
            labelrota.Visible = false;
        }

        private void SaveDelete_Click(object sender, EventArgs e)
        {
            VeiculoModelo.CodVeiculo = Convert.ToInt32(txtIdVeic.Text);
            var resposta = DialogResult;
            resposta = MessageBox.Show("Tem certeza que deseja deletar o usuário?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (Controle.DeletarUsuario(VeiculoModelo) == true)
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
            VeiculoModelo.PlacaVeiculo = txtPlaca.Text;
            VeiculoModelo.TipoVeiculo = txtTipo.Text;
            VeiculoModelo.SeguroVeiculo = dataSeguro.Text;

            if (dataSeguro.Text == "" || txtPlaca.Text == "" || txtTipo.Text == "") 
            {
                MessageBox.Show("Erro no cadastro.");
            }
            else
            {
                if (Controle.CadastrarVeiculo(VeiculoModelo) >= 1)
                {
                    MessageBox.Show("Usuário Cadastrado.");
                    CRUDUser fadmincrud = new CRUDUser();
                    this.Hide();
                    fadmincrud.Show();
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
            VeiculoModelo.TipoVeiculo = txtTipo.Text;
            VeiculoModelo.RotaVeiculo = txtRota.Text;

            if (Controle.AtualizarUsuario(VeiculoModelo) == true)
            {
                MessageBox.Show("Cadastro Atualizado.");

                CRUDUser fadmincrud = new CRUDUser();
                this.Hide();
                fadmincrud.Show();
            }
            else
            {
                MessageBox.Show("Erro na atualização.");
            }
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
