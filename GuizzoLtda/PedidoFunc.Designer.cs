namespace GuizzoLtda
{
    partial class PedidoFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoFunc));
            dtgPedido = new DataGridView();
            btnConfirma = new Button();
            cbAberto = new CheckBox();
            cbEncerrado = new CheckBox();
            labelDtPedido = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            txtIdPedido = new TextBox();
            txtStatusPedido = new TextBox();
            txtNmrVolumes = new TextBox();
            txtValorPedido = new TextBox();
            txtIdCliente = new TextBox();
            txtDtPedido = new TextBox();
            toolStrip1 = new ToolStrip();
            btnReturnMenu = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAprovar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnVoltar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dtgPedido).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgPedido
            // 
            dtgPedido.AllowUserToAddRows = false;
            dtgPedido.AllowUserToDeleteRows = false;
            dtgPedido.BackgroundColor = Color.Black;
            dtgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedido.GridColor = Color.Goldenrod;
            dtgPedido.Location = new Point(79, 292);
            dtgPedido.Margin = new Padding(3, 4, 3, 4);
            dtgPedido.Name = "dtgPedido";
            dtgPedido.ReadOnly = true;
            dtgPedido.RowHeadersWidth = 51;
            dtgPedido.RowTemplate.Height = 25;
            dtgPedido.Size = new Size(918, 335);
            dtgPedido.TabIndex = 1;
            dtgPedido.Visible = false;
            dtgPedido.CellClick += dtgPedido_CellClick_1;
            // 
            // btnConfirma
            // 
            btnConfirma.BackColor = Color.Black;
            btnConfirma.FlatStyle = FlatStyle.Flat;
            btnConfirma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirma.Location = new Point(22, 409);
            btnConfirma.Margin = new Padding(3, 4, 3, 4);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(253, 68);
            btnConfirma.TabIndex = 4;
            btnConfirma.Text = "Confirmar";
            btnConfirma.UseVisualStyleBackColor = false;
            btnConfirma.Click += btnConfirma_Click_1;
            // 
            // cbAberto
            // 
            cbAberto.AutoSize = true;
            cbAberto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbAberto.ForeColor = Color.Black;
            cbAberto.Location = new Point(31, 216);
            cbAberto.Margin = new Padding(3, 4, 3, 4);
            cbAberto.Name = "cbAberto";
            cbAberto.Size = new Size(74, 24);
            cbAberto.TabIndex = 5;
            cbAberto.Text = "Aberto";
            cbAberto.UseVisualStyleBackColor = true;
            // 
            // cbEncerrado
            // 
            cbEncerrado.AutoSize = true;
            cbEncerrado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbEncerrado.ForeColor = Color.Black;
            cbEncerrado.Location = new Point(122, 216);
            cbEncerrado.Margin = new Padding(3, 4, 3, 4);
            cbEncerrado.Name = "cbEncerrado";
            cbEncerrado.Size = new Size(95, 24);
            cbEncerrado.TabIndex = 6;
            cbEncerrado.Text = "Encerrado";
            cbEncerrado.UseVisualStyleBackColor = true;
            // 
            // labelDtPedido
            // 
            labelDtPedido.AutoSize = true;
            labelDtPedido.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDtPedido.ForeColor = Color.Black;
            labelDtPedido.Location = new Point(22, 49);
            labelDtPedido.Name = "labelDtPedido";
            labelDtPedido.Size = new Size(240, 40);
            labelDtPedido.TabIndex = 8;
            labelDtPedido.Text = "Confirmar Pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(22, 141);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(124, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(262, 141);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(129, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(187, 141);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 12;
            label1.Text = "Até";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(707, 49);
            txtIdPedido.Margin = new Padding(3, 4, 3, 4);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(114, 27);
            txtIdPedido.TabIndex = 16;
            txtIdPedido.Visible = false;
            // 
            // txtStatusPedido
            // 
            txtStatusPedido.Location = new Point(707, 104);
            txtStatusPedido.Margin = new Padding(3, 4, 3, 4);
            txtStatusPedido.Name = "txtStatusPedido";
            txtStatusPedido.Size = new Size(114, 27);
            txtStatusPedido.TabIndex = 17;
            txtStatusPedido.Visible = false;
            // 
            // txtNmrVolumes
            // 
            txtNmrVolumes.Location = new Point(707, 165);
            txtNmrVolumes.Margin = new Padding(3, 4, 3, 4);
            txtNmrVolumes.Name = "txtNmrVolumes";
            txtNmrVolumes.Size = new Size(114, 27);
            txtNmrVolumes.TabIndex = 18;
            txtNmrVolumes.Visible = false;
            // 
            // txtValorPedido
            // 
            txtValorPedido.Location = new Point(707, 228);
            txtValorPedido.Margin = new Padding(3, 4, 3, 4);
            txtValorPedido.Name = "txtValorPedido";
            txtValorPedido.Size = new Size(114, 27);
            txtValorPedido.TabIndex = 19;
            txtValorPedido.Visible = false;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(857, 59);
            txtIdCliente.Margin = new Padding(3, 4, 3, 4);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(114, 27);
            txtIdCliente.TabIndex = 21;
            txtIdCliente.Visible = false;
            // 
            // txtDtPedido
            // 
            txtDtPedido.Location = new Point(857, 104);
            txtDtPedido.Margin = new Padding(3, 4, 3, 4);
            txtDtPedido.Name = "txtDtPedido";
            txtDtPedido.Size = new Size(114, 27);
            txtDtPedido.TabIndex = 22;
            txtDtPedido.Visible = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturnMenu, toolStripSeparator1, btnAprovar, toolStripSeparator2, btnVoltar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1062, 27);
            toolStrip1.TabIndex = 23;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturnMenu
            // 
            btnReturnMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturnMenu.Image = Properties.Resources._688879_arrows_512x512;
            btnReturnMenu.ImageTransparentColor = Color.Magenta;
            btnReturnMenu.Name = "btnReturnMenu";
            btnReturnMenu.Size = new Size(69, 24);
            btnReturnMenu.Text = "Menu";
            btnReturnMenu.Click += btnReturnMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnAprovar
            // 
            btnAprovar.BackColor = Color.Transparent;
            btnAprovar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAprovar.Image = (Image)resources.GetObject("btnAprovar.Image");
            btnAprovar.ImageTransparentColor = Color.Magenta;
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(121, 24);
            btnAprovar.Text = "Recebimento";
            btnAprovar.Click += btnAprovar_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // btnVoltar
            // 
            btnVoltar.Enabled = false;
            btnVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Image = Properties.Resources.FlechaReturn;
            btnVoltar.ImageTransparentColor = Color.Magenta;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(91, 24);
            btnVoltar.Text = "Retornar";
            btnVoltar.Click += btnVoltar_Click;
            // 
            // PedidoFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(1062, 673);
            Controls.Add(toolStrip1);
            Controls.Add(txtDtPedido);
            Controls.Add(txtIdCliente);
            Controls.Add(txtValorPedido);
            Controls.Add(txtNmrVolumes);
            Controls.Add(txtStatusPedido);
            Controls.Add(txtIdPedido);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelDtPedido);
            Controls.Add(cbEncerrado);
            Controls.Add(cbAberto);
            Controls.Add(btnConfirma);
            Controls.Add(dtgPedido);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Goldenrod;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PedidoFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PedidoFunc_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgPedido).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgPedido;
        private Button btnConfirma;
        private CheckBox cbAberto;
        private CheckBox cbEncerrado;
        private Label labelDtPedido;

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button btnAprova;
        private TextBox txtIdPedido;
        private TextBox txtStatusPedido;
        private TextBox txtNmrVolumes;
        private TextBox txtValorPedido;
        private TextBox txtIdCliente;
        private TextBox txtDtPedido;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturnMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnVoltar;
        private ToolStripButton btnAprovar;
    }
}