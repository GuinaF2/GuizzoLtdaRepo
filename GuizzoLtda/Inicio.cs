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
        public Inicio()
        {


            InitializeComponent();

        }



        private void SelectEmp_Click(object sender, EventArgs e)
        {
            SelecionarEmpresa fadminsol = new SelecionarEmpresa(us, idcliente);
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
