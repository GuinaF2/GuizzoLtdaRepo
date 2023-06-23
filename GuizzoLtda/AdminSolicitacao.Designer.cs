namespace GuizzoLtda
{
    partial class AdminSolicitacao
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
            txtIdReq = new TextBox();
            labelidrequisicao = new Label();
            labeldescricao = new Label();
            txtDescricao = new TextBox();
            labeltipo = new Label();
            cbTipo = new ComboBox();
            cbStatus = new ComboBox();
            labelstatus = new Label();
            btnAprovar = new Button();
            btnRecusar = new Button();
            linkLabel1 = new LinkLabel();
            dgSolicitacao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).BeginInit();
            SuspendLayout();
            // 
            // txtIdReq
            // 
            txtIdReq.Location = new Point(59, 86);
            txtIdReq.Name = "txtIdReq";
            txtIdReq.Size = new Size(100, 23);
            txtIdReq.TabIndex = 0;
            // 
            // labelidrequisicao
            // 
            labelidrequisicao.AutoSize = true;
            labelidrequisicao.Location = new Point(60, 58);
            labelidrequisicao.Name = "labelidrequisicao";
            labelidrequisicao.Size = new Size(77, 15);
            labelidrequisicao.TabIndex = 1;
            labelidrequisicao.Text = "Id Requisição";
            // 
            // labeldescricao
            // 
            labeldescricao.AutoSize = true;
            labeldescricao.Location = new Point(226, 61);
            labeldescricao.Name = "labeldescricao";
            labeldescricao.Size = new Size(58, 15);
            labeldescricao.TabIndex = 2;
            labeldescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(230, 89);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(141, 110);
            txtDescricao.TabIndex = 3;
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Location = new Point(442, 94);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(90, 15);
            labeltipo.TabIndex = 4;
            labeltipo.Text = "Tipo Solicitação";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(438, 118);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 5;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "APROVADO", "RECUSADA" });
            cbStatus.Location = new Point(438, 176);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 23);
            cbStatus.TabIndex = 7;
            // 
            // labelstatus
            // 
            labelstatus.AutoSize = true;
            labelstatus.Location = new Point(442, 152);
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(39, 15);
            labelstatus.TabIndex = 6;
            labelstatus.Text = "Status";
            // 
            // btnAprovar
            // 
            btnAprovar.Location = new Point(524, 223);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(99, 39);
            btnAprovar.TabIndex = 8;
            btnAprovar.Text = "Aprovar";
            btnAprovar.UseVisualStyleBackColor = true;
            btnAprovar.Click += btnAprovar_Click;
            // 
            // btnRecusar
            // 
            btnRecusar.Location = new Point(376, 223);
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(99, 39);
            btnRecusar.TabIndex = 9;
            btnRecusar.Text = "Recusar";
            btnRecusar.UseVisualStyleBackColor = true;
            btnRecusar.Click += btnRecusar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(430, 205);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Requisições Finalizadas";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dgSolicitacao
            // 
            dgSolicitacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSolicitacao.Location = new Point(34, 268);
            dgSolicitacao.Name = "dgSolicitacao";
            dgSolicitacao.RowTemplate.Height = 25;
            dgSolicitacao.Size = new Size(564, 150);
            dgSolicitacao.TabIndex = 11;
            // 
            // AdminSolicitacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgSolicitacao);
            Controls.Add(linkLabel1);
            Controls.Add(btnRecusar);
            Controls.Add(btnAprovar);
            Controls.Add(cbStatus);
            Controls.Add(labelstatus);
            Controls.Add(cbTipo);
            Controls.Add(labeltipo);
            Controls.Add(txtDescricao);
            Controls.Add(labeldescricao);
            Controls.Add(labelidrequisicao);
            Controls.Add(txtIdReq);
            Name = "AdminSolicitacao";
            Text = "AdminSolicitacao";
            Load += AdminSolicitacao_Load;
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdReq;
        private Label labelidrequisicao;
        private Label labeldescricao;
        private TextBox txtDescricao;
        private Label labeltipo;
        private ComboBox cbTipo;
        private ComboBox cbStatus;
        private Label labelstatus;
        private Button btnAprovar;
        private Button btnRecusar;
        private LinkLabel linkLabel1;
        private DataGridView dgSolicitacao;
    }
}