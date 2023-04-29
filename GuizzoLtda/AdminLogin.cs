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

                FuncionarioCadLog ffunccadreturn = new FuncionarioCadLog();
                ffunccadreturn.Show();
                Hide();
            }
            else
            {
                if (Controle.logar(UsuarioModelo) >= 1)
                {
                    MessageBox.Show("Usuario Encontrado!");
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha não encontrados");
                }
            }
        }
    }
}
