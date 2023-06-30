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
    public partial class CadastroAprov : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        Conexao conexaosql = new Conexao();
        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();
        public CadastroAprov(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void CadastroAprov_Load(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
            dgSolicitacao.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente WHERE statuscadastro = 'Pendente'");
        }

        private void btnAprovar_Click_1(object sender, EventArgs e)
        {
            if (txtInscEstad.Text == "" || txtRazaoSoc.Text == "" || txtCnpj.Text == "")
            {
                MessageBox.Show("Favor selecionar uma solicitação.");
            }
            else
            {
                EmpresaModelo.CodCliente = Convert.ToInt32(txtIdCliente.Text);
                EmpresaModelo.StatusCadastro = "Aprovada";

                if (Controle.AtualizarEmpresa(EmpresaModelo) == true)
                {
                    MessageBox.Show("Solicitação Aprovada.");
                    CadastroAprov fadminaprov = new CadastroAprov(us, idcliente);
                    this.Hide();
                    fadminaprov.Show();
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }
            }
        }

        private void btnRecusar_Click_1(object sender, EventArgs e)
        {
            if (txtInscEstad.Text == "" || txtRazaoSoc.Text == "" || txtCnpj.Text == "")
            {
                MessageBox.Show("Favor selecionar uma solicitação.");
            }
            else
            {
                EmpresaModelo.CodCliente = Convert.ToInt32(txtIdCliente.Text);
                EmpresaModelo.StatusCadastro = "Recusada";

                if (Controle.AtualizarEmpresa(EmpresaModelo) == true)
                {
                    MessageBox.Show("Solicitação Aprovada.");
                    CadastroAprov faprovcad = new CadastroAprov(us, idcliente);
                    this.Hide();
                    faprovcad.Show();
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }
            }
        }

        private void dgSolicitacao_Click(object sender, EventArgs e)
        {

        }

        private void dgSolicitacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgSolicitacao.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgSolicitacao.CurrentRow.Selected = true;

                    txtIdEndereco.Text = dgSolicitacao.Rows[e.RowIndex].Cells["idendereco"].Value.ToString();
                    txtIdCliente.Text = dgSolicitacao.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
                    txtRazaoSoc.Text = dgSolicitacao.Rows[e.RowIndex].Cells["razao_social"].Value.ToString();
                    txtCnpj.Text = dgSolicitacao.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
                    txtInscEstad.Text = dgSolicitacao.Rows[e.RowIndex].Cells["inscricao_estadual"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Favor selecionar ID da Requisição");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\t\t    Favor selecionar ID da Solicitação. \n\nERRO\t\t: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Ver solicitações finalizadas")
            {
                btnAprovar.Enabled = false;
                btnRecusar.Enabled = false;
                linkLabel1.Text = "Ver solicitações pendentes";
                dgSolicitacao.DataSource = conexaosql.verDados("SELECT * FROM tb_empresa WHERE statuscadastro = 'Aprovada' OR statuscadastro = 'Recusada'");
            }
            else if (linkLabel1.Text == "Ver solicitações pendentes")
            {
                txtIdCliente.Text = "";
                txtStatus.Text = "";
                txtRazaoSoc.Text = "";
                txtInscEstad.Text = "";
                txtCnpj.Text = "";
                txtIdEndereco.Text = "";

                btnAprovar.Enabled = true;
                btnRecusar.Enabled = true;
                linkLabel1.Text = "Ver solicitações finalizadas";
                dgSolicitacao.DataSource = conexaosql.verDados("SELECT * FROM tb_empresa WHERE statuscadastro = 'Pendente'");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminMenu fmenureturn = new AdminMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }
    }
}
