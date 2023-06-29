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
            dtgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedido.Location = new Point(69, 219);
            dtgPedido.Name = "dtgPedido";
            dtgPedido.ReadOnly = true;
            dtgPedido.RowHeadersWidth = 51;
            dtgPedido.RowTemplate.Height = 25;
            dtgPedido.Size = new Size(803, 251);
            dtgPedido.TabIndex = 1;
            dtgPedido.Visible = false;
            dtgPedido.CellClick += dtgPedido_CellClick;
            dtgPedido.CellContentClick += dtgPedido_CellContentClick;
            // 
            // btnConfirma
            // 
            btnConfirma.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirma.Location = new Point(19, 299);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(203, 51);
            btnConfirma.TabIndex = 4;
            btnConfirma.Text = "Confirmar";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // cbAberto
            // 
            cbAberto.AutoSize = true;
            cbAberto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbAberto.Location = new Point(19, 159);
            cbAberto.Name = "cbAberto";
            cbAberto.Size = new Size(74, 24);
            cbAberto.TabIndex = 5;
            cbAberto.Text = "Aberto";
            cbAberto.UseVisualStyleBackColor = true;
            cbAberto.CheckedChanged += cbAberto_CheckedChanged;
            // 
            // cbEncerrado
            // 
            cbEncerrado.AutoSize = true;
            cbEncerrado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbEncerrado.Location = new Point(99, 159);
            cbEncerrado.Name = "cbEncerrado";
            cbEncerrado.Size = new Size(95, 24);
            cbEncerrado.TabIndex = 6;
            cbEncerrado.Text = "Encerrado";
            cbEncerrado.UseVisualStyleBackColor = true;
            cbEncerrado.CheckedChanged += cbEncerrado_CheckedChanged;
            // 
            // labelDtPedido
            // 
            labelDtPedido.AutoSize = true;
            labelDtPedido.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDtPedido.Location = new Point(19, 37);
            labelDtPedido.Name = "labelDtPedido";
            labelDtPedido.Size = new Size(225, 37);
            labelDtPedido.TabIndex = 8;
            labelDtPedido.Text = "Confirmar Pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(19, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(109, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(229, 106);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(113, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(162, 112);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 12;
            label1.Text = "Até";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(619, 37);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 16;
            txtIdPedido.Visible = false;
            // 
            // txtStatusPedido
            // 
            txtStatusPedido.Location = new Point(619, 78);
            txtStatusPedido.Name = "txtStatusPedido";
            txtStatusPedido.Size = new Size(100, 23);
            txtStatusPedido.TabIndex = 17;
            txtStatusPedido.Visible = false;
            // 
            // txtNmrVolumes
            // 
            txtNmrVolumes.Location = new Point(619, 124);
            txtNmrVolumes.Name = "txtNmrVolumes";
            txtNmrVolumes.Size = new Size(100, 23);
            txtNmrVolumes.TabIndex = 18;
            txtNmrVolumes.Visible = false;
            // 
            // txtValorPedido
            // 
            txtValorPedido.Location = new Point(619, 171);
            txtValorPedido.Name = "txtValorPedido";
            txtValorPedido.Size = new Size(100, 23);
            txtValorPedido.TabIndex = 19;
            txtValorPedido.Visible = false;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(750, 44);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 21;
            txtIdCliente.Visible = false;
            // 
            // txtDtPedido
            // 
            txtDtPedido.Location = new Point(750, 78);
            txtDtPedido.Name = "txtDtPedido";
            txtDtPedido.Size = new Size(100, 23);
            txtDtPedido.TabIndex = 22;
            txtDtPedido.Visible = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturnMenu, toolStripSeparator1, btnAprovar, toolStripSeparator2, btnVoltar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 25);
            toolStrip1.TabIndex = 23;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturnMenu
            // 
            btnReturnMenu.Image = Properties.Resources._688879_arrows_512x512;
            btnReturnMenu.ImageTransparentColor = Color.Magenta;
            btnReturnMenu.Name = "btnReturnMenu";
            btnReturnMenu.Size = new Size(58, 22);
            btnReturnMenu.Text = "Menu";
            btnReturnMenu.Click += btnReturnMenu_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnAprovar
            // 
            btnAprovar.BackColor = SystemColors.Control;
            btnAprovar.Image = Properties.Resources.checkimage;
            btnAprovar.ImageTransparentColor = Color.Magenta;
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(97, 22);
            btnAprovar.Text = "Recebimento";
            btnAprovar.Click += btnAprovar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnVoltar
            // 
            btnVoltar.Enabled = false;
            btnVoltar.Image = Properties.Resources.FlechaReturn;
            btnVoltar.ImageTransparentColor = Color.Magenta;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 22);
            btnVoltar.Text = "Retornar";
            btnVoltar.Click += toolStripButton3_Click;
            // 
            // PedidoFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 505);
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
            Name = "PedidoFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PedidoFunc_Load;
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