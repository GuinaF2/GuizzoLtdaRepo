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
            label1.Location = new Point(42, 75);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira o Id da Empresa";
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.Location = new Point(42, 99);
            txtIdEmpresa.Margin = new Padding(3, 4, 3, 4);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(114, 27);
            txtIdEmpresa.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(42, 351);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(178, 59);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgPedidoEmp
            // 
            dgPedidoEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidoEmp.Location = new Point(115, 124);
            dgPedidoEmp.Margin = new Padding(3, 4, 3, 4);
            dgPedidoEmp.Name = "dgPedidoEmp";
            dgPedidoEmp.RowHeadersWidth = 51;
            dgPedidoEmp.RowTemplate.Height = 25;
            dgPedidoEmp.Size = new Size(733, 324);
            dgPedidoEmp.TabIndex = 3;
            // 
            // PedidoEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 673);
            Controls.Add(dgPedidoEmp);
            Controls.Add(button1);
            Controls.Add(txtIdEmpresa);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PedidoEmpresa";
            Text = "PedidoEmpresa";
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