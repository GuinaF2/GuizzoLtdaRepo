namespace GuizzoLtda
{
    partial class CRUDVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDVeiculo));
            this.dataGridVeiculo = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnApaga = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.labeltipo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.labelplaca = new System.Windows.Forms.Label();
            this.SaveCreate = new System.Windows.Forms.Button();
            this.SaveDelete = new System.Windows.Forms.Button();
            this.SaveUpdate = new System.Windows.Forms.Button();
            this.dataSeguro = new System.Windows.Forms.DateTimePicker();
            this.labelseguro = new System.Windows.Forms.Label();
            this.txtIdVeic = new System.Windows.Forms.TextBox();
            this.labelIdVeic = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVeiculo
            // 
            this.dataGridVeiculo.AllowUserToAddRows = false;
            this.dataGridVeiculo.AllowUserToDeleteRows = false;
            this.dataGridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeiculo.Location = new System.Drawing.Point(411, -1);
            this.dataGridVeiculo.Name = "dataGridVeiculo";
            this.dataGridVeiculo.ReadOnly = true;
            this.dataGridVeiculo.RowTemplate.Height = 25;
            this.dataGridVeiculo.Size = new System.Drawing.Size(389, 453);
            this.dataGridVeiculo.TabIndex = 23;
            this.dataGridVeiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVeiculo_CellClick);
            this.dataGridVeiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVeiculo_CellContentClick);
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
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
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
            // labeltipo
            // 
            this.labeltipo.AutoSize = true;
            this.labeltipo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltipo.Location = new System.Drawing.Point(115, 205);
            this.labeltipo.Name = "labeltipo";
            this.labeltipo.Size = new System.Drawing.Size(126, 30);
            this.labeltipo.TabIndex = 21;
            this.labeltipo.Text = "Tipo Veiculo";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.White;
            this.txtPlaca.Location = new System.Drawing.Point(122, 179);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(125, 23);
            this.txtPlaca.TabIndex = 18;
            // 
            // labelplaca
            // 
            this.labelplaca.AutoSize = true;
            this.labelplaca.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelplaca.Location = new System.Drawing.Point(115, 146);
            this.labelplaca.Name = "labelplaca";
            this.labelplaca.Size = new System.Drawing.Size(135, 30);
            this.labelplaca.TabIndex = 17;
            this.labelplaca.Text = "Placa Veiculo";
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
            // dataSeguro
            // 
            this.dataSeguro.CustomFormat = "00/00/0000";
            this.dataSeguro.Location = new System.Drawing.Point(173, 290);
            this.dataSeguro.Name = "dataSeguro";
            this.dataSeguro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataSeguro.Size = new System.Drawing.Size(200, 23);
            this.dataSeguro.TabIndex = 27;
            this.dataSeguro.Value = new System.DateTime(2023, 5, 30, 0, 0, 0, 0);
            // 
            // labelseguro
            // 
            this.labelseguro.AutoSize = true;
            this.labelseguro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelseguro.Location = new System.Drawing.Point(25, 284);
            this.labelseguro.Name = "labelseguro";
            this.labelseguro.Size = new System.Drawing.Size(128, 30);
            this.labelseguro.TabIndex = 29;
            this.labelseguro.Text = "Data Seguro";
            // 
            // txtIdVeic
            // 
            this.txtIdVeic.BackColor = System.Drawing.Color.White;
            this.txtIdVeic.Enabled = false;
            this.txtIdVeic.Location = new System.Drawing.Point(122, 108);
            this.txtIdVeic.Name = "txtIdVeic";
            this.txtIdVeic.Size = new System.Drawing.Size(125, 23);
            this.txtIdVeic.TabIndex = 31;
            // 
            // labelIdVeic
            // 
            this.labelIdVeic.AutoSize = true;
            this.labelIdVeic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdVeic.Location = new System.Drawing.Point(115, 75);
            this.labelIdVeic.Name = "labelIdVeic";
            this.labelIdVeic.Size = new System.Drawing.Size(104, 30);
            this.labelIdVeic.TabIndex = 30;
            this.labelIdVeic.Text = "Id Veiculo";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Caminhão",
            "Fiorino",
            "Manual"});
            this.cbTipo.Location = new System.Drawing.Point(122, 238);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 23);
            this.cbTipo.TabIndex = 32;
            // 
            // CRUDVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtIdVeic);
            this.Controls.Add(this.labelIdVeic);
            this.Controls.Add(this.labelseguro);
            this.Controls.Add(this.dataSeguro);
            this.Controls.Add(this.dataGridVeiculo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labeltipo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.labelplaca);
            this.Controls.Add(this.SaveCreate);
            this.Controls.Add(this.SaveDelete);
            this.Controls.Add(this.SaveUpdate);
            this.Name = "CRUDVeiculo";
            this.Text = "CRUDVeiculo";
            this.Load += new System.EventHandler(this.CRUDVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridVeiculo;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCad;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnApaga;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private Label labeltipo;
        private TextBox txtPlaca;
        private Label labelplaca;
        private Button SaveCreate;
        private Button SaveDelete;
        private Button SaveUpdate;
        private DateTimePicker dataSeguro;
        private Label labelseguro;
        private TextBox txtIdVeic;
        private Label labelIdVeic;
        private ComboBox cbTipo;
    }
}