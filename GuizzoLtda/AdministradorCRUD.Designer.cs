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
            label1 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dataGridCRUD = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripTextBox3 = new ToolStripTextBox();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
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
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(25, 280);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(300, 50);
            SaveDelete.TabIndex = 1;
            SaveDelete.Text = "Salvar Tudo";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Click += SaveDelete_Click_1;
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(25, 337);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(300, 50);
            SaveCreate.TabIndex = 2;
            SaveCreate.Text = "Salvar Tudo";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Click += SaveCreate_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 90);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 3;
            label1.Text = "Id Usuario";
            // 
            // txtID
            // 
            txtID.Location = new Point(128, 136);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 23);
            txtID.TabIndex = 4;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 208);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(128, 280);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 23);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(128, 162);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(128, 234);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 8;
            label3.Text = "Senha";
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
            button1.Location = new Point(0, 39);
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 340);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Cargo";
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 25);
            toolStripTextBox1.Text = "Cadastrar";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 25);
            toolStripTextBox2.Text = "Atualizar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 25);
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
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // AdministradorCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridCRUD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private DataGridView dataGridCRUD;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
    }
}