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
    public partial class AdminLogin : Form
    {
        Conexao conexaosql = new Conexao();
        UsuarioModelo UsuarioModelo = new UsuarioModelo();
        UsuarioControle Controle = new UsuarioControle();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            UsuarioModelo.NomeUser = txtUserAdm.Text;

            UsuarioModelo.SenhaUser = txtSenhaAdm.Text;



            if (txtUserAdm.Text == "" || txtSenhaAdm.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");

                AdministradorCRUD fadmcrud = new AdministradorCRUD();
                fadmcrud.Show();
                Hide();
            }
            else
            {
                if (Controle.logar(UsuarioModelo) >= 1)
                {
                    AdministradorCRUD fadmincrud = new AdministradorCRUD();
                    this.Hide();
                    fadmincrud.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha não encontrados");
                }
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
