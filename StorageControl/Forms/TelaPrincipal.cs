using System;
using System.Windows.Forms;
using StorageControl.Classes;
using StorageProject.UI;

namespace StorageControl.Forms  
{
    public partial class TelaPrincipal : Form
    {
        private Panel QuantidadeProdutosUI;
        private Panel ValorTotalEstoqueUI;
        private Panel VisaoEstoqueUI;

        public TelaPrincipal()
        {
            VisaoEstoqueUI = new VisaoEstoqueUI().CriarPainel();    
            QuantidadeProdutosUI = new QuantidadeProdutosUI().CriarPainel();
            ValorTotalEstoqueUI = new ValorTotalEstoqueUI().CriarPainel();

            this.Controls.Add(VisaoEstoqueUI);
            this.Controls.Add(QuantidadeProdutosUI);
            this.Controls.Add(ValorTotalEstoqueUI);

            InitializeComponent();
        }

        public TelaPrincipal(bool isAdmin = false) // por padrão não-admin
        {
            InitializeComponent();
        }

        public void Baixa(bool visivel) 
        {
            lblTituloBaixa.Visible = visivel;
            lblQtde.Visible = visivel;
            lblPallet.Visible = visivel;
            lblReBaixa.Visible = visivel;
            lblSetor.Visible = visivel;

            txtQtde.Visible = visivel;
            txtBaixaPL.Visible = visivel;
            txtRE.Visible = visivel;
            txtSetor.Visible = visivel;

            lblFrase.Visible = visivel;
            PicBoxBaixa.Visible = visivel;

            btnEnviarBaixa.Visible = visivel;
        }

        public void Endereco(bool visivel) 
        {
            lblTituloEnd.Visible = visivel;
            lblPallet2.Visible = visivel;
            lblEnd.Visible = visivel;
            lblReEnd.Visible = visivel;

            txtEnderecoPL.Visible = visivel;
            txtEnd.Visible = visivel;
            txtReEND.Visible = visivel;

            PicBoxEnd.Visible = visivel;
            lblFrase.Visible = visivel;

            btnEnviarEnd.Visible = visivel;

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
            Baixa(true);
            Endereco(false);

            lblFrase2.Visible = true;
            txtNotas.Visible = true;
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
            Endereco(true);
            Baixa(false);
            lblFrase2.Visible = true;
            txtNotas.Visible = true;
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
