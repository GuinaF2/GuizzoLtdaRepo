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
            dataSeguro = new TextBox();
            toolStripSeparator3 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)dataGridVeiculo).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridVeiculo
            // 
            dataGridVeiculo.AllowUserToAddRows = false;
            dataGridVeiculo.AllowUserToDeleteRows = false;
            dataGridVeiculo.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridVeiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVeiculo.Location = new Point(601, 27);
            dataGridVeiculo.Margin = new Padding(3, 4, 3, 4);
            dataGridVeiculo.Name = "dataGridVeiculo";
            dataGridVeiculo.ReadOnly = true;
            dataGridVeiculo.RowHeadersWidth = 51;
            dataGridVeiculo.RowTemplate.Height = 25;
            dataGridVeiculo.Size = new Size(461, 648);
            dataGridVeiculo.TabIndex = 23;
            dataGridVeiculo.CellClick += dataGridVeiculo_CellClick_1;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, toolStripSeparator3, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1062, 27);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(173, 11, 0);
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(73, 24);
            btnReturn.Text = "Menu";
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(173, 11, 0);
            btnAtualizar.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.Goldenrod;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(96, 24);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnCad
            // 
            btnCad.BackColor = Color.FromArgb(173, 11, 0);
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCad.ForeColor = Color.Goldenrod;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(80, 24);
            btnCad.Text = "Cadastrar";
            btnCad.Click += btnCad_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnApaga
            // 
            btnApaga.BackColor = Color.FromArgb(173, 11, 0);
            btnApaga.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnApaga.ForeColor = Color.Goldenrod;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(84, 24);
            btnApaga.Text = "Deletar";
            btnApaga.Click += btnApaga_Click_1;
            // 
            // labeltipo
            // 
            labeltipo.AutoSize = true;
            labeltipo.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipo.ForeColor = Color.White;
            labeltipo.Location = new Point(210, 348);
            labeltipo.Name = "labeltipo";
            labeltipo.Size = new Size(133, 30);
            labeltipo.TabIndex = 21;
            labeltipo.Text = "Tipo Veiculo";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.Black;
            txtPlaca.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlaca.ForeColor = Color.Goldenrod;
            txtPlaca.Location = new Point(337, 289);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(170, 27);
            txtPlaca.TabIndex = 18;
            txtPlaca.KeyPress += txtPlaca_KeyPress_1;
            // 
            // labelplaca
            // 
            labelplaca.AutoSize = true;
            labelplaca.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelplaca.ForeColor = Color.Black;
            labelplaca.Location = new Point(337, 220);
            labelplaca.Name = "labelplaca";
            labelplaca.Size = new Size(139, 30);
            labelplaca.TabIndex = 17;
            labelplaca.Text = "Placa Veiculo";
            // 
            // SaveCreate
            // 
            SaveCreate.BackColor = Color.Black;
            SaveCreate.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.ForeColor = Color.Goldenrod;
            SaveCreate.Location = new Point(127, 576);
            SaveCreate.Margin = new Padding(3, 4, 3, 4);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(343, 67);
            SaveCreate.TabIndex = 16;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = false;
            SaveCreate.Visible = false;
            SaveCreate.Click += SaveCreate_Click_1;
            // 
            // SaveDelete
            // 
            SaveDelete.BackColor = Color.Black;
            SaveDelete.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.ForeColor = Color.Goldenrod;
            SaveDelete.Location = new Point(127, 576);
            SaveDelete.Margin = new Padding(3, 4, 3, 4);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(343, 67);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Deletar Usuário";
            SaveDelete.UseVisualStyleBackColor = false;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click_1;
            // 
            // SaveUpdate
            // 
            SaveUpdate.BackColor = Color.Black;
            SaveUpdate.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.ForeColor = Color.Goldenrod;
            SaveUpdate.Location = new Point(127, 576);
            SaveUpdate.Margin = new Padding(3, 4, 3, 4);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(343, 67);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = false;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // labelseguro
            // 
            labelseguro.AutoSize = true;
            labelseguro.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelseguro.ForeColor = Color.Black;
            labelseguro.Location = new Point(337, 106);
            labelseguro.Name = "labelseguro";
            labelseguro.Size = new Size(133, 30);
            labelseguro.TabIndex = 29;
            labelseguro.Text = "Data Seguro";
            // 
            // txtIdVeic
            // 
            txtIdVeic.BackColor = Color.Black;
            txtIdVeic.Enabled = false;
            txtIdVeic.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdVeic.ForeColor = Color.Goldenrod;
            txtIdVeic.Location = new Point(80, 181);
            txtIdVeic.Margin = new Padding(3, 4, 3, 4);
            txtIdVeic.Name = "txtIdVeic";
            txtIdVeic.Size = new Size(170, 27);
            txtIdVeic.TabIndex = 31;
            // 
            // labelIdVeic
            // 
            labelIdVeic.AutoSize = true;
            labelIdVeic.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdVeic.ForeColor = Color.Black;
            labelIdVeic.Location = new Point(80, 106);
            labelIdVeic.Name = "labelIdVeic";
            labelIdVeic.Size = new Size(109, 30);
            labelIdVeic.TabIndex = 30;
            labelIdVeic.Text = "Id Veiculo";
            // 
            // cbTipo
            // 
            cbTipo.BackColor = Color.Black;
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.ForeColor = Color.White;
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Carro", "Moto", "Caminhão", "Fiorino", "Manual" });
            cbTipo.Location = new Point(210, 410);
            cbTipo.Margin = new Padding(3, 4, 3, 4);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(170, 23);
            cbTipo.TabIndex = 32;
            // 
            // txtRenavam
            // 
            txtRenavam.BackColor = Color.Black;
            txtRenavam.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRenavam.ForeColor = Color.Goldenrod;
            txtRenavam.Location = new Point(80, 289);
            txtRenavam.Margin = new Padding(3, 4, 3, 4);
            txtRenavam.Name = "txtRenavam";
            txtRenavam.Size = new Size(170, 27);
            txtRenavam.TabIndex = 34;
            txtRenavam.KeyPress += txtRenavam_KeyPress_1;
            // 
            // labelrenavam
            // 
            labelrenavam.AutoSize = true;
            labelrenavam.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelrenavam.ForeColor = Color.Black;
            labelrenavam.Location = new Point(80, 220);
            labelrenavam.Name = "labelrenavam";
            labelrenavam.Size = new Size(102, 30);
            labelrenavam.TabIndex = 36;
            labelrenavam.Text = "Renavam";
            // 
            // labelespecifics
            // 
            labelespecifics.AutoSize = true;
            labelespecifics.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelespecifics.ForeColor = Color.Black;
            labelespecifics.Location = new Point(153, 53);
            labelespecifics.Name = "labelespecifics";
            labelespecifics.Size = new Size(307, 32);
            labelespecifics.TabIndex = 37;
            labelespecifics.Text = "Especificações do Veículo";
            // 
            // dataSeguro
            // 
            dataSeguro.BackColor = Color.Black;
            dataSeguro.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataSeguro.ForeColor = Color.Goldenrod;
            dataSeguro.Location = new Point(337, 181);
            dataSeguro.Margin = new Padding(3, 4, 3, 4);
            dataSeguro.Name = "dataSeguro";
            dataSeguro.Size = new Size(170, 27);
            dataSeguro.TabIndex = 39;
            dataSeguro.KeyPress += dataSeguro_KeyPress_2;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // CRUDVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(1062, 673);
            Controls.Add(dataSeguro);
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
            Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Goldenrod;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUDVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDVeiculo";
            Load += CRUDVeiculo_Load_1;
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
        private TextBox dataSeguro;
        private ToolStripSeparator toolStripSeparator3;
    }
}