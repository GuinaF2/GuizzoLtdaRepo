﻿namespace GuizzoLtda
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
            txtBairro = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtComple = new TextBox();
            btnCadEndereco = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtIncEstad = new TextBox();
            txtCnpj = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tabPage2 = new TabPage();
            txtCep = new TextBox();
            cbUniFed = new ComboBox();
            labelunidadefederal = new Label();
            txtNumero = new TextBox();
            txtRua = new MaskedTextBox();
            tabPage3 = new TabPage();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbFotoEmp).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnEscolherFotoEmp
            // 
            btnEscolherFotoEmp.FlatAppearance.BorderSize = 0;
            btnEscolherFotoEmp.FlatStyle = FlatStyle.Flat;
            btnEscolherFotoEmp.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEscolherFotoEmp.Location = new Point(499, 235);
            btnEscolherFotoEmp.Margin = new Padding(3, 4, 3, 4);
            btnEscolherFotoEmp.Name = "btnEscolherFotoEmp";
            btnEscolherFotoEmp.Size = new Size(263, 73);
            btnEscolherFotoEmp.TabIndex = 0;
            btnEscolherFotoEmp.Text = "Escolher Foto";
            btnEscolherFotoEmp.UseVisualStyleBackColor = true;
            btnEscolherFotoEmp.Click += btnEscolherFotoEmp_Click;
            // 
            // pbFotoEmp
            // 
            pbFotoEmp.BorderStyle = BorderStyle.Fixed3D;
            pbFotoEmp.Location = new Point(66, 72);
            pbFotoEmp.Margin = new Padding(3, 4, 3, 4);
            pbFotoEmp.Name = "pbFotoEmp";
            pbFotoEmp.Size = new Size(262, 328);
            pbFotoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoEmp.TabIndex = 1;
            pbFotoEmp.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 2;
            label1.Text = "Razão Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 109);
            label2.Name = "label2";
            label2.Size = new Size(52, 28);
            label2.TabIndex = 3;
            label2.Text = "Cnpj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 197);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 4;
            label3.Text = "Inscrição Estadual";
            // 
            // txtRazaosoc
            // 
            txtRazaosoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazaosoc.Location = new Point(34, 68);
            txtRazaosoc.Margin = new Padding(3, 4, 3, 4);
            txtRazaosoc.Name = "txtRazaosoc";
            txtRazaosoc.Size = new Size(251, 34);
            txtRazaosoc.TabIndex = 6;
            txtRazaosoc.KeyPress += txtRazaosoc_KeyPress;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBairro.Location = new Point(42, 127);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(251, 34);
            txtBairro.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 28);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 13;
            label5.Text = "Rua";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 95);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 14;
            label6.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(42, 177);
            label7.Name = "label7";
            label7.Size = new Size(46, 28);
            label7.TabIndex = 15;
            label7.Text = "Cep";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(610, 95);
            label8.Name = "label8";
            label8.Size = new Size(137, 28);
            label8.TabIndex = 19;
            label8.Text = "Complemento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(610, 16);
            label9.Name = "label9";
            label9.Size = new Size(84, 28);
            label9.TabIndex = 18;
            label9.Text = "Numero";
            // 
            // txtComple
            // 
            txtComple.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComple.Location = new Point(610, 127);
            txtComple.Margin = new Padding(3, 4, 3, 4);
            txtComple.Name = "txtComple";
            txtComple.Size = new Size(114, 34);
            txtComple.TabIndex = 17;
            txtComple.KeyPress += txtComple_KeyPress;
            // 
            // btnCadEndereco
            // 
            btnCadEndereco.BackColor = Color.Transparent;
            btnCadEndereco.FlatStyle = FlatStyle.Flat;
            btnCadEndereco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadEndereco.Location = new Point(325, 511);
            btnCadEndereco.Margin = new Padding(3, 4, 3, 4);
            btnCadEndereco.Name = "btnCadEndereco";
            btnCadEndereco.Size = new Size(263, 73);
            btnCadEndereco.TabIndex = 21;
            btnCadEndereco.Text = "Cadastrar";
            btnCadEndereco.UseVisualStyleBackColor = false;
            btnCadEndereco.Click += btnCadEndereco_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, 8);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(915, 495);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(txtIncEstad);
            tabPage1.Controls.Add(txtCnpj);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Controls.Add(txtRazaosoc);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(907, 462);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados";
            // 
            // txtIncEstad
            // 
            txtIncEstad.Location = new Point(34, 263);
            txtIncEstad.Margin = new Padding(3, 4, 3, 4);
            txtIncEstad.Name = "txtIncEstad";
            txtIncEstad.Size = new Size(159, 27);
            txtIncEstad.TabIndex = 13;
            txtIncEstad.KeyPress += txtIncEstad_KeyPress_1;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(34, 163);
            txtCnpj.Margin = new Padding(3, 4, 3, 4);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(195, 27);
            txtCnpj.TabIndex = 12;
            txtCnpj.KeyPress += txtCnpj_KeyPress_1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(3, 4);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(901, 27);
            toolStrip1.TabIndex = 11;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources._688879_arrows_512x512;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtCep);
            tabPage2.Controls.Add(cbUniFed);
            tabPage2.Controls.Add(labelunidadefederal);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Controls.Add(txtRua);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtComple);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(907, 462);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereço";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(42, 209);
            txtCep.Margin = new Padding(3, 4, 3, 4);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(114, 27);
            txtCep.TabIndex = 26;
            txtCep.KeyPress += txtCep_KeyPress_2;
            // 
            // cbUniFed
            // 
            cbUniFed.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniFed.FormattingEnabled = true;
            cbUniFed.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)\t", "Amapá (AP)\t", "Amazonas (AM)\t", "Bahia (BA)\tSalvador\t", "Ceará (CE)\tFortaleza\t", "Distrito Federal (DF)\t", "Espírito Santo (ES)\t", "Goiás (GO)\t", "Maranhão (MA)\t", "Mato Grosso (MT)\t", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)\t", "Pará (PA)\tBelém\t", "Paraíba (PB)\t", "Paraná (PR)\t", "Pernambuco (PE)\t", "Piauí (PI)\tTeresina\t", "Rio de Janeiro (RJ)\t", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)\t", "Roraima (RR)\t", "Santa Catarina (SC)\t", "São Paulo (SP)\t", "Sergipe (SE)\t", "Tocantins (TO)" });
            cbUniFed.Location = new Point(48, 276);
            cbUniFed.Margin = new Padding(3, 4, 3, 4);
            cbUniFed.Name = "cbUniFed";
            cbUniFed.Size = new Size(225, 28);
            cbUniFed.TabIndex = 25;
            cbUniFed.TextChanged += cbUniFed_TextChanged;
            // 
            // labelunidadefederal
            // 
            labelunidadefederal.AutoSize = true;
            labelunidadefederal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelunidadefederal.Location = new Point(42, 244);
            labelunidadefederal.Name = "labelunidadefederal";
            labelunidadefederal.Size = new Size(155, 28);
            labelunidadefederal.TabIndex = 24;
            labelunidadefederal.Text = "Unidade Federal";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(610, 60);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(114, 27);
            txtNumero.TabIndex = 23;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress_1;
            // 
            // txtRua
            // 
            txtRua.AsciiOnly = true;
            txtRua.Location = new Point(42, 60);
            txtRua.Margin = new Padding(3, 4, 3, 4);
            txtRua.Name = "txtRua";
            txtRua.ShortcutsEnabled = false;
            txtRua.Size = new Size(257, 27);
            txtRua.TabIndex = 22;
            txtRua.MaskInputRejected += txtRua_MaskInputRejected;
            txtRua.KeyPress += txtRua_KeyPress;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pbFotoEmp);
            tabPage3.Controls.Add(btnEscolherFotoEmp);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(907, 462);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Imagem";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(66, 353);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // CadEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tabControl1);
            Controls.Add(btnCadEndereco);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadEmpresa";
            Load += CadEmpresa_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbFotoEmp).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private TextBox txtBairro;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtComple;
        private Button btnCadEndereco;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox1;
        private MaskedTextBox txtRua;
        private TextBox txtNumero;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ComboBox cbUniFed;
        private Label labelunidadefederal;
        private TextBox txtCep;
        private TextBox txtIncEstad;
        private TextBox txtCnpj;
    }
}