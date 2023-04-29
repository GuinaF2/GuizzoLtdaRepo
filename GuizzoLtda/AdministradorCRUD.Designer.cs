namespace GuizzoLtda
{
    partial class AdministradorCRUD
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
            SaveUpdate = new Button();
            SaveDelete = new Button();
            SaveCreate = new Button();
            SuspendLayout();
            // 
            // SaveUpdate
            // 
            SaveUpdate.Location = new Point(72, 239);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(75, 23);
            SaveUpdate.TabIndex = 0;
            SaveUpdate.Text = "Atualizar";
            SaveUpdate.UseVisualStyleBackColor = true;
            // 
            // SaveDelete
            // 
            SaveDelete.Location = new Point(72, 304);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(75, 23);
            SaveDelete.TabIndex = 1;
            SaveDelete.Text = "Deletar";
            SaveDelete.UseVisualStyleBackColor = true;
            // 
            // SaveCreate
            // 
            SaveCreate.Location = new Point(72, 371);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(75, 23);
            SaveCreate.TabIndex = 2;
            SaveCreate.Text = "Cadastrar";
            SaveCreate.UseVisualStyleBackColor = true;
            // 
            // AdministradorCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Name = "AdministradorCRUD";
            Text = "AdministradorCRUD";
            Load += AdministradorCRUD_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button SaveUpdate;
        private Button SaveDelete;
        private Button SaveCreate;
    }
}