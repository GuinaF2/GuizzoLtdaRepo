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
            this.dataGridCRUD = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelcargo = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.labelsenha = new System.Windows.Forms.Label();
            this.labelnome = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.SaveCreate = new System.Windows.Forms.Button();
            this.SaveUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCRUD
            // 
            this.dataGridCRUD.AllowUserToAddRows = false;
            this.dataGridCRUD.AllowUserToDeleteRows = false;
            this.dataGridCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCRUD.Location = new System.Drawing.Point(529, 20);
            this.dataGridCRUD.Name = "dataGridCRUD";
            this.dataGridCRUD.ReadOnly = true;
            this.dataGridCRUD.RowHeadersWidth = 51;
            this.dataGridCRUD.RowTemplate.Height = 25;
            this.dataGridCRUD.Size = new System.Drawing.Size(400, 486);
            this.dataGridCRUD.TabIndex = 36;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturn,
            this.btnAtualizar,
            this.toolStripSeparator1,
            this.btnCad,
            this.toolStripSeparator2,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 27);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(24, 24);
            this.btnReturn.Text = "Retornar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(57, 24);
            this.btnAtualizar.Text = "Atualizar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnCad
            // 
            this.btnCad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCad.Image = ((System.Drawing.Image)(resources.GetObject("btnCad.Image")));
            this.btnCad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(61, 24);
            this.btnCad.Text = "Cadastrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.ajudaToolStripButton.Text = "Aju&da";
            // 
            // labelcargo
            // 
            this.labelcargo.AutoSize = true;
            this.labelcargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelcargo.ForeColor = System.Drawing.Color.White;
            this.labelcargo.Location = new System.Drawing.Point(350, 44);
            this.labelcargo.Name = "labelcargo";
            this.labelcargo.Size = new System.Drawing.Size(39, 15);
            this.labelcargo.TabIndex = 38;
            this.labelcargo.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbCargo.Location = new System.Drawing.Point(411, 42);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(63, 23);
            this.cbCargo.TabIndex = 37;
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelsenha.ForeColor = System.Drawing.Color.White;
            this.labelsenha.Location = new System.Drawing.Point(66, 231);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(70, 30);
            this.labelsenha.TabIndex = 35;
            this.labelsenha.Text = "Senha";
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelnome.ForeColor = System.Drawing.Color.White;
            this.labelnome.Location = new System.Drawing.Point(66, 134);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(70, 30);
            this.labelnome.TabIndex = 34;
            this.labelnome.Text = "Nome";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(66, 277);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(125, 23);
            this.txtSenha.TabIndex = 33;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(66, 185);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 23);
            this.txtNome.TabIndex = 32;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(66, 93);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 23);
            this.txtID.TabIndex = 31;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelid.ForeColor = System.Drawing.Color.White;
            this.labelid.Location = new System.Drawing.Point(66, 44);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(107, 30);
            this.labelid.TabIndex = 30;
            this.labelid.Text = "Id Usuario";
            // 
            // SaveCreate
            // 
            this.SaveCreate.BackColor = System.Drawing.Color.Black;
            this.SaveCreate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCreate.ForeColor = System.Drawing.Color.Goldenrod;
            this.SaveCreate.Location = new System.Drawing.Point(94, 371);
            this.SaveCreate.Name = "SaveCreate";
            this.SaveCreate.Size = new System.Drawing.Size(300, 50);
            this.SaveCreate.TabIndex = 29;
            this.SaveCreate.Text = "Salvar Cadastro";
            this.SaveCreate.UseVisualStyleBackColor = false;
            this.SaveCreate.Visible = false;
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.BackColor = System.Drawing.Color.Black;
            this.SaveUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveUpdate.ForeColor = System.Drawing.Color.Goldenrod;
            this.SaveUpdate.Location = new System.Drawing.Point(94, 371);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(300, 50);
            this.SaveUpdate.TabIndex = 27;
            this.SaveUpdate.Text = "Salvar Alteração";
            this.SaveUpdate.UseVisualStyleBackColor = false;
            this.SaveUpdate.Visible = false;
            // 
            // CRUDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(929, 505);
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
            this.Controls.Add(this.SaveUpdate);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministradorCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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