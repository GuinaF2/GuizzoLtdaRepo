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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEmpresa));
            btnEscolherFotoEmp = new Button();
            pbFotoEmp = new PictureBox();
            btnCadEndereco = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtIncEstad = new TextBox();
            txtCnpj = new TextBox();
            txtRazaosoc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            txtEstado = new TextBox();
            txtCidade = new TextBox();
            label4 = new Label();
            label10 = new Label();
            txtRua = new TextBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtComple = new TextBox();
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
            btnEscolherFotoEmp.BackColor = Color.Goldenrod;
            btnEscolherFotoEmp.BackgroundImage = (Image)resources.GetObject("btnEscolherFotoEmp.BackgroundImage");
            btnEscolherFotoEmp.BackgroundImageLayout = ImageLayout.Stretch;
            btnEscolherFotoEmp.FlatAppearance.BorderSize = 0;
            btnEscolherFotoEmp.FlatStyle = FlatStyle.Popup;
            btnEscolherFotoEmp.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnEscolherFotoEmp.ForeColor = Color.Black;
            btnEscolherFotoEmp.Location = new Point(430, 288);
            btnEscolherFotoEmp.Name = "btnEscolherFotoEmp";
            btnEscolherFotoEmp.Size = new Size(67, 59);
            btnEscolherFotoEmp.TabIndex = 0;
            btnEscolherFotoEmp.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEscolherFotoEmp.UseVisualStyleBackColor = false;
            btnEscolherFotoEmp.Click += btnEscolherFotoEmp_Click_1;
            // 
            // pbFotoEmp
            // 
            pbFotoEmp.BackColor = Color.Black;
            pbFotoEmp.BackgroundImageLayout = ImageLayout.Stretch;
            pbFotoEmp.BorderStyle = BorderStyle.FixedSingle;
            pbFotoEmp.Location = new Point(335, 6);
            pbFotoEmp.Name = "pbFotoEmp";
            pbFotoEmp.Size = new Size(251, 276);
            pbFotoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoEmp.TabIndex = 1;
            pbFotoEmp.TabStop = false;
            // 
            // btnCadEndereco
            // 
            btnCadEndereco.BackColor = Color.Black;
            btnCadEndereco.FlatStyle = FlatStyle.Flat;
            btnCadEndereco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadEndereco.ForeColor = Color.White;
            btnCadEndereco.Location = new Point(350, 400);
            btnCadEndereco.Name = "btnCadEndereco";
            btnCadEndereco.Size = new Size(230, 55);
            btnCadEndereco.TabIndex = 21;
            btnCadEndereco.Text = "Cadastrar";
            btnCadEndereco.UseVisualStyleBackColor = false;
            btnCadEndereco.Click += btnCadEndereco_Click_1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(-1, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 380);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Goldenrod;
            tabPage1.Controls.Add(txtIncEstad);
            tabPage1.Controls.Add(txtCnpj);
            tabPage1.Controls.Add(txtRazaosoc);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(910, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            // 
            // txtIncEstad
            // 
            txtIncEstad.Location = new Point(347, 247);
            txtIncEstad.Multiline = true;
            txtIncEstad.Name = "txtIncEstad";
            txtIncEstad.Size = new Size(219, 27);
            txtIncEstad.TabIndex = 13;
            txtIncEstad.KeyPress += txtIncEstad_KeyPress;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(347, 144);
            txtCnpj.Multiline = true;
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(219, 26);
            txtCnpj.TabIndex = 12;
            txtCnpj.KeyPress += txtCnpj_KeyPress;
            // 
            // txtRazaosoc
            // 
            txtRazaosoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazaosoc.Location = new Point(347, 64);
            txtRazaosoc.Name = "txtRazaosoc";
            txtRazaosoc.Size = new Size(219, 29);
            txtRazaosoc.TabIndex = 6;
            txtRazaosoc.KeyPress += txtRazaosoc_KeyPress_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(347, 33);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 2;
            label1.Text = "Razão Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(347, 106);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 3;
            label2.Text = "Cnpj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(347, 196);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 4;
            label3.Text = "Inscrição Estadual";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Goldenrod;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(txtEstado);
            tabPage2.Controls.Add(txtCidade);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtRua);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtComple);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(910, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereço";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(124, 38);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(219, 27);
            txtEstado.TabIndex = 31;
            txtEstado.KeyPress += txtEstado_KeyPress;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(124, 91);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(219, 27);
            txtCidade.TabIndex = 28;
            txtCidade.KeyPress += txtCidade_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(124, 14);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 30;
            label4.Text = "Estado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(124, 67);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 29;
            label10.Text = "Cidade";
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRua.Location = new Point(124, 226);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(219, 24);
            txtRua.TabIndex = 27;
            txtRua.KeyPress += txtRua_KeyPress_1;
            // 
            // txtCep
            // 
            txtCep.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCep.Location = new Point(124, 157);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(219, 27);
            txtCep.TabIndex = 26;
            txtCep.KeyPress += txtCep_KeyPress;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(529, 125);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 27);
            txtNumero.TabIndex = 23;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(124, 286);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(219, 27);
            txtBairro.TabIndex = 11;
            txtBairro.KeyPress += txtBairro_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(124, 121);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 15;
            label7.Text = "Cep";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(529, 165);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 19;
            label8.Text = "Complemento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(529, 92);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 18;
            label9.Text = "Numero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(124, 262);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 14;
            label6.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(124, 202);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 13;
            label5.Text = "Rua";
            // 
            // txtComple
            // 
            txtComple.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtComple.Location = new Point(529, 199);
            txtComple.Name = "txtComple";
            txtComple.Size = new Size(120, 27);
            txtComple.TabIndex = 17;
            txtComple.KeyPress += txtComple_KeyPress_1;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Goldenrod;
            tabPage3.Controls.Add(btnEscolherFotoEmp);
            tabPage3.Controls.Add(pbFotoEmp);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(910, 347);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Imagem";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(347, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 2;
            // 
            // CadEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(929, 505);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(btnCadEndereco);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadEmpresa";
            Load += CadEmpresa_Load_2;
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
        private Button btnCadEndereco;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private TextBox textBox1;
        private TabPage tabPage1;
        private TextBox txtIncEstad;
        private TextBox txtCnpj;
        private TextBox txtRazaosoc;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabPage tabPage2;
        private TextBox txtEstado;
        private TextBox txtCidade;
        private Label label4;
        private Label label10;
        private TextBox txtRua;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label5;
        private TextBox txtComple;
    }
}