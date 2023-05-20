namespace GuizzoLtda
{
    partial class CadEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEscolherFotoEmp = new Button();
            pbFotoEmp = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRazaosoc = new TextBox();
            txtCnpj = new TextBox();
            txtIncEstad = new TextBox();
            txtRua = new TextBox();
            txtBairro = new TextBox();
            txtCep = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtComple = new TextBox();
            txtNumero = new TextBox();
            btnCadEndereco = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbFotoEmp).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnEscolherFotoEmp
            // 
            btnEscolherFotoEmp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEscolherFotoEmp.Location = new Point(324, 120);
            btnEscolherFotoEmp.Name = "btnEscolherFotoEmp";
            btnEscolherFotoEmp.Size = new Size(230, 55);
            btnEscolherFotoEmp.TabIndex = 0;
            btnEscolherFotoEmp.Text = "Escolher Foto";
            btnEscolherFotoEmp.UseVisualStyleBackColor = true;
            btnEscolherFotoEmp.Click += btnFotoEmp_Click;
            // 
            // pbFotoEmp
            // 
            pbFotoEmp.BorderStyle = BorderStyle.Fixed3D;
            pbFotoEmp.Location = new Point(39, 21);
            pbFotoEmp.Name = "pbFotoEmp";
            pbFotoEmp.Size = new Size(230, 247);
            pbFotoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoEmp.TabIndex = 1;
            pbFotoEmp.TabStop = false;
            pbFotoEmp.Click += pbFotoEmp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Razão Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Cnpj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 148);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "Inscrição Estadual";
            // 
            // txtRazaosoc
            // 
            txtRazaosoc.Location = new Point(30, 51);
            txtRazaosoc.Name = "txtRazaosoc";
            txtRazaosoc.Size = new Size(211, 23);
            txtRazaosoc.TabIndex = 6;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(30, 110);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(211, 23);
            txtCnpj.TabIndex = 7;
            // 
            // txtIncEstad
            // 
            txtIncEstad.Location = new Point(30, 185);
            txtIncEstad.Name = "txtIncEstad";
            txtIncEstad.Size = new Size(211, 23);
            txtIncEstad.TabIndex = 8;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(45, 34);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(100, 23);
            txtRua.TabIndex = 10;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(42, 89);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 11;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(47, 148);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 14);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 13;
            label5.Text = "Rua";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 71);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 130);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 15;
            label7.Text = "Cep";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 244);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 19;
            label8.Text = "Complemento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 185);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 18;
            label9.Text = "Numero";
            // 
            // txtComple
            // 
            txtComple.Location = new Point(47, 262);
            txtComple.Name = "txtComple";
            txtComple.Size = new Size(100, 23);
            txtComple.TabIndex = 17;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(42, 203);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 16;
            // 
            // btnCadEndereco
            // 
            btnCadEndereco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadEndereco.Location = new Point(385, 383);
            btnCadEndereco.Name = "btnCadEndereco";
            btnCadEndereco.Size = new Size(230, 55);
            btnCadEndereco.TabIndex = 21;
            btnCadEndereco.Text = "Cadastrar";
            btnCadEndereco.UseVisualStyleBackColor = true;
            btnCadEndereco.Click += button1_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 381);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtRazaosoc);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtCnpj);
            tabPage1.Controls.Add(txtIncEstad);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(793, 353);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(txtRua);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtComple);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(793, 353);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereço";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(pbFotoEmp);
            tabPage3.Controls.Add(btnEscolherFotoEmp);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(793, 353);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Imagem";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 2;
            // 
            // CadEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(btnCadEndereco);
            Name = "CadEmpresa";
            Text = "CadEmpresa";
            Load += CadEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotoEmp).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEscolherFotoEmp;
        private PictureBox pbFotoEmp;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRazaosoc;
        private TextBox txtCnpj;
        private TextBox txtIncEstad;
        private TextBox txtRua;
        private TextBox txtBairro;
        private TextBox txtCep;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtComple;
        private TextBox txtNumero;
        private Button btnCadEndereco;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox1;
    }
}