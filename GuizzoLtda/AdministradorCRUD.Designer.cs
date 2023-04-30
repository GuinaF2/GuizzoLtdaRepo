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
            this.SaveUpdate = new System.Windows.Forms.Button();
            this.SaveDelete = new System.Windows.Forms.Button();
            this.SaveCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridCRUD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.Location = new System.Drawing.Point(25, 246);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(325, 59);
            this.SaveUpdate.TabIndex = 0;
            this.SaveUpdate.Text = "Atualizar";
            this.SaveUpdate.UseVisualStyleBackColor = true;
            // 
            // SaveDelete
            // 
            this.SaveDelete.Location = new System.Drawing.Point(25, 311);
            this.SaveDelete.Name = "SaveDelete";
            this.SaveDelete.Size = new System.Drawing.Size(325, 59);
            this.SaveDelete.TabIndex = 1;
            this.SaveDelete.Text = "Deletar";
            this.SaveDelete.UseVisualStyleBackColor = true;
            // 
            // SaveCreate
            // 
            this.SaveCreate.Location = new System.Drawing.Point(25, 378);
            this.SaveCreate.Name = "SaveCreate";
            this.SaveCreate.Size = new System.Drawing.Size(325, 59);
            this.SaveCreate.TabIndex = 2;
            this.SaveCreate.Text = "Cadastrar";
            this.SaveCreate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(25, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(133, 23);
            this.txtID.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 23);
            this.txtNome.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(25, 197);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(133, 23);
            this.txtSenha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // dataGridCRUD
            // 
            this.dataGridCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCRUD.Location = new System.Drawing.Point(411, 0);
            this.dataGridCRUD.Name = "dataGridCRUD";
            this.dataGridCRUD.RowTemplate.Height = 25;
            this.dataGridCRUD.Size = new System.Drawing.Size(389, 453);
            this.dataGridCRUD.TabIndex = 9;
            this.dataGridCRUD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCRUD_CellContentClick_1);
            // 
            // AdministradorCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridCRUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveCreate);
            this.Controls.Add(this.SaveDelete);
            this.Controls.Add(this.SaveUpdate);
            this.Name = "AdministradorCRUD";
            this.Text = "AdministradorCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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