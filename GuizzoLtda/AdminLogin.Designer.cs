namespace GuizzoLtda
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserAdm = new System.Windows.Forms.TextBox();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.txtSenhaAdm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtUserAdm
            // 
            resources.ApplyResources(this.txtUserAdm, "txtUserAdm");
            this.txtUserAdm.Name = "txtUserAdm";
            // 
            // btnLoginAdmin
            // 
            resources.ApplyResources(this.btnLoginAdmin, "btnLoginAdmin");
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            // 
            // txtSenhaAdm
            // 
            resources.ApplyResources(this.txtSenhaAdm, "txtSenhaAdm");
            this.txtSenhaAdm.Name = "txtSenhaAdm";
            // 
            // AdminLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSenhaAdm);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.txtUserAdm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserAdm;
        private Button btnLoginAdmin;
        private TextBox txtSenhaAdm;
    }
}