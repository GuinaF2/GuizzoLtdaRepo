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
    public partial class AdminSolicitacao : Form
    {
        Conexao conexaosql = new Conexao();
        SolicitacaoModelo SolicitacaoM = new SolicitacaoModelo();
        SolicitacaoControle SolicitacaoC = new SolicitacaoControle();

        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        public AdminSolicitacao(EmpresaModelo um,int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void AdminSolicitacao_Load_1(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
            dgSolicitacao.DataSource = conexaosql.verDados("SELECT * FROM tb_solicitacao WHERE condicao = 'Pendente'");
        }

        private void btnAprovar_Click_1(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "" || cbStatus.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Favor selecionar uma solicitação.");
            }
            else
            {
                SolicitacaoM.CodSolicitacao = Convert.ToInt32(txtIdReq.Text);
                SolicitacaoM.StatusSolicitacao = "Aprovada";

                if (SolicitacaoC.AtualizarSolicitacao(SolicitacaoM) == true)
                {
                    MessageBox.Show("Solicitação Aprovada.");
                    AdminSolicitacao fadminsol = new AdminSolicitacao(us,idcliente);
                    this.Hide();
                    fadminsol.Show();
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }
            }
        }

        private void btnRecusar_Click_1(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "" || cbStatus.Text == "" || cbTipo.Text == "")
            {
                MessageBox.Show("Favor selecionar uma solicitação.");
            }
            else
            {
                SolicitacaoM.CodSolicitacao = Convert.ToInt32(txtIdReq.Text);
                SolicitacaoM.StatusSolicitacao = "Recusada";

                if (SolicitacaoC.AtualizarSolicitacao(SolicitacaoM) == true)
                {
                    MessageBox.Show("Solicitação Aprovada.");
                    AdminSolicitacao fadminsol = new AdminSolicitacao(us,idcliente);
                    this.Hide();
                    fadminsol.Show();
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Ver solicitações finalizadas")
            {
                btnAprovar.Enabled = false;
                btnRecusar.Enabled = false;
                linkLabel1.Text = "Ver solicitações pendentes";
                dgSolicitacao.DataSource = conexaosql.verDados("SELECT * FROM tb_solicitacao WHERE condicao = 'Aprovada' OR condicao = 'Recusada'");
            }
            else if (linkLabel1.Text == "Ver solicitações pendentes")
            {
                txtIdReq.Text = "";
                txtDescricao.Text = "";
                cbTipo.Text = "";
                cbStatus.Text = "";

                btnAprovar.Enabled = true;
                btnRecusar.Enabled = true;
                linkLabel1.Text = "Ver solicitações finalizadas";
                dgSolicitacao.DataSource = conexaosql.verDados("SELECT * FROM tb_solicitacao WHERE condicao = 'Pendente'");
            }
        }

        private void dgSolicitacao_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgSolicitacao.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgSolicitacao.CurrentRow.Selected = true;

                    txtDescricao.Text = dgSolicitacao.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                    txtStatus.Text = dgSolicitacao.Rows[e.RowIndex].Cells["condicao"].Value.ToString();
                    txtTipoSoli.Text = dgSolicitacao.Rows[e.RowIndex].Cells["tipo_solicit"].Value.ToString();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AdminMenu fadminlog = new AdminMenu(us, idcliente);
            this.Hide();
            fadminlog.Show();
        }
    }
}
