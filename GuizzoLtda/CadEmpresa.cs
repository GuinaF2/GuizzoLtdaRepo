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

    public partial class CadEmpresa : Form
    {
        EnderecoModelo EnderecoModelo = new EnderecoModelo();
        EnderecoControle Controle = new EnderecoControle();

        EmpresaModelo EmpresaModelo = new EmpresaModelo();
        EmpresaControle Control = new EmpresaControle();



        public CadEmpresa()
        {
            InitializeComponent();
        }

        private void btnFotoEmp_Click(object sender, EventArgs e)
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


        private void pbFotoEmp_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_1(object sender, EventArgs e)
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

            if (textBox1.Text == "" || txtCnpj.Text == "" || txtRazaosoc.Text == "" || txtIncEstad.Text == "" || txtRua.Text == "" || txtBairro.Text == "" || txtCep.Text == "" || txtNumero.Text == "" || txtComple.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");

                CadEmpresa fcadastroreturn = new CadEmpresa();
                fcadastroreturn.Show();
                this.Hide();
            }
            else
            {

                if (Controle.CadastroEndereco(EnderecoModelo) >= 1)
                {
                    if (Control.CadastroEmpresa(EmpresaModelo) >= 1)

                    {

                        MessageBox.Show("Usuário Cadastrado com Sucesso");
                        Principal fprincipalreturn = new Principal();
                        this.Hide();
                        fprincipalreturn.Show();

                    }
                }


            }
        }

        private void CadEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
