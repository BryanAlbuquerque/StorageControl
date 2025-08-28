using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();
        }

        private void btnGestao_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.Show();
            this.Hide();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.Show();
            this.Hide();
        }

        private void btnBaixa_Click(object sender, EventArgs e)
        {
            //Visibilidade para o botão Baixa
            lblTituloBaixa.Visible = true;
            lblQtde.Visible = true;
            lblPallet.Visible = true;
            txtQtde.Visible = true;
            txtBaixaPL.Visible = true;
            btnEnviarBaixa.Visible = true;
            PicBoxBaixa.Visible = true;
            lblFrase.Visible = true;
            lblFrase2.Visible = true;
            lblAnotacoes.Visible = true;

            //Esconde os outros componentes
            lblTituloEnd.Visible = false;
            lblPallet2.Visible = false;
            lblEnd.Visible = false;
            txtEnderecoPL.Visible = false;
            txtEnd.Visible = false;
            btnEnviarEnd.Visible = false;
            PicBoxEnd.Visible = false;
        }

        private void btnEnviarBaixa_Click(object sender, EventArgs e)
        {
            int PalletID = int.Parse(txtBaixaPL.Text);
            int Quantidade = int.Parse(txtQtde.Text);
            int RE = int.Parse(txtRE.Text);

            if (string.IsNullOrEmpty(txtBaixaPL.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
            }
            else if (BaixasDB.Baixas(PalletID, Quantidade, RE))
            {
                MessageBox.Show("Baixa realizada!");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Visibilidade do botão de endereçamento
            lblTituloEnd.Visible = true;
            lblPallet2.Visible = true;
            lblEnd.Visible = true;
            txtEnderecoPL.Visible = true;
            txtEnd.Visible = true;
            btnEnviarEnd.Visible = true;
            PicBoxEnd.Visible = true;
            lblFrase.Visible = true;
            lblFrase2.Visible = true;
            lblAnotacoes.Visible = true;

            //Enconde os outros componentes
            lblTituloBaixa.Visible = false;
            lblQtde.Visible = false;
            lblPallet.Visible = false;
            txtQtde.Visible = false;
            txtBaixaPL.Visible = false;
            btnEnviarBaixa.Visible = false;
            PicBoxBaixa.Visible = false;
        }

        private void btnEnviarEnd_Click(object sender, EventArgs e)
        {
            int PalletID = int.Parse(txtEnderecoPL.Text);
            string Endereco = txtEnd.Text;


            if (string.IsNullOrEmpty(txtEnderecoPL.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
            }
            else if (EnderecoDB.Enderecamento(PalletID, Endereco))
            {
                MessageBox.Show("Endereçamento Realizado!");
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
            this.Hide();
        }
    }
}
