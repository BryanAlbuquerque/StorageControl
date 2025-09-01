using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Gestao : Form
    {
        private GestaoDB DB = new GestaoDB();
        private bool _isAdmin;

        public Gestao(bool isAdmin = false)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }

        private void Gestao_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridGestao.AutoGenerateColumns = true;
            dataGridGestao.DataSource = DB.CarregarDados();

            if (_isAdmin)
            {
                btnSalvar.Visible = true;
                dataGridGestao.ReadOnly = false;
                dataGridGestao.AllowUserToAddRows = true;
                dataGridGestao.AllowUserToDeleteRows = true;
                MessageBox.Show("Edição liberada para Administrador! ");
            }
            else
            {
                btnSalvar.Visible = false;
                dataGridGestao.ReadOnly = true;
                dataGridGestao.AllowUserToAddRows = false;
                dataGridGestao.AllowUserToDeleteRows = false;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DB.AlteracoesAdmin();
                MessageBox.Show("Alterações salvas no banco com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar alterações: " + ex.Message);
            }
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(_isAdmin);
            telaPrincipal.Show();
            this.Hide();
        }
    }
}
