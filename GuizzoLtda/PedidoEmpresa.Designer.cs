namespace GuizzoLtda
{
    partial class PedidoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoEmpresa));
            label1 = new Label();
            txtIdEmpresa = new TextBox();
            button1 = new Button();
            dgPedidoEmp = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPedidoEmp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Insira o Id da Empresa";
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.Location = new Point(37, 74);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(100, 23);
            txtIdEmpresa.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(37, 263);
            button1.Name = "button1";
            button1.Size = new Size(156, 44);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgPedidoEmp
            // 
            dgPedidoEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidoEmp.Location = new Point(101, 93);
            dgPedidoEmp.Name = "dgPedidoEmp";
            dgPedidoEmp.RowHeadersWidth = 51;
            dgPedidoEmp.RowTemplate.Height = 25;
            dgPedidoEmp.Size = new Size(641, 243);
            dgPedidoEmp.TabIndex = 3;
            // 
            // PedidoEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 505);
            Controls.Add(dgPedidoEmp);
            Controls.Add(button1);
            Controls.Add(txtIdEmpresa);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PedidoEmpresa";
            Text = "PedidoEmpresa";
            Load += PedidoEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dgPedidoEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdEmpresa;
        private Button button1;
        private DataGridView dgPedidoEmp;
    }
}