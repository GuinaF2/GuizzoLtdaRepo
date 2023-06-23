namespace GuizzoLtda
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            SelectEmp = new Button();
            btnAcessarSys = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SelectEmp
            // 
            SelectEmp.FlatStyle = FlatStyle.Popup;
            SelectEmp.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            SelectEmp.ForeColor = Color.White;
            SelectEmp.Location = new Point(350, 313);
            SelectEmp.Margin = new Padding(3, 4, 3, 4);
            SelectEmp.Name = "SelectEmp";
            SelectEmp.Size = new Size(380, 112);
            SelectEmp.TabIndex = 2;
            SelectEmp.Text = "Selecionar Empresa";
            SelectEmp.UseVisualStyleBackColor = true;
            SelectEmp.Click += button1_Click;
            // 
            // btnAcessarSys
            // 
            btnAcessarSys.Enabled = false;
            btnAcessarSys.FlatStyle = FlatStyle.Popup;
            btnAcessarSys.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcessarSys.ForeColor = Color.White;
            btnAcessarSys.Location = new Point(350, 158);
            btnAcessarSys.Margin = new Padding(3, 4, 3, 4);
            btnAcessarSys.Name = "btnAcessarSys";
            btnAcessarSys.Size = new Size(380, 112);
            btnAcessarSys.TabIndex = 2;
            btnAcessarSys.Text = "Acessar Sistema";
            btnAcessarSys.UseVisualStyleBackColor = true;
            btnAcessarSys.EnabledChanged += btnAcessarSys_EnabledChanged;
            btnAcessarSys.Click += btnAcessarSys_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(173, 11, 0);
            button1.Location = new Point(290, 0);
            button1.Name = "button1";
            button1.Size = new Size(500, 1000);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(173, 11, 0);
            label1.Font = new Font("Leelawadee UI", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(386, 43);
            label1.Name = "label1";
            label1.Size = new Size(321, 72);
            label1.TabIndex = 3;
            label1.Text = "Oieeeeee :3";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 430);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1062, 673);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnAcessarSys);
            Controls.Add(SelectEmp);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inicio";
            Text = "Inicio";
            FormClosed += Inicio_FormClosed;
            Load += Inicio_Load;
            Leave += Inicio_Leave;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectEmp;
        public Button btnAcessarSys;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}