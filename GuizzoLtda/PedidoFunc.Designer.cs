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
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dtgPedido = new DataGridView();
            btnConfirma = new Button();
            cbAberto = new CheckBox();
            cbEncerrado = new CheckBox();
            txtDtPedido = new TextBox();
            labelDtPedido = new Label();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dtgPedido).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dtgPedido
            // 
            dtgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedido.Location = new Point(0, 264);
            dtgPedido.Margin = new Padding(3, 4, 3, 4);
            dtgPedido.Name = "dtgPedido";
            dtgPedido.RowHeadersWidth = 51;
            dtgPedido.RowTemplate.Height = 25;
            dtgPedido.Size = new Size(918, 335);
            dtgPedido.TabIndex = 1;
            dtgPedido.Visible = false;
            // 
            // btnConfirma
            // 
            btnConfirma.Location = new Point(22, 399);
            btnConfirma.Margin = new Padding(3, 4, 3, 4);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.Size = new Size(165, 53);
            btnConfirma.TabIndex = 4;
            btnConfirma.Text = "Confirmar";
            btnConfirma.UseVisualStyleBackColor = true;
            btnConfirma.Click += btnConfirma_Click;
            // 
            // cbAberto
            // 
            cbAberto.AutoSize = true;
            cbAberto.Location = new Point(22, 200);
            cbAberto.Margin = new Padding(3, 4, 3, 4);
            cbAberto.Name = "cbAberto";
            cbAberto.Size = new Size(77, 24);
            cbAberto.TabIndex = 5;
            cbAberto.Text = "Aberto";
            cbAberto.UseVisualStyleBackColor = true;
            cbAberto.CheckedChanged += cbAberto_CheckedChanged;
            // 
            // cbEncerrado
            // 
            cbEncerrado.AutoSize = true;
            cbEncerrado.Location = new Point(113, 200);
            cbEncerrado.Margin = new Padding(3, 4, 3, 4);
            cbEncerrado.Name = "cbEncerrado";
            cbEncerrado.Size = new Size(98, 24);
            cbEncerrado.TabIndex = 6;
            cbEncerrado.Text = "Encerrado";
            cbEncerrado.UseVisualStyleBackColor = true;
            cbEncerrado.CheckedChanged += cbEncerrado_CheckedChanged;
            // 
            // txtDtPedido
            // 
            txtDtPedido.Location = new Point(22, 115);
            txtDtPedido.Margin = new Padding(3, 4, 3, 4);
            txtDtPedido.Name = "txtDtPedido";
            txtDtPedido.Size = new Size(114, 27);
            txtDtPedido.TabIndex = 7;
            // 
            // labelDtPedido
            // 
            labelDtPedido.AutoSize = true;
            labelDtPedido.Location = new Point(22, 91);
            labelDtPedido.Name = "labelDtPedido";
            labelDtPedido.Size = new Size(91, 20);
            labelDtPedido.TabIndex = 8;
            labelDtPedido.Text = "Data Pedido";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1062, 27);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = Properties.Resources._688879_arrows_512x512;
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(29, 24);
            btnReturn.Text = "toolStripButton1";
            btnReturn.Click += btnReturn_Click;
            // 
            // dtPedido
            // 
            dtPedido.Location = new Point(19, 107);
            dtPedido.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtPedido.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPedido.Name = "dtPedido";
            dtPedido.Size = new Size(200, 23);
            dtPedido.TabIndex = 10;
            dtPedido.Value = new DateTime(2023, 6, 24, 0, 0, 0, 0);
            // 
            // dtPedido2
            // 
            dtPedido2.Location = new Point(307, 107);
            dtPedido2.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtPedido2.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPedido2.Name = "dtPedido2";
            dtPedido2.Size = new Size(200, 23);
            dtPedido2.TabIndex = 11;
            // 
            // PedidoFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(toolStrip1);
            Controls.Add(labelDtPedido);
            Controls.Add(txtDtPedido);
            Controls.Add(cbEncerrado);
            Controls.Add(cbAberto);
            Controls.Add(btnConfirma);
            Controls.Add(dtgPedido);
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private DateTimePicker dtPedido;
        private DateTimePicker dtPedido2;
    }
}