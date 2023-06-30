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
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCad = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            labelrg = new Label();
            labelcpf = new Label();
            txtRg = new TextBox();
            txtCpf = new TextBox();
            txtIdMoto = new TextBox();
            labelIdMoto = new Label();
            SaveCreate = new Button();
            SaveDelete = new Button();
            SaveUpdate = new Button();
            labelNome = new Label();
            labelIdVeiculo = new Label();
            txtNome = new TextBox();
            txtIdVeiculo = new TextBox();
            labelcodigo = new Label();
            labelinfo = new Label();
            labelcnh = new Label();
            txtCnh = new TextBox();
            labeltipocnh = new Label();
            cbTipoCnh = new ComboBox();
            dataGridMotorista = new DataGridView();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMotorista).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, toolStripSeparator3, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 28);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(193, 11, 0);
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Goldenrod;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(73, 25);
            btnReturn.Text = "Menu";
            btnReturn.Click += btnReturn_Click_1;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.Goldenrod;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(103, 25);
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCad.ForeColor = Color.Goldenrod;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(86, 25);
            btnCad.Text = "Cadastrar";
            btnCad.Click += btnCad_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // btnApaga
            // 
            btnApaga.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApaga.ForeColor = Color.Goldenrod;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(90, 25);
            btnApaga.Text = "Deletar";
            btnApaga.Click += btnApaga_Click_1;
            // 
            // labelrg
            // 
            labelrg.AutoSize = true;
            labelrg.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelrg.ForeColor = SystemColors.ActiveCaptionText;
            labelrg.Location = new Point(53, 233);
            labelrg.Name = "labelrg";
            labelrg.Size = new Size(150, 30);
            labelrg.TabIndex = 22;
            labelrg.Text = "Registro Geral";
            // 
            // labelcpf
            // 
            labelcpf.AutoSize = true;
            labelcpf.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelcpf.ForeColor = SystemColors.ActiveCaptionText;
            labelcpf.Location = new Point(53, 162);
            labelcpf.Name = "labelcpf";
            labelcpf.Size = new Size(47, 30);
            labelcpf.TabIndex = 21;
            labelcpf.Text = "Cpf";
            // 
            // txtRg
            // 
            txtRg.BackColor = Color.Black;
            txtRg.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRg.ForeColor = Color.Goldenrod;
            txtRg.Location = new Point(53, 270);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(185, 27);
            txtRg.TabIndex = 20;
            txtRg.KeyPress += txtRg_KeyPress_1;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.Black;
            txtCpf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.ForeColor = Color.Goldenrod;
            txtCpf.Location = new Point(53, 200);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(185, 27);
            txtCpf.TabIndex = 19;
            txtCpf.KeyPress += txtCpf_KeyPress_1;
            // 
            // txtIdMoto
            // 
            txtIdMoto.BackColor = Color.Black;
            txtIdMoto.Enabled = false;
            txtIdMoto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdMoto.ForeColor = Color.Goldenrod;
            txtIdMoto.Location = new Point(334, 128);
            txtIdMoto.Name = "txtIdMoto";
            txtIdMoto.Size = new Size(125, 27);
            txtIdMoto.TabIndex = 18;
            // 
            // labelIdMoto
            // 
            labelIdMoto.AutoSize = true;
            labelIdMoto.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdMoto.ForeColor = SystemColors.ActiveCaptionText;
            labelIdMoto.Location = new Point(334, 97);
            labelIdMoto.Name = "labelIdMoto";
            labelIdMoto.Size = new Size(183, 30);
            labelIdMoto.TabIndex = 17;
            labelIdMoto.Text = "Codigo Motorista";
            // 
            // SaveCreate
            // 
            SaveCreate.BackColor = Color.Black;
            SaveCreate.FlatStyle = FlatStyle.Flat;
            SaveCreate.Font = new Font("Leelawadee UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.ForeColor = Color.Goldenrod;
            SaveCreate.Location = new Point(100, 409);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(334, 64);
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
            SaveDelete.Location = new Point(100, 424);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(300, 50);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = false;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click_1;
            // 
            // SaveUpdate
            // 
            SaveUpdate.BackColor = Color.Black;
            SaveUpdate.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.ForeColor = Color.Goldenrod;
            SaveUpdate.Location = new Point(100, 424);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = false;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click_1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = SystemColors.ActiveCaptionText;
            labelNome.Location = new Point(53, 97);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(73, 30);
            labelNome.TabIndex = 30;
            labelNome.Text = "Nome";
            // 
            // labelIdVeiculo
            // 
            labelIdVeiculo.AutoSize = true;
            labelIdVeiculo.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdVeiculo.ForeColor = SystemColors.ActiveCaptionText;
            labelIdVeiculo.Location = new Point(334, 167);
            labelIdVeiculo.Name = "labelIdVeiculo";
            labelIdVeiculo.Size = new Size(161, 30);
            labelIdVeiculo.TabIndex = 29;
            labelIdVeiculo.Text = "Codigo Veiculo";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Black;
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = Color.Goldenrod;
            txtNome.Location = new Point(53, 128);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 27);
            txtNome.TabIndex = 28;
            txtNome.KeyPress += txtNome_KeyPress_1;
            // 
            // txtIdVeiculo
            // 
            txtIdVeiculo.BackColor = Color.Black;
            txtIdVeiculo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdVeiculo.ForeColor = Color.Goldenrod;
            txtIdVeiculo.Location = new Point(334, 200);
            txtIdVeiculo.Name = "txtIdVeiculo";
            txtIdVeiculo.ReadOnly = true;
            txtIdVeiculo.Size = new Size(125, 27);
            txtIdVeiculo.TabIndex = 27;
            txtIdVeiculo.Click += txtIdVeiculo_Click_1;
            // 
            // labelcodigo
            // 
            labelcodigo.AutoSize = true;
            labelcodigo.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelcodigo.ForeColor = Color.Black;
            labelcodigo.Location = new Point(347, 41);
            labelcodigo.Name = "labelcodigo";
            labelcodigo.Size = new Size(122, 37);
            labelcodigo.TabIndex = 31;
            labelcodigo.Text = "Códigos";
            // 
            // labelinfo
            // 
            labelinfo.AutoSize = true;
            labelinfo.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelinfo.ForeColor = Color.Black;
            labelinfo.Location = new Point(53, 41);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(177, 37);
            labelinfo.TabIndex = 32;
            labelinfo.Text = "Informações";
            // 
            // labelcnh
            // 
            labelcnh.AutoSize = true;
            labelcnh.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelcnh.ForeColor = SystemColors.ActiveCaptionText;
            labelcnh.Location = new Point(53, 312);
            labelcnh.Name = "labelcnh";
            labelcnh.Size = new Size(233, 30);
            labelcnh.TabIndex = 34;
            labelcnh.Text = "Carteira de Habilitação";
            // 
            // txtCnh
            // 
            txtCnh.BackColor = Color.Black;
            txtCnh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnh.ForeColor = Color.Goldenrod;
            txtCnh.Location = new Point(53, 345);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(185, 27);
            txtCnh.TabIndex = 33;
            txtCnh.KeyPress += txtCnh_KeyPress_1;
            // 
            // labeltipocnh
            // 
            labeltipocnh.AutoSize = true;
            labeltipocnh.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipocnh.ForeColor = SystemColors.ActiveCaptionText;
            labeltipocnh.Location = new Point(334, 239);
            labeltipocnh.Name = "labeltipocnh";
            labeltipocnh.Size = new Size(169, 30);
            labeltipocnh.TabIndex = 36;
            labeltipocnh.Text = "Tipo de Carteira";
            // 
            // cbTipoCnh
            // 
            cbTipoCnh.FormattingEnabled = true;
            cbTipoCnh.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cbTipoCnh.Location = new Point(379, 273);
            cbTipoCnh.Name = "cbTipoCnh";
            cbTipoCnh.Size = new Size(55, 23);
            cbTipoCnh.TabIndex = 37;
            // 
            // dataGridMotorista
            // 
            dataGridMotorista.AllowUserToAddRows = false;
            dataGridMotorista.AllowUserToDeleteRows = false;
            dataGridMotorista.BackgroundColor = Color.Black;
            dataGridMotorista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMotorista.GridColor = Color.Black;
            dataGridMotorista.Location = new Point(538, 27);
            dataGridMotorista.Name = "dataGridMotorista";
            dataGridMotorista.ReadOnly = true;
            dataGridMotorista.RowTemplate.Height = 25;
            dataGridMotorista.Size = new Size(391, 480);
            dataGridMotorista.TabIndex = 38;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // CRUDMotorista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(929, 505);
            Controls.Add(cbTipoCnh);
            Controls.Add(labeltipocnh);
            Controls.Add(labelcnh);
            Controls.Add(txtCnh);
            Controls.Add(labelinfo);
            Controls.Add(labelcodigo);
            Controls.Add(labelNome);
            Controls.Add(labelIdVeiculo);
            Controls.Add(txtNome);
            Controls.Add(txtIdVeiculo);
            Controls.Add(toolStrip1);
            Controls.Add(labelrg);
            Controls.Add(labelcpf);
            Controls.Add(txtRg);
            Controls.Add(txtCpf);
            Controls.Add(txtIdMoto);
            Controls.Add(labelIdMoto);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Controls.Add(dataGridMotorista);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CRUDMotorista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDMotorista";
            Load += CRUDMotorista_Load_1;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMotorista).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label labelrg;
        private Label labelcpf;
        private TextBox txtRg;
        private TextBox txtCpf;
        private TextBox txtIdMoto;
        private Label labelIdMoto;
        private Button SaveCreate;
        private Button SaveDelete;
        private Button SaveUpdate;
        private Label labelNome;
        private Label labelIdVeiculo;
        private TextBox txtNome;
        private TextBox txtIdVeiculo;
        private Label labelcodigo;
        private Label labelinfo;
        private Label labelcnh;
        private TextBox txtCnh;
        private Label labeltipocnh;
        private ComboBox cbTipoCnh;
        private Label labelidcliente;
        private TextBox txtIdEmpresa;
        private DataGridView dataGridView1;
        private ToolStripSeparator toolStripSeparator3;
    }
}