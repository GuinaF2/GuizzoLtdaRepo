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
            toolStripTextBox2 = new ToolStripSplitButton();
            abrirPedidoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            veiculosToolStripMenuItem = new ToolStripMenuItem();
            motoristasToolStripMenuItem = new ToolStripMenuItem();
            empresasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSplitButton1 = new ToolStripSplitButton();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            pbFotoAdminMenu = new PictureBox();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoAdminMenu).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(173, 11, 0);
            toolStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, toolStripSeparator3, toolStripTextBox2, toolStripSeparator2, toolStripSplitButton1, toolStripSplitButton2, toolStripSeparator1, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(929, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Transparent;
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.Goldenrod;
            btnReturn.Image = Properties.Resources._688879_arrows_512x512;
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(73, 24);
            btnReturn.Text = "Menu";
            btnReturn.Click += btnReturn_Click_1;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.DropDownItems.AddRange(new ToolStripItem[] { abrirPedidoToolStripMenuItem, pedidosToolStripMenuItem, veiculosToolStripMenuItem, motoristasToolStripMenuItem, empresasToolStripMenuItem });
            toolStripTextBox2.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripTextBox2.ForeColor = Color.Goldenrod;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(74, 24);
            toolStripTextBox2.Text = "Alterar";
            toolStripTextBox2.ButtonClick += toolStripTextBox2_ButtonClick;
            // 
            // abrirPedidoToolStripMenuItem
            // 
            abrirPedidoToolStripMenuItem.Name = "abrirPedidoToolStripMenuItem";
            abrirPedidoToolStripMenuItem.Size = new Size(180, 24);
            abrirPedidoToolStripMenuItem.Text = "Funcionarios";
            abrirPedidoToolStripMenuItem.Click += abrirPedidoToolStripMenuItem_Click;
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(180, 24);
            pedidosToolStripMenuItem.Text = "Pedidos";
            pedidosToolStripMenuItem.Click += pedidosToolStripMenuItem_Click_1;
            // 
            // veiculosToolStripMenuItem
            // 
            veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            veiculosToolStripMenuItem.Size = new Size(180, 24);
            veiculosToolStripMenuItem.Text = "Veiculos";
            veiculosToolStripMenuItem.Click += veiculosToolStripMenuItem_Click_1;
            // 
            // motoristasToolStripMenuItem
            // 
            motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            motoristasToolStripMenuItem.Size = new Size(180, 24);
            motoristasToolStripMenuItem.Text = "Motoristas";
            motoristasToolStripMenuItem.Click += motoristasToolStripMenuItem_Click_1;
            // 
            // empresasToolStripMenuItem
            // 
            empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            empresasToolStripMenuItem.Size = new Size(180, 24);
            empresasToolStripMenuItem.Text = "Empresas";
            empresasToolStripMenuItem.Click += empresasToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { encerrarToolStripMenuItem });
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(69, 24);
            toolStripSplitButton1.Text = "Sistema";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(125, 22);
            encerrarToolStripMenuItem.Text = "Encerrar";
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton2.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripSplitButton2.ForeColor = Color.Goldenrod;
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(94, 24);
            toolStripSplitButton2.Text = "Solicitações";
            toolStripSplitButton2.TextImageRelation = TextImageRelation.TextAboveImage;
            toolStripSplitButton2.Click += toolStripSplitButton2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripButton1.ForeColor = Color.Goldenrod;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(134, 24);
            toolStripButton1.Text = "Cadastros Cliente";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // pbFotoAdminMenu
            // 
            pbFotoAdminMenu.BackColor = Color.Black;
            pbFotoAdminMenu.BorderStyle = BorderStyle.Fixed3D;
            pbFotoAdminMenu.Location = new Point(498, 23);
            pbFotoAdminMenu.Name = "pbFotoAdminMenu";
            pbFotoAdminMenu.Size = new Size(432, 485);
            pbFotoAdminMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoAdminMenu.TabIndex = 2;
            pbFotoAdminMenu.TabStop = false;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(173, 11, 0);
            ClientSize = new Size(929, 505);
            Controls.Add(toolStrip1);
            Controls.Add(pbFotoAdminMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMenu";
            Load += AdminMenu_Load_1;
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
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private PictureBox pbFotoAdminMenu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnReturn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripSplitButton2;
        private ToolStripSeparator toolStripSeparator3;
    }
}