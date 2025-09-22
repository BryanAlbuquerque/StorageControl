using System;
using System.Windows.Forms;
using StorageControl.Classes;


namespace StorageControl.Forms
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            DateTime dataEntrada = dtData.Value;
            string nome = txtNome.Text;
            string fornecedor = txtForn.Text;
            int quantidade = int.Parse(txtQtde.Text);

            string valorUnitario = txtValorUni.Text.ToString();
            string valorTotal = txtValor.Text.ToString();

            int numeroNotaFiscal = int.Parse(txtNF.Text);
            string numeroPedido = txtNP.Text.ToString();
            int PLID = int.Parse(txtPL.Text);
            int reColab = int.Parse(txtReColab.Text);



            if (string.IsNullOrEmpty(nome) ||
                string.IsNullOrEmpty(fornecedor) ||
                string.IsNullOrEmpty(txtQtde.Text) ||
                string.IsNullOrEmpty(valorUnitario) ||
                string.IsNullOrEmpty(valorTotal) ||
                string.IsNullOrEmpty(txtNF.Text) ||
                string.IsNullOrEmpty(numeroPedido) ||
                string.IsNullOrEmpty(txtPL.Text) ||
                string.IsNullOrEmpty(txtReColab.Text))
            {
                MessageBox.Show("Erro! Existem espaços em branco!");
            }
            else if (EntradaDB.Entrada(
            dataEntrada,
            nome,
            fornecedor,
            quantidade,
            valorUnitario,
            valorTotal,
            numeroNotaFiscal,
            numeroPedido,
            PLID,
            reColab))
            {
                MessageBox.Show("Entrada realizado com sucesso!");
            }

            if (txtNP.Text.Length > 10)
            {
                MessageBox.Show("Permitido Somente 10 Caracteres!");
            }
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

            dtData.Value = DateTime.Now;
            MessageBox.Show("Qualquer erro de preencimento é necessario" +
                " contatar aos Adiminstradores para realizar as alterações!");
        }
    }
}
