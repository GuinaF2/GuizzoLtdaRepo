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
            this.labeldescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labeltipo = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.btnRecusar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dgSolicitacao = new System.Windows.Forms.DataGridView();
            this.txtTipoSoli = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSolicitacao)).BeginInit();
            this.SuspendLayout();
            // 
            // labeldescricao
            // 
            this.labeldescricao.AutoSize = true;
            this.labeldescricao.Location = new System.Drawing.Point(240, 32);
            this.labeldescricao.Name = "labeldescricao";
            this.labeldescricao.Size = new System.Drawing.Size(58, 15);
            this.labeldescricao.TabIndex = 2;
            this.labeldescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(244, 60);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(258, 110);
            this.txtDescricao.TabIndex = 3;
            // 
            // labeltipo
            // 
            this.labeltipo.AutoSize = true;
            this.labeltipo.Location = new System.Drawing.Point(565, 60);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(90, 15);
            this.labeltipo.TabIndex = 4;
            this.labeltipo.Text = "Tipo Solicitação";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(565, 118);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(39, 15);
            this.labelstatus.TabIndex = 6;
            this.labelstatus.Text = "Status";
            // 
            // btnAprovar
            // 
            this.btnAprovar.Location = new System.Drawing.Point(623, 223);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(99, 39);
            this.btnAprovar.TabIndex = 8;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = true;
            // 
            // btnRecusar
            // 
            this.btnRecusar.Location = new System.Drawing.Point(518, 223);
            this.btnRecusar.Name = "btnRecusar";
            this.btnRecusar.Size = new System.Drawing.Size(99, 39);
            this.btnRecusar.TabIndex = 9;
            this.btnRecusar.Text = "Recusar";
            this.btnRecusar.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(553, 191);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Requisições Finalizadas";
            // 
            // dgSolicitacao
            // 
            this.dgSolicitacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSolicitacao.Location = new System.Drawing.Point(34, 268);
            this.dgSolicitacao.Name = "dgSolicitacao";
            this.dgSolicitacao.RowTemplate.Height = 25;
            this.dgSolicitacao.Size = new System.Drawing.Size(564, 150);
            this.dgSolicitacao.TabIndex = 11;
            // 
            // txtTipoSoli
            // 
            this.txtTipoSoli.Location = new System.Drawing.Point(573, 95);
            this.txtTipoSoli.Name = "txtTipoSoli";
            this.txtTipoSoli.Size = new System.Drawing.Size(100, 23);
            this.txtTipoSoli.TabIndex = 12;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(573, 156);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 23);
            this.txtStatus.TabIndex = 13;
            // 
            // AdminSolicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtTipoSoli);
            this.Controls.Add(this.dgSolicitacao);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnRecusar);
            this.Controls.Add(this.btnAprovar);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.labeltipo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labeldescricao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminSolicitacao";
            this.Text = "AdminSolicitacao";
            ((System.ComponentModel.ISupportInitialize)(this.dgSolicitacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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