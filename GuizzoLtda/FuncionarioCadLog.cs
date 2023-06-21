using Modelos;
using Controle;
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
    public partial class FuncionarioCadLog : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        UsuarioModelo UsuarioModelo = new UsuarioModelo();
        UsuarioControle Controle = new UsuarioControle();
        public FuncionarioCadLog()
        {

            InitializeComponent();
        }

        private void txtLogin_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLoginFunc_Click_1(object sender, EventArgs e)
        {
            UsuarioModelo.NomeUser = txtLogin.Text;

            UsuarioModelo.SenhaUser = txtSenha.Text;



            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");

                FuncionarioCadLog ffunccadreturn = new FuncionarioCadLog();
                ffunccadreturn.Show();
                Hide();
            }
            else
            {
                if (Controle.Login(UsuarioModelo) >= 1)
                {
                    FuncionarioMenu ffuncmenu = new FuncionarioMenu(us, idcliente);
                    this.Hide();
                    ffuncmenu.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha não encontrados");
                }
            }
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Principal fprincipalreturn = new Principal(us, idcliente);
            this.Hide();
            fprincipalreturn.Show();
        }
    }
}
