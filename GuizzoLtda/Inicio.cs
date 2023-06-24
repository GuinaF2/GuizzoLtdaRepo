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

        private void button1_Click(object sender, EventArgs e)
        {
            var form2Obj = new SelecionarEmpresa(us, idcliente);
            form2Obj.Shown += (o, args) => { btnAcessarSys.Enabled = false; };
            form2Obj.FormClosed += (o, args) => { btnAcessarSys.Enabled = true; };
            form2Obj.Show();
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
            var form2Obj = new SelecionarEmpresa(us, idcliente);
            form2Obj.Shown += (o, args) => { btnAcessarSys.Enabled = false; };
            form2Obj.FormClosed += (o, args) => { btnAcessarSys.Enabled = true; };
            form2Obj.Show();
        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
            MessageBox.Show(us.CodCliente.ToString());
        }

        private void btnAcessarSys_Click_1(object sender, EventArgs e)
        {
            Principal fcomeco = new Principal(us, idcliente);
            this.Hide();
            fcomeco.Show();
        }
    }
}
