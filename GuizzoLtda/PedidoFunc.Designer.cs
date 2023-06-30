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
            this.dtgPedido = new System.Windows.Forms.DataGridView();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.cbAberto = new System.Windows.Forms.CheckBox();
            this.cbEncerrado = new System.Windows.Forms.CheckBox();
            this.labelDtPedido = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.txtStatusPedido = new System.Windows.Forms.TextBox();
            this.txtNmrVolumes = new System.Windows.Forms.TextBox();
            this.txtValorPedido = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtDtPedido = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturnMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAprovar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPedido
            // 
            this.dtgPedido.AllowUserToAddRows = false;
            this.dtgPedido.AllowUserToDeleteRows = false;
            this.dtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedido.Location = new System.Drawing.Point(69, 219);
            this.dtgPedido.Name = "dtgPedido";
            this.dtgPedido.ReadOnly = true;
            this.dtgPedido.RowHeadersWidth = 51;
            this.dtgPedido.RowTemplate.Height = 25;
            this.dtgPedido.Size = new System.Drawing.Size(803, 251);
            this.dtgPedido.TabIndex = 1;
            this.dtgPedido.Visible = false;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirma.Location = new System.Drawing.Point(19, 299);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(203, 51);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            // 
            // cbAberto
            // 
            this.cbAberto.AutoSize = true;
            this.cbAberto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAberto.Location = new System.Drawing.Point(19, 159);
            this.cbAberto.Name = "cbAberto";
            this.cbAberto.Size = new System.Drawing.Size(74, 24);
            this.cbAberto.TabIndex = 5;
            this.cbAberto.Text = "Aberto";
            this.cbAberto.UseVisualStyleBackColor = true;
            // 
            // cbEncerrado
            // 
            this.cbEncerrado.AutoSize = true;
            this.cbEncerrado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEncerrado.Location = new System.Drawing.Point(99, 159);
            this.cbEncerrado.Name = "cbEncerrado";
            this.cbEncerrado.Size = new System.Drawing.Size(95, 24);
            this.cbEncerrado.TabIndex = 6;
            this.cbEncerrado.Text = "Encerrado";
            this.cbEncerrado.UseVisualStyleBackColor = true;
            // 
            // labelDtPedido
            // 
            this.labelDtPedido.AutoSize = true;
            this.labelDtPedido.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDtPedido.Location = new System.Drawing.Point(19, 37);
            this.labelDtPedido.Name = "labelDtPedido";
            this.labelDtPedido.Size = new System.Drawing.Size(225, 37);
            this.labelDtPedido.TabIndex = 8;
            this.labelDtPedido.Text = "Confirmar Pedido";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(229, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 27);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Até";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(619, 37);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 23);
            this.txtIdPedido.TabIndex = 16;
            this.txtIdPedido.Visible = false;
            // 
            // txtStatusPedido
            // 
            this.txtStatusPedido.Location = new System.Drawing.Point(619, 78);
            this.txtStatusPedido.Name = "txtStatusPedido";
            this.txtStatusPedido.Size = new System.Drawing.Size(100, 23);
            this.txtStatusPedido.TabIndex = 17;
            this.txtStatusPedido.Visible = false;
            // 
            // txtNmrVolumes
            // 
            this.txtNmrVolumes.Location = new System.Drawing.Point(619, 124);
            this.txtNmrVolumes.Name = "txtNmrVolumes";
            this.txtNmrVolumes.Size = new System.Drawing.Size(100, 23);
            this.txtNmrVolumes.TabIndex = 18;
            this.txtNmrVolumes.Visible = false;
            // 
            // txtValorPedido
            // 
            this.txtValorPedido.Location = new System.Drawing.Point(619, 171);
            this.txtValorPedido.Name = "txtValorPedido";
            this.txtValorPedido.Size = new System.Drawing.Size(100, 23);
            this.txtValorPedido.TabIndex = 19;
            this.txtValorPedido.Visible = false;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(750, 44);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 23);
            this.txtIdCliente.TabIndex = 21;
            this.txtIdCliente.Visible = false;
            // 
            // txtDtPedido
            // 
            this.txtDtPedido.Location = new System.Drawing.Point(750, 78);
            this.txtDtPedido.Name = "txtDtPedido";
            this.txtDtPedido.Size = new System.Drawing.Size(100, 23);
            this.txtDtPedido.TabIndex = 22;
            this.txtDtPedido.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturnMenu,
            this.toolStripSeparator1,
            this.btnAprovar,
            this.toolStripSeparator2,
            this.btnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Image = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.btnReturnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(58, 22);
            this.btnReturnMenu.Text = "Menu";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAprovar.Image = global::GuizzoLtda.Properties.Resources.checkimage;
            this.btnAprovar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(97, 22);
            this.btnAprovar.Text = "Recebimento";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Enabled = false;
            this.btnVoltar.Image = global::GuizzoLtda.Properties.Resources.FlechaReturn;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(72, 22);
            this.btnVoltar.Text = "Retornar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "RESOLVIDUS";
            // 
            // PedidoFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDtPedido);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtValorPedido);
            this.Controls.Add(this.txtNmrVolumes);
            this.Controls.Add(this.txtStatusPedido);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDtPedido);
            this.Controls.Add(this.cbEncerrado);
            this.Controls.Add(this.cbAberto);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.dtgPedido);
            this.Name = "PedidoFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label2;
    }
}