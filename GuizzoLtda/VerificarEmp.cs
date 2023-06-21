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

        public VerificarEmp(EmpresaModelo um,int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
        }

        private void VerificarEmp_Load(object sender, EventArgs e)
        {
            dgVerEmp.DataSource = conexaosql.verDados("SELECT * FROM tb_cliente");
        }

        private void dgVerEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtRazaoSoc_Click(object sender, EventArgs e)
        {
            txtRazaoSoc.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us,idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    btnMenu.Visible = false;
                    dgVerEmp.Visible = true;
                    returnBtn.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(ex.Message));
                }
            }

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            txtCnpj.Visible = true;

            labelCnpj.Visible = true;
            btnConfirmar.Visible = true;
            btnMenu.Visible = true;
            dgVerEmp.Visible = false;
            returnBtn.Visible = false;
        }
    }
}


