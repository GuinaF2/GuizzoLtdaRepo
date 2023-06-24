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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SelectEmp
            // 
            SelectEmp.FlatStyle = FlatStyle.Popup;
            SelectEmp.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            SelectEmp.ForeColor = Color.White;
            SelectEmp.Location = new Point(311, 267);
            SelectEmp.Name = "SelectEmp";
            SelectEmp.Size = new Size(332, 84);
            SelectEmp.TabIndex = 2;
            SelectEmp.Text = "Selecionar Empresa";
            SelectEmp.UseVisualStyleBackColor = true;
            SelectEmp.Click += SelectEmp_Click;
            // 
            // btnAcessarSys
            // 
            btnAcessarSys.Enabled = false;
            btnAcessarSys.FlatStyle = FlatStyle.Popup;
            btnAcessarSys.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcessarSys.ForeColor = Color.White;
            btnAcessarSys.Location = new Point(311, 150);
            btnAcessarSys.Name = "btnAcessarSys";
            btnAcessarSys.Size = new Size(332, 84);
            btnAcessarSys.TabIndex = 2;
            btnAcessarSys.Text = "Acessar Sistema";
            btnAcessarSys.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(173, 11, 0);
            button1.Location = new Point(254, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(438, 750);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 322);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(173, 10, 0);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(340, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(281, 103);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(929, 505);
            Controls.Add(btnAcessarSys);
            Controls.Add(SelectEmp);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SelectEmp;
        public Button btnAcessarSys;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}