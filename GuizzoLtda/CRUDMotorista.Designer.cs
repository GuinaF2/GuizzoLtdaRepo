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
            dataGridMotorista.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridMotorista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMotorista.Location = new Point(578, 0);
            dataGridMotorista.Name = "dataGridMotorista";
            dataGridMotorista.ReadOnly = true;
            dataGridMotorista.RowHeadersWidth = 51;
            dataGridMotorista.RowTemplate.Height = 25;
            dataGridMotorista.Size = new Size(352, 506);
            dataGridMotorista.TabIndex = 23;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Black;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 28);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Goldenrod;
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(24, 25);
            btnReturn.Text = "Retornar";
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.Goldenrod;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 25);
            btnAtualizar.Text = "Atualizar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCad.ForeColor = Color.Goldenrod;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(81, 25);
            btnCad.Text = "Cadastrar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // btnApaga
            // 
            btnApaga.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnApaga.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnApaga.ForeColor = Color.Goldenrod;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(64, 25);
            btnApaga.Text = "Deletar";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 28);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(24, 25);
            ajudaToolStripButton.Text = "Aju&da";
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
            txtRg.BackColor = Color.White;
            txtRg.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRg.Location = new Point(53, 270);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(185, 27);
            txtRg.TabIndex = 20;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = Color.White;
            txtCpf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(53, 200);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(185, 27);
            txtCpf.TabIndex = 19;
            // 
            // txtIdMoto
            // 
            txtIdMoto.BackColor = Color.White;
            txtIdMoto.Enabled = false;
            txtIdMoto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            labelIdMoto.Location = new Point(334, 96);
            labelIdMoto.Name = "labelIdMoto";
            labelIdMoto.Size = new Size(183, 30);
            labelIdMoto.TabIndex = 17;
            labelIdMoto.Text = "Codigo Motorista";
            // 
            // SaveCreate
            // 
            SaveCreate.BackColor = Color.Black;
            SaveCreate.Font = new Font("Leelawadee UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.ForeColor = Color.Goldenrod;
            SaveCreate.Location = new Point(100, 423);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(300, 50);
            SaveCreate.TabIndex = 16;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = false;
            SaveCreate.Visible = false;
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
            labelIdVeiculo.Location = new Point(334, 168);
            labelIdVeiculo.Name = "labelIdVeiculo";
            labelIdVeiculo.Size = new Size(161, 30);
            labelIdVeiculo.TabIndex = 29;
            labelIdVeiculo.Text = "Codigo Veiculo";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(53, 128);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(185, 27);
            txtNome.TabIndex = 28;
            // 
            // txtIdVeiculo
            // 
            txtIdVeiculo.BackColor = Color.White;
            txtIdVeiculo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdVeiculo.Location = new Point(334, 200);
            txtIdVeiculo.Name = "txtIdVeiculo";
            txtIdVeiculo.ReadOnly = true;
            txtIdVeiculo.Size = new Size(125, 27);
            txtIdVeiculo.TabIndex = 27;
            // 
            // labelcodigo
            // 
            labelcodigo.AutoSize = true;
            labelcodigo.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelcodigo.ForeColor = Color.White;
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
            labelinfo.ForeColor = Color.White;
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
            labelcnh.Location = new Point(53, 304);
            labelcnh.Name = "labelcnh";
            labelcnh.Size = new Size(233, 30);
            labelcnh.TabIndex = 34;
            labelcnh.Text = "Carteira de Habilitação";
            // 
            // txtCnh
            // 
            txtCnh.BackColor = Color.White;
            txtCnh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCnh.Location = new Point(53, 345);
            txtCnh.Name = "txtCnh";
            txtCnh.Size = new Size(185, 27);
            txtCnh.TabIndex = 33;
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
        private Label labelidcliente;
        private TextBox txtIdEmpresa;
    }
}