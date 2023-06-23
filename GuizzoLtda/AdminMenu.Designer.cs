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
            btnReturn = new ToolStripButton();
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
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            pbFotoAdminMenu = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoAdminMenu).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, toolStripSeparator1, toolStripTextBox2, toolStripSeparator2, toolStripSplitButton6, toolStripSplitButton1, toolStripSeparator3, toolStripButton1, toolStripSeparator4, toolStripSeparator5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1062, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.DropDownItems.AddRange(new ToolStripItem[] { abrirPedidoToolStripMenuItem, pedidosToolStripMenuItem, veiculosToolStripMenuItem, motoristasToolStripMenuItem, empresasToolStripMenuItem });
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(73, 24);
            toolStripTextBox2.Text = "Alterar";
            toolStripTextBox2.ButtonClick += toolStripTextBox2_ButtonClick;
            // 
            // abrirPedidoToolStripMenuItem
            // 
            abrirPedidoToolStripMenuItem.Name = "abrirPedidoToolStripMenuItem";
            abrirPedidoToolStripMenuItem.Size = new Size(175, 26);
            abrirPedidoToolStripMenuItem.Text = "Funcionarios";
            abrirPedidoToolStripMenuItem.Click += abrirPedidoToolStripMenuItem_Click_1;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(175, 26);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click;
            // 
            // veiculosToolStripMenuItem
            // 
            veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            veiculosToolStripMenuItem.Size = new Size(175, 26);
            veiculosToolStripMenuItem.Text = "Veiculos";
            veiculosToolStripMenuItem.Click += veiculosToolStripMenuItem_Click;
            // 
            // motoristasToolStripMenuItem
            // 
            motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            motoristasToolStripMenuItem.Size = new Size(175, 26);
            motoristasToolStripMenuItem.Text = "Motoristas";
            motoristasToolStripMenuItem.Click += motoristasToolStripMenuItem_Click;
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.Size = new Size(175, 26);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += empresasToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripSplitButton6
            // 
            toolStripSplitButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton6.Image = (Image)resources.GetObject("toolStripSplitButton6.Image");
            toolStripSplitButton6.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton6.Name = "toolStripSplitButton6";
            toolStripSplitButton6.Size = new Size(105, 24);
            toolStripSplitButton6.Text = "Devoluções";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { encerrarToolStripMenuItem });
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(80, 24);
            toolStripSplitButton1.Text = "Sistema";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(146, 26);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += encerrarToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(106, 24);
            toolStripButton1.Text = "Rentabilidade";
            toolStripButton1.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // pbFotoAdminMenu
            // 
            pbFotoAdminMenu.BorderStyle = BorderStyle.Fixed3D;
            pbFotoAdminMenu.Location = new Point(458, 37);
            pbFotoAdminMenu.Margin = new Padding(3, 4, 3, 4);
            pbFotoAdminMenu.Name = "pbFotoAdminMenu";
            pbFotoAdminMenu.Size = new Size(455, 561);
            pbFotoAdminMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoAdminMenu.TabIndex = 2;
            pbFotoAdminMenu.TabStop = false;
            pbFotoAdminMenu.Click += pbFotoAdminMenu_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(pbFotoAdminMenu);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoAdminMenu).EndInit();
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
        private PictureBox pbFotoAdminMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnReturn;
        private ToolStripSeparator toolStripSeparator5;
    }
}