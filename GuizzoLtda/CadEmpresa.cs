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
        UsuarioModelo UsuarioModelo = new UsuarioModelo();
        UsuarioControle Controle = new UsuarioControle();

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
            UsuarioModelo.RuaUser = txtRua.Text;

            UsuarioModelo.BairroUser = txtBairro.Text;

            UsuarioModelo.CepUser = txtCep.Text;

            UsuarioModelo.NmrUser = txtNumero.Text;

            UsuarioModelo.CompUser = txtComple.Text;

            if (txtRua.Text == "" || txtBairro.Text == "" || txtCep.Text == "" || txtNumero.Text == "" || txtComple.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");

                AdministradorCRUD fadmcrud = new AdministradorCRUD();
                fadmcrud.Show();
                Hide();
            }
            else
            {
                if (Controle.CadastroEmpresa(UsuarioModelo) >= 1)
                {
                    AdministradorCRUD fadmincrud = new AdministradorCRUD();
                    this.Hide();
                    fadmincrud.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha não encontrados");
                }
            }
        }
    }
}
