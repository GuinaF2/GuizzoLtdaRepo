namespace GuizzoLtda
{
    partial class CRUDPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDPedido));
            dataGridCRUD = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnReturn = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCad = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnApaga = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            ajudaToolStripButton = new ToolStripButton();
            txtIdCliente = new TextBox();
            SaveCreate = new Button();
            SaveDelete = new Button();
            SaveUpdate = new Button();
            txtIdMoto = new TextBox();
            txtDataPed = new TextBox();
            txtIdPedido = new TextBox();
            labelidpedido = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridCRUD
            // 
            dataGridCRUD.AllowUserToAddRows = false;
            dataGridCRUD.AllowUserToDeleteRows = false;
            dataGridCRUD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCRUD.Location = new Point(411, -1);
            dataGridCRUD.Name = "dataGridCRUD";
            dataGridCRUD.ReadOnly = true;
            dataGridCRUD.RowTemplate.Height = 25;
            dataGridCRUD.Size = new Size(389, 453);
            dataGridCRUD.TabIndex = 23;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnReturn, btnAtualizar, toolStripSeparator1, btnCad, toolStripSeparator2, btnApaga, toolStripSeparator, ajudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnReturn
            // 
            btnReturn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.ImageTransparentColor = Color.Magenta;
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(23, 22);
            btnReturn.Text = "Retornar";
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAtualizar.Image = (Image)resources.GetObject("btnAtualizar.Image");
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(57, 22);
            btnAtualizar.Text = "Atualizar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnCad
            // 
            btnCad.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCad.Image = (Image)resources.GetObject("btnCad.Image");
            btnCad.ImageTransparentColor = Color.Magenta;
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(61, 22);
            btnCad.Text = "Cadastrar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnApaga
            // 
            btnApaga.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnApaga.Image = (Image)resources.GetObject("btnApaga.Image");
            btnApaga.ImageTransparentColor = Color.Magenta;
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(48, 22);
            btnApaga.Text = "Deletar";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            ajudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ajudaToolStripButton.Image = (Image)resources.GetObject("ajudaToolStripButton.Image");
            ajudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ajudaToolStripButton.Name = "ajudaToolStripButton";
            ajudaToolStripButton.Size = new Size(23, 22);
            ajudaToolStripButton.Text = "Aju&da";
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = Color.White;
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new Point(202, 171);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(125, 23);
            txtIdCliente.TabIndex = 18;
            // 
            // SaveCreate
            // 
            SaveCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveCreate.Location = new Point(52, 298);
            SaveCreate.Name = "SaveCreate";
            SaveCreate.Size = new Size(300, 50);
            SaveCreate.TabIndex = 16;
            SaveCreate.Text = "Salvar Cadastro";
            SaveCreate.UseVisualStyleBackColor = true;
            SaveCreate.Visible = false;
            // 
            // SaveDelete
            // 
            SaveDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveDelete.Location = new Point(52, 331);
            SaveDelete.Name = "SaveDelete";
            SaveDelete.Size = new Size(300, 50);
            SaveDelete.TabIndex = 15;
            SaveDelete.Text = "Salvar Alteração";
            SaveDelete.UseVisualStyleBackColor = true;
            SaveDelete.Visible = false;
            // 
            // SaveUpdate
            // 
            SaveUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUpdate.Location = new Point(52, 365);
            SaveUpdate.Name = "SaveUpdate";
            SaveUpdate.Size = new Size(300, 50);
            SaveUpdate.TabIndex = 14;
            SaveUpdate.Text = "Salvar Alteração";
            SaveUpdate.UseVisualStyleBackColor = true;
            SaveUpdate.Visible = false;
            // 
            // txtIdMoto
            // 
            txtIdMoto.BackColor = Color.White;
            txtIdMoto.Enabled = false;
            txtIdMoto.Location = new Point(71, 171);
            txtIdMoto.Name = "txtIdMoto";
            txtIdMoto.Size = new Size(125, 23);
            txtIdMoto.TabIndex = 30;
            // 
            // txtDataPed
            // 
            txtDataPed.BackColor = Color.White;
            txtDataPed.Location = new Point(270, 242);
            txtDataPed.Name = "txtDataPed";
            txtDataPed.Size = new Size(125, 23);
            txtDataPed.TabIndex = 31;
            // 
            // txtIdPedido
            // 
            txtIdPedido.BackColor = Color.White;
            txtIdPedido.Enabled = false;
            txtIdPedido.Location = new Point(139, 112);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(125, 23);
            txtIdPedido.TabIndex = 34;
            // 
            // labelidpedido
            // 
            labelidpedido.AutoSize = true;
            labelidpedido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelidpedido.Location = new Point(139, 79);
            labelidpedido.Name = "labelidpedido";
            labelidpedido.Size = new Size(100, 30);
            labelidpedido.TabIndex = 33;
            labelidpedido.Text = "Id Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 153);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 35;
            label4.Text = "Id Motorista";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 153);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 36;
            label5.Text = "Id Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(8, 209);
            label6.Name = "label6";
            label6.Size = new Size(123, 30);
            label6.TabIndex = 37;
            label6.Text = "Nº Volumes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(139, 209);
            label7.Name = "label7";
            label7.Size = new Size(100, 30);
            label7.TabIndex = 38;
            label7.Text = "Id Pedido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(270, 209);
            label8.Name = "label8";
            label8.Size = new Size(126, 30);
            label8.TabIndex = 39;
            label8.Text = "Data Pedido";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Enabled = false;
            textBox2.Location = new Point(8, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 40;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Enabled = false;
            textBox3.Location = new Point(139, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 23);
            textBox3.TabIndex = 41;
            // 
            // CRUDPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtIdPedido);
            Controls.Add(labelidpedido);
            Controls.Add(txtDataPed);
            Controls.Add(txtIdMoto);
            Controls.Add(dataGridCRUD);
            Controls.Add(toolStrip1);
            Controls.Add(txtIdCliente);
            Controls.Add(SaveCreate);
            Controls.Add(SaveDelete);
            Controls.Add(SaveUpdate);
            Name = "CRUDPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDPedido";
            Load += CRUDPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCRUD).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridCRUD;
        private ToolStrip toolStrip1;
        private ToolStripButton btnReturn;
        private ToolStripButton btnAtualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCad;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnApaga;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton ajudaToolStripButton;
        private Label labelcargo;
        private ComboBox cbCargo;
        private Label labelsenha;
        private Label labelnome;
        private TextBox txtSenha;
        private TextBox txtNome;
        private TextBox txtIdCliente;
        private Label labelid;
        private Button SaveCreate;
        private Button SaveDelete;
        private Button SaveUpdate;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtIdMoto;
        private Label label2;
        private Label label3;
        private TextBox txtDataPed;
        private TextBox txtIdPedido;
        private Label labelidpedido;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}