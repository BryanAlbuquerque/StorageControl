using System;
using System.Windows.Forms;
using StorageControl.Classes;

namespace StorageControl.Forms
{
    public partial class Historicos : Form
    {
        HistoricoDB HistoricoDB = new HistoricoDB();
        public Historicos()
        {
            InitializeComponent();
        }

        private void Historicos_Load(object sender, EventArgs e)
        {
            dataGridBaixa.AutoGenerateColumns = true;
            dataGridBaixa.DataSource = HistoricoDB.CarregarDadosBaixas();

            dataGridEndereco.AutoGenerateColumns = true;
            dataGridEndereco.DataSource = HistoricoDB.CarregarDadosEnderecos();

        }

        private void btnBaixas_Click_1(object sender, EventArgs e)
        {
            dataGridBaixa.Visible = true;
            dataGridEndereco.Visible = false;
        }

        private void btnHistorico_Click_1(object sender, EventArgs e)
        {
            dataGridEndereco.Visible = true;
            dataGridBaixa.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
