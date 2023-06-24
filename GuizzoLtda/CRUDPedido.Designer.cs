namespace GuizzoLtda
{
    partial class CRUDPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDPedido));
            dgPedido = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCad = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            txtIdCliente = new TextBox();
            SaveCreate = new Button();
            SaveDelete = new Button();
            SaveUpdate = new Button();
            txtIdMoto = new TextBox();
            txtIdPedido = new TextBox();
            labelidpedido = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtVolume = new TextBox();
            txtTipoPedido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtPedido = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgPedido).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgPedido
            // 
            dgPedido.AllowUserToAddRows = false;
            dgPedido.AllowUserToDeleteRows = false;
            dgPedido.BackgroundColor = SystemColors.ActiveCaptionText;
            dgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedido.Location = new Point(594, 0);
            dgPedido.Margin = new Padding(3, 4, 3, 4);
            dgPedido.Name = "dgPedido";
            dgPedido.ReadOnly = true;
            dgPedido.RowHeadersWidth = 51;
            dgPedido.RowTemplate.Height = 25;
            dgPedido.Size = new Size(468, 646);
            dgPedido.TabIndex = 23;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Black;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1026, 27);
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
            btnReturn.Size = new Size(24, 24);
            btnReturn.Text = "Retornar";
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.Goldenrod;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(72, 24);
            btnAtualizar.Text = "Atualizar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCad.ForeColor = Color.Goldenrod;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(76, 24);
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
            btnApaga.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnApaga.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApaga.ForeColor = Color.Goldenrod;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(62, 24);
            btnApaga.Text = "Deletar";
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
            ajudaToolStripButton.Size = new Size(24, 24);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = Color.White;
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(57, 314);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(142, 22);
            txtIdCliente.TabIndex = 18;
            // 
            // SaveCreate
            // 
            SaveCreate.BackColor = Color.Black;
            SaveCreate.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.ForeColor = Color.Goldenrod;
            SaveCreate.Location = new Point(95, 455);
            SaveCreate.Margin = new Padding(3, 4, 3, 4);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(343, 64);
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
            SaveDelete.Location = new Point(95, 455);
            SaveDelete.Margin = new Padding(3, 4, 3, 4);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(343, 64);
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
            SaveUpdate.Location = new Point(95, 455);
            SaveUpdate.Margin = new Padding(3, 4, 3, 4);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(343, 64);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = false;
            SaveUpdate.Visible = false;
            // 
            // txtIdMoto
            // 
            txtIdMoto.BackColor = Color.White;
            txtIdMoto.Enabled = false;
            txtIdMoto.Location = new Point(57, 217);
            txtIdMoto.Margin = new Padding(3, 4, 3, 4);
            txtIdMoto.Name = "txtIdMoto";
            txtIdMoto.Size = new Size(142, 22);
            txtIdMoto.TabIndex = 30;
            txtIdMoto.TextChanged += txtIdMoto_TextChanged_1;
            // 
            // txtIdPedido
            // 
            txtIdPedido.BackColor = Color.White;
            txtIdPedido.Enabled = false;
            txtIdPedido.Location = new Point(57, 116);
            txtIdPedido.Margin = new Padding(3, 4, 3, 4);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(142, 22);
            txtIdPedido.TabIndex = 34;
            // 
            // labelidpedido
            // 
            labelidpedido.AutoSize = true;
            labelidpedido.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelidpedido.ForeColor = Color.White;
            labelidpedido.Location = new Point(57, 62);
            labelidpedido.Name = "labelidpedido";
            labelidpedido.Size = new Size(106, 30);
            labelidpedido.TabIndex = 33;
            labelidpedido.Text = "Id Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(57, 161);
            label4.Name = "label4";
            label4.Size = new Size(131, 30);
            label4.TabIndex = 35;
            label4.Text = "Id Motorista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 259);
            label5.Name = "label5";
            label5.Size = new Size(56, 13);
            label5.TabIndex = 36;
            label5.Text = "Id Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(309, 62);
            label6.Name = "label6";
            label6.Size = new Size(128, 30);
            label6.TabIndex = 37;
            label6.Text = "Nº Volumes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(309, 161);
            label7.Name = "label7";
            label7.Size = new Size(68, 13);
            label7.TabIndex = 38;
            label7.Text = "Tipo Pedido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(309, 259);
            label8.Name = "label8";
            label8.Size = new Size(70, 13);
            label8.TabIndex = 39;
            label8.Text = "Data Pedido";
            // 
            // txtVolume
            // 
            txtVolume.BackColor = Color.White;
            txtVolume.Location = new Point(309, 116);
            txtVolume.Margin = new Padding(3, 4, 3, 4);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(142, 22);
            txtVolume.TabIndex = 40;
            // 
            // txtTipoPedido
            // 
            txtTipoPedido.BackColor = Color.White;
            txtTipoPedido.Location = new Point(309, 217);
            txtTipoPedido.Margin = new Padding(3, 4, 3, 4);
            txtTipoPedido.Name = "txtTipoPedido";
            txtTipoPedido.Size = new Size(142, 22);
            txtTipoPedido.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 259);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 36;
            label1.Text = "Id Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(309, 161);
            label2.Name = "label2";
            label2.Size = new Size(130, 30);
            label2.TabIndex = 38;
            label2.Text = "Tipo Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(309, 259);
            label3.Name = "label3";
            label3.Size = new Size(131, 30);
            label3.TabIndex = 39;
            label3.Text = "Data Pedido";
            // 
            // dtPedido
            // 
            dtPedido.Location = new Point(294, 310);
            dtPedido.Name = "dtPedido";
            dtPedido.Size = new Size(200, 22);
            dtPedido.TabIndex = 42;
            // 
            // CRUDPedido
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(1026, 542);
            Controls.Add(dtPedido);
            Controls.Add(txtTipoPedido);
            Controls.Add(txtVolume);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtIdPedido);
            Controls.Add(labelidpedido);
            Controls.Add(txtIdMoto);
            Controls.Add(toolStrip1);
            Controls.Add(txtIdCliente);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Controls.Add(dgPedido);
            Font = new Font("Leelawadee UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUDPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDPedido";
            ((System.ComponentModel.ISupportInitialize)dgPedido).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPedido;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCad;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnApaga;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private Label labelcargo;
        private ComboBox cbCargo;
        private Label labelsenha;
        private Label labelnome;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtIdCliente;
        private Label labelid;
        private Button SaveCreate;
        private Button SaveDelete;
        private Button SaveUpdate;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtIdMoto;
        private Label label2;
        private Label label3;
        private TextBox txtIdPedido;
        private Label labelidpedido;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtVolume;
        private TextBox txtTipoPedido;
        private DateTimePicker dtPedido;
    }
}