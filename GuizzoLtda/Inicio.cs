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
    public partial class Inicio : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();
        int id;
        public Inicio()
        {
            idcliente = id;
            InitializeComponent();

        }

        
        private void Inicio_Load(object sender, EventArgs e)
        {

        }



        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnAcessarSys_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Leave(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectEmp_Click(object sender, EventArgs e)
        {
            SelecionarEmpresa fadminsol = new SelecionarEmpresa(us,idcliente);
            this.Hide();
            fadminsol.Show();
        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);

        }

        private void btnAcessarSys_Click_1(object sender, EventArgs e)
        {

        }
    }
}
