using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            if (admin.ValidarLogin(txtUsuario.Text, txtSenha.Text))
            {
                TelaPrincipal tela = new TelaPrincipal(true); // << informa que é admin
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
