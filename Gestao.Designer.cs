namespace StorageProject
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.dataGridGestao.Location = new System.Drawing.Point(99, 49);
            this.dataGridGestao.Name = "dataGridGestao";
            this.dataGridGestao.Size = new System.Drawing.Size(1333, 118);
            this.dataGridGestao.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1337, 9);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 27);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Navy;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(-1, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 667);
            this.listBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 9);
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
            this.pictureBox1.Size = new System.Drawing.Size(79, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // clnEnd
            // 
            this.clnEnd.DataPropertyName = "Endereco";
            this.clnEnd.HeaderText = "ENDEREÇO";
            this.clnEnd.Name = "clnEnd";
            this.clnEnd.Width = 90;
            // 
            // clnPL
            // 
            this.clnPL.DataPropertyName = "PalletID";
            this.clnPL.HeaderText = "PALLET ID";
            this.clnPL.Name = "clnPL";
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
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 672);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
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
        private System.Windows.Forms.Button btnVoltar;
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
    }
}