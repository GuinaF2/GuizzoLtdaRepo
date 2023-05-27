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
            dataGridVeiculo = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCad = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            labeltipo = new Label();
            txtPlaca = new TextBox();
            labelplaca = new Label();
            SaveCreate = new Button();
            SaveDelete = new Button();
            SaveUpdate = new Button();
            dataSeguro = new DateTimePicker();
            labelseguro = new Label();
            txtIdVeic = new TextBox();
            labelIdVeic = new Label();
            cbTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridVeiculo).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridVeiculo
            // 
            dataGridVeiculo.AllowUserToAddRows = false;
            dataGridVeiculo.AllowUserToDeleteRows = false;
            dataGridVeiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVeiculo.Location = new Point(411, -1);
            dataGridVeiculo.Name = "dataGridVeiculo";
            dataGridVeiculo.ReadOnly = true;
            dataGridVeiculo.RowTemplate.Height = 25;
            dataGridVeiculo.Size = new Size(389, 453);
            dataGridVeiculo.TabIndex = 23;
            dataGridVeiculo.CellClick += dataGridVeiculo_CellClick;
            dataGridVeiculo.CellContentClick += dataGridVeiculo_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga, toolStripSeparator, ajudaToolStripButton });
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
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(61, 22);
            btnCad.Text = "Cadastrar";
            btnCad.Click += btnCad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
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
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.Location = new Point(115, 205);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(126, 30);
            labeltipo.TabIndex = 21;
            labeltipo.Text = "Tipo Veiculo";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.White;
            txtPlaca.Location = new Point(122, 179);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(125, 23);
            txtPlaca.TabIndex = 18;
            // 
            // labelplaca
            // 
            labelplaca.AutoSize = true;
            labelplaca.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelplaca.Location = new Point(115, 146);
            labelplaca.Name = "labelplaca";
            labelplaca.Size = new Size(135, 30);
            labelplaca.TabIndex = 17;
            labelplaca.Text = "Placa Veiculo";
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(50, 368);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(300, 50);
            SaveCreate.TabIndex = 16;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Visible = false;
            SaveCreate.Click += SaveCreate_Click;
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(50, 368);
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
            // dataSeguro
            // 
            dataSeguro.CustomFormat = "00/00/0000";
            dataSeguro.Location = new Point(173, 290);
            dataSeguro.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dataSeguro.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dataSeguro.Name = "dataSeguro";
            dataSeguro.Size = new Size(200, 23);
            dataSeguro.TabIndex = 27;
            dataSeguro.Value = new DateTime(2023, 5, 27, 0, 0, 0, 0);
            dataSeguro.ValueChanged += dataSeguro_ValueChanged;
            // 
            // labelseguro
            // 
            labelseguro.AutoSize = true;
            labelseguro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelseguro.Location = new Point(25, 284);
            labelseguro.Name = "labelseguro";
            labelseguro.Size = new Size(128, 30);
            labelseguro.TabIndex = 29;
            labelseguro.Text = "Data Seguro";
            // 
            // txtIdVeic
            // 
            txtIdVeic.BackColor = Color.White;
            txtIdVeic.Enabled = false;
            txtIdVeic.Location = new Point(122, 108);
            txtIdVeic.Name = "txtIdVeic";
            txtIdVeic.Size = new Size(125, 23);
            txtIdVeic.TabIndex = 31;
            // 
            // labelIdVeic
            // 
            labelIdVeic.AutoSize = true;
            labelIdVeic.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdVeic.Location = new Point(115, 75);
            labelIdVeic.Name = "labelIdVeic";
            labelIdVeic.Size = new Size(104, 30);
            labelIdVeic.TabIndex = 30;
            labelIdVeic.Text = "Id Veiculo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Carro", "Moto", "Caminhão", "Fiorino", "Manual" });
            cbTipo.Location = new Point(122, 238);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 32;
            // 
            // CRUDVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbTipo);
            Controls.Add(txtIdVeic);
            Controls.Add(labelIdVeic);
            Controls.Add(labelseguro);
            Controls.Add(dataSeguro);
            Controls.Add(dataGridVeiculo);
            Controls.Add(toolStrip1);
            Controls.Add(labeltipo);
            Controls.Add(txtPlaca);
            Controls.Add(labelplaca);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Name = "CRUDVeiculo";
            Text = "CRUDVeiculo";
            Load += CRUDVeiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridVeiculo).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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