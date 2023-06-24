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
        public AdminSolicitacao()
        {
            InitializeComponent();
        }

        private void AdminSolicitacao_Load(object sender, EventArgs e)
        {
            dgSolicitacao.DataSource = conexaosql.verDados("SELECT * FROM tb_solicitacao WHERE condicao = 'Pendente'");
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            if (txtIdReq.Text == "" || txtDescricao.Text == "" || cbStatus.Text == "" || cbTipo.Text == "")
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
                    AdminSolicitacao fadminsol = new AdminSolicitacao();
                    this.Hide();
                    fadminsol.Show();
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }
            }
        }

        private void btnRecusar_Click(object sender, EventArgs e)
        {
            if (txtIdReq.Text == "" || txtDescricao.Text == "" || cbStatus.Text == "" || cbTipo.Text == "")
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
                    AdminSolicitacao fadminsol = new AdminSolicitacao();
                    this.Hide();
                    fadminsol.Show();
                }
                else
                {
                    MessageBox.Show("Erro na atualização.");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
    }
}
