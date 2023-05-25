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
            this.SaveUpdate = new System.Windows.Forms.Button();
            this.SaveDelete = new System.Windows.Forms.Button();
            this.SaveCreate = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.labelnome = new System.Windows.Forms.Label();
            this.labelsenha = new System.Windows.Forms.Label();
            this.dataGridCRUD = new System.Windows.Forms.DataGridView();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.labelcargo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnApaga = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveUpdate.Location = new System.Drawing.Point(50, 375);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(300, 50);
            this.SaveUpdate.TabIndex = 0;
            this.SaveUpdate.Text = "Salvar Alteração";
            this.SaveUpdate.UseVisualStyleBackColor = true;
            this.SaveUpdate.Visible = false;
            this.SaveUpdate.Click += new System.EventHandler(this.SaveUpdate_Click);
            // 
            // SaveDelete
            // 
            this.SaveDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveDelete.Location = new System.Drawing.Point(50, 313);
            this.SaveDelete.Name = "SaveDelete";
            this.SaveDelete.Size = new System.Drawing.Size(300, 50);
            this.SaveDelete.TabIndex = 1;
            this.SaveDelete.Text = "Salvar Alteração";
            this.SaveDelete.UseVisualStyleBackColor = true;
            this.SaveDelete.Visible = false;
            this.SaveDelete.Click += new System.EventHandler(this.SaveDelete_Click);
            // 
            // SaveCreate
            // 
            this.SaveCreate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCreate.Location = new System.Drawing.Point(50, 313);
            this.SaveCreate.Name = "SaveCreate";
            this.SaveCreate.Size = new System.Drawing.Size(300, 50);
            this.SaveCreate.TabIndex = 2;
            this.SaveCreate.Text = "Salvar Cadastro";
            this.SaveCreate.UseVisualStyleBackColor = true;
            this.SaveCreate.Visible = false;
            this.SaveCreate.Click += new System.EventHandler(this.SaveCreate_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelid.Location = new System.Drawing.Point(135, 68);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(107, 30);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "Id Usuario";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(135, 101);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 23);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged_1);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(135, 160);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 23);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged_1);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(135, 232);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(125, 23);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged_1);
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelnome.Location = new System.Drawing.Point(135, 127);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(70, 30);
            this.labelnome.TabIndex = 7;
            this.labelnome.Text = "Nome";
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelsenha.Location = new System.Drawing.Point(135, 199);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(70, 30);
            this.labelsenha.TabIndex = 8;
            this.labelsenha.Text = "Senha";
            // 
            // dataGridCRUD
            // 
            this.dataGridCRUD.AllowUserToAddRows = false;
            this.dataGridCRUD.AllowUserToDeleteRows = false;
            this.dataGridCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCRUD.Location = new System.Drawing.Point(411, 0);
            this.dataGridCRUD.Name = "dataGridCRUD";
            this.dataGridCRUD.ReadOnly = true;
            this.dataGridCRUD.RowTemplate.Height = 25;
            this.dataGridCRUD.Size = new System.Drawing.Size(389, 453);
            this.dataGridCRUD.TabIndex = 9;
            this.dataGridCRUD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCRUD_CellClick);
            this.dataGridCRUD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCRUD_CellContentClick);
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbCargo.Location = new System.Drawing.Point(197, 292);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(63, 23);
            this.cbCargo.TabIndex = 11;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // labelcargo
            // 
            this.labelcargo.AutoSize = true;
            this.labelcargo.Location = new System.Drawing.Point(135, 295);
            this.labelcargo.Name = "labelcargo";
            this.labelcargo.Size = new System.Drawing.Size(39, 15);
            this.labelcargo.TabIndex = 12;
            this.labelcargo.Text = "Cargo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturn,
            this.btnAtualizar,
            this.toolStripSeparator1,
            this.btnCad,
            this.toolStripSeparator2,
            this.btnApaga,
            this.toolStripSeparator,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            this.btnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(23, 22);
            this.btnReturn.Text = "Retornar";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(57, 22);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCad
            // 
            this.btnCad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCad.Image = ((System.Drawing.Image)(resources.GetObject("btnCad.Image")));
            this.btnCad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(61, 22);
            this.btnCad.Text = "Cadastrar";
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnApaga
            // 
            this.btnApaga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(48, 22);
            this.btnApaga.Text = "Deletar";
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "Aju&da";
            // 
            // AdministradorCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridCRUD);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelcargo);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.SaveCreate);
            this.Controls.Add(this.SaveDelete);
            this.Controls.Add(this.SaveUpdate);
            this.Name = "AdministradorCRUD";
            this.Text = "AdministradorCRUD";
            this.Load += new System.EventHandler(this.AdministradorCRUD_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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