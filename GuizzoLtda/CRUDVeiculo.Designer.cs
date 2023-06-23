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
            labelseguro = new Label();
            txtIdVeic = new TextBox();
            labelIdVeic = new Label();
            cbTipo = new ComboBox();
            txtRenavam = new TextBox();
            labelrenavam = new Label();
            labelespecifics = new Label();
            labeldados = new Label();
            dataSeguro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridVeiculo).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridVeiculo
            // 
            dataGridVeiculo.AllowUserToAddRows = false;
            dataGridVeiculo.AllowUserToDeleteRows = false;
            dataGridVeiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVeiculo.Location = new Point(470, -1);
            dataGridVeiculo.Margin = new Padding(3, 4, 3, 4);
            dataGridVeiculo.Name = "dataGridVeiculo";
            dataGridVeiculo.ReadOnly = true;
            dataGridVeiculo.RowHeadersWidth = 51;
            dataGridVeiculo.RowTemplate.Height = 25;
            dataGridVeiculo.Size = new Size(445, 604);
            dataGridVeiculo.TabIndex = 23;
            dataGridVeiculo.CellClick += dataGridVeiculo_CellClick;
            dataGridVeiculo.CellContentClick += dataGridVeiculo_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1062, 27);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(29, 24);
            btnReturn.Text = "Retornar";
            btnReturn.Click += btnReturn_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(72, 24);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(76, 24);
            btnCad.Text = "Cadastrar";
            btnCad.Click += btnCad_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnApaga
            // 
            btnApaga.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(62, 24);
            btnApaga.Text = "Deletar";
            btnApaga.Click += btnApaga_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(29, 24);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.Location = new Point(49, 211);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(163, 37);
            labeltipo.TabIndex = 21;
            labeltipo.Text = "Tipo Veiculo";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.White;
            txtPlaca.Location = new Point(273, 335);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(142, 27);
            txtPlaca.TabIndex = 18;
            txtPlaca.KeyPress += txtPlaca_KeyPress;
            // 
            // labelplaca
            // 
            labelplaca.AutoSize = true;
            labelplaca.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelplaca.Location = new Point(265, 291);
            labelplaca.Name = "labelplaca";
            labelplaca.Size = new Size(172, 37);
            labelplaca.TabIndex = 17;
            labelplaca.Text = "Placa Veiculo";
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(57, 491);
            SaveCreate.Margin = new Padding(3, 4, 3, 4);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(343, 67);
            SaveCreate.TabIndex = 16;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Visible = false;
            SaveCreate.Click += SaveCreate_Click;
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(57, 491);
            SaveDelete.Margin = new Padding(3, 4, 3, 4);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(343, 67);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Deletar Usuário";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(57, 491);
            SaveUpdate.Margin = new Padding(3, 4, 3, 4);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(343, 67);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // labelseguro
            // 
            labelseguro.AutoSize = true;
            labelseguro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelseguro.Location = new Point(265, 193);
            labelseguro.Name = "labelseguro";
            labelseguro.Size = new Size(164, 37);
            labelseguro.TabIndex = 29;
            labelseguro.Text = "Data Seguro";
            // 
            // txtIdVeic
            // 
            txtIdVeic.BackColor = Color.White;
            txtIdVeic.Enabled = false;
            txtIdVeic.Location = new Point(57, 157);
            txtIdVeic.Margin = new Padding(3, 4, 3, 4);
            txtIdVeic.Name = "txtIdVeic";
            txtIdVeic.Size = new Size(142, 27);
            txtIdVeic.TabIndex = 31;
            // 
            // labelIdVeic
            // 
            labelIdVeic.AutoSize = true;
            labelIdVeic.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdVeic.Location = new Point(49, 113);
            labelIdVeic.Name = "labelIdVeic";
            labelIdVeic.Size = new Size(133, 37);
            labelIdVeic.TabIndex = 30;
            labelIdVeic.Text = "Id Veiculo";
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Carro", "Moto", "Caminhão", "Fiorino", "Manual" });
            cbTipo.Location = new Point(57, 255);
            cbTipo.Margin = new Padding(3, 4, 3, 4);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(138, 28);
            cbTipo.TabIndex = 32;
            // 
            // txtRenavam
            // 
            txtRenavam.Location = new Point(273, 143);
            txtRenavam.Margin = new Padding(3, 4, 3, 4);
            txtRenavam.Name = "txtRenavam";
            txtRenavam.Size = new Size(100, 27);
            txtRenavam.TabIndex = 34;
            txtRenavam.KeyPress += txtRenavam_KeyPress;
            // 
            // labelrenavam
            // 
            labelrenavam.AutoSize = true;
            labelrenavam.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelrenavam.Location = new Point(273, 99);
            labelrenavam.Name = "labelrenavam";
            labelrenavam.Size = new Size(125, 37);
            labelrenavam.TabIndex = 36;
            labelrenavam.Text = "Renavam";
            // 
            // labelespecifics
            // 
            labelespecifics.AutoSize = true;
            labelespecifics.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelespecifics.Location = new Point(26, 45);
            labelespecifics.Name = "labelespecifics";
            labelespecifics.Size = new Size(227, 25);
            labelespecifics.TabIndex = 37;
            labelespecifics.Text = "Especificações do Veículo";
            // 
            // labeldados
            // 
            labeldados.AutoSize = true;
            labeldados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeldados.Location = new Point(273, 43);
            labeldados.Name = "labeldados";
            labeldados.Size = new Size(68, 28);
            labeldados.TabIndex = 38;
            labeldados.Text = "Dados";
            // 
            // dataSeguro
            // 
            dataSeguro.Location = new Point(273, 237);
            dataSeguro.Margin = new Padding(3, 4, 3, 4);
            dataSeguro.Name = "dataSeguro";
            dataSeguro.Size = new Size(114, 27);
            dataSeguro.TabIndex = 39;
            dataSeguro.KeyPress += dataSeguro_KeyPress_1;
            // 
            // CRUDVeiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(dataSeguro);
            Controls.Add(labeldados);
            Controls.Add(labelespecifics);
            Controls.Add(labelrenavam);
            Controls.Add(txtRenavam);
            Controls.Add(cbTipo);
            Controls.Add(txtIdVeic);
            Controls.Add(labelIdVeic);
            Controls.Add(labelseguro);
            Controls.Add(dataGridVeiculo);
            Controls.Add(toolStrip1);
            Controls.Add(labeltipo);
            Controls.Add(txtPlaca);
            Controls.Add(labelplaca);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUDVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label labelseguro;
        private TextBox txtIdVeic;
        private Label labelIdVeic;
        private ComboBox cbTipo;
        private TextBox txtRenavam;
        private Label labelrenavam;
        private Label labelespecifics;
        private Label labeldados;
        private TextBox dataSeguro;
    }
}