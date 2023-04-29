namespace GuizzoLtda
{
    partial class FuncionarioMenu
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
            toolStrip1 = new ToolStrip();
            toolStripTextBox2 = new ToolStripSplitButton();
            toolStripSplitButton5 = new ToolStripSplitButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            sadsdasToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox2, toolStripSplitButton5, toolStripSplitButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.DropDownItems.AddRange(new ToolStripItem[] { sadsdasToolStripMenuItem });
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 22);
            toolStripTextBox2.Text = "Configurações";
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // toolStripSplitButton5
            // 
            toolStripSplitButton5.Name = "toolStripSplitButton5";
            toolStripSplitButton5.Size = new Size(68, 22);
            toolStripSplitButton5.Text = "Retornar";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(64, 22);
            toolStripSplitButton1.Text = "Sistema";
            // 
            // sadsdasToolStripMenuItem
            // 
            sadsdasToolStripMenuItem.Name = "sadsdasToolStripMenuItem";
            sadsdasToolStripMenuItem.Size = new Size(180, 22);
            sadsdasToolStripMenuItem.Text = "sadsdas";
            // 
            // FuncionarioMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "FuncionarioMenu";
            Text = "FuncionarioMenu";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripSplitButton toolStripTextBox2;
        private ToolStripSplitButton toolStripSplitButton5;
        private ToolStripSplitButton toolStripSplitButton4;
        private ToolStripSplitButton toolStripSplitButton3;
        private ToolStripMenuItem sadsdasToolStripMenuItem;
    }
}