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
            label2 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgPedidoEmp).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 67);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 0;
            label1.Text = "Insira o Id da Empresa";
            // 
            // txtIdEmpresa
            // 
            txtIdEmpresa.BackColor = Color.Black;
            txtIdEmpresa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdEmpresa.ForeColor = Color.Goldenrod;
            txtIdEmpresa.Location = new Point(49, 106);
            txtIdEmpresa.Name = "txtIdEmpresa";
            txtIdEmpresa.Size = new Size(100, 27);
            txtIdEmpresa.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Goldenrod;
            button1.Location = new Point(48, 261);
            button1.Name = "button1";
            button1.Size = new Size(219, 66);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgPedidoEmp
            // 
            dgPedidoEmp.BackgroundColor = Color.Black;
            dgPedidoEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidoEmp.GridColor = Color.Goldenrod;
            dgPedidoEmp.Location = new Point(89, 159);
            dgPedidoEmp.Name = "dgPedidoEmp";
            dgPedidoEmp.RowHeadersWidth = 51;
            dgPedidoEmp.RowTemplate.Height = 25;
            dgPedidoEmp.Size = new Size(721, 260);
            dgPedidoEmp.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 22);
            label2.Name = "label2";
            label2.Size = new Size(218, 45);
            label2.TabIndex = 5;
            label2.Text = "Verificar Label";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(894, 27);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripButton1.ForeColor = Color.Goldenrod;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(69, 24);
            toolStripButton1.Text = "Menu";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripButton2.ForeColor = Color.Goldenrod;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(91, 24);
            toolStripButton2.Text = "Retornar";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // PedidoEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(894, 505);
            Controls.Add(toolStrip1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dgPedidoEmp);
            Controls.Add(txtIdEmpresa);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PedidoEmpresa";
            Text = "PedidoEmpresa";
            Load += PedidoEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dgPedidoEmp).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdEmpresa;
        private Button button1;
        private DataGridView dgPedidoEmp;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
    }
}