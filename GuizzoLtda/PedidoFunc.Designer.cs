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
            dtPedido = new DateTimePicker();
            labelDtPedido = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            btnReturnMenu = new Button();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPedido).BeginInit();
            SuspendLayout();
            // 
            // dtgPedido
            // 
            dtgPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedido.Location = new Point(0, 198);
            dtgPedido.Name = "dtgPedido";
            dtgPedido.RowHeadersWidth = 51;
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
            cbAberto.Location = new Point(14, 158);
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
            cbEncerrado.Location = new Point(94, 158);
            cbEncerrado.Name = "cbEncerrado";
            cbEncerrado.Size = new Size(79, 19);
            cbEncerrado.TabIndex = 6;
            cbEncerrado.Text = "Encerrado";
            cbEncerrado.UseVisualStyleBackColor = true;
            cbEncerrado.CheckedChanged += cbEncerrado_CheckedChanged;
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
            // labelDtPedido
            // 
            labelDtPedido.AutoSize = true;
            labelDtPedido.Location = new Point(213, 27);
            labelDtPedido.Name = "labelDtPedido";
            labelDtPedido.Size = new Size(71, 15);
            labelDtPedido.TabIndex = 8;
            labelDtPedido.Text = "Data Pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(281, 106);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 114);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 12;
            label1.Text = "Até";
            // 
            // btnReturnMenu
            // 
            btnReturnMenu.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            btnReturnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturnMenu.Location = new Point(0, -1);
            btnReturnMenu.Name = "btnReturnMenu";
            btnReturnMenu.Size = new Size(34, 26);
            btnReturnMenu.TabIndex = 13;
            btnReturnMenu.UseVisualStyleBackColor = true;
            btnReturnMenu.Click += btnReturnMenu_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources._688879_arrows_512x512;
            btnReturn.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturn.Location = new Point(0, -1);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(34, 26);
            btnReturn.TabIndex = 14;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click_1;
            // 
            // PedidoFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 505);
            Controls.Add(btnReturn);
            Controls.Add(btnReturnMenu);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgPedido;
        private Button btnConfirma;
        private CheckBox cbAberto;
        private CheckBox cbEncerrado;
        private Label labelDtPedido;
        private DateTimePicker dtPedido;
        private DateTimePicker dtPedido2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button btnReturnMenu;
        private Button btnReturn;
    }
}