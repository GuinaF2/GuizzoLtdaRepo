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
            SaveUpdate = new Button();
            SaveDelete = new Button();
            SaveCreate = new Button();
            labelid = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            labelnome = new Label();
            labelsenha = new Label();
            dataGridCRUD = new DataGridView();
            cbCargo = new ComboBox();
            labelcargo = new Label();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCad = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(50, 369);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 0;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(50, 313);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(300, 50);
            SaveDelete.TabIndex = 1;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(50, 339);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(300, 50);
            SaveCreate.TabIndex = 2;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Visible = false;
            SaveCreate.Click += SaveCreate_Click;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelid.Location = new Point(135, 68);
            labelid.Name = "labelid";
            labelid.Size = new Size(107, 30);
            labelid.TabIndex = 3;
            labelid.Text = "Id Usuario";
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Enabled = false;
            txtID.Location = new Point(135, 101);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 23);
            txtID.TabIndex = 4;
            txtID.TextChanged += txtID_TextChanged_1;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(135, 160);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged_1;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.Location = new Point(135, 232);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 23);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged_1;
            // 
            // labelnome
            // 
            labelnome.AutoSize = true;
            labelnome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelnome.Location = new Point(135, 127);
            labelnome.Name = "labelnome";
            labelnome.Size = new Size(70, 30);
            labelnome.TabIndex = 7;
            labelnome.Text = "Nome";
            // 
            // labelsenha
            // 
            labelsenha.AutoSize = true;
            labelsenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelsenha.Location = new Point(135, 199);
            labelsenha.Name = "labelsenha";
            labelsenha.Size = new Size(70, 30);
            labelsenha.TabIndex = 8;
            labelsenha.Text = "Senha";
            // 
            // dataGridCRUD
            // 
            dataGridCRUD.AllowUserToAddRows = false;
            dataGridCRUD.AllowUserToDeleteRows = false;
            dataGridCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUD.Location = new Point(411, 0);
            dataGridCRUD.Name = "dataGridCRUD";
            dataGridCRUD.ReadOnly = true;
            dataGridCRUD.RowTemplate.Height = 25;
            dataGridCRUD.Size = new Size(389, 453);
            dataGridCRUD.TabIndex = 9;
            dataGridCRUD.CellClick += dataGridCRUD_CellClick;
            dataGridCRUD.CellContentClick += dataGridCRUD_CellContentClick;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "1", "2" });
            cbCargo.Location = new Point(197, 292);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(63, 23);
            cbCargo.TabIndex = 11;
            cbCargo.SelectedIndexChanged += cbCargo_SelectedIndexChanged;
            // 
            // labelcargo
            // 
            labelcargo.AutoSize = true;
            labelcargo.Location = new Point(135, 295);
            labelcargo.Name = "labelcargo";
            labelcargo.Size = new Size(39, 15);
            labelcargo.TabIndex = 12;
            labelcargo.Text = "Cargo";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(23, 22);
            btnReturn.Text = "Retornar";
            btnReturn.Click += btnReturn_Click;
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
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(61, 22);
            btnCad.Text = "Cadastrar";
            btnCad.Click += btnCad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
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
            // CRUDUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridCRUD);
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
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Name = "CRUDUser";
            Text = "AdministradorCRUD";
            Load += AdministradorCRUD_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveUpdate;
        private Button SaveDelete;
        private Button SaveCreate;
        private Label labelid;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtSenha;
        private Label labelnome;
        private Label labelsenha;
        private DataGridView dataGridCRUD;
        private ComboBox comboBox1;
        private Label labelcargo;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private ToolStripButton btnAtualizar;
        private ToolStripButton btnCad;
        private ToolStripButton btnApaga;
        private ComboBox cbCargo;
    }
}