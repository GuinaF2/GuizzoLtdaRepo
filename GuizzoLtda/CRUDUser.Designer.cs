namespace GuizzoLtda
{
    partial class CRUDUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDUser));
            dataGridCRUD = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCad = new ToolStripButton();
            labelcargo = new Label();
            cbCargo = new ComboBox();
            labelsenha = new Label();
            labelnome = new Label();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            labelid = new Label();
            SaveCreate = new Button();
            SaveUpdate = new Button();
            toolStripSeparator2 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCRUD
            // 
            dataGridCRUD.AllowUserToAddRows = false;
            dataGridCRUD.AllowUserToDeleteRows = false;
            dataGridCRUD.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUD.Location = new Point(529, 20);
            dataGridCRUD.Name = "dataGridCRUD";
            dataGridCRUD.ReadOnly = true;
            dataGridCRUD.RowHeadersWidth = 51;
            dataGridCRUD.RowTemplate.Height = 25;
            dataGridCRUD.Size = new Size(400, 486);
            dataGridCRUD.TabIndex = 36;
            dataGridCRUD.CellClick += dataGridCRUD_CellClick;
            dataGridCRUD.CellContentClick += dataGridCRUD_CellContentClick_2;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, toolStripSeparator2, btnAtualizar, toolStripSeparator1, btnCad });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 27);
            toolStrip1.TabIndex = 39;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(173, 11, 0);
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Goldenrod;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(73, 24);
            btnReturn.Text = "Menu";
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(173, 11, 0);
            btnAtualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(82, 24);
            btnAtualizar.Text = "Alterar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(80, 24);
            btnCad.Text = "Cadastrar";
            btnCad.Click += btnCad_Click;
            // 
            // labelcargo
            // 
            labelcargo.AutoSize = true;
            labelcargo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelcargo.ForeColor = Color.Black;
            labelcargo.Location = new Point(207, 307);
            labelcargo.Name = "labelcargo";
            labelcargo.Size = new Size(49, 20);
            labelcargo.TabIndex = 38;
            labelcargo.Text = "Cargo";
            // 
            // cbCargo
            // 
            cbCargo.BackColor = Color.Black;
            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "1", "2" });
            cbCargo.Location = new Point(207, 330);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(63, 23);
            cbCargo.TabIndex = 37;
            // 
            // labelsenha
            // 
            labelsenha.AutoSize = true;
            labelsenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelsenha.ForeColor = Color.Black;
            labelsenha.Location = new Point(181, 226);
            labelsenha.Name = "labelsenha";
            labelsenha.Size = new Size(70, 30);
            labelsenha.TabIndex = 35;
            labelsenha.Text = "Senha";
            // 
            // labelnome
            // 
            labelnome.AutoSize = true;
            labelnome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelnome.ForeColor = Color.Black;
            labelnome.Location = new Point(181, 145);
            labelnome.Name = "labelnome";
            labelnome.Size = new Size(70, 30);
            labelnome.TabIndex = 34;
            labelnome.Text = "Nome";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Black;
            txtSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.Goldenrod;
            txtSenha.Location = new Point(181, 269);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 33;
            txtSenha.KeyPress += txtSenha_KeyPress_1;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Black;
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.Goldenrod;
            txtNome.Location = new Point(181, 196);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 32;
            txtNome.KeyPress += txtNome_KeyPress_1;
            // 
            // txtID
            // 
            txtID.BackColor = Color.Black;
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.ForeColor = Color.Goldenrod;
            txtID.Location = new Point(181, 115);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 31;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelid.ForeColor = Color.Black;
            labelid.Location = new Point(181, 66);
            labelid.Name = "labelid";
            labelid.Size = new Size(107, 30);
            labelid.TabIndex = 30;
            labelid.Text = "Id Usuário";
            // 
            // SaveCreate
            // 
            SaveCreate.BackColor = Color.Black;
            SaveCreate.FlatStyle = FlatStyle.Flat;
            SaveCreate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.ForeColor = Color.Goldenrod;
            SaveCreate.Location = new Point(94, 388);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(300, 65);
            SaveCreate.TabIndex = 29;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = false;
            SaveCreate.Visible = false;
            SaveCreate.Click += SaveCreate_Click;
            // 
            // SaveUpdate
            // 
            SaveUpdate.BackColor = Color.Black;
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.ForeColor = Color.Goldenrod;
            SaveUpdate.Location = new Point(94, 388);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 27;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = false;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // CRUDUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(929, 505);
            Controls.Add(toolStrip1);
            Controls.Add(labelcargo);
            Controls.Add(cbCargo);
            Controls.Add(labelsenha);
            Controls.Add(labelnome);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(labelid);
            Controls.Add(SaveCreate);
            Controls.Add(SaveUpdate);
            Controls.Add(dataGridCRUD);
            ForeColor = Color.Goldenrod;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CRUDUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministradorCRUD";
            Load += CRUDUser_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private DataGridView dataGridCRUD;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCad;
        private Label labelcargo;
        private ComboBox cbCargo;
        private Label labelsenha;
        private Label labelnome;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtID;
        private Label labelid;
        private Button SaveCreate;
        private Button SaveUpdate;
        private ToolStripSeparator toolStripSeparator2;
    }
}