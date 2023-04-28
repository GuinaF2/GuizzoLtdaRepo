﻿using Modelos;
using Controle;
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
        UsuarioModelo UsuarioModelo = new UsuarioModelo();
        UsuarioControle Controle = new UsuarioControle();
        public FuncionarioCadLog()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginFunc_Click(object sender, EventArgs e)
        {
            UsuarioModelo.NomeUser = txtLogin.Text;
            UsuarioModelo.ContatoUser = txtContato.Text;
            UsuarioModelo.CpfUser = txtCpf.Text;
            UsuarioModelo.NascimentoUser = NascimentoDt.Text;
            UsuarioModelo.SenhaUser = txtSenha.Text;

            if (txtLogin.Text == "" || txtCpf.Text == "" || txtContato.Text == "" || NascimentoDt.Text == "")
            {
                MessageBox.Show("Erro no cadastro.");

                FuncionarioCadLog ffunccadreturn = new FuncionarioCadLog();
                ffunccadreturn.Show();
                Hide();
            }
            else
            {
                if (Controle.cadastrar(UsuarioModelo) >= 1)
                {
                    MessageBox.Show("Cadastro com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Principal fprincipalreturn = new Principal();
            this.Hide();
            fprincipalreturn.Show();
        }
    }
}
