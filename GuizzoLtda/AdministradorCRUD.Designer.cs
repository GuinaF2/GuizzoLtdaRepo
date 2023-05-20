namespace GuizzoLtda
{
    partial class AdministradorCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorCRUD));
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            labelcargo = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripTextBox2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripTextBox3 = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(25, 385);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 0;
            SaveUpdate.Text = "Salvar Tudo";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(25, 385);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(300, 50);
            SaveDelete.TabIndex = 1;
            SaveDelete.Text = "Salvar Tudo";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click_1;
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(25, 385);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(300, 50);
            SaveCreate.TabIndex = 2;
            SaveCreate.Text = "Salvar Tudo";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Visible = false;
            SaveCreate.Click += SaveCreate_Click_1;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelid.Location = new Point(128, 90);
            labelid.Name = "labelid";
            labelid.Size = new Size(107, 30);
            labelid.TabIndex = 3;
            labelid.Text = "Id Usuario";
            labelid.Visible = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(128, 136);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 23);
            txtID.TabIndex = 4;
            txtID.Visible = false;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 208);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 5;
            txtNome.Visible = false;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(128, 280);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 23);
            txtSenha.TabIndex = 6;
            txtSenha.Visible = false;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // labelnome
            // 
            labelnome.AutoSize = true;
            labelnome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelnome.Location = new Point(128, 162);
            labelnome.Name = "labelnome";
            labelnome.Size = new Size(70, 30);
            labelnome.TabIndex = 7;
            labelnome.Text = "Nome";
            labelnome.Visible = false;
            // 
            // labelsenha
            // 
            labelsenha.AutoSize = true;
            labelsenha.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelsenha.Location = new Point(128, 234);
            labelsenha.Name = "labelsenha";
            labelsenha.Size = new Size(70, 30);
            labelsenha.TabIndex = 8;
            labelsenha.Text = "Senha";
            labelsenha.Visible = false;
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
            dataGridCRUD.CellClick += dataGridCRUD_CellContentClick_1;
            dataGridCRUD.CellContentClick += dataGridCRUD_CellContentClick_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 28);
            button1.Name = "button1";
            button1.Size = new Size(108, 46);
            button1.TabIndex = 10;
            button1.Text = "Retornar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2" });
            comboBox1.Location = new Point(190, 337);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(63, 23);
            comboBox1.TabIndex = 11;
            comboBox1.Visible = false;
            // 
            // labelcargo
            // 
            labelcargo.AutoSize = true;
            labelcargo.Location = new Point(128, 340);
            labelcargo.Name = "labelcargo";
            labelcargo.Size = new Size(39, 15);
            labelcargo.TabIndex = 12;
            labelcargo.Text = "Cargo";
            labelcargo.Visible = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripTextBox2, toolStripSeparator1, toolStripTextBox1, toolStripSeparator2, toolStripTextBox3, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripTextBox2.Image = (Image)resources.GetObject("toolStripTextBox2.Image");
            toolStripTextBox2.ImageTransparentColor = Color.Magenta;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(57, 22);
            toolStripTextBox2.Text = "Atualizar";
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripTextBox1.Image = (Image)resources.GetObject("toolStripTextBox1.Image");
            toolStripTextBox1.ImageTransparentColor = Color.Magenta;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(61, 22);
            toolStripTextBox1.Text = "Cadastrar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripTextBox3.Image = (Image)resources.GetObject("toolStripTextBox3.Image");
            toolStripTextBox3.ImageTransparentColor = Color.Magenta;
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(48, 22);
            toolStripTextBox3.Text = "Deletar";
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
            // AdministradorCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(labelcargo);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridCRUD);
            Controls.Add(labelsenha);
            Controls.Add(labelnome);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(labelid);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Name = "AdministradorCRUD";
            Text = "AdministradorCRUD";
            Load += AdministradorCRUD_Load;
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
        private Button button1;
        private ComboBox comboBox1;
        private Label labelcargo;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private ToolStripButton toolStripTextBox2;
        private ToolStripButton toolStripTextBox1;
        private ToolStripButton toolStripTextBox3;
    }
}