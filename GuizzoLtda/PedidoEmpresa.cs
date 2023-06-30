﻿using Controle;
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
        public PedidoEmpresa()
        {
            InitializeComponent();
            us = usu.CarregaEmpresa(idcliente);
        }

        private void button1_Click(object sender, EventArgs e)
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

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(ex.Message));
                }


            }
        }

        private void PedidoEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuncionarioMenu fmenureturn = new FuncionarioMenu(us, idcliente);
            this.Hide();
            fmenureturn.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}