using Controle;
using Modelos;
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
    public partial class PedidoEmpresa : Form
    {
        Conexao conexaosql = new Conexao();
        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();

        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        public PedidoEmpresa(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
            us = usu.CarregaEmpresa(idcliente);
        }

        private void PedidoEmpresa_Load(object sender, EventArgs e)
        {

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PedidoEmpresa fmenureturn = new PedidoEmpresa(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtIdEmpresa.Text != "")
            {
                try
                {
                    conexaosql = new Conexao();
                    MySqlConnection con = conexaosql.getConexao();
                    con.Open();


                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_pedido WHERE idcliente=" + txtIdEmpresa.Text, con);
                    DataTable SearchDataTable = new DataTable();
                    using (MySqlDataAdapter adaptor = new MySqlDataAdapter(cmd))
                    {
                        adaptor.Fill(SearchDataTable);
                    }
                    dgPedidoEmp.DataSource = SearchDataTable;
                    dgPedidoEmp.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    txtIdEmpresa.Visible = false;
                    button1.Visible = false;
                    toolStripButton2.Enabled = true;

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(ex.Message));
                }


            }
        }
    }
}