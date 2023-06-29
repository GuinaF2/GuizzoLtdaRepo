using Controle;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuizzoLtda
{
    public partial class VerificarEmp : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        Conexao conexaosql = new Conexao();
        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();

        public VerificarEmp(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }





        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != "")
            {
                try
                {
                    conexaosql = new Conexao();
                    MySqlConnection con = conexaosql.getConexao();
                    con.Open();


                    MySqlCommand cmd = new MySqlCommand("SELECT idcliente,razao_social FROM tb_cliente WHERE cnpj=" + txtCnpj.Text, con);
                    DataTable SearchDataTable = new DataTable();
                    using (MySqlDataAdapter adaptor = new MySqlDataAdapter(cmd))
                    {
                        adaptor.Fill(SearchDataTable);
                    }
                    dgVerEmp.DataSource = SearchDataTable;

                    con.Close();


                    txtCnpj.Visible = false;

                    labelCnpj.Visible = false;
                    btnConfirmar.Visible = false;
                    btnMenu.Visible = true;
                    dgVerEmp.Visible = true;
                    returnBtn.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(ex.Message));
                }
            }
        }

        private void VerificarEmp_Load_1(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCnpj.MaxLength = 14;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }



        private void returnBtn_Click_1(object sender, EventArgs e)
        {
            txtCnpj.Visible = true;
            labelCnpj.Visible = true;
            btnConfirmar.Visible = true;
            btnMenu.Visible = true;
            dgVerEmp.Visible = false;
            returnBtn.Enabled = false;
        }

        private void btnMenu_Click_2(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }
    }
}


