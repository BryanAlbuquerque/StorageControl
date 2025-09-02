using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        // Evento que realiza o cadastro usando o UserStorage
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

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
