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
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).BeginInit();
            SuspendLayout();
            // 
            // SaveUpdate
            // 
            SaveUpdate.Location = new Point(72, 239);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(75, 23);
            SaveUpdate.TabIndex = 0;
            SaveUpdate.Text = "Atualizar";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // SaveDelete
            // 
            SaveDelete.Location = new Point(72, 304);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(75, 23);
            SaveDelete.TabIndex = 1;
            SaveDelete.Text = "Deletar";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // SaveCreate
            // 
            SaveCreate.Location = new Point(72, 371);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(75, 23);
            SaveCreate.TabIndex = 2;
            SaveCreate.Text = "Cadastrar";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Click += SaveCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 68);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Id Usuario";
            // 
            // txtID
            // 
            txtID.Location = new Point(25, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(217, 21);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(411, 21);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 68);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // dataGridCRUD
            // 
            dataGridCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUD.Location = new Point(411, 203);
            dataGridCRUD.Name = "dataGridCRUD";
            dataGridCRUD.RowTemplate.Height = 25;
            dataGridCRUD.Size = new Size(389, 250);
            dataGridCRUD.TabIndex = 9;
            dataGridCRUD.CellClick += dataGridCRUD_CellContentClick;
            dataGridCRUD.CellContentClick += dataGridCRUD_CellContentClick;
            // 
            // AdministradorCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}