using System;
using System.Data;
using Microsoft.Data.SqlClient;
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
            dataGridGestao.AutoGenerateColumns = false;
            dataGridGestao.DataSource = DB.CarregarDados();

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }
    }
}

