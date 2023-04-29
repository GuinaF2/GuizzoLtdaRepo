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
            this.components = new System.ComponentModel.Container();
            this.SaveCadastro = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridUsuario = new System.Windows.Forms.DataGridView();
            this.conexaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveUpdate = new System.Windows.Forms.Button();
            this.SaveDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveCadastro
            // 
            this.SaveCadastro.Location = new System.Drawing.Point(-2, 363);
            this.SaveCadastro.Name = "SaveCadastro";
            this.SaveCadastro.Size = new System.Drawing.Size(369, 87);
            this.SaveCadastro.TabIndex = 0;
            this.SaveCadastro.Text = "Cadastrar";
            this.SaveCadastro.UseVisualStyleBackColor = true;
            this.SaveCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(355, 57);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // DataGridUsuario
            // 
            this.DataGridUsuario.AutoGenerateColumns = false;
            this.DataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUsuario.DataSource = this.conexaoBindingSource;
            this.DataGridUsuario.Location = new System.Drawing.Point(364, 196);
            this.DataGridUsuario.Name = "DataGridUsuario";
            this.DataGridUsuario.RowTemplate.Height = 25;
            this.DataGridUsuario.Size = new System.Drawing.Size(437, 254);
            this.DataGridUsuario.TabIndex = 5;
            this.DataGridUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // conexaoBindingSource
            // 
            this.conexaoBindingSource.DataSource = typeof(Controle.Conexao);
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.Location = new System.Drawing.Point(-2, 279);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(369, 87);
            this.SaveUpdate.TabIndex = 6;
            this.SaveUpdate.Text = "Atualizar";
            this.SaveUpdate.UseVisualStyleBackColor = true;
            this.SaveUpdate.Click += new System.EventHandler(this.SaveUpdate_Click);
            // 
            // SaveDelete
            // 
            this.SaveDelete.Location = new System.Drawing.Point(-2, 196);
            this.SaveDelete.Name = "SaveDelete";
            this.SaveDelete.Size = new System.Drawing.Size(369, 87);
            this.SaveDelete.TabIndex = 7;
            this.SaveDelete.Text = "Excluir";
            this.SaveDelete.UseVisualStyleBackColor = true;
            this.SaveDelete.Click += new System.EventHandler(this.SaveDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(195, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 9;
            // 
            // AdminCadLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveDelete);
            this.Controls.Add(this.SaveUpdate);
            this.Controls.Add(this.DataGridUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.SaveCadastro);
            this.Name = "AdminCadLog";
            this.Text = "AdminCadLog";
            this.Load += new System.EventHandler(this.AdminCadLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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