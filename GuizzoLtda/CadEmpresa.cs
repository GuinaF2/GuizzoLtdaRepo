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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuizzoLtda
{

    public partial class CadEmpresa : Form
    {
        int idcliente;
        EmpresaControle usu = new EmpresaControle();
        EmpresaModelo us = new EmpresaModelo();


        EnderecoModelo EnderecoModelo = new EnderecoModelo();
        EnderecoControle Controle = new EnderecoControle();

        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Control = new EmpresaControle();



        public CadEmpresa()
        {
            InitializeComponent();
        }








        private void btnCadEndereco_Click_1(object sender, EventArgs e)
        {
            string usuariowin = Environment.UserName;
            string letradisco = Path.GetPathRoot(Environment.CurrentDirectory);
            try
            {
                File.Copy(textBox1.Text, Path.Combine(letradisco + @"Users\" + usuariowin + @"\Source\Repos\GuinaF2\GuizzoLtdaRepo\GuizzoLtda\IMAGES\", Path.GetFileName(textBox1.Text)), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n\nErro ao inserir imagem: " + ex);
            }

            EmpresaModelo.LogoEmpresa = Path.Combine(letradisco + @"Users\" + usuariowin + @"\Source\Repos\GuinaF2\GuizzoLtdaRepo\GuizzoLtda\IMAGES\", Path.GetFileName(textBox1.Text));

            EmpresaModelo.CnpjUser = txtCnpj.Text;

            EmpresaModelo.RazaoSocialUser = txtRazaosoc.Text;

            EmpresaModelo.InscEstadUser = txtIncEstad.Text;

            EnderecoModelo.RuaUser = txtRua.Text;

            EnderecoModelo.BairroUser = txtBairro.Text;

            EnderecoModelo.CepUser = txtCep.Text;

            EnderecoModelo.NmrUser = txtNumero.Text;

            EnderecoModelo.CompUser = txtComple.Text;
            EnderecoModelo.CidadeUser = txtCidade.Text;
            EnderecoModelo.EstadoUser = txtEstado.Text;





            if (txtComple.Text == "" || txtNumero.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");

            }
            else
            {

                if (Controle.CadastroEndereco(EnderecoModelo) >= 1)
                {
                    if (Control.CadastroEmpresa(EmpresaModelo) >= 1)

                    {

                        MessageBox.Show("Pronto! Aguarde seu cadastro ser aprovado");
                        SelecionarEmpresa freturnselect = new SelecionarEmpresa(us, idcliente);
                        this.Hide();
                        freturnselect.Show();

                    }
                }


            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.MaxLength = 4;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtRua_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtRua_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SelecionarEmpresa fprincipalreturn = new SelecionarEmpresa(us, idcliente);
            this.Hide();
            fprincipalreturn.Show();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUniFed_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadEmpresa_Load_1(object sender, EventArgs e)
        {

        }

        private void txtRazaosoc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }




        private void txtComple_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCep_KeyPress_2(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCnpj.MaxLength = 14;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtIncEstad_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtIncEstad.MaxLength = 14;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }




        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void CadEmpresa_Load_2(object sender, EventArgs e)
        {
            us = usu.CarregaEmpresa(idcliente);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEscolherFotoEmp_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog abririmg = new OpenFileDialog();
            abririmg.FilterIndex = 2;
            abririmg.RestoreDirectory = true;
            abririmg.Filter = "Image Files(*.jpg;*.png;*.jpeg;*.bmp;)|*.jpg;*.png;*.jpeg;*.bmp;";

            if (abririmg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = abririmg.FileName;
                pbFotoEmp.Image = new Bitmap(abririmg.FileName);
                pbFotoEmp.ImageLocation = abririmg.FileName;
            }
        }



        private void txtRazaosoc_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtRua_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


    }
}
