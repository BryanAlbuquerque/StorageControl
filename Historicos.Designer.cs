namespace StorageProject
{
    partial class Historicos
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBaixas = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_RegistroEmpresarial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalletID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetorSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Navy;
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-5, -7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(805, 108);
            this.listBox1.TabIndex = 6;
            // 
            // btnBaixas
            // 
            this.btnBaixas.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBaixas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaixas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixas.ForeColor = System.Drawing.Color.White;
            this.btnBaixas.Location = new System.Drawing.Point(1, 7);
            this.btnBaixas.Name = "btnBaixas";
            this.btnBaixas.Size = new System.Drawing.Size(143, 51);
            this.btnBaixas.TabIndex = 32;
            this.btnBaixas.Text = "Histórico Baixas";
            this.btnBaixas.UseVisualStyleBackColor = false;
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Navy;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(165, 6);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(153, 51);
            this.btnHistorico.TabIndex = 33;
            this.btnHistorico.Text = "Histórico Endereçamentos";
            this.btnHistorico.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.ID_RegistroEmpresarial,
            this.PalletID,
            this.SetorSolicitante,
            this.Quantidade});
            this.dataGridView1.Location = new System.Drawing.Point(1, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(799, 349);
            this.dataGridView1.TabIndex = 34;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 140;
            // 
            // ID_RegistroEmpresarial
            // 
            this.ID_RegistroEmpresarial.HeaderText = "ID_RegistroEmpresarial";
            this.ID_RegistroEmpresarial.Name = "ID_RegistroEmpresarial";
            this.ID_RegistroEmpresarial.ReadOnly = true;
            this.ID_RegistroEmpresarial.Width = 150;
            // 
            // PalletID
            // 
            this.PalletID.HeaderText = "PalletID";
            this.PalletID.Name = "PalletID";
            this.PalletID.ReadOnly = true;
            // 
            // SetorSolicitante
            // 
            this.SetorSolicitante.HeaderText = "Setor Solicitante";
            this.SetorSolicitante.Name = "SetorSolicitante";
            this.SetorSolicitante.ReadOnly = true;
            this.SetorSolicitante.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 130;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(684, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 27);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // Historicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnBaixas);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historicos";
            this.Text = "Historicos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBaixas;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RegistroEmpresarial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalletID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetorSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnVoltar;
    }
}