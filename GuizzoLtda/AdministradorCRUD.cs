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
    public partial class AdministradorCRUD : Form
    {
        Conexao conexaosql = new Conexao();
        UsuarioModelo UsuarioModelo = new UsuarioModelo();
        UsuarioControle Controle = new UsuarioControle();
        int id;
        public AdministradorCRUD()
        {
            InitializeComponent();
        }

        private void AdministradorCRUD_Load_1(object sender, EventArgs e)
        {
            dataGridCRUD.DataSource = conexaosql.verDados("SELECT * FROM tb_funcionario");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtID.Visible = false;
            txtNome.Visible= false;
            txtSenha.Visible = false;
            cbCargo.Visible = false;

            labelcargo.Visible = false;
            labelid.Visible = false;
            labelnome.Visible = false;
            labelsenha.Visible = false;

        }


        private void dataGridCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void SaveCreate_Click(object sender, EventArgs e)
        {
            UsuarioModelo.NomeUser = txtID.Text;
            UsuarioModelo.SenhaUser = txtSenha.Text;

            if (txtID.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Erro no cadastro.");
            }
            else
            {
                if (Controle.Cadastrar(UsuarioModelo) >= 1)
                {
                    MessageBox.Show("Usuário Cadastrado.");
                    AdministradorCRUD fadmincrud = new AdministradorCRUD();
                    this.Hide();
                    fadmincrud.Show();
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
        }

        private void SaveDelete_Click(object sender, EventArgs e)
        {
            UsuarioModelo.CodUsuario = Convert.ToInt32(txtID.Text);
            var resposta = DialogResult;
            resposta = MessageBox.Show("Tem certeza que deseja deletar o usuário?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (Controle.DeletarUsuario(UsuarioModelo) == true)
                {
                    MessageBox.Show("Usuário deletado.");
                }
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Processo cancelado.");
            }
            AdministradorCRUD fadmincrud = new AdministradorCRUD();
            this.Hide();
            fadmincrud.Show();
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            UsuarioModelo.CodUsuario = Convert.ToInt32(txtID.Text);
            UsuarioModelo.NomeUser = txtNome.Text;
            UsuarioModelo.SenhaUser = txtSenha.Text;
            UsuarioModelo.CodCargo = Convert.ToInt32(cbCargo.Text);

            if (Controle.AtualizarUsuario(UsuarioModelo) == true)
            {
                MessageBox.Show("Cadastro Atualizado.");

                AdministradorCRUD fadmincrud = new AdministradorCRUD();
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

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu();
            this.Hide();
            fmenureturn.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtID.Visible = true;
            txtNome.Visible = true;
            txtSenha.Visible = true;
            cbCargo.Visible = true;

            labelcargo.Visible = true;
            labelid.Visible = true;
            labelnome.Visible = true;
            labelsenha.Visible = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = true;

            txtID.Visible = true;
            txtNome.Visible = true;
            txtSenha.Visible = true;
            cbCargo.Visible = false;

            labelcargo.Visible = false;
            labelid.Visible = true;
            labelnome.Visible = true;
            labelsenha.Visible = true;
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            SaveCreate.Visible = false;
            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;
        }

        private void dataGridCRUD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dataGridCRUD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridCRUD.CurrentRow.Selected = true;

                    txtID.Text = dataGridCRUD.Rows[e.RowIndex].Cells["idfuncionario"].Value.ToString();
                    txtNome.Text = dataGridCRUD.Rows[e.RowIndex].Cells["NomeUser"].Value.ToString();
                    txtSenha.Text = dataGridCRUD.Rows[e.RowIndex].Cells["SenhaUser"].Value.ToString();
                    cbCargo.Text = dataGridCRUD.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
                }

                else
                {
                    MessageBox.Show("Favor selecionar ID do usuário");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do usuário. \n\nERRO: " + ex.Message);
            }
        }
    }
}
