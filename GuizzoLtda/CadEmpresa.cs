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
    }
}
