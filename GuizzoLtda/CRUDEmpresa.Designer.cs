﻿namespace GuizzoLtda
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
            dataGridCRUDEmpresa = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            labelfoto = new Label();
            labelcnpj = new Label();
            labelrazaosocial = new Label();
            txtCnpj = new TextBox();
            txtRazaoSocial = new TextBox();
            txtIdEmpresa = new TextBox();
            labelid = new Label();
            SaveDelete = new Button();
            SaveUpdate = new Button();
            labelinscestad = new Label();
            txtInscEstadual = new TextBox();
            btnFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUDEmpresa).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCRUDEmpresa
            // 
            dataGridCRUDEmpresa.AllowUserToAddRows = false;
            dataGridCRUDEmpresa.AllowUserToDeleteRows = false;
            dataGridCRUDEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUDEmpresa.Location = new Point(411, -1);
            dataGridCRUDEmpresa.Name = "dataGridCRUDEmpresa";
            dataGridCRUDEmpresa.ReadOnly = true;
            dataGridCRUDEmpresa.RowTemplate.Height = 25;
            dataGridCRUDEmpresa.Size = new Size(389, 453);
            dataGridCRUDEmpresa.TabIndex = 23;
            dataGridCRUDEmpresa.CellClick += dataGridCRUDEmpresa_CellClick;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(23, 22);
            btnReturn.Text = "Retornar";
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(57, 22);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnApaga
            // 
            btnApaga.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(48, 22);
            btnApaga.Text = "Deletar";
            btnApaga.Click += btnApaga_Click;
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
            // labelfoto
            // 
            labelfoto.AutoSize = true;
            labelfoto.Location = new Point(85, 299);
            labelfoto.Name = "labelfoto";
            labelfoto.Size = new Size(72, 15);
            labelfoto.TabIndex = 25;
            labelfoto.Text = "Alterar Logo";
            // 
            // labelcnpj
            // 
            labelcnpj.AutoSize = true;
            labelcnpj.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelcnpj.Location = new Point(132, 154);
            labelcnpj.Name = "labelcnpj";
            labelcnpj.Size = new Size(55, 30);
            labelcnpj.TabIndex = 22;
            labelcnpj.Text = "Cnpj";
            // 
            // labelrazaosocial
            // 
            labelrazaosocial.AutoSize = true;
            labelrazaosocial.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelrazaosocial.Location = new Point(132, 98);
            labelrazaosocial.Name = "labelrazaosocial";
            labelrazaosocial.Size = new Size(130, 30);
            labelrazaosocial.TabIndex = 21;
            labelrazaosocial.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = Color.White;
            txtCnpj.Location = new Point(132, 187);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(125, 23);
            txtCnpj.TabIndex = 20;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.BackColor = Color.White;
            txtRazaoSocial.Location = new Point(132, 131);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(125, 23);
            txtRazaoSocial.TabIndex = 19;
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.BackColor = Color.White;
            txtIdEmpresa.Enabled = false;
            txtIdEmpresa.Location = new Point(132, 73);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(125, 23);
            txtIdEmpresa.TabIndex = 18;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelid.Location = new Point(132, 40);
            labelid.Name = "labelid";
            labelid.Size = new Size(116, 30);
            labelid.TabIndex = 17;
            labelid.Text = "Id Empresa";
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(50, 348);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(300, 50);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(50, 368);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // labelinscestad
            // 
            labelinscestad.AutoSize = true;
            labelinscestad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelinscestad.Location = new Point(132, 222);
            labelinscestad.Name = "labelinscestad";
            labelinscestad.Size = new Size(179, 30);
            labelinscestad.TabIndex = 28;
            labelinscestad.Text = "Inscrição Estadual";
            // 
            // txtInscEstadual
            // 
            txtInscEstadual.BackColor = Color.White;
            txtInscEstadual.Location = new Point(132, 255);
            txtInscEstadual.Name = "txtInscEstadual";
            txtInscEstadual.Size = new Size(125, 23);
            txtInscEstadual.TabIndex = 27;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(173, 295);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(75, 23);
            btnFoto.TabIndex = 29;
            btnFoto.Text = "Alterar";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += button1_Click;
            // 
            // CRUDEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFoto);
            Controls.Add(labelinscestad);
            Controls.Add(txtInscEstadual);
            Controls.Add(dataGridCRUDEmpresa);
            Controls.Add(toolStrip1);
            Controls.Add(labelfoto);
            Controls.Add(labelcnpj);
            Controls.Add(labelrazaosocial);
            Controls.Add(txtCnpj);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtIdEmpresa);
            Controls.Add(labelid);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Name = "CRUDEmpresa";
            Text = "CRUDEmpresa";
            Load += CRUDEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCRUDEmpresa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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