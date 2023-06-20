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
            dataGridMotorista = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCad = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)dataGridMotorista).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridMotorista
            // 
            dataGridMotorista.AllowUserToAddRows = false;
            dataGridMotorista.AllowUserToDeleteRows = false;
            dataGridMotorista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMotorista.Location = new Point(411, -1);
            dataGridMotorista.Name = "dataGridMotorista";
            dataGridMotorista.ReadOnly = true;
            dataGridMotorista.RowTemplate.Height = 25;
            dataGridMotorista.Size = new Size(389, 453);
            dataGridMotorista.TabIndex = 23;
            dataGridMotorista.CellClick += dataGridMotorista_CellClick;
            dataGridMotorista.CellContentClick += dataGridMotorista_CellContentClick;
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
            // labelrg
            // 
            labelrg.AutoSize = true;
            labelrg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelrg.Location = new Point(243, 198);
            labelrg.Name = "labelrg";
            labelrg.Size = new Size(142, 30);
            labelrg.TabIndex = 22;
            labelrg.Text = "Registro Geral";
            // 
            // labelcpf
            // 
            labelcpf.AutoSize = true;
            labelcpf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelcpf.Location = new Point(243, 136);
            labelcpf.Name = "labelcpf";
            labelcpf.Size = new Size(45, 30);
            labelcpf.TabIndex = 21;
            labelcpf.Text = "Cpf";
            // 
            // txtRg
            // 
            txtRg.BackColor = Color.White;
            txtRg.Location = new Point(243, 231);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(125, 23);
            txtRg.TabIndex = 20;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.White;
            txtCpf.Location = new Point(243, 169);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(125, 23);
            txtCpf.TabIndex = 19;
            // 
            // txtIdMoto
            // 
            txtIdMoto.BackColor = Color.White;
            txtIdMoto.Enabled = false;
            txtIdMoto.Location = new Point(22, 131);
            txtIdMoto.Name = "txtIdMoto";
            txtIdMoto.Size = new Size(125, 23);
            txtIdMoto.TabIndex = 18;
            // 
            // labelIdMoto
            // 
            labelIdMoto.AutoSize = true;
            labelIdMoto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdMoto.Location = new Point(22, 98);
            labelIdMoto.Name = "labelIdMoto";
            labelIdMoto.Size = new Size(174, 30);
            labelIdMoto.TabIndex = 17;
            labelIdMoto.Text = "Codigo Motorista";
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(51, 367);
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
            SaveDelete.Location = new Point(51, 367);
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
            SaveUpdate.Location = new Point(51, 367);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(243, 77);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(70, 30);
            labelNome.TabIndex = 30;
            labelNome.Text = "Nome";
            // 
            // labelIdVeiculo
            // 
            labelIdVeiculo.AutoSize = true;
            labelIdVeiculo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdVeiculo.Location = new Point(22, 157);
            labelIdVeiculo.Name = "labelIdVeiculo";
            labelIdVeiculo.Size = new Size(152, 30);
            labelIdVeiculo.TabIndex = 29;
            labelIdVeiculo.Text = "Codigo Veiculo";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(243, 110);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 28;
            // 
            // txtIdVeiculo
            // 
            txtIdVeiculo.BackColor = Color.White;
            txtIdVeiculo.Location = new Point(22, 190);
            txtIdVeiculo.Name = "txtIdVeiculo";
            txtIdVeiculo.ReadOnly = true;
            txtIdVeiculo.Size = new Size(125, 23);
            txtIdVeiculo.TabIndex = 27;
            txtIdVeiculo.Click += txtIdVeiculo_Click;
            txtIdVeiculo.TextChanged += txtIdVeiculo_TextChanged;
            // 
            // labelcodigo
            // 
            labelcodigo.AutoSize = true;
            labelcodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelcodigo.Location = new Point(39, 41);
            labelcodigo.Name = "labelcodigo";
            labelcodigo.Size = new Size(81, 25);
            labelcodigo.TabIndex = 31;
            labelcodigo.Text = "Códigos";
            // 
            // labelinfo
            // 
            labelinfo.AutoSize = true;
            labelinfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelinfo.Location = new Point(243, 41);
            labelinfo.Name = "labelinfo";
            labelinfo.Size = new Size(116, 25);
            labelinfo.TabIndex = 32;
            labelinfo.Text = "Informações";
            // 
            // labelcnh
            // 
            labelcnh.AutoSize = true;
            labelcnh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelcnh.Location = new Point(228, 276);
            labelcnh.Name = "labelcnh";
            labelcnh.Size = new Size(167, 21);
            labelcnh.TabIndex = 34;
            labelcnh.Text = "Carteira de Habilitação";
            labelcnh.Click += label1_Click;
            // 
            // txtCnh
            // 
            txtCnh.BackColor = Color.White;
            txtCnh.Location = new Point(243, 300);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(125, 23);
            txtCnh.TabIndex = 33;
            // 
            // labeltipocnh
            // 
            labeltipocnh.AutoSize = true;
            labeltipocnh.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labeltipocnh.Location = new Point(22, 224);
            labeltipocnh.Name = "labeltipocnh";
            labeltipocnh.Size = new Size(160, 30);
            labeltipocnh.TabIndex = 36;
            labeltipocnh.Text = "Tipo de Carteira";
            // 
            // cbTipoCnh
            // 
            cbTipoCnh.FormattingEnabled = true;
            cbTipoCnh.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cbTipoCnh.Location = new Point(22, 274);
            cbTipoCnh.Name = "cbTipoCnh";
            cbTipoCnh.Size = new Size(55, 23);
            cbTipoCnh.TabIndex = 37;
            // 
            // CRUDMotorista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(dataGridMotorista);
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
            Name = "CRUDMotorista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDMotorista";
            Load += CRUDMotorista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMotorista).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
    }
}