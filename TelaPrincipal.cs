using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StorageProject
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private bool _isAdmin;

        public TelaPrincipal(bool isAdmin = false) // por padrão não-admin
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                MessageBox.Show("Bem-vindo! Você entrou como Administrador.");

                btnHistorico.Visible = true; // Exibe o botão Histórico
            }
        }

        private void btnGestao_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao(_isAdmin); // << passa info para a gestão
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
            txtRE.Visible = true;
            btnEnviarBaixa.Visible = true;
            PicBoxBaixa.Visible = true;
            lblFrase.Visible = true;
            lblFrase2.Visible = true;
            //lblAnotacoes.Visible = true;
            lblReBaixa.Visible = true;

            //Esconde os outros componentes
            lblTituloEnd.Visible = false;
            lblPallet2.Visible = false;
            lblEnd.Visible = false;
            txtEnderecoPL.Visible = false;
            txtEnd.Visible = false;
            txtReEND.Visible = false;
            btnEnviarEnd.Visible = false;
            PicBoxEnd.Visible = false;
            lblReEnd.Visible = false;
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
            
            bool sucessoBaixa = BaixasDB.Baixas(PalletID, Quantidade);
            bool sucessoHistorico = BaixasDB.BaixasRealizadas(RE, PalletID, Quantidade);

            if (sucessoBaixa && sucessoHistorico)
            {
                MessageBox.Show("Baixa Realizada com Sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao realizar a baixa.");
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
            txtReEND.Visible = true;
            btnEnviarEnd.Visible = true;
            PicBoxEnd.Visible = true;
            lblFrase.Visible = true;
            lblFrase2.Visible = true;
            //lblAnotacoes.Visible = true;
            lblReEnd.Visible = true;

            //Enconde os outros componentes
            lblTituloBaixa.Visible = false;
            lblQtde.Visible = false;
            lblPallet.Visible = false;
            txtQtde.Visible = false;
            txtBaixaPL.Visible = false;
            txtRE.Visible = false;
            btnEnviarBaixa.Visible = false;
            PicBoxBaixa.Visible = false;
            lblReBaixa.Visible = false;
        }

        private void btnEnviarEnd_Click(object sender, EventArgs e)
        {
            int RE = int.Parse(txtReEND.Text);
            int PalletID = int.Parse(txtEnderecoPL.Text);
            string Endereco = txtEnd.Text;


            if (string.IsNullOrEmpty(txtEnderecoPL.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
                return;
            }

            bool sucessoEnderecamento = EnderecoDB.Enderecamento(PalletID, Endereco);
            bool sucessoHistorico = EnderecoDB.HistoricoEnderecos(RE, PalletID, Endereco);

            if (sucessoEnderecamento && sucessoHistorico)
            {
                MessageBox.Show("Endereçamento Realizado!");
            }
            else 
            {
                MessageBox.Show("");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Historicos historicos = new Historicos();
            historicos.Show();
            this.Hide();
        }
    }
}
