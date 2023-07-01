﻿using Controle;
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
        int idcliente;

        Conexao conexaosql = new Conexao();
        MotoristaModelo MotoristaModelo = new MotoristaModelo();
        MotoristaControle Controle = new MotoristaControle();
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        public CRUDMotorista(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;

            InitializeComponent(); ;
        }

        private void SaveDelete_Click_1(object sender, EventArgs e)
        {

            if (txtIdMoto.Text == "")
            {
                MessageBox.Show("Selecione o Id para ser deletado");
                txtNome.Text = String.Empty;
                txtCpf.Text = String.Empty;
                txtCnh.Text = String.Empty;
                txtRg.Text = String.Empty;

            }
            else
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
            }

        }

        private void SaveCreate_Click_1(object sender, EventArgs e)
        {


            if (txtCpf.Text == "" || txtRg.Text == "" || txtNome.Text == "" || txtCnh.Text == "" || cbTipoCnh.Text == "" || txtIdVeiculo.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos");
            }
            else
            {
                MotoristaModelo.CodVeiculo = Convert.ToInt32(txtIdVeiculo.Text);
                MotoristaModelo.cpfMotorista = txtCpf.Text;
                MotoristaModelo.RgMotorista = txtRg.Text;
                MotoristaModelo.nomeMotorista = txtNome.Text;
                MotoristaModelo.CnhMotorista = txtCnh.Text;
                MotoristaModelo.TipoCnhMotorista = cbTipoCnh.Text;
                if (Controle.CadastrarMotorista(MotoristaModelo) >= 1)
                {
                    MessageBox.Show("Motorista Cadastrado Com Sucesso!");
                    CRUDMotorista fmotoristacrud = new CRUDMotorista(us, idcliente);
                    this.Hide();
                    fmotoristacrud.Show();
                }
                else
                {
                    MessageBox.Show("Erro no cadastro.");
                }
            }
        }

        private void SaveUpdate_Click_1(object sender, EventArgs e)
        {

            if (txtCpf.Text == "" || txtRg.Text == "" || txtNome.Text == "" || txtCnh.Text == "" || cbTipoCnh.Text == "" || txtIdVeiculo.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos");
            }
            else if (Controle.AtualizarMotorista(MotoristaModelo) == true)
            {
                MotoristaModelo.CodMotorista = Convert.ToInt32(txtIdMoto.Text);
                MotoristaModelo.cpfMotorista = txtCpf.Text;
                MotoristaModelo.RgMotorista = txtRg.Text;
                MotoristaModelo.nomeMotorista = txtNome.Text;
                MotoristaModelo.CnhMotorista = txtCnh.Text;
                MotoristaModelo.TipoCnhMotorista = cbTipoCnh.Text;
                MessageBox.Show("Cadastro Atualizado.");

                CRUDMotorista fmotoristacrud = new CRUDMotorista(us, idcliente);
                this.Hide();
                fmotoristacrud.Show();
            }
            else
            {
                MessageBox.Show("Erro na atualização.");
            }

        }

        private void CRUDMotorista_Load_1(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);

            dataGridMotorista.DataSource = conexaosql.verDados("SELECT * FROM tb_motorista");

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdMoto.Visible = false;
            txtIdVeiculo.Visible = false;
            txtNome.Visible = false;
            txtCpf.Visible = false;
            txtRg.Visible = false;
            cbTipoCnh.Visible = false;
            txtCnh.Visible = false;

            labelcodigo.Visible = false;
            labeltipocnh.Visible = false;
            labelcnh.Visible = false;
            labelinfo.Visible = false;
            labelIdMoto.Visible = false;
            labelIdVeiculo.Visible = false;
            labelcpf.Visible = false;
            labelNome.Visible = false;
            labelrg.Visible = false;
        }

        private void dataGridMotorista_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
                    txtCnh.Text = dataGridMotorista.Rows[e.RowIndex].Cells["carteiramotorista"].Value.ToString();
                    cbTipoCnh.Text = dataGridMotorista.Rows[e.RowIndex].Cells["tipocarteira"].Value.ToString();

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

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtCnh.Text = String.Empty;
            txtRg.Text = String.Empty;

            SaveUpdate.Visible = true;
            SaveDelete.Visible = false;
            SaveCreate.Visible = false;

            txtIdVeiculo.Visible = true;
            txtIdMoto.Visible = true;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtRg.Visible = true;
            cbTipoCnh.Visible = true;
            txtCnh.Visible = true;

            txtIdVeiculo.Enabled = true;
            txtRg.Enabled = true;
            txtNome.Enabled = true;
            txtCnh.Enabled = true;
            txtCpf.Enabled = true;
            cbTipoCnh.Enabled = true;

            labelcodigo.Visible = true;
            labeltipocnh.Visible = true;
            labelcnh.Visible = true;
            labelinfo.Visible = true;
            labelIdVeiculo.Visible = true;
            labelNome.Visible = true;
            labelIdMoto.Visible = true;
            labelcpf.Visible = true;
            labelrg.Visible = true;
        }

        private void btnCad_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtCnh.Text = String.Empty;
            txtRg.Text = String.Empty;

            SaveUpdate.Visible = false;
            SaveDelete.Visible = false;
            SaveCreate.Visible = true;

            txtIdVeiculo.Visible = true;
            txtIdMoto.Visible = true;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtRg.Visible = true;
            cbTipoCnh.Visible = true;
            txtCnh.Visible = true;

            txtIdVeiculo.Enabled = true;
            txtRg.Enabled = true;
            txtNome.Enabled = true;
            txtCnh.Enabled = true;
            txtCpf.Enabled = true;
            cbTipoCnh.Enabled = true;

            labelcodigo.Visible = true;
            labeltipocnh.Visible = true;
            labelcnh.Visible = true;
            labelinfo.Visible = true;
            labelNome.Visible = true;
            labelIdVeiculo.Visible = true;
            labelIdMoto.Visible = true;
            labelcpf.Visible = true;
            labelrg.Visible = true;
        }

        private void btnApaga_Click_1(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtCnh.Text = String.Empty;
            txtRg.Text = String.Empty;

            SaveUpdate.Visible = false;
            SaveDelete.Visible = true;
            SaveCreate.Visible = false;

            txtIdVeiculo.Visible = true;
            txtIdMoto.Visible = true;
            txtNome.Visible = true;
            txtCpf.Visible = true;
            txtRg.Visible = true;
            cbTipoCnh.Visible = true;
            txtCnh.Visible = true;

            txtIdVeiculo.Enabled = false;
            txtIdMoto.Enabled = false;
            txtRg.Enabled = false;
            txtNome.Enabled = false;
            txtCnh.Enabled = false;
            txtCpf.Enabled = false;
            cbTipoCnh.Enabled = false;

            labelcodigo.Visible = true;
            labeltipocnh.Visible = true;
            labelcnh.Visible = true;
            labelinfo.Visible = true;
            labelNome.Visible = true;
            labelIdVeiculo.Visible = true;
            labelIdMoto.Visible = true;
            labelcpf.Visible = true;
            labelrg.Visible = true;
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void txtIdVeiculo_TextChanged(object sender, EventArgs e)
        { }


        private void dataGridMotorista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdVeiculo_Click_1(object sender, EventArgs e)
        {
            SelecionarVeiculo cselectveic = new SelecionarVeiculo(us, idcliente);
            cselectveic.ShowDialog();

            if (cselectveic.DialogResult == DialogResult.OK)
            {
                txtIdVeiculo.Text = cselectveic.idveic.ToString();
            }
            else
            {
                MessageBox.Show("Erro. Verifique se selecionou um Veiculo corretamente.");
            }


        }

        private void txtCpf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtCpf.MaxLength = 11;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtRg_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtRg.MaxLength = 9;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {//permite letras e espaços
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCnh_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtCnh.MaxLength = 10;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


    }
}