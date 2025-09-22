namespace StorageControl.Forms
{
    partial class Gestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestao));
            this.dataGridGestao = new System.Windows.Forms.DataGridView();
            this.clnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtdeIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtdeAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGestao
            // 
            this.dataGridGestao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridGestao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGestao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnEnd,
            this.clnPL,
            this.clnData,
            this.clnNomeIn,
            this.clnForn,
            this.clnQtdeIni,
            this.clnValorUni,
            this.clnValorTotal,
            this.clnNF,
            this.clnNP,
            this.clnCon,
            this.clnQtdeAtual,
            this.clnColaborador});
            this.dataGridGestao.Location = new System.Drawing.Point(99, 62);
            this.dataGridGestao.Name = "dataGridGestao";
            this.dataGridGestao.Size = new System.Drawing.Size(1333, 635);
            this.dataGridGestao.TabIndex = 4;
            // 
            // clnEnd
            // 
            this.clnEnd.DataPropertyName = "Endereco";
            this.clnEnd.HeaderText = "ENDEREÇO";
            this.clnEnd.Name = "clnEnd";
            this.clnEnd.Width = 110;
            // 
            // clnPL
            // 
            this.clnPL.DataPropertyName = "PalletID";
            this.clnPL.HeaderText = "PALLET ID";
            this.clnPL.Name = "clnPL";
            this.clnPL.Width = 90;
            // 
            // clnData
            // 
            this.clnData.DataPropertyName = "DataEntrada";
            this.clnData.HeaderText = "DATA DE ENTRADA";
            this.clnData.Name = "clnData";
            // 
            // clnNomeIn
            // 
            this.clnNomeIn.DataPropertyName = "NomeInsumo";
            this.clnNomeIn.HeaderText = "NOME DO INSUMO";
            this.clnNomeIn.Name = "clnNomeIn";
            // 
            // clnForn
            // 
            this.clnForn.DataPropertyName = "Fornecedor";
            this.clnForn.HeaderText = "FORNECEDOR";
            this.clnForn.Name = "clnForn";
            // 
            // clnQtdeIni
            // 
            this.clnQtdeIni.DataPropertyName = "Quantidade";
            this.clnQtdeIni.HeaderText = "QUANTIDADE";
            this.clnQtdeIni.Name = "clnQtdeIni";
            // 
            // clnValorUni
            // 
            this.clnValorUni.DataPropertyName = "ValorUnitario";
            this.clnValorUni.HeaderText = "VALOR UNITÁRIO";
            this.clnValorUni.Name = "clnValorUni";
            // 
            // clnValorTotal
            // 
            this.clnValorTotal.DataPropertyName = "ValorTotal";
            this.clnValorTotal.HeaderText = "VALOR TOTAL";
            this.clnValorTotal.Name = "clnValorTotal";
            // 
            // clnNF
            // 
            this.clnNF.DataPropertyName = "NumeroNotaFiscal";
            this.clnNF.HeaderText = "NÚMERO DA NOTA FISCAL";
            this.clnNF.Name = "clnNF";
            // 
            // clnNP
            // 
            this.clnNP.DataPropertyName = "NumeroPedido";
            this.clnNP.HeaderText = "NÚMERO DO PEDIDO";
            this.clnNP.Name = "clnNP";
            // 
            // clnCon
            // 
            this.clnCon.DataPropertyName = "Consumo";
            this.clnCon.HeaderText = "CONSUMO";
            this.clnCon.Name = "clnCon";
            this.clnCon.Width = 90;
            // 
            // clnQtdeAtual
            // 
            this.clnQtdeAtual.DataPropertyName = "QuantidadeAtual";
            this.clnQtdeAtual.HeaderText = "QUANTIDADE ATUAL";
            this.clnQtdeAtual.Name = "clnQtdeAtual";
            // 
            // clnColaborador
            // 
            this.clnColaborador.DataPropertyName = "ID_RegistroEmpresarial";
            this.clnColaborador.HeaderText = "RE DO COLABORADOR";
            this.clnColaborador.Name = "clnColaborador";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Navy;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-2, -2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 1083);
            this.listBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Gestão do Estoque";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
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
            this.btnVoltar.Location = new System.Drawing.Point(2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 25);
            this.btnVoltar.TabIndex = 99;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.BorderColor = System.Drawing.Color.Navy;
            this.btnSalvar.BorderRadius = 15;
            this.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvar.FillColor = System.Drawing.Color.Navy;
            this.btnSalvar.FillColor2 = System.Drawing.Color.Red;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(1238, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(190, 42);
            this.btnSalvar.TabIndex = 105;
            this.btnSalvar.Text = "Salvar alterações";
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridGestao);
            this.Controls.Add(this.listBox1);
            this.MinimizeBox = false;
            this.Name = "Gestao";
            this.Load += new System.EventHandler(this.Gestao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridGestao;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtdeIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtdeAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnColaborador;
        private Guna.UI2.WinForms.Guna2GradientButton btnVoltar;
        private Guna.UI2.WinForms.Guna2GradientButton btnSalvar;
    }
}