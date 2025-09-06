using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void lblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm cadastro = new CadastroForm();
            cadastro.Show();
            this.Hide();
        }

        private void lblAdm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm adm = new AdminForm();
            adm.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Erro! preencha todos os campos!");
            }
            else if(UserStorage.Autenticar(usuario, senha))
            {
                TelaPrincipal tela = new TelaPrincipal();
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, ou conta inativa!");
            }
        }

        private void radOlhoFechado_Click(object sender, EventArgs e)
        {
            radOlhoAberto.Visible = true;
            radOlhoFechado.Visible = false;
        }

        private void radOlhoAberto_Click(object sender, EventArgs e)
        {
            radOlhoFechado.Visible = true;
            radOlhoAberto.Visible = false;

            txtSenha.UseSystemPasswordChar = true;
        }
    }
}
