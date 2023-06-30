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
            toolStripSeparator2 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUDEmpresa).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCRUDEmpresa
            // 
            dataGridCRUDEmpresa.AllowUserToAddRows = false;
            dataGridCRUDEmpresa.AllowUserToDeleteRows = false;
            dataGridCRUDEmpresa.BackgroundColor = Color.Black;
            dataGridCRUDEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUDEmpresa.Location = new Point(540, 20);
            dataGridCRUDEmpresa.Name = "dataGridCRUDEmpresa";
            dataGridCRUDEmpresa.ReadOnly = true;
            dataGridCRUDEmpresa.RowHeadersWidth = 51;
            dataGridCRUDEmpresa.RowTemplate.Height = 25;
            dataGridCRUDEmpresa.Size = new Size(389, 485);
            dataGridCRUDEmpresa.TabIndex = 23;
            dataGridCRUDEmpresa.CellClick += dataGridCRUDEmpresa_CellClick_1;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, toolStripSeparator2, btnAtualizar, toolStripSeparator1, btnApaga });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 28);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Goldenrod;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(73, 25);
            btnReturn.Text = "Menu";
            btnReturn.Click += btnReturn_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.Goldenrod;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(103, 25);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnApaga
            // 
            btnApaga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApaga.ForeColor = Color.Goldenrod;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(90, 25);
            btnApaga.Text = "Deletar";
            btnApaga.Click += btnApaga_Click_1;
            // 
            // labelcnpj
            // 
            labelcnpj.AutoSize = true;
            labelcnpj.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelcnpj.Location = new Point(155, 215);
            labelcnpj.Name = "labelcnpj";
            labelcnpj.Size = new Size(57, 30);
            labelcnpj.TabIndex = 22;
            labelcnpj.Text = "Cnpj";
            // 
            // labelrazaosocial
            // 
            labelrazaosocial.AutoSize = true;
            labelrazaosocial.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelrazaosocial.Location = new Point(155, 143);
            labelrazaosocial.Name = "labelrazaosocial";
            labelrazaosocial.Size = new Size(133, 30);
            labelrazaosocial.TabIndex = 21;
            labelrazaosocial.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = Color.Black;
            txtCnpj.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnpj.Location = new Point(155, 259);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(206, 27);
            txtCnpj.TabIndex = 20;
            txtCnpj.KeyPress += txtCnpj_KeyPress;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.Black;
            txtRazaoSocial.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazaoSocial.Location = new Point(155, 183);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(206, 27);
            txtRazaoSocial.TabIndex = 19;
            txtRazaoSocial.KeyPress += txtRazaoSocial_KeyPress;
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.BackColor = Color.Black;
            txtIdEmpresa.Enabled = false;
            txtIdEmpresa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdEmpresa.Location = new Point(155, 112);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(206, 27);
            txtIdEmpresa.TabIndex = 18;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelid.Location = new Point(155, 74);
            labelid.Name = "labelid";
            labelid.Size = new Size(121, 30);
            labelid.TabIndex = 17;
            labelid.Text = "Id Empresa";
            // 
            // SaveDelete
            // 
            SaveDelete.BackColor = Color.Black;
            SaveDelete.FlatStyle = FlatStyle.Flat;
            SaveDelete.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.ForeColor = Color.Goldenrod;
            SaveDelete.Location = new Point(116, 392);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(320, 74);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = false;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click_1;
            // 
            // SaveUpdate
            // 
            SaveUpdate.BackColor = Color.Black;
            SaveUpdate.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.ForeColor = Color.Goldenrod;
            SaveUpdate.Location = new Point(116, 392);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = false;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // labelinscestad
            // 
            labelinscestad.AutoSize = true;
            labelinscestad.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelinscestad.Location = new Point(155, 291);
            labelinscestad.Name = "labelinscestad";
            labelinscestad.Size = new Size(182, 30);
            labelinscestad.TabIndex = 28;
            labelinscestad.Text = "Inscrição Estadual";
            // 
            // txtInscEstadual
            // 
            txtInscEstadual.BackColor = Color.Black;
            txtInscEstadual.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtInscEstadual.ForeColor = Color.Goldenrod;
            txtInscEstadual.Location = new Point(155, 332);
            txtInscEstadual.Name = "txtInscEstadual";
            txtInscEstadual.Size = new Size(206, 27);
            txtInscEstadual.TabIndex = 27;
            txtInscEstadual.KeyPress += txtInscEstadual_KeyPress;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // CRUDEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(929, 505);
            Controls.Add(labelinscestad);
            Controls.Add(txtInscEstadual);
            Controls.Add(toolStrip1);
            Controls.Add(labelcnpj);
            Controls.Add(labelrazaosocial);
            Controls.Add(txtCnpj);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtIdEmpresa);
            Controls.Add(labelid);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Controls.Add(dataGridCRUDEmpresa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CRUDEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDEmpresa";
            Load += CRUDEmpresa_Load_1;
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