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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Adm admin = new Adm();

            if (admin.ValidarLogin(txtEmail.Text, txtSenha.Text))
            {
                MessageBox.Show("Login realizado com sucesso como Administrador!");

                Gestao gestao = new Gestao(true); // true = admin
                gestao.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro! Email ou senha incorretos.");
            }
        }
    }
}
