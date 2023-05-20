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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).BeginInit();
            SuspendLayout();
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(25, 253);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(351, 52);
            SaveUpdate.TabIndex = 0;
            SaveUpdate.Text = "Atualizar";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(25, 318);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(351, 52);
            SaveDelete.TabIndex = 1;
            SaveDelete.Text = "Deletar";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Click += SaveDelete_Click_1;
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(25, 385);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(351, 52);
            SaveCreate.TabIndex = 2;
            SaveCreate.Text = "Cadastrar";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Click += SaveCreate_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(220, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 3;
            label1.Text = "Id Usuario";
            // 
            // txtID
            // 
            txtID.Location = new Point(220, 62);
            txtID.Name = "txtID";
            txtID.Size = new Size(133, 23);
            txtID.TabIndex = 4;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(220, 134);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(133, 23);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(220, 206);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(133, 23);
            txtSenha.TabIndex = 6;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(220, 160);
            label3.Name = "label3";
            label3.Size = new Size(70, 30);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // dataGridCRUD
            // 
            dataGridCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUD.Location = new Point(411, 0);
            dataGridCRUD.Name = "dataGridCRUD";
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
            button1.Location = new Point(-4, 0);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 10;
            button1.Text = "Retornar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdministradorCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}