using Controle;
using Modelos;
using MySqlX.XDevAPI;
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
    public partial class FuncionarioSolicit : Form
    {
        SolicitacaoControle sc = new SolicitacaoControle();
        SolicitacaoModelo sm = new SolicitacaoModelo();

        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        public FuncionarioSolicit(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void FuncionarioSolicit_Load(object sender, EventArgs e)
        {

            us = usu.CarregaEmpresa(idcliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sm.TipoSolicitacao = cbTipoSolicit.Text;
            sm.DescSolicitacao = txtDescricao.Text;
            sm.StatusSolicitacao = "Pendente";

            if (cbTipoSolicit.Text == "" || txtDescricao.Text == "")
            {
                MessageBox.Show("Favor preencher todas as informações.");
            }
            else
            {
                if (sc.CadastrarSolicitacao(sm) >= 1)
                {
                    MessageBox.Show("Solicitação enviada.");

                    FuncionarioSolicit cliente = new FuncionarioSolicit(us, idcliente);
                    this.Hide();
                    cliente.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao criar solicitação.");
                }
            }
        }

        private void labeltipo_Click(object sender, EventArgs e)
        {

        }

        private void labeldesc_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FuncionarioMenu ffuncmenu = new FuncionarioMenu(us, idcliente);
            this.Hide();
            ffuncmenu.Show();
        }
    }
}
