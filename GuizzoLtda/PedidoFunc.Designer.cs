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
            btnReturnMenu = new Button();
            btnReturn = new Button();
            button1 = new Button();
            txtIdPedido = new TextBox();
            txtStatusPedido = new TextBox();
            txtNmrVolumes = new TextBox();
            txtValorPedido = new TextBox();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPedido).BeginInit();
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
            cbAberto.Location = new Point(19, 159);
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
            cbEncerrado.Location = new Point(99, 159);
            cbEncerrado.Name = "cbEncerrado";
            cbEncerrado.Size = new Size(79, 19);
            cbEncerrado.TabIndex = 6;
            cbEncerrado.Text = "Encerrado";
            cbEncerrado.UseVisualStyleBackColor = true;
            cbEncerrado.CheckedChanged += cbEncerrado_CheckedChanged;
            // 
            // labelDtPedido
            // 
            labelDtPedido.AutoSize = true;
            labelDtPedido.Location = new Point(217, 67);
            labelDtPedido.Name = "labelDtPedido";
            labelDtPedido.Size = new Size(71, 15);
            labelDtPedido.TabIndex = 8;
            labelDtPedido.Text = "Data Pedido";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(19, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(87, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(229, 106);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(113, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 112);
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
            // button1
            // 
            button1.Location = new Point(378, 54);
            button1.Name = "button1";
            button1.Size = new Size(94, 40);
            button1.TabIndex = 15;
            button1.Text = "Aprovar";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
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
            // btnVoltar
            // 
            btnVoltar.Enabled = false;
            btnVoltar.Location = new Point(112, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // PedidoFunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 505);
            Controls.Add(btnVoltar);
            Controls.Add(txtValorPedido);
            Controls.Add(txtNmrVolumes);
            Controls.Add(txtStatusPedido);
            Controls.Add(txtIdPedido);
            Controls.Add(button1);
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

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button btnReturnMenu;
        private Button btnReturn;
        private Button button1;
        private TextBox txtIdPedido;
        private TextBox txtStatusPedido;
        private TextBox txtNmrVolumes;
        private TextBox txtValorPedido;
        private Button btnVoltar;
    }
}