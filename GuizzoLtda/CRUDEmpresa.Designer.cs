namespace GuizzoLtda
{
    partial class CRUDEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDEmpresa));
            txtIdCliente = new TextBox();
            labelIdCliente = new Label();
            labelInscricao = new Label();
            dataGridEmpresa = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            labelRazaoSocial = new Label();
            txtCnpj = new TextBox();
            labelCnpj = new Label();
            SaveDelete = new Button();
            SaveUpdate = new Button();
            txtRazaoSocial = new TextBox();
            txtInscricaoEst = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpresa).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = Color.White;
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(122, 94);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(125, 23);
            txtIdCliente.TabIndex = 44;
            // 
            // labelIdCliente
            // 
            labelIdCliente.AutoSize = true;
            labelIdCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdCliente.Location = new Point(115, 61);
            labelIdCliente.Name = "labelIdCliente";
            labelIdCliente.Size = new Size(101, 30);
            labelIdCliente.TabIndex = 43;
            labelIdCliente.Text = "Id Cliente";
            // 
            // labelInscricao
            // 
            labelInscricao.AutoSize = true;
            labelInscricao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelInscricao.Location = new Point(115, 273);
            labelInscricao.Name = "labelInscricao";
            labelInscricao.Size = new Size(179, 30);
            labelInscricao.TabIndex = 42;
            labelInscricao.Text = "Inscrição Estadual";
            labelInscricao.Click += labelInscricao_Click;
            // 
            // dataGridEmpresa
            // 
            dataGridEmpresa.AllowUserToAddRows = false;
            dataGridEmpresa.AllowUserToDeleteRows = false;
            dataGridEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpresa.Location = new Point(411, -1);
            dataGridEmpresa.Name = "dataGridEmpresa";
            dataGridEmpresa.ReadOnly = true;
            dataGridEmpresa.RowTemplate.Height = 25;
            dataGridEmpresa.Size = new Size(389, 453);
            dataGridEmpresa.TabIndex = 39;
            dataGridEmpresa.CellClick += dataGridEmpresa_CellClick;
            dataGridEmpresa.CellContentClick += dataGridEmpresa_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 40;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(23, 22);
            btnReturn.Text = "Retornar";
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(57, 22);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnApaga
            // 
            btnApaga.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(48, 22);
            btnApaga.Text = "Deletar";
            btnApaga.Click += btnApaga_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 22);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // labelRazaoSocial
            // 
            labelRazaoSocial.AutoSize = true;
            labelRazaoSocial.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelRazaoSocial.Location = new Point(115, 191);
            labelRazaoSocial.Name = "labelRazaoSocial";
            labelRazaoSocial.Size = new Size(130, 30);
            labelRazaoSocial.TabIndex = 38;
            labelRazaoSocial.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = Color.White;
            txtCnpj.Location = new Point(122, 165);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(125, 23);
            txtCnpj.TabIndex = 37;
            // 
            // labelCnpj
            // 
            labelCnpj.AutoSize = true;
            labelCnpj.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCnpj.Location = new Point(115, 132);
            labelCnpj.Name = "labelCnpj";
            labelCnpj.Size = new Size(61, 30);
            labelCnpj.TabIndex = 36;
            labelCnpj.Text = "CNPJ";
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(50, 368);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(300, 50);
            SaveDelete.TabIndex = 34;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(50, 368);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 33;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.White;
            txtRazaoSocial.Location = new Point(122, 244);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(125, 23);
            txtRazaoSocial.TabIndex = 45;
            // 
            // txtInscricaoEst
            // 
            txtInscricaoEst.BackColor = Color.White;
            txtInscricaoEst.Location = new Point(120, 306);
            txtInscricaoEst.Name = "txtInscricaoEst";
            txtInscricaoEst.Size = new Size(125, 23);
            txtInscricaoEst.TabIndex = 46;
            // 
            // CRUDEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInscricaoEst);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtIdCliente);
            Controls.Add(labelIdCliente);
            Controls.Add(labelInscricao);
            Controls.Add(dataGridEmpresa);
            Controls.Add(toolStrip1);
            Controls.Add(labelRazaoSocial);
            Controls.Add(txtCnpj);
            Controls.Add(labelCnpj);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Name = "CRUDEmpresa";
            Text = "CRUDEmpresa";
            Load += CRUDEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEmpresa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCliente;
        private Label labelIdCliente;
        private Label labelInscricao;
        private DataGridView dataGridEmpresa;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnApaga;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private Label labelRazaoSocial;
        private TextBox txtCnpj;
        private Label labelCnpj;
        private Button SaveDelete;
        private Button SaveUpdate;
        private TextBox txtRazaoSocial;
        private TextBox txtInscricaoEst;
    }
}