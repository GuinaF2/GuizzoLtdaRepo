
using Controle;
using Modelos;

﻿using System;


namespace GuizzoLtda
{
    public partial class CRUDEmpresa : Form
    {

        Conexao conexaosql = new Conexao();
        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();
        int id;

        public CRUDEmpresa()
        {
            InitializeComponent();
        }


        private void labelInscricao_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;

            txtIdCliente.Visible = true;
            txtCnpj.Visible = true;
            txtRazaoSocial.Visible = true;
            txtInscricaoEst.Visible = true;

            labelIdCliente.Visible = true;
            labelCnpj.Visible = true;
            labelRazaoSocial.Visible = true;
            labelInscricao.Visible = true;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;

            txtIdCliente.Visible = true;
            txtCnpj.Visible = true;
            txtRazaoSocial.Visible = true;
            txtInscricaoEst.Visible = true;

            labelIdCliente.Visible = true;
            labelCnpj.Visible = true;
            labelRazaoSocial.Visible = true;
            labelInscricao.Visible = true;
        }



        private void SaveDelete_Click(object sender, EventArgs e)
        {
            EmpresaModelo.CodCliente = Convert.ToInt32(txtIdCliente.Text);
            var resposta = DialogResult;
            resposta = MessageBox.Show("Tem certeza que deseja deletar o usuário?", "! Aviso !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                if (Controle.DeletarEmpresa(EmpresaModelo) == true)
                {
                    MessageBox.Show("Usuário deletado.");
                }
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Processo cancelado.");
            }
            CRUDUser fadmincrud = new CRUDUser();
            this.Hide();
            fadmincrud.Show();
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CRUDEmpresa_Load(object sender, EventArgs e)
        {
            dataGridEmpresa.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;


            txtIdCliente.Visible = false;
            txtCnpj.Visible = false;
            txtRazaoSocial.Visible = false;
            txtInscricaoEst.Visible = false;

            labelIdCliente.Visible = false;
            labelCnpj.Visible = false;
            labelRazaoSocial.Visible = false;
            labelInscricao.Visible = false;
        }

    }
}
