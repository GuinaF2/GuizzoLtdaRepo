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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSolicitacao));
            labeldescricao = new Label();
            txtDescricao = new TextBox();
            labeltipo = new Label();
            labelstatus = new Label();
            btnAprovar = new Button();
            btnRecusar = new Button();
            linkLabel1 = new LinkLabel();
            dgSolicitacao = new DataGridView();
            txtTipoSoli = new TextBox();
            txtStatus = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).BeginInit();
            SuspendLayout();
            // 
            // labeldescricao
            // 
            labeldescricao.AutoSize = true;
            labeldescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeldescricao.Location = new Point(30, 9);
            labeldescricao.Name = "labeldescricao";
            labeldescricao.Size = new Size(77, 21);
            labeldescricao.TabIndex = 2;
            labeldescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(34, 37);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(391, 110);
            txtDescricao.TabIndex = 3;
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.Location = new Point(448, 56);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(116, 20);
            labeltipo.TabIndex = 4;
            labeltipo.Text = "Tipo Solicitação";
            // 
            // labelstatus
            // 
            labelstatus.AutoSize = true;
            labelstatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelstatus.Location = new Point(640, 62);
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(49, 20);
            labelstatus.TabIndex = 6;
            labelstatus.Text = "Status";
            // 
            // btnAprovar
            // 
            btnAprovar.Location = new Point(437, 223);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(161, 39);
            btnAprovar.TabIndex = 8;
            btnAprovar.Text = "Aprovar";
            btnAprovar.UseVisualStyleBackColor = true;
            // 
            // btnRecusar
            // 
            btnRecusar.Location = new Point(604, 223);
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(161, 39);
            btnRecusar.TabIndex = 9;
            btnRecusar.Text = "Recusar";
            btnRecusar.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(157, 150);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Requisições Finalizadas";
            // 
            // dgSolicitacao
            // 
            dgSolicitacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSolicitacao.Location = new Point(34, 268);
            dgSolicitacao.Name = "dgSolicitacao";
            dgSolicitacao.RowTemplate.Height = 25;
            dgSolicitacao.Size = new Size(731, 170);
            dgSolicitacao.TabIndex = 11;
            // 
            // txtTipoSoli
            // 
            txtTipoSoli.Location = new Point(456, 91);
            txtTipoSoli.Name = "txtTipoSoli";
            txtTipoSoli.Size = new Size(100, 23);
            txtTipoSoli.TabIndex = 12;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(640, 91);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 13;
            // 
            // AdminSolicitacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatus);
            Controls.Add(txtTipoSoli);
            Controls.Add(dgSolicitacao);
            Controls.Add(linkLabel1);
            Controls.Add(btnRecusar);
            Controls.Add(btnAprovar);
            Controls.Add(labelstatus);
            Controls.Add(labeltipo);
            Controls.Add(txtDescricao);
            Controls.Add(labeldescricao);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminSolicitacao";
            Text = "AdminSolicitacao";
            Load += AdminSolicitacao_Load_1;
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
        private TextBox txtTipoSoli;
        private TextBox txtStatus;
    }
}