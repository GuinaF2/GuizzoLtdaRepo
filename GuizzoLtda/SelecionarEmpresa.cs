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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuizzoLtda
{
    public partial class SelecionarEmpresa : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();

        Conexao conexaosql = new Conexao();

        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Controle = new EmpresaControle();

        int id;
        public SelecionarEmpresa(EmpresaModelo um, int id)
        {
            us = um;
            idcliente = id;
            InitializeComponent();
            Program.thePictureBox = pbLogoEmp;

        }



        private void SelecionarEmpresa_Load(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
            dgViewSelEmp.DataSource = conexaosql.verDados("SELECT idcliente, razao_social,logo FROM tb_cliente WHERE statuscadastro= 'Aprovada'");

        }

        private void dgViewSelEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void pbLogoEmp_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkCadEmp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadEmpresa fcadastro = new CadEmpresa();
            this.Hide();
            fcadastro.Show();
        }

        private void SelecionarEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }




        


        private void dgViewSelEmp_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            this.Close();
            us = usu.CarregaEmpresa(idcliente);
            Principal fcomeco = new Principal(us, idcliente);
            this.Hide();
            fcomeco.Show();

        }

        private void dgViewSelEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgViewSelEmp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgViewSelEmp.CurrentRow.Selected = true;
                    textBox1.Text = dgViewSelEmp.Rows[e.RowIndex].Cells["logo"].Value.ToString();
                    pbLogoEmp.ImageLocation = textBox1.Text;
                }
                
            }
            catch
            {
                MessageBox.Show("Selecione your company plese!!!!!!");
            }
        }
    }
}

