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
            linkLabel1 = new LinkLabel();
            dgSolicitacao = new DataGridView();
            txtTipoSoli = new TextBox();
            txtStatus = new TextBox();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAprovar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnRecusar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labeldescricao
            // 
            labeldescricao.AutoSize = true;
            labeldescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeldescricao.ForeColor = Color.Black;
            labeldescricao.Location = new Point(34, 75);
            labeldescricao.Name = "labeldescricao";
            labeldescricao.Size = new Size(77, 21);
            labeldescricao.TabIndex = 2;
            labeldescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new Point(34, 99);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(391, 110);
            txtDescricao.TabIndex = 3;
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.ForeColor = Color.Black;
            labeltipo.Location = new Point(482, 117);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(118, 21);
            labeltipo.TabIndex = 4;
            labeltipo.Text = "Tipo Solicitação";
            // 
            // labelstatus
            // 
            labelstatus.AutoSize = true;
            labelstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelstatus.ForeColor = Color.Black;
            labelstatus.Location = new Point(640, 117);
            labelstatus.Name = "labelstatus";
            labelstatus.Size = new Size(52, 21);
            labelstatus.TabIndex = 6;
            labelstatus.Text = "Status";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(164, 212);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Requisições Finalizadas";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // dgSolicitacao
            // 
            dgSolicitacao.BackgroundColor = Color.Black;
            dgSolicitacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSolicitacao.GridColor = Color.Goldenrod;
            dgSolicitacao.Location = new Point(34, 268);
            dgSolicitacao.Name = "dgSolicitacao";
            dgSolicitacao.RowTemplate.Height = 25;
            dgSolicitacao.Size = new Size(731, 170);
            dgSolicitacao.TabIndex = 11;
            dgSolicitacao.CellClick += dgSolicitacao_CellClick_1;
            // 
            // txtTipoSoli
            // 
            txtTipoSoli.Location = new Point(482, 146);
            txtTipoSoli.Name = "txtTipoSoli";
            txtTipoSoli.Size = new Size(100, 23);
            txtTipoSoli.TabIndex = 12;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(640, 146);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(100, 23);
            txtStatus.TabIndex = 13;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, toolStripSeparator1, btnAprovar, toolStripSeparator2, btnRecusar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(69, 24);
            btnReturn.Text = "Menu";
            btnReturn.Click += btnReturn_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAprovar
            // 
            btnAprovar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAprovar.Image = (Image)resources.GetObject("btnAprovar.Image");
            btnAprovar.ImageTransparentColor = Color.Magenta;
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(121, 24);
            btnAprovar.Text = "Recebimento";
            btnAprovar.Click += btnAprovar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnRecusar
            // 
            btnRecusar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecusar.Image = (Image)resources.GetObject("btnRecusar.Image");
            btnRecusar.ImageTransparentColor = Color.Magenta;
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(84, 24);
            btnRecusar.Text = "Recusar";
            btnRecusar.Click += btnRecusar_Click;
            // 
            // AdminSolicitacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(txtStatus);
            Controls.Add(txtTipoSoli);
            Controls.Add(dgSolicitacao);
            Controls.Add(linkLabel1);
            Controls.Add(labelstatus);
            Controls.Add(labeltipo);
            Controls.Add(txtDescricao);
            Controls.Add(labeldescricao);
            ForeColor = Color.Goldenrod;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminSolicitacao";
            Text = "AdminSolicitacao";
            Load += AdminSolicitacao_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgSolicitacao).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private LinkLabel linkLabel1;
        private DataGridView dgSolicitacao;
        private TextBox txtTipoSoli;
        private TextBox txtStatus;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAprovar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnRecusar;
    }
}