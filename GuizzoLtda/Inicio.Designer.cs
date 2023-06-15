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
            SelectEmp = new Button();
            btnAcessarSys = new Button();
            SuspendLayout();
            // 
            // SelectEmp
            // 
            SelectEmp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SelectEmp.Location = new Point(24, 192);
            SelectEmp.Name = "SelectEmp";
            SelectEmp.Size = new Size(245, 63);
            SelectEmp.TabIndex = 0;
            SelectEmp.Text = "Selecionar Empresa";
            SelectEmp.UseVisualStyleBackColor = true;
            SelectEmp.Click += button1_Click;
            // 
            // btnAcessarSys
            // 
            btnAcessarSys.Enabled = false;
            btnAcessarSys.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcessarSys.Location = new Point(415, 179);
            btnAcessarSys.Name = "btnAcessarSys";
            btnAcessarSys.Size = new Size(337, 84);
            btnAcessarSys.TabIndex = 1;
            btnAcessarSys.Text = "Acessar Sistema";
            btnAcessarSys.UseVisualStyleBackColor = true;
            btnAcessarSys.EnabledChanged += btnAcessarSys_EnabledChanged;
            btnAcessarSys.Click += btnAcessarSys_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAcessarSys);
            Controls.Add(SelectEmp);
            Name = "Inicio";
            Text = "Inicio";
            FormClosed += Inicio_FormClosed;
            Load += Inicio_Load;
            Leave += Inicio_Leave;
            ResumeLayout(false);
        }

        #endregion

        private Button SelectEmp;
        public Button btnAcessarSys;
    }
}