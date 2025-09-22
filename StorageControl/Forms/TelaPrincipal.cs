using System;
using System.Windows.Forms;
using StorageControl.Classes;

namespace StorageControl.Forms  
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        public TelaPrincipal(bool isAdmin = false) // por padrão não-admin
        {
            InitializeComponent();
        }
        private void btnHistorico_Click_1(object sender, EventArgs e)
        {
            Historicos historicos = new Historicos();
            historicos.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_MouseHover(object sender, EventArgs e)
        {
            txtNotas.Multiline = true;
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
            lblReBaixa.Visible = true;
            lblSetor.Visible = true;

            txtQtde.Visible = true;
            txtBaixaPL.Visible = true;
            txtRE.Visible = true;
            txtSetor.Visible = true;

            lblFrase.Visible = true;
            lblFrase2.Visible = true;
            PicBoxBaixa.Visible = true;
            txtNotas.Visible = true;

            btnEnviarBaixa.Visible = true;


            //Esconde os outros componentes
            lblTituloEnd.Visible = false;
            lblPallet2.Visible = false;
            lblEnd.Visible = false;
            lblReEnd.Visible = false;

            txtEnderecoPL.Visible = false;
            txtEnd.Visible = false;
            txtReEND.Visible = false;

            btnEnviarEnd.Visible = false;
            PicBoxEnd.Visible = false;
        }

        private void btnEnviarBaixa_Click(object sender, EventArgs e)
        {
            int PalletID = int.Parse(txtBaixaPL.Text);
            string Setor = txtSetor.Text;
            int Quantidade = int.Parse(txtQtde.Text);
            int RE = int.Parse(txtRE.Text);

            if (string.IsNullOrEmpty(txtBaixaPL.Text))
            {
                MessageBox.Show("Erro Existem espaços em Branco!");
            }

            bool sucessoBaixa = BaixasDB.Baixas(PalletID, Quantidade);
            bool sucessoHistorico = BaixasDB.BaixasRealizadas(RE, PalletID, Setor, Quantidade);

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
            lblReEnd.Visible = true;

            txtEnderecoPL.Visible = true;
            txtEnd.Visible = true;
            txtReEND.Visible = true;

            PicBoxEnd.Visible = true;
            lblFrase.Visible = true;
            lblFrase2.Visible = true;
            txtNotas.Visible = true;

            btnEnviarEnd.Visible = true;

            //Enconde os outros componentes
            lblTituloBaixa.Visible = false;
            lblQtde.Visible = false;
            lblPallet.Visible = false;
            lblSetor.Visible = false;
            lblReBaixa.Visible = false;

            txtQtde.Visible = false;
            txtBaixaPL.Visible = false;
            txtRE.Visible = false;
            txtSetor.Visible = false;

            PicBoxBaixa.Visible = false;

            btnEnviarBaixa.Visible = false;
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

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            if (SessaoUsuario.IsAdmin)
            {
                MessageBox.Show("Você esta logado como Administrador! ");
                btnHistorico.Visible = true;
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Historicos historicos = new Historicos();
            historicos.Show();
            this.Hide();
        }

        private void btnGestao_MouseEnter(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            btnGestao.BackColor = System.Drawing.Color.White;

            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            btnEntrada.BackColor = System.Drawing.Color.Navy;
            btnBaixa.BackColor = System.Drawing.Color.Navy;
            btnEnd.BackColor = System.Drawing.Color.Navy;
        }

        private void btnEntrada_MouseEnter(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            btnEntrada.BackColor = System.Drawing.Color.White;

            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            btnGestao.BackColor = System.Drawing.Color.Navy;
            btnBaixa.BackColor = System.Drawing.Color.Navy;
            btnEnd.BackColor = System.Drawing.Color.Navy;
        }

        private void btnBaixa_MouseEnter(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            btnBaixa.BackColor = System.Drawing.Color.White;

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel4.Visible = false;
            btnEnd.BackColor = System.Drawing.Color.Navy;
            btnGestao.BackColor = System.Drawing.Color.Navy;
            btnEntrada.BackColor = System.Drawing.Color.Navy;

        }

        private void btnEnd_MouseEnter(object sender, EventArgs e)
        {
            Panel4.Visible = true;
            btnEnd.BackColor = System.Drawing.Color.White;

            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            btnBaixa.BackColor = System.Drawing.Color.Navy;
            btnGestao.BackColor = System.Drawing.Color.Navy;
            btnEntrada.BackColor = System.Drawing.Color.Navy;
        }

        private void btnHistorico_MouseEnter(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }
    }
}
