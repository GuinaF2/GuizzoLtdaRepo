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
            txtDataPed = new TextBox();
            txtIdPedido = new TextBox();
            labelidpedido = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtVolume = new TextBox();
            txtTipoPedido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgPedido).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgPedido
            // 
            dgPedido.AllowUserToAddRows = false;
            dgPedido.AllowUserToDeleteRows = false;
            dgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedido.Location = new Point(470, -1);
            dgPedido.Margin = new Padding(3, 4, 3, 4);
            dgPedido.Name = "dgPedido";
            dgPedido.ReadOnly = true;
            dgPedido.RowHeadersWidth = 51;
            dgPedido.RowTemplate.Height = 25;
            dgPedido.Size = new Size(445, 604);
            dgPedido.TabIndex = 23;
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
            btnReturn.Click += btnReturn_Click;
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
            // txtIdCliente
            // 
            txtIdCliente.BackColor = Color.White;
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(26, 303);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(142, 27);
            txtIdCliente.TabIndex = 18;
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(55, 341);
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
            SaveDelete.Location = new Point(55, 404);
            SaveDelete.Margin = new Padding(3, 4, 3, 4);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(343, 67);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Visible = false;
            SaveDelete.Click += SaveDelete_Click;
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(55, 467);
            SaveUpdate.Margin = new Padding(3, 4, 3, 4);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(343, 67);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            SaveUpdate.Click += SaveUpdate_Click;
            // 
            // txtIdMoto
            // 
            txtIdMoto.BackColor = Color.White;
            txtIdMoto.Enabled = false;
            txtIdMoto.Location = new Point(26, 228);
            txtIdMoto.Margin = new Padding(3, 4, 3, 4);
            txtIdMoto.Name = "txtIdMoto";
            txtIdMoto.Size = new Size(142, 27);
            txtIdMoto.TabIndex = 30;
            // 
            // txtDataPed
            // 
            txtDataPed.BackColor = Color.White;
            txtDataPed.Location = new Point(251, 303);
            txtDataPed.Margin = new Padding(3, 4, 3, 4);
            txtDataPed.Name = "txtDataPed";
            txtDataPed.Size = new Size(142, 27);
            txtDataPed.TabIndex = 31;
            // 
            // txtIdPedido
            // 
            txtIdPedido.BackColor = Color.White;
            txtIdPedido.Enabled = false;
            txtIdPedido.Location = new Point(26, 149);
            txtIdPedido.Margin = new Padding(3, 4, 3, 4);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(142, 27);
            txtIdPedido.TabIndex = 34;
            // 
            // labelidpedido
            // 
            labelidpedido.AutoSize = true;
            labelidpedido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelidpedido.Location = new Point(26, 105);
            labelidpedido.Name = "labelidpedido";
            labelidpedido.Size = new Size(130, 37);
            labelidpedido.TabIndex = 33;
            labelidpedido.Text = "Id Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 184);
            label4.Name = "label4";
            label4.Size = new Size(162, 37);
            label4.TabIndex = 35;
            label4.Text = "Id Motorista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 263);
            label5.Name = "label5";
            label5.Size = new Size(130, 37);
            label5.TabIndex = 36;
            label5.Text = "Id Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(251, 105);
            label6.Name = "label6";
            label6.Size = new Size(157, 37);
            label6.TabIndex = 37;
            label6.Text = "Nº Volumes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(251, 184);
            label7.Name = "label7";
            label7.Size = new Size(160, 37);
            label7.TabIndex = 38;
            label7.Text = "Tipo Pedido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(250, 263);
            label8.Name = "label8";
            label8.Size = new Size(163, 37);
            label8.TabIndex = 39;
            label8.Text = "Data Pedido";
            // 
            // txtVolume
            // 
            txtVolume.BackColor = Color.White;
            txtVolume.Location = new Point(251, 149);
            txtVolume.Margin = new Padding(3, 4, 3, 4);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(142, 27);
            txtVolume.TabIndex = 40;
            // 
            // txtTipoPedido
            // 
            txtTipoPedido.BackColor = Color.White;
            txtTipoPedido.Location = new Point(251, 228);
            txtTipoPedido.Margin = new Padding(3, 4, 3, 4);
            txtTipoPedido.Name = "txtTipoPedido";
            txtTipoPedido.Size = new Size(142, 27);
            txtTipoPedido.TabIndex = 41;
            // 
            // CRUDPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(txtTipoPedido);
            Controls.Add(txtVolume);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtIdPedido);
            Controls.Add(labelidpedido);
            Controls.Add(txtDataPed);
            Controls.Add(txtIdMoto);
            Controls.Add(dgPedido);
            Controls.Add(toolStrip1);
            Controls.Add(txtIdCliente);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUDPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDPedido";
            Load += CRUDPedido_Load;
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
        private TextBox txtDataPed;
        private TextBox txtIdPedido;
        private Label labelidpedido;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtVolume;
        private TextBox txtTipoPedido;
    }
}