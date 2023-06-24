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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelIdVeiculo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdVeiculo = new System.Windows.Forms.TextBox();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.labelinfo = new System.Windows.Forms.Label();
            this.labelcnh = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.labeltipocnh = new System.Windows.Forms.Label();
            this.cbTipoCnh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotorista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMotorista
            // 
            this.dataGridMotorista.AllowUserToAddRows = false;
            this.dataGridMotorista.AllowUserToDeleteRows = false;
            this.dataGridMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMotorista.Location = new System.Drawing.Point(578, 0);
            this.dataGridMotorista.Name = "dataGridMotorista";
            this.dataGridMotorista.ReadOnly = true;
            this.dataGridMotorista.RowHeadersWidth = 51;
            this.dataGridMotorista.RowTemplate.Height = 25;
            this.dataGridMotorista.Size = new System.Drawing.Size(352, 506);
            this.dataGridMotorista.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            // btnCad
            // 
            this.btnCad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCad.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnCad.Image = ((System.Drawing.Image)(resources.GetObject("btnCad.Image")));
            this.btnCad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(61, 24);
            this.btnCad.Text = "Cadastrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // labelrg
            // 
            this.labelrg.AutoSize = true;
            this.labelrg.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelrg.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelrg.Location = new System.Drawing.Point(25, 202);
            this.labelrg.Name = "labelrg";
            this.labelrg.Size = new System.Drawing.Size(150, 30);
            this.labelrg.TabIndex = 22;
            this.labelrg.Text = "Registro Geral";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcpf.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelcpf.Location = new System.Drawing.Point(25, 131);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(47, 30);
            this.labelcpf.TabIndex = 21;
            this.labelcpf.Text = "Cpf";
            // 
            // txtRg
            // 
            this.txtRg.BackColor = System.Drawing.Color.White;
            this.txtRg.Location = new System.Drawing.Point(25, 239);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(185, 23);
            this.txtRg.TabIndex = 20;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.Location = new System.Drawing.Point(25, 169);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(185, 23);
            this.txtCpf.TabIndex = 19;
            // 
            // txtIdMoto
            // 
            this.txtIdMoto.BackColor = System.Drawing.Color.White;
            this.txtIdMoto.Enabled = false;
            this.txtIdMoto.Location = new System.Drawing.Point(318, 97);
            this.txtIdMoto.Name = "txtIdMoto";
            this.txtIdMoto.Size = new System.Drawing.Size(125, 23);
            this.txtIdMoto.TabIndex = 18;
            // 
            // labelIdMoto
            // 
            this.labelIdMoto.AutoSize = true;
            this.labelIdMoto.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdMoto.ForeColor = System.Drawing.Color.Orange;
            this.labelIdMoto.Location = new System.Drawing.Point(318, 65);
            this.labelIdMoto.Name = "labelIdMoto";
            this.labelIdMoto.Size = new System.Drawing.Size(183, 30);
            this.labelIdMoto.TabIndex = 17;
            this.labelIdMoto.Text = "Codigo Motorista";
            // 
            // SaveCreate
            // 
            this.SaveCreate.BackColor = System.Drawing.Color.Black;
            this.SaveCreate.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveCreate.ForeColor = System.Drawing.Color.Goldenrod;
            this.SaveCreate.Location = new System.Drawing.Point(100, 424);
            this.SaveCreate.Name = "SaveCreate";
            this.SaveCreate.Size = new System.Drawing.Size(300, 50);
            this.SaveCreate.TabIndex = 16;
            this.SaveCreate.Text = "Salvar Cadastro";
            this.SaveCreate.UseVisualStyleBackColor = false;
            this.SaveCreate.Visible = false;
            // 
            // SaveDelete
            // 
            this.SaveDelete.BackColor = System.Drawing.Color.Black;
            this.SaveDelete.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveDelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.SaveDelete.Location = new System.Drawing.Point(100, 424);
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
            this.SaveUpdate.Location = new System.Drawing.Point(100, 424);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(300, 50);
            this.SaveUpdate.TabIndex = 14;
            this.SaveUpdate.Text = "Salvar Alteração";
            this.SaveUpdate.UseVisualStyleBackColor = false;
            this.SaveUpdate.Visible = false;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelNome.Location = new System.Drawing.Point(25, 66);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(73, 30);
            this.labelNome.TabIndex = 30;
            this.labelNome.Text = "Nome";
            // 
            // labelIdVeiculo
            // 
            this.labelIdVeiculo.AutoSize = true;
            this.labelIdVeiculo.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdVeiculo.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelIdVeiculo.Location = new System.Drawing.Point(318, 137);
            this.labelIdVeiculo.Name = "labelIdVeiculo";
            this.labelIdVeiculo.Size = new System.Drawing.Size(161, 30);
            this.labelIdVeiculo.TabIndex = 29;
            this.labelIdVeiculo.Text = "Codigo Veiculo";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(25, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(185, 23);
            this.txtNome.TabIndex = 28;
            // 
            // txtIdVeiculo
            // 
            this.txtIdVeiculo.BackColor = System.Drawing.Color.White;
            this.txtIdVeiculo.Location = new System.Drawing.Point(318, 169);
            this.txtIdVeiculo.Name = "txtIdVeiculo";
            this.txtIdVeiculo.ReadOnly = true;
            this.txtIdVeiculo.Size = new System.Drawing.Size(125, 23);
            this.txtIdVeiculo.TabIndex = 27;
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelcodigo.ForeColor = System.Drawing.Color.White;
            this.labelcodigo.Location = new System.Drawing.Point(318, 20);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(85, 25);
            this.labelcodigo.TabIndex = 31;
            this.labelcodigo.Text = "Códigos";
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Font = new System.Drawing.Font("Leelawadee UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelinfo.ForeColor = System.Drawing.Color.White;
            this.labelinfo.Location = new System.Drawing.Point(25, 20);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(123, 25);
            this.labelinfo.TabIndex = 32;
            this.labelinfo.Text = "Informações";
            // 
            // labelcnh
            // 
            this.labelcnh.AutoSize = true;
            this.labelcnh.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelcnh.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelcnh.Location = new System.Drawing.Point(25, 273);
            this.labelcnh.Name = "labelcnh";
            this.labelcnh.Size = new System.Drawing.Size(233, 30);
            this.labelcnh.TabIndex = 34;
            this.labelcnh.Text = "Carteira de Habilitação";
            // 
            // txtCnh
            // 
            this.txtCnh.BackColor = System.Drawing.Color.White;
            this.txtCnh.Location = new System.Drawing.Point(25, 314);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(185, 23);
            this.txtCnh.TabIndex = 33;
            // 
            // labeltipocnh
            // 
            this.labeltipocnh.AutoSize = true;
            this.labeltipocnh.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltipocnh.ForeColor = System.Drawing.Color.Goldenrod;
            this.labeltipocnh.Location = new System.Drawing.Point(318, 208);
            this.labeltipocnh.Name = "labeltipocnh";
            this.labeltipocnh.Size = new System.Drawing.Size(169, 30);
            this.labeltipocnh.TabIndex = 36;
            this.labeltipocnh.Text = "Tipo de Carteira";
            // 
            // cbTipoCnh
            // 
            this.cbTipoCnh.FormattingEnabled = true;
            this.cbTipoCnh.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbTipoCnh.Location = new System.Drawing.Point(318, 239);
            this.cbTipoCnh.Name = "cbTipoCnh";
            this.cbTipoCnh.Size = new System.Drawing.Size(55, 23);
            this.cbTipoCnh.TabIndex = 37;
            // 
            // CRUDMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.cbTipoCnh);
            this.Controls.Add(this.labeltipocnh);
            this.Controls.Add(this.labelcnh);
            this.Controls.Add(this.txtCnh);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.labelcodigo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelIdVeiculo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdVeiculo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRUDMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDMotorista";
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