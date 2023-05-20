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


        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaAdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginAdmin_Click_1(object sender, EventArgs e)
        {
            UsuarioModelo.NomeUser = txtUserAdm.Text;

            UsuarioModelo.SenhaUser = txtSenhaAdm.Text;



            if (txtUserAdm.Text == "" || txtSenhaAdm.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");

                AdminLogin fadmlogin = new AdminLogin();
                fadmlogin.Show();
                Hide();
            }
            else
            {
                if (Controle.LogarAdm(UsuarioModelo) >= 1)
                {
                    AdminMenu fmenuadm = new AdminMenu();
                    this.Hide();
                    fmenuadm.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha não encontrados");
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Principal fprincipalreturn = new Principal();
            this.Hide();
            fprincipalreturn.Show();
        }

        private void AdminLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
