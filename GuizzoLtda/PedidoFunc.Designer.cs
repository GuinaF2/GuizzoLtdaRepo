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
            this.txtEmpresaid = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dtgPedido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmpresaId = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.cbAberto = new System.Windows.Forms.CheckBox();
            this.cbEncerrado = new System.Windows.Forms.CheckBox();
            this.txtDtPedido = new System.Windows.Forms.TextBox();
            this.labelDtPedido = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReturn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmpresaid
            // 
            this.txtEmpresaid.Location = new System.Drawing.Point(19, 56);
            this.txtEmpresaid.Name = "txtEmpresaid";
            this.txtEmpresaid.Size = new System.Drawing.Size(100, 23);
            this.txtEmpresaid.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // dtgPedido
            // 
            this.dtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedido.Location = new System.Drawing.Point(-2, 199);
            this.dtgPedido.Name = "dtgPedido";
            this.dtgPedido.RowTemplate.Height = 25;
            this.dtgPedido.Size = new System.Drawing.Size(803, 251);
            this.dtgPedido.TabIndex = 1;
            this.dtgPedido.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // labelEmpresaId
            // 
            this.labelEmpresaId.AutoSize = true;
            this.labelEmpresaId.Location = new System.Drawing.Point(19, 38);
            this.labelEmpresaId.Name = "labelEmpresaId";
            this.labelEmpresaId.Size = new System.Drawing.Size(62, 15);
            this.labelEmpresaId.TabIndex = 3;
            this.labelEmpresaId.Text = "EmpresaId";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(19, 299);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(144, 40);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // cbAberto
            // 
            this.cbAberto.AutoSize = true;
            this.cbAberto.Location = new System.Drawing.Point(19, 150);
            this.cbAberto.Name = "cbAberto";
            this.cbAberto.Size = new System.Drawing.Size(62, 19);
            this.cbAberto.TabIndex = 5;
            this.cbAberto.Text = "Aberto";
            this.cbAberto.UseVisualStyleBackColor = true;
            this.cbAberto.CheckedChanged += new System.EventHandler(this.cbAberto_CheckedChanged);
            // 
            // cbEncerrado
            // 
            this.cbEncerrado.AutoSize = true;
            this.cbEncerrado.Location = new System.Drawing.Point(99, 150);
            this.cbEncerrado.Name = "cbEncerrado";
            this.cbEncerrado.Size = new System.Drawing.Size(79, 19);
            this.cbEncerrado.TabIndex = 6;
            this.cbEncerrado.Text = "Encerrado";
            this.cbEncerrado.UseVisualStyleBackColor = true;
            this.cbEncerrado.CheckedChanged += new System.EventHandler(this.cbEncerrado_CheckedChanged);
            // 
            // txtDtPedido
            // 
            this.txtDtPedido.Location = new System.Drawing.Point(19, 110);
            this.txtDtPedido.Name = "txtDtPedido";
            this.txtDtPedido.Size = new System.Drawing.Size(100, 23);
            this.txtDtPedido.TabIndex = 7;
            // 
            // labelDtPedido
            // 
            this.labelDtPedido.AutoSize = true;
            this.labelDtPedido.Location = new System.Drawing.Point(19, 92);
            this.labelDtPedido.Name = "labelDtPedido";
            this.labelDtPedido.Size = new System.Drawing.Size(71, 15);
            this.labelDtPedido.TabIndex = 8;
            this.labelDtPedido.Text = "Data Pedido";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnReturn
            // 
            this.btnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturn.Image = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(23, 22);
            this.btnReturn.Text = "toolStripButton1";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // PedidoFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelDtPedido);
            this.Controls.Add(this.txtDtPedido);
            this.Controls.Add(this.cbEncerrado);
            this.Controls.Add(this.cbAberto);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.labelEmpresaId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgPedido);
            this.Controls.Add(this.txtEmpresaid);
            this.Name = "PedidoFunc";
            this.Load += new System.EventHandler(this.PedidoFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmpresaid;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dtgPedido;
        private Label label1;
        private Label labelEmpresaId;
        private Button btnConfirma;
        private CheckBox cbAberto;
        private CheckBox cbEncerrado;
        private TextBox txtDtPedido;
        private Label labelDtPedido;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
    }
}