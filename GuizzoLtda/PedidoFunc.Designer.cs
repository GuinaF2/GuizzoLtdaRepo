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
            txtDtPedido = new TextBox();
            labelDtPedido = new Label();
            btnReturn = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)dtgPedido).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgPedido
            // 
            dtgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedido.Location = new Point(0, 198);
            dtgPedido.Name = "dtgPedido";
            dtgPedido.RowTemplate.Height = 25;
            dtgPedido.Size = new Size(803, 251);
            dtgPedido.TabIndex = 1;
            dtgPedido.Visible = false;
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(19, 299);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(144, 40);
            btnConfirma.TabIndex = 4;
            btnConfirma.Text = "Confirmar";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // cbAberto
            // 
            cbAberto.AutoSize = true;
            cbAberto.Location = new Point(19, 150);
            cbAberto.Name = "cbAberto";
            cbAberto.Size = new Size(62, 19);
            cbAberto.TabIndex = 5;
            cbAberto.Text = "Aberto";
            cbAberto.UseVisualStyleBackColor = true;
            cbAberto.CheckedChanged += cbAberto_CheckedChanged;
            // 
            // cbEncerrado
            // 
            cbEncerrado.AutoSize = true;
            cbEncerrado.Location = new Point(99, 150);
            cbEncerrado.Name = "cbEncerrado";
            cbEncerrado.Size = new Size(79, 19);
            cbEncerrado.TabIndex = 6;
            cbEncerrado.Text = "Encerrado";
            cbEncerrado.UseVisualStyleBackColor = true;
            cbEncerrado.CheckedChanged += cbEncerrado_CheckedChanged;
            // 
            // txtDtPedido
            // 
            txtDtPedido.Location = new Point(19, 86);
            txtDtPedido.Name = "txtDtPedido";
            txtDtPedido.Size = new Size(100, 23);
            txtDtPedido.TabIndex = 7;
            // 
            // labelDtPedido
            // 
            labelDtPedido.AutoSize = true;
            labelDtPedido.Location = new Point(19, 68);
            labelDtPedido.Name = "labelDtPedido";
            labelDtPedido.Size = new Size(71, 15);
            labelDtPedido.TabIndex = 8;
            labelDtPedido.Text = "Data Pedido";
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = Properties.Resources._688879_arrows_512x512;
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(23, 22);
            btnReturn.Text = "toolStripButton1";
            btnReturn.Click += btnReturn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // PedidoFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(labelDtPedido);
            Controls.Add(txtDtPedido);
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
        private TextBox txtDtPedido;
        private Label labelDtPedido;
        private ToolStripButton btnReturn;
        private ToolStrip toolStrip1;
    }
}