namespace Projeto_TCC.Alterar
{
    partial class frmPets1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Apto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.rbtApto = new System.Windows.Forms.RadioButton();
            this.rbtBloco = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apto,
            this.Bloco,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(25, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(434, 250);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.VirtualMode = true;
            // 
            // Apto
            // 
            this.Apto.FillWeight = 3F;
            this.Apto.HeaderText = "Apto";
            this.Apto.Name = "Apto";
            this.Apto.ReadOnly = true;
            this.Apto.Width = 60;
            // 
            // Bloco
            // 
            this.Bloco.FillWeight = 3F;
            this.Bloco.HeaderText = "Bloco";
            this.Bloco.Name = "Bloco";
            this.Bloco.ReadOnly = true;
            this.Bloco.Width = 60;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 270;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(374, 134);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 35);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(196, 134);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(196, 68);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(263, 29);
            this.txtBusca.TabIndex = 4;
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNome.Location = new System.Drawing.Point(25, 134);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(80, 28);
            this.rbtNome.TabIndex = 3;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            // 
            // rbtApto
            // 
            this.rbtApto.AutoSize = true;
            this.rbtApto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtApto.Location = new System.Drawing.Point(25, 102);
            this.rbtApto.Name = "rbtApto";
            this.rbtApto.Size = new System.Drawing.Size(67, 28);
            this.rbtApto.TabIndex = 2;
            this.rbtApto.TabStop = true;
            this.rbtApto.Text = "Apto";
            this.rbtApto.UseVisualStyleBackColor = true;
            // 
            // rbtBloco
            // 
            this.rbtBloco.AutoSize = true;
            this.rbtBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBloco.Location = new System.Drawing.Point(25, 68);
            this.rbtBloco.Name = "rbtBloco";
            this.rbtBloco.Size = new System.Drawing.Size(76, 28);
            this.rbtBloco.TabIndex = 1;
            this.rbtBloco.TabStop = true;
            this.rbtBloco.Text = "Bloco";
            this.rbtBloco.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 52;
            this.label1.Text = "Buscar Animal";
            // 
            // frmPets1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.rbtNome);
            this.Controls.Add(this.rbtApto);
            this.Controls.Add(this.rbtBloco);
            this.Controls.Add(this.label1);
            this.Name = "frmPets1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPets1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.RadioButton rbtApto;
        private System.Windows.Forms.RadioButton rbtBloco;
        private System.Windows.Forms.Label label1;
    }
}