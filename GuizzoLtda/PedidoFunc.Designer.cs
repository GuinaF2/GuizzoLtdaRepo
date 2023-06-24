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
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.dtgPedido = new System.Windows.Forms.DataGridView();
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
            this.dtgPedido.Location = new System.Drawing.Point(0, 198);
            this.dtgPedido.Name = "dtgPedido";
            this.dtgPedido.RowHeadersWidth = 51;
            this.dtgPedido.RowTemplate.Height = 25;
            this.dtgPedido.Size = new System.Drawing.Size(803, 251);
            this.dtgPedido.TabIndex = 1;
            this.dtgPedido.Visible = false;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(19, 299);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(144, 40);
            this.btnConfirma.TabIndex = 4;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
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
            // 
            // txtDtPedido
            // 
            this.txtDtPedido.Location = new System.Drawing.Point(19, 86);
            this.txtDtPedido.Name = "txtDtPedido";
            this.txtDtPedido.Size = new System.Drawing.Size(100, 23);
            this.txtDtPedido.TabIndex = 7;
            // 
            // labelDtPedido
            // 
            this.labelDtPedido.AutoSize = true;
            this.labelDtPedido.Location = new System.Drawing.Point(19, 68);
            this.labelDtPedido.Name = "labelDtPedido";
            this.labelDtPedido.Size = new System.Drawing.Size(71, 15);
            this.labelDtPedido.TabIndex = 8;
            this.labelDtPedido.Text = "Data Pedido";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReturn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            this.btnReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturn.Image = global::GuizzoLtda.Properties.Resources._688879_arrows_512x512;
            this.btnReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(24, 24);
            this.btnReturn.Text = "toolStripButton1";
            // 
            // PedidoFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelDtPedido);
            this.Controls.Add(this.txtDtPedido);
            this.Controls.Add(this.cbEncerrado);
            this.Controls.Add(this.cbAberto);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.dtgPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedidoFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dtgPedido;
        private Button btnConfirma;
        private CheckBox cbAberto;
        private CheckBox cbEncerrado;
        private TextBox txtDtPedido;
        private Label labelDtPedido;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
    }
}