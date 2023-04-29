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
        public AdministradorCRUD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            UsuarioModelo.NomeUser = txtID.Text;
            UsuarioModelo.SenhaUser = txtSenha.Text;

            if (txtID.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Erro no cadastro.");
            }
            else
            {
                if (Controle.cadastrar(UsuarioModelo) >= 1)
                {
                    MessageBox.Show("Usuário Cadastrado.");
                    AdministradorCRUD fadmin = new AdministradorCRUD();
                    this.Hide();
                    fadmin.Show();
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DataGridUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (id <= 0)
                {
                    MessageBox.Show("Favor selecionar ID do usuário");
                }

                else
                {
                    UsuarioModelo = Controle.CarregaUsuario(id);

                    txtID.Text = id.ToString();
                    txtID.Text = UsuarioModelo.NomeUser;
                    txtSenha.Text = UsuarioModelo.SenhaUser;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID do usuário. \n\nERRO: " + ex.Message);
            }
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            UsuarioModelo.CodUsuario = Convert.ToInt32(txtID.Text);
            UsuarioModelo.NomeUser = txtNome.Text;
            UsuarioModelo.SenhaUser = txtSenha.Text;

            if (Controle.AtualizarUsuario(UsuarioModelo) == true)
            {
                MessageBox.Show("Cadastro Atualizado.");
                AdministradorCRUD fadmin = new AdministradorCRUD();
                this.Hide();
                fadmin.Show();
            }
            else
            {
                MessageBox.Show("Erro na atualização.");
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


            AdministradorCRUD fadmin = new AdministradorCRUD();
            this.Hide();
            fadmin.Show();
        }

        private void AdminCadLog_Load(object sender, EventArgs e)
        {
            DataGridUsuario.DataSource = conexaosql.verDados("SELECT * FROM tb_funcionario");
        }
    }
}
