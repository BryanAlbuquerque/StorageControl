using System;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class Gestao : Form
    {
        private GestaoDB DB = new GestaoDB();

        public Gestao()
        {
            InitializeComponent();
        }

        private void Gestao_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridGestao.AutoGenerateColumns = true;
            dataGridGestao.ReadOnly = true;
            dataGridGestao.AllowUserToAddRows = false;
            dataGridGestao.AllowUserToDeleteRows = false;
            dataGridGestao.DataSource = DB.CarregarDados();
            
        }

        //private void btnSalvar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DB.SalvarAlteracoes();
        //        MessageBox.Show("Alterações salvas no banco de dados!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao salvar: " + ex.Message);
        //    }
        //}

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }
    }
}
