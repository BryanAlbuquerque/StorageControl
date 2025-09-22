using System;
using System.Windows.Forms;
using StorageControl.Classes;

namespace StorageControl.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Classes.Admin admin = new Classes.Admin();

            if (admin.ValidarLogin(txtUsuario.Text, txtSenha.Text))
            {
                SessaoUsuario.IsAdmin = true; // marca que é admin
                TelaPrincipal tela = new TelaPrincipal();
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro! Email ou senha incorretos.");
            }
        }
    }
}
