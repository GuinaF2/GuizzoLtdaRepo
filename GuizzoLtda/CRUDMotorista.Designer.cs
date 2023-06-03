namespace GuizzoLtda
{
    partial class CRUDMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDMotorista));
            this.dataGridMotorista = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnApaga = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labelrg = new System.Windows.Forms.Label();
            this.labelcpf = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtIdMoto = new System.Windows.Forms.TextBox();
            this.labelIdMoto = new System.Windows.Forms.Label();
            this.SaveCreate = new System.Windows.Forms.Button();
            this.SaveDelete = new System.Windows.Forms.Button();
            this.SaveUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotorista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMotorista
            // 
            this.dataGridMotorista.AllowUserToAddRows = false;
            this.dataGridMotorista.AllowUserToDeleteRows = false;
            this.dataGridMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMotorista.Location = new System.Drawing.Point(411, -1);
            this.dataGridMotorista.Name = "dataGridMotorista";
            this.dataGridMotorista.ReadOnly = true;
            this.dataGridMotorista.RowTemplate.Height = 25;
            this.dataGridMotorista.Size = new System.Drawing.Size(389, 453);
            this.dataGridMotorista.TabIndex = 23;
            this.dataGridMotorista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMotorista_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturn,
            this.btnAtualizar,
            this.toolStripSeparator1,
            this.btnCad,
            this.toolStripSeparator2,
            this.btnApaga,
            this.toolStripSeparator,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            this.btnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(23, 22);
            this.btnReturn.Text = "Retornar";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(57, 22);
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCad
            // 
            this.btnCad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCad.Image = ((System.Drawing.Image)(resources.GetObject("btnCad.Image")));
            this.btnCad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(61, 22);
            this.btnCad.Text = "Cadastrar";
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnApaga
            // 
            this.btnApaga.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(48, 22);
            this.btnApaga.Text = "Deletar";
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "Aju&da";
            // 
            // labelrg
            // 
            this.labelrg.AutoSize = true;
            this.labelrg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelrg.Location = new System.Drawing.Point(135, 198);
            this.labelrg.Name = "labelrg";
            this.labelrg.Size = new System.Drawing.Size(142, 30);
            this.labelrg.TabIndex = 22;
            this.labelrg.Text = "Registro Geral";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcpf.Location = new System.Drawing.Point(135, 126);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(45, 30);
            this.labelcpf.TabIndex = 21;
            this.labelcpf.Text = "Cpf";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.Color.White;
            this.txtRg.Location = new System.Drawing.Point(135, 231);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(125, 23);
            this.txtRg.TabIndex = 20;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.Location = new System.Drawing.Point(135, 159);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(125, 23);
            this.txtCpf.TabIndex = 19;
            // 
            // txtIdMoto
            // 
            this.txtIdMoto.BackColor = System.Drawing.Color.White;
            this.txtIdMoto.Enabled = false;
            this.txtIdMoto.Location = new System.Drawing.Point(135, 100);
            this.txtIdMoto.Name = "txtIdMoto";
            this.txtIdMoto.Size = new System.Drawing.Size(125, 23);
            this.txtIdMoto.TabIndex = 18;
            // 
            // labelIdMoto
            // 
            this.labelIdMoto.AutoSize = true;
            this.labelIdMoto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdMoto.Location = new System.Drawing.Point(135, 67);
            this.labelIdMoto.Name = "labelIdMoto";
            this.labelIdMoto.Size = new System.Drawing.Size(126, 30);
            this.labelIdMoto.TabIndex = 17;
            this.labelIdMoto.Text = "Id Motorista";
            // 
            // SaveCreate
            // 
            this.SaveCreate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCreate.Location = new System.Drawing.Point(50, 368);
            this.SaveCreate.Name = "SaveCreate";
            this.SaveCreate.Size = new System.Drawing.Size(300, 50);
            this.SaveCreate.TabIndex = 16;
            this.SaveCreate.Text = "Salvar Cadastro";
            this.SaveCreate.UseVisualStyleBackColor = true;
            this.SaveCreate.Visible = false;
            this.SaveCreate.Click += new System.EventHandler(this.SaveCreate_Click);
            // 
            // SaveDelete
            // 
            this.SaveDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveDelete.Location = new System.Drawing.Point(50, 368);
            this.SaveDelete.Name = "SaveDelete";
            this.SaveDelete.Size = new System.Drawing.Size(300, 50);
            this.SaveDelete.TabIndex = 15;
            this.SaveDelete.Text = "Salvar Alteração";
            this.SaveDelete.UseVisualStyleBackColor = true;
            this.SaveDelete.Visible = false;
            this.SaveDelete.Click += new System.EventHandler(this.SaveDelete_Click);
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveUpdate.Location = new System.Drawing.Point(50, 368);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(300, 50);
            this.SaveUpdate.TabIndex = 14;
            this.SaveUpdate.Text = "Salvar Alteração";
            this.SaveUpdate.UseVisualStyleBackColor = true;
            this.SaveUpdate.Visible = false;
            this.SaveUpdate.Click += new System.EventHandler(this.SaveUpdate_Click);
            // 
            // CRUDMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridMotorista);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelrg);
            this.Controls.Add(this.labelcpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtIdMoto);
            this.Controls.Add(this.labelIdMoto);
            this.Controls.Add(this.SaveCreate);
            this.Controls.Add(this.SaveDelete);
            this.Controls.Add(this.SaveUpdate);
            this.Name = "CRUDMotorista";
            this.Text = "CRUDMotorista";
            this.Load += new System.EventHandler(this.CRUDMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotorista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridMotorista;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCad;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnApaga;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private Label labelrg;
        private Label labelcpf;
        private TextBox txtRg;
        private TextBox txtCpf;
        private TextBox txtIdMoto;
        private Label labelIdMoto;
        private Button SaveCreate;
        private Button SaveDelete;
        private Button SaveUpdate;
    }
}