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
            txtIdEndereco = new TextBox();
            txtIdCliente = new TextBox();
            dgSolicitacao = new DataGridView();
            btnRecusar = new Button();
            btnAprovar = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).BeginInit();
            SuspendLayout();
            // 
            // txtIdEndereco
            // 
            txtIdEndereco.Location = new Point(205, 72);
            txtIdEndereco.Name = "txtIdEndereco";
            txtIdEndereco.Size = new Size(100, 23);
            txtIdEndereco.TabIndex = 20;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(39, 72);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 19;
            // 
            // dgSolicitacao
            // 
            dgSolicitacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSolicitacao.Location = new Point(35, 246);
            dgSolicitacao.Name = "dgSolicitacao";
            dgSolicitacao.RowTemplate.Height = 25;
            dgSolicitacao.Size = new Size(731, 170);
            dgSolicitacao.TabIndex = 18;
            dgSolicitacao.CellClick += dgSolicitacao_CellClick;
            dgSolicitacao.Click += dgSolicitacao_Click;
            // 
            // btnRecusar
            // 
            btnRecusar.Location = new Point(605, 201);
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(161, 39);
            btnRecusar.TabIndex = 17;
            btnRecusar.Text = "Recusar";
            btnRecusar.UseVisualStyleBackColor = true;
            btnRecusar.Click += btnRecusar_Click;
            // 
            // btnAprovar
            // 
            btnAprovar.Location = new Point(438, 201);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(161, 39);
            btnAprovar.TabIndex = 16;
            btnAprovar.Text = "Aprovar";
            btnAprovar.UseVisualStyleBackColor = true;
            btnAprovar.Click += btnAprovar_Click;
            // 
            // labelendereco
            // 
            labelendereco.AutoSize = true;
            labelendereco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelendereco.Location = new Point(205, 43);
            labelendereco.Name = "labelendereco";
            labelendereco.Size = new Size(88, 20);
            labelendereco.TabIndex = 15;
            labelendereco.Text = "Id Endereço";
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.Location = new Point(31, 37);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(72, 20);
            labeltipo.TabIndex = 14;
            labeltipo.Text = "Id Cliente";
            // 
            // txtRazaoSoc
            // 
            txtRazaoSoc.Location = new Point(512, 72);
            txtRazaoSoc.Name = "txtRazaoSoc";
            txtRazaoSoc.Size = new Size(100, 23);
            txtRazaoSoc.TabIndex = 24;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(369, 72);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(100, 23);
            txtCnpj.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(512, 43);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 22;
            label1.Text = "Razão Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(361, 37);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 21;
            label2.Text = "Cnpj";
            // 
            // txtInscEstad
            // 
            txtInscEstad.Location = new Point(666, 72);
            txtInscEstad.Name = "txtInscEstad";
            txtInscEstad.Size = new Size(100, 23);
            txtInscEstad.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(666, 43);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 25;
            label3.Text = "Inscrição Estadual";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(39, 153);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 124);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 27;
            label4.Text = "Id Endereço";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(31, 225);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 15);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Requisições Finalizadas";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // CadastroAprov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(btnRecusar);
            Controls.Add(btnAprovar);
            Controls.Add(labelendereco);
            Controls.Add(labeltipo);
            Name = "CadastroAprov";
            Text = "CadastroAprov";
            Load += CadastroAprov_Load;
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdEndereco;
        private TextBox txtIdCliente;
        private DataGridView dgSolicitacao;
        private Button btnRecusar;
        private Button btnAprovar;
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
    }
}