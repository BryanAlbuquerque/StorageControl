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
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            if (UserStorage.Autenticar(usuario, senha))
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
    }
}
