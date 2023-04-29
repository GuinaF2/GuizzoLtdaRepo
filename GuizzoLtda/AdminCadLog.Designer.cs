namespace GuizzoLtda
{
    partial class AdminCadLog
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
            components = new System.ComponentModel.Container();
            SaveCadastro = new Button();
            txtID = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DataGridUsuario = new DataGridView();
            conexaoBindingSource = new BindingSource(components);
            SaveUpdate = new Button();
            SaveDelete = new Button();
            label3 = new Label();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // SaveCadastro
            // 
            SaveCadastro.Location = new Point(-2, 363);
            SaveCadastro.Name = "SaveCadastro";
            SaveCadastro.Size = new Size(369, 87);
            SaveCadastro.TabIndex = 0;
            SaveCadastro.Text = "Cadastrar";
            SaveCadastro.UseVisualStyleBackColor = true;
            SaveCadastro.Click += button1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(39, 57);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(355, 57);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Id Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 25);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // DataGridUsuario
            // 
            DataGridUsuario.AutoGenerateColumns = false;
            DataGridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridUsuario.DataSource = conexaoBindingSource;
            DataGridUsuario.Location = new Point(364, 196);
            DataGridUsuario.Name = "DataGridUsuario";
            DataGridUsuario.RowTemplate.Height = 25;
            DataGridUsuario.Size = new Size(437, 254);
            DataGridUsuario.TabIndex = 5;
            DataGridUsuario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // conexaoBindingSource
            // 
            conexaoBindingSource.DataSource = typeof(Controle.Conexao);
            // 
            // SaveUpdate
            // 
            SaveUpdate.Location = new Point(-2, 279);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(369, 87);
            SaveUpdate.TabIndex = 6;
            SaveUpdate.Text = "Atualizar";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // SaveDelete
            // 
            SaveDelete.Location = new Point(-2, 196);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(369, 87);
            SaveDelete.TabIndex = 7;
            SaveDelete.Text = "Excluir";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 25);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(195, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 9;
            // 
            // AdminCadLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Controls.Add(DataGridUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtID);
            Controls.Add(SaveCadastro);
            Name = "AdminCadLog";
            Text = "AdminCadLog";
            Load += AdminCadLog_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveCadastro;
        private TextBox txtID;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private DataGridView DataGridUsuario;
        private BindingSource conexaoBindingSource;
        private Button SaveUpdate;
        private Button SaveDelete;
        private Label label3;
        private TextBox txtNome;
        private DataGridViewTextBoxColumn nome;
    }
}