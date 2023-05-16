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

        OpenFileDialog Abrirfoto;
        Image Foto;
        string caminhofoto = "\\foto";

        public CadEmpresa()
        {
            InitializeComponent();
        }

        private void btnFotoEmp_Click(object sender, EventArgs e)
        {
            try
            {
                Abrirfoto = new OpenFileDialog();
                Abrirfoto.Filter = "imagem file (*.jng; *.png;)| *.jpg; *.png";

                if (Abrirfoto.ShowDialog() == DialogResult.OK)
                {

                    Foto = Image.FromFile(Abrirfoto.FileName);
                    pbFotoEmp.Image = Foto;
                    File.Copy(Abrirfoto.FileName, caminhofoto);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }
        }

        private void pbFotoEmp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnderecoModelo.RuaUser = txtRua.Text;

            EnderecoModelo.BairroUser = txtBairro.Text;

            EnderecoModelo.CepUser = txtCep.Text;

            EnderecoModelo.NmrUser = txtNumero.Text;

            EnderecoModelo.CompUser = txtComple.Text;

            if (txtRua.Text == "" || txtBairro.Text == "" || txtCep.Text == "" || txtNumero.Text == "" || txtComple.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos.");

                AdministradorCRUD fadmcrud = new AdministradorCRUD();
                fadmcrud.Show();
                Hide();
            }
            else
            {
                if (Controle.CadastroEndereco(EnderecoModelo) >= 1)
                {
                    if (Controle.CadastroEndereco(EnderecoModelo) >= 1)
                    {
                        EmpresaMenu fadmincrud = new EmpresaMenu();
                        this.Hide();
                        fadmincrud.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Usuário ou Senha não encontrados");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EmpresaModelo.CnpjUser = txtCnpj.Text;

            EmpresaModelo.RazaoSocialUser = txtRazaosoc.Text;

            EmpresaModelo.InscEstadUser = txtIncEstad.Text;

            if (txtCnpj.Text == "" || txtRazaosoc.Text == "" || txtIncEstad.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");

                AdministradorCRUD fadmcrud = new AdministradorCRUD();
                fadmcrud.Show();
                Hide();
            }
            else
            {
                if (Control.CadastroEmpresa(EmpresaModelo) >= 1)
                {
                    if (Control.CadastroEmpresa(EmpresaModelo) >= 1)
                    {
                        AdministradorCRUD fadmincrud = new AdministradorCRUD();
                        this.Hide();
                        fadmincrud.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Usuário ou Senha não encontrados");
                }
            }
        }
    }
}
