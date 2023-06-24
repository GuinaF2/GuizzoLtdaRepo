namespace GuizzoLtda
{
    partial class CRUDEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDEmpresa));
            this.dataGridCRUDEmpresa = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnApaga = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelfoto = new System.Windows.Forms.Label();
            this.labelcnpj = new System.Windows.Forms.Label();
            this.labelrazaosocial = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.SaveDelete = new System.Windows.Forms.Button();
            this.SaveUpdate = new System.Windows.Forms.Button();
            this.labelinscestad = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUDEmpresa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCRUDEmpresa
            // 
            this.dataGridCRUDEmpresa.AllowUserToAddRows = false;
            this.dataGridCRUDEmpresa.AllowUserToDeleteRows = false;
            this.dataGridCRUDEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCRUDEmpresa.Location = new System.Drawing.Point(540, 20);
            this.dataGridCRUDEmpresa.Name = "dataGridCRUDEmpresa";
            this.dataGridCRUDEmpresa.ReadOnly = true;
            this.dataGridCRUDEmpresa.RowHeadersWidth = 51;
            this.dataGridCRUDEmpresa.RowTemplate.Height = 25;
            this.dataGridCRUDEmpresa.Size = new System.Drawing.Size(389, 422);
            this.dataGridCRUDEmpresa.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturn,
            this.btnAtualizar,
            this.toolStripSeparator1,
            this.btnApaga,
            this.toolStripSeparator,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 27);
            this.toolStrip1.TabIndex = 26;
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
            this.btnAtualizar.ForeColor = System.Drawing.Color.Goldenrod;
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
            // btnApaga
            // 
            this.btnApaga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnApaga.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(48, 24);
            this.btnApaga.Text = "Deletar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
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
            // labelfoto
            // 
            this.labelfoto.AutoSize = true;
            this.labelfoto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelfoto.ForeColor = System.Drawing.Color.White;
            this.labelfoto.Location = new System.Drawing.Point(441, 50);
            this.labelfoto.Name = "labelfoto";
            this.labelfoto.Size = new System.Drawing.Size(76, 15);
            this.labelfoto.TabIndex = 25;
            this.labelfoto.Text = "Alterar Logo";
            // 
            // labelcnpj
            // 
            this.labelcnpj.AutoSize = true;
            this.labelcnpj.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcnpj.Location = new System.Drawing.Point(90, 178);
            this.labelcnpj.Name = "labelcnpj";
            this.labelcnpj.Size = new System.Drawing.Size(57, 30);
            this.labelcnpj.TabIndex = 22;
            this.labelcnpj.Text = "Cnpj";
            // 
            // labelrazaosocial
            // 
            this.labelrazaosocial.AutoSize = true;
            this.labelrazaosocial.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelrazaosocial.Location = new System.Drawing.Point(90, 106);
            this.labelrazaosocial.Name = "labelrazaosocial";
            this.labelrazaosocial.Size = new System.Drawing.Size(133, 30);
            this.labelrazaosocial.TabIndex = 21;
            this.labelrazaosocial.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BackColor = System.Drawing.Color.White;
            this.txtCnpj.Location = new System.Drawing.Point(90, 222);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(206, 23);
            this.txtCnpj.TabIndex = 20;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.BackColor = System.Drawing.Color.White;
            this.txtRazaoSocial.Location = new System.Drawing.Point(90, 146);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(206, 23);
            this.txtRazaoSocial.TabIndex = 19;
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.BackColor = System.Drawing.Color.White;
            this.txtIdEmpresa.Enabled = false;
            this.txtIdEmpresa.Location = new System.Drawing.Point(90, 75);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(206, 23);
            this.txtIdEmpresa.TabIndex = 18;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelid.Location = new System.Drawing.Point(90, 37);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(121, 30);
            this.labelid.TabIndex = 17;
            this.labelid.Text = "Id Empresa";
            // 
            // SaveDelete
            // 
            this.SaveDelete.BackColor = System.Drawing.Color.Black;
            this.SaveDelete.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveDelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.SaveDelete.Location = new System.Drawing.Point(116, 340);
            this.SaveDelete.Name = "SaveDelete";
            this.SaveDelete.Size = new System.Drawing.Size(300, 50);
            this.SaveDelete.TabIndex = 15;
            this.SaveDelete.Text = "Salvar Alteração";
            this.SaveDelete.UseVisualStyleBackColor = false;
            this.SaveDelete.Visible = false;
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.BackColor = System.Drawing.Color.Black;
            this.SaveUpdate.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveUpdate.ForeColor = System.Drawing.Color.Goldenrod;
            this.SaveUpdate.Location = new System.Drawing.Point(116, 340);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(300, 50);
            this.SaveUpdate.TabIndex = 14;
            this.SaveUpdate.Text = "Salvar Alteração";
            this.SaveUpdate.UseVisualStyleBackColor = false;
            this.SaveUpdate.Visible = false;
            // 
            // labelinscestad
            // 
            this.labelinscestad.AutoSize = true;
            this.labelinscestad.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelinscestad.Location = new System.Drawing.Point(90, 254);
            this.labelinscestad.Name = "labelinscestad";
            this.labelinscestad.Size = new System.Drawing.Size(182, 30);
            this.labelinscestad.TabIndex = 28;
            this.labelinscestad.Text = "Inscrição Estadual";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.BackColor = System.Drawing.Color.White;
            this.txtInscEstadual.Location = new System.Drawing.Point(90, 295);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(206, 23);
            this.txtInscEstadual.TabIndex = 27;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.Black;
            this.btnFoto.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFoto.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnFoto.Location = new System.Drawing.Point(446, 70);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 29;
            this.btnFoto.Text = "Alterar";
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // CRUDEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.labelinscestad);
            this.Controls.Add(this.txtInscEstadual);
            this.Controls.Add(this.dataGridCRUDEmpresa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelfoto);
            this.Controls.Add(this.labelcnpj);
            this.Controls.Add(this.labelrazaosocial);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtIdEmpresa);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.SaveDelete);
            this.Controls.Add(this.SaveUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCRUDEmpresa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridCRUDEmpresa;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCad;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnApaga;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private Label labelfoto;
        private Label labelcnpj;
        private Label labelrazaosocial;
        private TextBox txtCnpj;
        private TextBox txtRazaoSocial;
        private TextBox txtIdEmpresa;
        private Label labelid;
        private Button SaveCreate;
        private Button SaveDelete;
        private Button SaveUpdate;
        private Label labelinscestad;
        private TextBox txtInscEstadual;
        private Button btnFoto;
    }
}