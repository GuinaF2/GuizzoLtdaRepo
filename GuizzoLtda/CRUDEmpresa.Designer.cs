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
            dataGridCRUDEmpresa = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            labelfoto = new Label();
            labelcnpj = new Label();
            labelrazaosocial = new Label();
            txtCnpj = new TextBox();
            txtRazaoSocial = new TextBox();
            txtIdEmpresa = new TextBox();
            labelid = new Label();
            SaveDelete = new Button();
            SaveUpdate = new Button();
            labelinscestad = new Label();
            txtInscEstadual = new TextBox();
            btnFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUDEmpresa).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCRUDEmpresa
            // 
            dataGridCRUDEmpresa.AllowUserToAddRows = false;
            dataGridCRUDEmpresa.AllowUserToDeleteRows = false;
            dataGridCRUDEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUDEmpresa.Location = new Point(617, 27);
            dataGridCRUDEmpresa.Margin = new Padding(3, 4, 3, 4);
            dataGridCRUDEmpresa.Name = "dataGridCRUDEmpresa";
            dataGridCRUDEmpresa.ReadOnly = true;
            dataGridCRUDEmpresa.RowHeadersWidth = 51;
            dataGridCRUDEmpresa.RowTemplate.Height = 25;
            dataGridCRUDEmpresa.Size = new Size(445, 563);
            dataGridCRUDEmpresa.TabIndex = 23;
            dataGridCRUDEmpresa.CellClick += dataGridCRUDEmpresa_CellClick;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Black;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1062, 27);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Goldenrod;
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(29, 24);
            btnReturn.Text = "Retornar";
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.ForeColor = Color.Goldenrod;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(72, 24);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnApaga
            // 
            btnApaga.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnApaga.ForeColor = Color.Goldenrod;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(62, 24);
            btnApaga.Text = "Deletar";
            btnApaga.Click += btnApaga_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(29, 24);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // labelfoto
            // 
            labelfoto.AutoSize = true;
            labelfoto.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelfoto.ForeColor = Color.White;
            labelfoto.Location = new Point(504, 67);
            labelfoto.Name = "labelfoto";
            labelfoto.Size = new Size(97, 20);
            labelfoto.TabIndex = 25;
            labelfoto.Text = "Alterar Logo";
            // 
            // labelcnpj
            // 
            labelcnpj.AutoSize = true;
            labelcnpj.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelcnpj.Location = new Point(103, 238);
            labelcnpj.Name = "labelcnpj";
            labelcnpj.Size = new Size(73, 38);
            labelcnpj.TabIndex = 22;
            labelcnpj.Text = "Cnpj";
            // 
            // labelrazaosocial
            // 
            labelrazaosocial.AutoSize = true;
            labelrazaosocial.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelrazaosocial.Location = new Point(103, 142);
            labelrazaosocial.Name = "labelrazaosocial";
            labelrazaosocial.Size = new Size(171, 38);
            labelrazaosocial.TabIndex = 21;
            labelrazaosocial.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = Color.White;
            txtCnpj.Location = new Point(103, 296);
            txtCnpj.Margin = new Padding(3, 4, 3, 4);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(235, 27);
            txtCnpj.TabIndex = 20;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.White;
            txtRazaoSocial.Location = new Point(103, 194);
            txtRazaoSocial.Margin = new Padding(3, 4, 3, 4);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(235, 27);
            txtRazaoSocial.TabIndex = 19;
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.BackColor = Color.White;
            txtIdEmpresa.Enabled = false;
            txtIdEmpresa.Location = new Point(103, 100);
            txtIdEmpresa.Margin = new Padding(3, 4, 3, 4);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(235, 27);
            txtIdEmpresa.TabIndex = 18;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelid.Location = new Point(103, 49);
            labelid.Name = "labelid";
            labelid.Size = new Size(153, 38);
            labelid.TabIndex = 17;
            labelid.Text = "Id Empresa";
            // 
            // SaveDelete
            // 
            SaveDelete.BackColor = Color.Black;
            SaveDelete.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.ForeColor = Color.Goldenrod;
            SaveDelete.Location = new Point(132, 454);
            SaveDelete.Margin = new Padding(3, 4, 3, 4);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(343, 67);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = false;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // SaveUpdate
            // 
            SaveUpdate.BackColor = Color.Black;
            SaveUpdate.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.ForeColor = Color.Goldenrod;
            SaveUpdate.Location = new Point(132, 454);
            SaveUpdate.Margin = new Padding(3, 4, 3, 4);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(343, 67);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = false;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // labelinscestad
            // 
            labelinscestad.AutoSize = true;
            labelinscestad.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelinscestad.Location = new Point(103, 339);
            labelinscestad.Name = "labelinscestad";
            labelinscestad.Size = new Size(235, 38);
            labelinscestad.TabIndex = 28;
            labelinscestad.Text = "Inscrição Estadual";
            // 
            // txtInscEstadual
            // 
            txtInscEstadual.BackColor = Color.White;
            txtInscEstadual.Location = new Point(103, 393);
            txtInscEstadual.Margin = new Padding(3, 4, 3, 4);
            txtInscEstadual.Name = "txtInscEstadual";
            txtInscEstadual.Size = new Size(235, 27);
            txtInscEstadual.TabIndex = 27;
            // 
            // btnFoto
            // 
            btnFoto.BackColor = Color.Black;
            btnFoto.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFoto.ForeColor = Color.Goldenrod;
            btnFoto.Location = new Point(510, 93);
            btnFoto.Margin = new Padding(3, 4, 3, 4);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(86, 31);
            btnFoto.TabIndex = 29;
            btnFoto.Text = "Alterar";
            btnFoto.UseVisualStyleBackColor = false;
            btnFoto.Click += button1_Click;
            // 
            // CRUDEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(1062, 673);
            Controls.Add(btnFoto);
            Controls.Add(labelinscestad);
            Controls.Add(txtInscEstadual);
            Controls.Add(dataGridCRUDEmpresa);
            Controls.Add(toolStrip1);
            Controls.Add(labelfoto);
            Controls.Add(labelcnpj);
            Controls.Add(labelrazaosocial);
            Controls.Add(txtCnpj);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtIdEmpresa);
            Controls.Add(labelid);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUDEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDEmpresa";
            Load += CRUDEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCRUDEmpresa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCRUDEmpresa;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCad;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnApaga;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private Label labelfoto;
        private Label labelcnpj;
        private Label labelrazaosocial;
        private TextBox txtCnpj;
        private TextBox txtRazaoSocial;
        private TextBox txtIdEmpresa;
        private Label labelid;
        private Button SaveCreate;
        private Button SaveDelete;
        private Button SaveUpdate;
        private Label labelinscestad;
        private TextBox txtInscEstadual;
        private Button btnFoto;
    }
}