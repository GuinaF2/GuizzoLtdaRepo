namespace GuizzoLtda
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox2 = new ToolStripSplitButton();
            abrirPedidoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            veiculosToolStripMenuItem = new ToolStripMenuItem();
            motoristasToolStripMenuItem = new ToolStripMenuItem();
            empresasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSplitButton6 = new ToolStripSplitButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripTextBox2, toolStripSeparator2, toolStripSplitButton6, toolStripSplitButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.DropDownItems.AddRange(new ToolStripItem[] { abrirPedidoToolStripMenuItem, pedidosToolStripMenuItem, veiculosToolStripMenuItem, motoristasToolStripMenuItem, empresasToolStripMenuItem });
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(58, 22);
            toolStripTextBox2.Text = "Alterar";
            toolStripTextBox2.ButtonClick += toolStripTextBox2_ButtonClick;
            // 
            // abrirPedidoToolStripMenuItem
            // 
            abrirPedidoToolStripMenuItem.Name = "abrirPedidoToolStripMenuItem";
            abrirPedidoToolStripMenuItem.Size = new Size(142, 22);
            abrirPedidoToolStripMenuItem.Text = "Funcionarios";
            abrirPedidoToolStripMenuItem.Click += abrirPedidoToolStripMenuItem_Click_1;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(142, 22);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // veiculosToolStripMenuItem
            // 
            veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            veiculosToolStripMenuItem.Size = new Size(142, 22);
            veiculosToolStripMenuItem.Text = "Veiculos";
            veiculosToolStripMenuItem.Click += veiculosToolStripMenuItem_Click;
            // 
            // motoristasToolStripMenuItem
            // 
            motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            motoristasToolStripMenuItem.Size = new Size(142, 22);
            motoristasToolStripMenuItem.Text = "Motoristas";
            motoristasToolStripMenuItem.Click += motoristasToolStripMenuItem_Click;
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.Size = new Size(142, 22);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += empresasToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSplitButton6
            // 
            toolStripSplitButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton6.Image = (Image)resources.GetObject("toolStripSplitButton6.Image");
            toolStripSplitButton6.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton6.Name = "toolStripSplitButton6";
            toolStripSplitButton6.Size = new Size(75, 22);
            toolStripSplitButton6.Text = "Relatorios";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { encerrarToolStripMenuItem });
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(64, 22);
            toolStripSplitButton1.Text = "Sistema";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(117, 22);
            encerrarToolStripMenuItem.Text = "Encerrar";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(401, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 422);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripTextBox2;
        private ToolStripMenuItem abrirPedidoToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem veiculosToolStripMenuItem;
        private ToolStripMenuItem motoristasToolStripMenuItem;
        private ToolStripMenuItem empresasToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton6;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
    }
}