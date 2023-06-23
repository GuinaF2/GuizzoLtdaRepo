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
            toolStripSeparator2 = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCRUD
            // 
            dataGridCRUD.AllowUserToAddRows = false;
            dataGridCRUD.AllowUserToDeleteRows = false;
            dataGridCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUD.Location = new Point(470, -1);
            dataGridCRUD.Margin = new Padding(3, 4, 3, 4);
            dataGridCRUD.Name = "dataGridCRUD";
            dataGridCRUD.ReadOnly = true;
            dataGridCRUD.RowHeadersWidth = 51;
            dataGridCRUD.RowTemplate.Height = 25;
            dataGridCRUD.Size = new Size(445, 604);
            dataGridCRUD.TabIndex = 36;
            dataGridCRUD.CellClick += dataGridCRUD_CellClick;
            dataGridCRUD.CellContentClick += dataGridCRUD_CellContentClick_1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1062, 27);
            toolStrip1.TabIndex = 39;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(29, 24);
            btnReturn.Text = "Retornar";
            btnReturn.Click += btnReturn_Click_2;
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(72, 24);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(76, 24);
            btnCad.Text = "Cadastrar";
            btnCad.Click += btnCad_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
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
            // labelcargo
            // 
            labelcargo.AutoSize = true;
            labelcargo.Location = new Point(154, 392);
            labelcargo.Name = "labelcargo";
            labelcargo.Size = new Size(49, 20);
            labelcargo.TabIndex = 38;
            labelcargo.Text = "Cargo";
            // 
            // cbCargo
            // 
            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "1", "2" });
            cbCargo.Location = new Point(225, 388);
            cbCargo.Margin = new Padding(3, 4, 3, 4);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(71, 28);
            cbCargo.TabIndex = 37;
            // 
            // labelsenha
            // 
            labelsenha.AutoSize = true;
            labelsenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelsenha.Location = new Point(154, 264);
            labelsenha.Name = "labelsenha";
            labelsenha.Size = new Size(89, 37);
            labelsenha.TabIndex = 35;
            labelsenha.Text = "Senha";
            // 
            // labelnome
            // 
            labelnome.AutoSize = true;
            labelnome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelnome.Location = new Point(154, 185);
            labelnome.Name = "labelnome";
            labelnome.Size = new Size(90, 37);
            labelnome.TabIndex = 34;
            labelnome.Text = "Nome";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.Location = new Point(154, 308);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(142, 27);
            txtSenha.TabIndex = 33;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(154, 229);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(142, 27);
            txtNome.TabIndex = 32;
            txtNome.Click += txtNome_Click;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtID
            // 
            txtID.BackColor = Color.White;
            txtID.Enabled = false;
            txtID.Location = new Point(154, 133);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(142, 27);
            txtID.TabIndex = 31;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelid.Location = new Point(154, 89);
            labelid.Name = "labelid";
            labelid.Size = new Size(138, 37);
            labelid.TabIndex = 30;
            labelid.Text = "Id Usuario";
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(57, 451);
            SaveCreate.Margin = new Padding(3, 4, 3, 4);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(343, 67);
            SaveCreate.TabIndex = 29;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Visible = false;
            SaveCreate.Click += SaveCreate_Click_1;
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(57, 491);
            SaveUpdate.Margin = new Padding(3, 4, 3, 4);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(343, 67);
            SaveUpdate.TabIndex = 27;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // CRUDUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
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
            Controls.Add(SaveUpdate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUDUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministradorCRUD";
            Load += CRUDUser_Load;
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
        private ToolStripButton ajudaToolStripButton;
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