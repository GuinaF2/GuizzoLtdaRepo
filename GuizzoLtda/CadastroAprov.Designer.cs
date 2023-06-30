namespace GuizzoLtda
{
    partial class CadastroAprov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAprov));
            txtIdEndereco = new TextBox();
            txtIdCliente = new TextBox();
            dgSolicitacao = new DataGridView();
            labelendereco = new Label();
            labeltipo = new Label();
            txtRazaoSoc = new TextBox();
            txtCnpj = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtInscEstad = new TextBox();
            label3 = new Label();
            txtStatus = new TextBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            toolStrip1 = new ToolStrip();
            button1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAprovar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnRecusar = new ToolStripButton();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdEndereco
            // 
            txtIdEndereco.BackColor = Color.Black;
            txtIdEndereco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdEndereco.ForeColor = Color.Goldenrod;
            txtIdEndereco.Location = new Point(35, 199);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.Size = new Size(100, 27);
            txtIdEndereco.TabIndex = 20;
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = Color.Black;
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdCliente.ForeColor = Color.Goldenrod;
            txtIdCliente.Location = new Point(35, 135);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 27);
            txtIdCliente.TabIndex = 19;
            // 
            // dgSolicitacao
            // 
            dgSolicitacao.BackgroundColor = Color.Black;
            dgSolicitacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSolicitacao.Location = new Point(35, 246);
            dgSolicitacao.Name = "dgSolicitacao";
            dgSolicitacao.RowTemplate.Height = 25;
            dgSolicitacao.Size = new Size(731, 170);
            dgSolicitacao.TabIndex = 18;
            dgSolicitacao.CellClick += dgSolicitacao_CellClick;
            dgSolicitacao.Click += dgSolicitacao_Click;
            // 
            // labelendereco
            // 
            labelendereco.AutoSize = true;
            labelendereco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelendereco.Location = new Point(35, 176);
            labelendereco.Name = "labelendereco";
            labelendereco.Size = new Size(88, 20);
            labelendereco.TabIndex = 15;
            labelendereco.Text = "Id Endereço";
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.Location = new Point(35, 112);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(72, 20);
            labeltipo.TabIndex = 14;
            labeltipo.Text = "Id Cliente";
            // 
            // txtRazaoSoc
            // 
            txtRazaoSoc.BackColor = Color.Black;
            txtRazaoSoc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazaoSoc.ForeColor = Color.Goldenrod;
            txtRazaoSoc.Location = new Point(454, 135);
            txtRazaoSoc.Name = "txtRazaoSoc";
            txtRazaoSoc.Size = new Size(100, 27);
            txtRazaoSoc.TabIndex = 24;
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = Color.Black;
            txtCnpj.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnpj.ForeColor = Color.Goldenrod;
            txtCnpj.Location = new Point(297, 135);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(100, 27);
            txtCnpj.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(454, 112);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 22;
            label1.Text = "Razão Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(297, 112);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 21;
            label2.Text = "Cnpj";
            // 
            // txtInscEstad
            // 
            txtInscEstad.BackColor = Color.Black;
            txtInscEstad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInscEstad.ForeColor = Color.Goldenrod;
            txtInscEstad.Location = new Point(454, 199);
            txtInscEstad.Name = "txtInscEstad";
            txtInscEstad.Size = new Size(100, 27);
            txtInscEstad.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(454, 176);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 25;
            label3.Text = "Inscrição Estadual";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.Black;
            txtStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.ForeColor = Color.Goldenrod;
            txtStatus.Location = new Point(297, 199);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 27);
            txtStatus.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(297, 176);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 27;
            label4.Text = "Status Cadastro";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(637, 228);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 15);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Requisições Finalizadas";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStrip1.Items.AddRange(new ToolStripItem[] { button1, toolStripSeparator1, btnAprovar, toolStripSeparator2, btnRecusar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 31;
            toolStrip1.Text = "toolStrip1";
            // 
            // button1
            // 
            button1.ForeColor = Color.Goldenrod;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageTransparentColor = Color.Magenta;
            button1.Name = "button1";
            button1.Size = new Size(69, 24);
            button1.Text = "Menu";
            button1.Click += button1_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAprovar
            // 
            btnAprovar.ForeColor = Color.Goldenrod;
            btnAprovar.Image = (Image)resources.GetObject("btnAprovar.Image");
            btnAprovar.ImageTransparentColor = Color.Magenta;
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(86, 24);
            btnAprovar.Text = "Aprovar";
            btnAprovar.Click += btnAprovar_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnRecusar
            // 
            btnRecusar.ForeColor = Color.Goldenrod;
            btnRecusar.Image = (Image)resources.GetObject("btnRecusar.Image");
            btnRecusar.ImageTransparentColor = Color.Magenta;
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(84, 24);
            btnRecusar.Text = "Recusar";
            btnRecusar.Click += btnRecusar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 39);
            label5.Name = "label5";
            label5.Size = new Size(275, 47);
            label5.TabIndex = 32;
            label5.Text = "Cadastro Cliente";
            // 
            // CadastroAprov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(toolStrip1);
            Controls.Add(linkLabel1);
            Controls.Add(txtStatus);
            Controls.Add(label4);
            Controls.Add(txtInscEstad);
            Controls.Add(label3);
            Controls.Add(txtRazaoSoc);
            Controls.Add(txtCnpj);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtIdEndereco);
            Controls.Add(txtIdCliente);
            Controls.Add(dgSolicitacao);
            Controls.Add(labelendereco);
            Controls.Add(labeltipo);
            Name = "CadastroAprov";
            Text = "CadastroAprov";
            Load += CadastroAprov_Load;
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdEndereco;
        private TextBox txtIdCliente;
        private DataGridView dgSolicitacao;
        private Label labelendereco;
        private Label labeltipo;
        private TextBox txtRazaoSoc;
        private TextBox txtCnpj;
        private Label label1;
        private Label label2;
        private TextBox txtInscEstad;
        private Label label3;
        private TextBox txtStatus;
        private Label label4;
        private LinkLabel linkLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton button1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAprovar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnRecusar;
        private Label label5;
    }
}