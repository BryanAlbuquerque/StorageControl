namespace StorageControl.Forms
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridBaixa = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_RegistroEmpresarial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalletID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetorSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridEndereco = new System.Windows.Forms.DataGridView();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPalletID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHistorico = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnBaixas = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnFechar = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Navy;
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-5, -7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(731, 108);
            this.listBox1.TabIndex = 6;
            // 
            // dataGridBaixa
            // 
            this.dataGridBaixa.AllowUserToDeleteRows = false;
            this.dataGridBaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.ID_RegistroEmpresarial,
            this.PalletID,
            this.SetorSolicitante,
            this.Quantidade});
            this.dataGridBaixa.Location = new System.Drawing.Point(1, 98);
            this.dataGridBaixa.Name = "dataGridBaixa";
            this.dataGridBaixa.ReadOnly = true;
            this.dataGridBaixa.Size = new System.Drawing.Size(716, 349);
            this.dataGridBaixa.TabIndex = 34;
            this.dataGridBaixa.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data_Realizada";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 140;
            // 
            // ID_RegistroEmpresarial
            // 
            this.ID_RegistroEmpresarial.DataPropertyName = "ID_RegistroEmpresarial";
            this.ID_RegistroEmpresarial.HeaderText = "ID_RegistroEmpresarial";
            this.ID_RegistroEmpresarial.Name = "ID_RegistroEmpresarial";
            this.ID_RegistroEmpresarial.ReadOnly = true;
            this.ID_RegistroEmpresarial.Width = 150;
            // 
            // PalletID
            // 
            this.PalletID.DataPropertyName = "PalletID";
            this.PalletID.HeaderText = "PalletID";
            this.PalletID.Name = "PalletID";
            this.PalletID.ReadOnly = true;
            // 
            // SetorSolicitante
            // 
            this.SetorSolicitante.DataPropertyName = "Setor_Solicitante";
            this.SetorSolicitante.HeaderText = "Setor Solicitante";
            this.SetorSolicitante.Name = "SetorSolicitante";
            this.SetorSolicitante.ReadOnly = true;
            this.SetorSolicitante.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 130;
            // 
            // dataGridEndereco
            // 
            this.dataGridEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnData,
            this.clnID,
            this.clnPalletID,
            this.clnEndereco});
            this.dataGridEndereco.Location = new System.Drawing.Point(1, 99);
            this.dataGridEndereco.Name = "dataGridEndereco";
            this.dataGridEndereco.Size = new System.Drawing.Size(716, 349);
            this.dataGridEndereco.TabIndex = 36;
            this.dataGridEndereco.Visible = false;
            // 
            // clnData
            // 
            this.clnData.DataPropertyName = "Data_Realizada";
            this.clnData.HeaderText = "Data Realizada";
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            this.clnData.Width = 160;
            // 
            // clnID
            // 
            this.clnID.DataPropertyName = "ID_RegistroEmpresarial";
            this.clnID.HeaderText = "ID_RegistroEmpresarial";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Width = 150;
            // 
            // clnPalletID
            // 
            this.clnPalletID.DataPropertyName = "PalletID";
            this.clnPalletID.HeaderText = "PalletID";
            this.clnPalletID.Name = "clnPalletID";
            this.clnPalletID.ReadOnly = true;
            this.clnPalletID.Width = 120;
            // 
            // clnEndereco
            // 
            this.clnEndereco.DataPropertyName = "Endereco";
            this.clnEndereco.HeaderText = "Endereço";
            this.clnEndereco.Name = "clnEndereco";
            this.clnEndereco.ReadOnly = true;
            this.clnEndereco.Width = 150;
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Navy;
            this.btnHistorico.BorderColor = System.Drawing.Color.Navy;
            this.btnHistorico.BorderRadius = 15;
            this.btnHistorico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistorico.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistorico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistorico.FillColor = System.Drawing.Color.Red;
            this.btnHistorico.FillColor2 = System.Drawing.Color.Navy;
            this.btnHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(377, 26);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(190, 42);
            this.btnHistorico.TabIndex = 106;
            this.btnHistorico.Text = "Histórico endereçamento";
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click_1);
            // 
            // btnBaixas
            // 
            this.btnBaixas.BackColor = System.Drawing.Color.Navy;
            this.btnBaixas.BorderColor = System.Drawing.Color.Navy;
            this.btnBaixas.BorderRadius = 15;
            this.btnBaixas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBaixas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBaixas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaixas.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBaixas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBaixas.FillColor = System.Drawing.Color.Navy;
            this.btnBaixas.FillColor2 = System.Drawing.Color.Red;
            this.btnBaixas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaixas.ForeColor = System.Drawing.Color.White;
            this.btnBaixas.Location = new System.Drawing.Point(151, 26);
            this.btnBaixas.Name = "btnBaixas";
            this.btnBaixas.Size = new System.Drawing.Size(190, 42);
            this.btnBaixas.TabIndex = 107;
            this.btnBaixas.Text = "Históricos Baixas";
            this.btnBaixas.Click += new System.EventHandler(this.btnBaixas_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.BorderRadius = 10;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.LightGray;
            this.btnVoltar.FillColor2 = System.Drawing.Color.Navy;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(5, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 25);
            this.btnVoltar.TabIndex = 108;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Navy;
            this.btnFechar.BorderRadius = 10;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFechar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFechar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFechar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFechar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFechar.FillColor = System.Drawing.Color.Blue;
            this.btnFechar.FillColor2 = System.Drawing.Color.Red;
            this.btnFechar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(656, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 25);
            this.btnFechar.TabIndex = 109;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Historicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnBaixas);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridEndereco);
            this.Controls.Add(this.dataGridBaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historicos";
            this.Text = "Historicos";
            this.Load += new System.EventHandler(this.Historicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEndereco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridBaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RegistroEmpresarial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalletID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetorSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridView dataGridEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPalletID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndereco;
        private Guna.UI2.WinForms.Guna2GradientButton btnHistorico;
        private Guna.UI2.WinForms.Guna2GradientButton btnBaixas;
        private Guna.UI2.WinForms.Guna2GradientButton btnVoltar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton btnFechar;
    }
}