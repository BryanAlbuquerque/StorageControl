using System;
using System.Windows.Forms;
using StorageControl.Classes;


namespace StorageControl.Forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;
            string reTexto = txtRE.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(reTexto))
            {
                MessageBox.Show("Erro! Preencha todos os campos.");
                return;
            }

            if (!int.TryParse(reTexto, out int re))
            {
                MessageBox.Show("Erro! O RE deve conter apenas números.");
                return;
            }

            bool cadastroOk = UserStorage.CadastrarUsuario(usuario, senha, re);

            if (cadastroOk)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cadastro não realizado! Verifique se o RE existe e está ativo.");
            }

            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
